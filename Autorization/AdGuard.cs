using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Data;
using System.Collections.Generic;

namespace Autorization
{
    public partial class AdGuard : Form
    {
        string atlantall = "123456789%*?@#$abcdefghijklmnopqrstuvwxyz%*?@#$ABCDEFGHIJKLMNOPQRSTUVWXYZ%*?@#$",
               atlant1 = "123456789",
               atlant2 = "abcdefghijklmnopqrstuvwxyz",
               atlant3 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
               atlant4 = "%*?@#$",
               atlantjir = "";

        ToolTip copysuccess = new ToolTip();
        DB db = new DB();
        Random rand = new Random();
        HashClass hash = new HashClass();

        public bool isLoad;
        bool Work = false;

        public AdGuard()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            helperLogin();
            copysuccess.SetToolTip(pictureBoxCopy, "Скопировать");
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            if (comboBoxId.Text.Replace(" ", string.Empty) == "")
            {
                DialogResult dialogResult = MessageBox.Show("Вы не вписали идентификатор.\n\nОтменить действие?", "Идентификатор", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (dialogResult == DialogResult.Yes)
                {
                    comboBoxId.Focus();
                    return;
                }
                else if (dialogResult == DialogResult.Cancel)
                    return;
            }

            if (Work == true)
            {
                MessageBox.Show("Прошлый процесс сохранения данных ещё не окончен. Пожалуйста, повторите попытку позже.");
                return;
            }

            if (Properties.Settings.Default.EnterTxt)
            {
                using (StreamWriter stream = new StreamWriter("pass.txt", true))
                {
                    stream.WriteLine("");
                    stream.WriteLine("Идентификатор:     " + comboBoxId.Text);
                    stream.WriteLine("Логин:             " + comboBoxLogin.Text);
                    stream.WriteLine("Пароль:            " + comboBoxPassword.Text);
                    stream.WriteLine();
                    stream.WriteLine(string.Concat(Enumerable.Repeat("=", 50)));
                }
                if (comboBoxLogin.Items.IndexOf(comboBoxLogin.Text) == -1 && comboBoxLogin.Text.Replace(" ", string.Empty) == "")
                    comboBoxLogin.Items.Add(comboBoxLogin.Text);
                MessageBox.Show("Данные успешно записаны!");
            }

            if (Properties.Settings.Default.EnterBase)
            {
                WriteToDB(comboBoxId.Text, comboBoxLogin.Text, comboBoxPassword.Text);
            }

            helperLogin();
        }

