using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Autorization
{
    public partial class Notebook : Form
    {
        string CurrentFile = "null";
        bool Work = false; // Если "true", то паралельно идёт работа с асинхронным потоком, 
                           //значит не будут работать функции сохранения и т.д.
                           // что бы не возникало ошибок.
        DB db = new DB();
        HashClass hash = new HashClass();

        public Notebook()
        {
            InitializeComponent();
        }

        private void Notebook_Load(object sender, EventArgs e) // при входе в блокнот выполняется автозагрузка файла,
        {                                                       // который выбрали в настройках (если выбрали)
            if (Properties.Settings.Default.radioNote == 1)
                loadBase();
            else if (Properties.Settings.Default.radioNote == 2)
                loadTxt();
            else
                return;
        }

        private void закрытьПриложениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void закрытьОкноToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();

        private void СохранитьТолькоВБлокнотtoolStripMenuItem_Click(object sender, EventArgs e) => SaveTxt();

        private void загружатьСОблакаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogWindow())
            {
                return;
            } else
                loadBase();
        }

        private void загрузитьДанныеСБлокнотаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogWindow())
            {
                return;
            }
            else
                loadTxt();
        }

        private void сохранитьВБлокнотИОблакоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveTxt();
            SaveBase();
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.S)
            {
                SaveTxt();
                SaveBase();
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                if (CurrentFile == "Txt")
                    SaveTxt();
                else if (CurrentFile == "Base")
                    SaveBase();
                else
                    return;
            }
        }

        private async void SaveBase()
        {
            bool appRestart = false;
            Work = true;
            try
            {
                string linesText = textBox.Text.Replace("\r\n", "`");
                await Task.Run(() =>
                {
                    string logField = hash.hashlogin(Properties.Settings.Default.currLog);
                    string passField = hash.hashpass(Properties.Settings.Default.currPass);

                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    MySqlCommand commandTake = new MySqlCommand("SELECT `bloknothash` FROM `users` WHERE " +
                        "`login` = @log AND `pass` = @pass", db.getConnection());
                    commandTake.Parameters.Add("@log", MySqlDbType.VarChar).Value = logField;
                    commandTake.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField;

                    adapter.SelectCommand = commandTake;
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        db.openCoonection();

                        MySqlCommand commandGive = new MySqlCommand("UPDATE `users` SET bloknothash = @uBloknot " +
                            "WHERE `login` = @uL AND `pass` = @uP", db.getConnection());
                        commandGive.Parameters.Add("@uBloknot", MySqlDbType.Text).Value = hash.EncryptBase(linesText);
                        commandGive.Parameters.Add("@uL", MySqlDbType.VarChar).Value = logField;
                        commandGive.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passField;

                        if (commandGive.ExecuteNonQuery() != 1)
                        {
                            Work = false;
                            MessageBox.Show("Данные не записаны в облако. Произошла ошибка.",
                                "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Work = false;
                            MessageBox.Show("Данные успешно сохранены в облачное хранилище!",
                                            "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        db.closeConnection();
                    }
                    else
                    {
                        Properties.Settings.Default.isAutoEnter = false;
                        Properties.Settings.Default.SecretEnter = false;
                        Properties.Settings.Default.Save();
                        MessageBox.Show("Что-то пошло не так при загрузке данных!. Пожалуйста, войдите в аккаунт заново!.",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        appRestart = true;
                    }
                });
                if (appRestart)
                    Application.Restart();
                Work = false;
            }
            catch
            {
                Work = false;
                MessageBox.Show("Во время сохранения данных в облачное хранилище произошла ошибка!",
                    "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void SaveTxt()
        {
            Work = true;
            try
            {
                List<string> linesText = textBox.Text.Replace("\n", "").Split('\r').ToList();
                await Task.Run(() =>
                {
                    using (StreamWriter streamWriter = new StreamWriter("pass.txt", false))
                    {
                        for (int i = 0; i < linesText.Count; i++)
                        {
                            streamWriter.WriteLine(linesText[i]);
                        }
                    }
                });
                Work = false;
                MessageBox.Show("Данные успешно сохранены в блокнот!",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                Work = false;
                MessageBox.Show("Во время сохранения файла произошла ошибка!",
                    "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void loadBase() // Загрузка pass.txt на форму в текстбокс
        {
            try
            {
                Work = true;
                string bloknotHash = "";
                bool appRestart = false;
                await Task.Run(() =>
                {
                    string logField = hash.hashlogin(Properties.Settings.Default.currLog);
                    string passField = hash.hashpass(Properties.Settings.Default.currPass);

                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    MySqlCommand command = new MySqlCommand("SELECT `bloknothash` FROM `users` WHERE " +
                        "`login` = @log AND `pass` = @pass", db.getConnection());
                    command.Parameters.Add("@log", MySqlDbType.VarChar).Value = logField;
                    command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField;

                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        db.openCoonection();
                        bloknotHash = hash.DencryptBase(command.ExecuteScalar().ToString());
                        db.closeConnection();
                    }
                    else
                    {
                        Properties.Settings.Default.isAutoEnter = false;
                        Properties.Settings.Default.SecretEnter = false;
                        Properties.Settings.Default.Save();
                        MessageBox.Show("Что-то пошло не так при загрузке данных!. Пожалуйста, войдите в аккаунт заново!.",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        appRestart = true;
                    }
                });
                
                if (appRestart) // Если, вдруг, по логину и паролю не найдётся пользователь, то выкинет с аккаунта
                    Application.Restart();
                
                // Если всё прошло "как должно", то записываем полученные данные в TextBox
                string text = "";
                for (int i = 0; i < bloknotHash.Length; i++)
                {
                    if (bloknotHash[i] == '`')  // Символ ' - ставится в базу для идентификации переноса строки.
                    {
                        text += "\r\n";         // Здесь меняется этот символ ' на перенос строки
                    }
                    else                       // (за исключением полседней строки)
                    {
                        text += bloknotHash[i];
                    }
                }
                textBox.Text = text;
                textBox.Select(0, 0);

                this.Text = "Notebook (облачное хранилище)";
                CurrentFile = "Base";
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так при загрузке данных из облака!", 
                    "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Work = false;

        }

        private void loadTxt() // Загрузка из Txt данных
        {
            Work = true;
            try
            {
                string[] lines = File.ReadAllLines("pass.txt");
                textBox.Clear();
                for (int line = 0; line < lines.Length; line++)
                {
                    if (line == lines.Length - 1)
                        textBox.Text += lines[line];
                    else
                        textBox.Text += lines[line] + "\r\n";
                }
                textBox.Select(0, 0);

                this.Text = "Notebook (pass.txt)";
                CurrentFile = "Txt";
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так при загрузке данных из облака!", 
                    "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Work = false;
        }

        private void Notebook_FormClosing(object sender, FormClosingEventArgs e) 
        {
            if (Work) // Ставим, чтобы маленькие задержки асинхронных потоков не тратили нервы пользователя
                Thread.Sleep(200);

            if (Work) // Не позволяем выйти, при работающем процессе.
            {
                MessageBox.Show("Пожалуйста, дождитесь завершения работы активных процессов", "Работа процессов не закончена!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }

            if (DialogWindow()) // Если true - отменяем выход, если false - выходим
                e.Cancel = true;
            else
                e.Cancel = false;
        }
        private bool DialogWindow()// Вызывает окно "сохранить ли изменения"
        {                           // если они есть
            if (CurrentFile == "Txt") // Проверка на изменения данные, и, если они есть, предложение сохранить их
            {
                bool isChange = isChangeTxt();
                if (isChange)
                {
                    DialogResult msg = MessageBox.Show("Сохранить ли текущие изменения в блокнот?",
                        "Сохранение данных", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        SaveTxt();
                        return false;
                    }
                    else if (msg == DialogResult.No)
                        return false;
                    else
                        return true;
                }
            }
            else if (CurrentFile == "Base")
            {
                bool isChange = isChangeBase();
                if (isChange)
                {
                    DialogResult msg = MessageBox.Show("Сохранить ли текущие изменения в облако?",
                        "Сохранение данных", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        SaveBase();
                        return false;
                    }
                    else if (msg == DialogResult.No)
                        return false;
                    else
                        return true;
                }
            }
            else
            {
                return false;
            }
            return false;
        }

        private bool isChangeBase()
        {
            Work = true;
            try
            {
                string bloknotHash = "";

                string logField = hash.hashlogin(Properties.Settings.Default.currLog);
                string passField = hash.hashpass(Properties.Settings.Default.currPass);

                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand commandTake = new MySqlCommand("SELECT `bloknothash` FROM `users` WHERE " +
                    "`login` = @log AND `pass` = @pass", db.getConnection());
                commandTake.Parameters.Add("@log", MySqlDbType.VarChar).Value = logField;
                commandTake.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField;

                adapter.SelectCommand = commandTake;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    db.openCoonection();

                    bloknotHash = hash.DencryptBase(commandTake.ExecuteScalar().ToString());

                    db.closeConnection();

                    var textBoxText = textBox.Text.Replace("\r\n", "`");
                    
                    Work = false;

                    if (bloknotHash == textBoxText)
                        return false;
                    else
                        return true;
                }
                else
                {
                    Properties.Settings.Default.isAutoEnter = false;
                    Properties.Settings.Default.SecretEnter = false;
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Что-то пошло не так при проверке данных!. Пожалуйста, войдите в аккаунт заново!.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Work = false;
                    Application.Restart();
                    return false; // Что бы компилятор не ругался
                }
            }
            catch
            {
                MessageBox.Show("Что то пошло не так! ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Work = false;
                return true;
            }
        }

        private bool isChangeTxt() // Проверка на изменения в Txt файле
        {
            if (File.Exists("pass.txt"))
            {
                List<string> linesTxt = File.ReadAllLines("pass.txt").ToList();

                List<string> linesText = textBox.Text.Replace("\n", "").Split('\r').ToList();
                
                if (linesText.Count == linesTxt.Count)
                {
                    for (int i = 0; i < linesTxt.Count; i++)
                        if (linesText[i] != linesTxt[i])
                            return true;
                } else
                    return true;

                return false;
            } else
            {
                return true;
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сейчас Вы находитесь в блокноте. Здесь показываются нужные " +
                "Вам данные для вашего пользования или редактирования!\nКогда Вы заходите - " +
                "Вы можете загрузить данные с локального блокнота (с названием pass.txt) или с облачного " +
                "сервера, и, конечно, в полной мере: редактировать, удалять, сохранять, загружать все Ваши записи.\n" +
                "После загрузки каких-либо данных Вам покажется в названии окна (сверху) - откуда данные открыты " +
                "(если там ничего не написано кроме \"Settings\", то записи ещё не загружены).\n" +
                "Для того, что бы загрузить или сохранить какие либо данные Вам нужно воспользоваться " +
                "соответсвующим действием во вкладке 'Действия'.\n\n" +
                "Хоткеи:\n1) CTRL + S (сохранить данные в место, откуда получены эти данные);\n" +
                "2) CTRL + SHIFT + S (сохранить и в облако, и в локальный блокнот весь текст);\n" +
                "3) CTRL + Z (отменить действие).\n\n" +
                "По вопросам пишите в тех. поддержку:\nTroyHelper@yandex.ru", "Справка", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