        private async void WriteToDB(string id, string login, string password)
        {
            bool appRestart = false;
            Work = true;
            try
            {
                await Task.Run(() =>
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

                        bloknotHash = commandTake.ExecuteScalar().ToString();

                        string newWords =  // Символ ' - будет заменён на \r\n при загрузке в блокнот данных.
                        "`Идентификатор:     " + id +
                        "`Логин:             " + login +
                        "`Пароль:            " + password +
                        "``" +
                        string.Concat(Enumerable.Repeat("=", 50)) + "`";

                        string text = bloknotHash + hash.EncryptBase(newWords);

                        MySqlCommand commandGive = new MySqlCommand("UPDATE `users` SET bloknothash = @uBloknot " +
                            "WHERE `login` = @uL AND `pass` = @uP", db.getConnection());
                        commandGive.Parameters.Add("@uBloknot", MySqlDbType.Text).Value = text;
                        commandGive.Parameters.Add("@uL", MySqlDbType.VarChar).Value = logField;
                        commandGive.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passField;

                        if (commandGive.ExecuteNonQuery() != 1)
                            MessageBox.Show("Данные не записаны в облако. Произошла ошибка.",
                                "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

            }
            catch
            {
                db.closeConnection();
                MessageBox.Show("Что то пошло не так! ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Work = false;
        }

        private void pictureBoxCopy_Click(object sender, EventArgs e)
        {
            if (comboBoxPassword.Text.Replace(" ", string.Empty) == "")
            {
                return;
            }
            Clipboard.SetText(comboBoxPassword.Text);
            if (Clipboard.GetText() == comboBoxPassword.Text)
                copysuccess.SetToolTip(pictureBoxCopy, "Успешно скопировано!");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.buttonUpdate_Click(this, e);
            comboBoxId.Text = "";
            if (comboBoxLogin.Items.IndexOf(comboBoxLogin.Text) == -1 && comboBoxLogin.Text == "")
                comboBoxLogin.Items.Add(comboBoxLogin.Text);
            comboBoxLogin.Text = "";
        }

        private void закрытьПриложениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void выйтиИзУчётнойЗаписиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.isAutoEnter = false;
            Properties.Settings.Default.SecretEnter = false;
            Properties.Settings.Default.Save();
            Application.Restart();
        }

        private void сменитьФонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangeBackground changeBackground = new ChangeBackground();
            changeBackground.ShowDialog();
            this.Close();
        }

        private void AdGuard_Load(object sender, EventArgs e)
        {
            buttonUpdate_Click(sender, e);
            helperLogin();
            label6.Text = "Аккаунт пользователя: " + Properties.Settings.Default.currLog;
            if (isLoad != true)
            {
                gradientPanel1.TopColor = Properties.Settings.Default.AutoTop;
                gradientPanel1.BottomColor = Properties.Settings.Default.AutoBottom;
                gradientPanel1.Angle = Properties.Settings.Default.AutoAngle;
                gradientPanel1.Refresh();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int i; comboBoxPassword.Text = "";

            if (this.comboBoxCountPass.Text == "") { return; }

            if (this.checkBoxNum.Checked == true && this.checkBoxLowerCase.Checked == true && this.checkBoxUppercase.Checked == true && this.checkBoxBadges.Checked == true)
            {
                for (i = 1; i <= Convert.ToInt32(comboBoxCountPass.Text); i++)
                {
                    comboBoxPassword.Text += Convert.ToString(atlantall[1 + rand.Next(78)]);
                }
                return;
            }

            if (this.checkBoxNum.Checked == true && this.checkBoxLowerCase.Checked == true && this.checkBoxUppercase.Checked == true && this.checkBoxBadges.Checked == false)
            {
                atlantjir = atlant1 + atlant2 + atlant3;
                for (i = 1; i <= Convert.ToInt32(comboBoxCountPass.Text); i++)
                {
                    comboBoxPassword.Text += Convert.ToString(atlantjir[rand.Next(atlantjir.Length - 1) + 1]);
                }
                return;
            }
            //1
            if (this.checkBoxNum.Checked == true && this.checkBoxLowerCase.Checked == true && this.checkBoxUppercase.Checked == false && this.checkBoxBadges.Checked == true)
            {
                atlantjir = atlant1 + atlant2 + atlant4;
                for (i = 1; i <= Convert.ToInt32(comboBoxCountPass.Text); i++)
                {
                    comboBoxPassword.Text += Convert.ToString(atlantjir[rand.Next(atlantjir.Length - 1) + 1]);
                }
                return;
            }

            if (this.checkBoxNum.Checked == true && this.checkBoxLowerCase.Checked == true && this.checkBoxUppercase.Checked == false && this.checkBoxBadges.Checked == false)
            {
                atlantjir = atlant1 + atlant2;
                for (i = 1; i <= Convert.ToInt32(comboBoxCountPass.Text); i++)
                {
                    comboBoxPassword.Text += Convert.ToString(atlantjir[rand.Next(atlantjir.Length - 1) + 1]);
                }
                return;
            }
            //2
            if (this.checkBoxNum.Checked == true && this.checkBoxLowerCase.Checked == false && this.checkBoxUppercase.Checked == true && this.checkBoxBadges.Checked == true)
            {
                atlantjir = atlant1 + atlant4 + atlant3;
                for (i = 1; i <= Convert.ToInt32(comboBoxCountPass.Text); i++)
                {
                    comboBoxPassword.Text += Convert.ToString(atlantjir[rand.Next(atlantjir.Length - 1) + 1]);
                }
                return;
            }

            if (this.checkBoxNum.Checked == true && this.checkBoxLowerCase.Checked == false && this.checkBoxUppercase.Checked == true && this.checkBoxBadges.Checked == false)
            {
                atlantjir = atlant1 + atlant3;
                for (i = 1; i <= Convert.ToInt32(comboBoxCountPass.Text); i++)
                {
                    comboBoxPassword.Text += Convert.ToString(atlantjir[rand.Next(atlantjir.Length - 1) + 1]);
                }
                return;
            }
            //3
            if (this.checkBoxNum.Checked == true && this.checkBoxLowerCase.Checked == false && this.checkBoxUppercase.Checked == false && this.checkBoxBadges.Checked == true)
            {
                atlantjir = atlant1 + atlant4;
                for (i = 1; i <= Convert.ToInt32(comboBoxCountPass.Text); i++)
                {
                    comboBoxPassword.Text += Convert.ToString(atlantjir[rand.Next(atlantjir.Length - 1) + 1]);
                }
                return;
            }

            if (this.checkBoxNum.Checked == true && this.checkBoxLowerCase.Checked == false && this.checkBoxUppercase.Checked == false && this.checkBoxBadges.Checked == false)
            {
                for (i = 1; i <= Convert.ToInt32(comboBoxCountPass.Text); i++)
                {
                    comboBoxPassword.Text += Convert.ToString(atlant1[rand.Next(atlant1.Length - 1) + 1]);
                }
                return;
            }
            //4
            if (this.checkBoxNum.Checked == false && this.checkBoxLowerCase.Checked == true && this.checkBoxUppercase.Checked == true && this.checkBoxBadges.Checked == true)
            {
                atlantjir = atlant4 + atlant2 + atlant3;
                for (i = 1; i <= Convert.ToInt32(comboBoxCountPass.Text); i++)
                {
                    comboBoxPassword.Text += Convert.ToString(atlantjir[rand.Next(atlantjir.Length - 1) + 1]);
                }
                return;
            }
            if (this.checkBoxNum.Checked == false && this.checkBoxLowerCase.Checked == true && this.checkBoxUppercase.Checked == true && this.checkBoxBadges.Checked == false)
            {
                atlantjir = atlant2 + atlant3;
                for (i = 1; i <= Convert.ToInt32(comboBoxCountPass.Text); i++)
                {
                    comboBoxPassword.Text += Convert.ToString(atlantjir[rand.Next(atlantjir.Length - 1) + 1]);
                }
                return;
            }
            //5
            if (this.checkBoxNum.Checked == false && this.checkBoxLowerCase.Checked == true && this.checkBoxUppercase.Checked == false && this.checkBoxBadges.Checked == true)
            {
                atlantjir = atlant4 + atlant2;
                for (i = 1; i <= Convert.ToInt32(comboBoxCountPass.Text); i++)
                {
                    comboBoxPassword.Text += Convert.ToString(atlantjir[rand.Next(atlantjir.Length - 1) + 1]);
                }
                return;
            }
            if (this.checkBoxNum.Checked == false && this.checkBoxLowerCase.Checked == true && this.checkBoxUppercase.Checked == false && this.checkBoxBadges.Checked == false)
            {
                for (i = 1; i <= Convert.ToInt32(comboBoxCountPass.Text); i++)
                {
                    comboBoxPassword.Text += Convert.ToString(atlant2[rand.Next(atlant2.Length - 1) + 1]);
                }
                return;
            }
            //6
            if (this.checkBoxNum.Checked == false && this.checkBoxLowerCase.Checked == false && this.checkBoxUppercase.Checked == true && this.checkBoxBadges.Checked == true)
            {
                atlantjir = atlant4 + atlant3;
                for (i = 1; i <= Convert.ToInt32(comboBoxCountPass.Text); i++)
                {
                    comboBoxPassword.Text += Convert.ToString(atlantjir[rand.Next(atlantjir.Length - 1) + 1]);
                }
                return;
            }
            if (this.checkBoxNum.Checked == false && this.checkBoxLowerCase.Checked == false && this.checkBoxUppercase.Checked == true && this.checkBoxBadges.Checked == false)
            {
                for (i = 1; i <= Convert.ToInt32(comboBoxCountPass.Text); i++)
                {
                    comboBoxPassword.Text += Convert.ToString(atlant3[rand.Next(atlant3.Length - 1) + 1]);
                }
                return;
            }
            //7
            if (this.checkBoxNum.Checked == false && this.checkBoxLowerCase.Checked == false && this.checkBoxUppercase.Checked == false && this.checkBoxBadges.Checked == true)
            {
                for (i = 1; i <= Convert.ToInt32(comboBoxCountPass.Text); i++)
                {
                    comboBoxPassword.Text += Convert.ToString(atlant4[rand.Next(atlant4.Length - 1) + 1]);
                }
                return;
            }
            return;
        }

        private void comboBoxId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down)
                comboBoxLogin.Focus();
            if (e.KeyData == Keys.Up)
                comboBoxPassword.Focus();
        }

        private void comboBoxLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down)
                comboBoxPassword.Focus();
            if (e.KeyData == Keys.Up)
                comboBoxId.Focus();
        }

        private void comboBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down)
                comboBoxId.Focus();
            if (e.KeyData == Keys.Up)
                comboBoxLogin.Focus();
            if (e.KeyData == Keys.Enter)
                buttonWrite_Click(sender, e);
        }

        private void настройкиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.ShowDialog();
        }

        private void comboBoxCountPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void comboBoxCountPass_TextChanged(object sender, EventArgs e)
        {
            this.buttonUpdate_Click(this, e);
        }

        private void buttonOpenNote_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.SecretEnter)
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == "notebook")
                    {
                        form.WindowState = FormWindowState.Normal;
                        form.BringToFront();
                        helperLogin();
                        return;
                    }
                }
                Notebook notebook = new Notebook();
                notebook.ShowDialog();
                helperLogin();
                return;
            }
            else
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == "isValidPass")
                    {
                        form.WindowState = FormWindowState.Normal;
                        form.BringToFront();
                        helperLogin();
                        return;
                    }
                }
                isValidPass isValidPass = new isValidPass();
                isValidPass.ShowDialog();
                helperLogin();
            }
        }

        private void pictureBoxCopy_MouseEnter(object sender, EventArgs e)
        {
            if (Clipboard.GetText() == comboBoxPassword.Text)
            {
                copysuccess.SetToolTip(pictureBoxCopy, "Успешно скопировано!");
                return;
            }
            copysuccess.SetToolTip(pictureBoxCopy, "Скопировать");
        }

        private void helperLogin()
        {
            if (File.Exists("pass.txt") == true)
            {
                if (comboBoxLogin.Items.Contains("Прошлые логины не найдены") == true)
                    comboBoxLogin.Items.Remove("Прошлые логины не найдены");
                string pass = "pass.txt";
                using (StreamReader str = new StreamReader(pass, true))
                    while (!str.EndOfStream)
                    {
                        string st = str.ReadLine();
                        if (st.StartsWith("Логин:"))
                        {
                            string help = st.Replace("Логин:", "").Trim(' ');
                            if (comboBoxLogin.Items.IndexOf(help) == -1 && help.Replace(" ", string.Empty) != "")
                                comboBoxLogin.Items.Add(help);
                        }
                    }
            }

            if (comboBoxLogin.Items.Count == 0)
                comboBoxLogin.Items.Add("Прошлые логины не найдены");
        }
    }
}
