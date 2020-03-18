using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Autorization
{
    public partial class AuthorizationForm : Form
    {
        Font underlineFont = new Font("Century Gothic", 12, FontStyle.Bold | FontStyle.Underline);
        Font defFont = new Font("Century Gothic", 12, FontStyle.Bold);

        bool work = true;

        DB db = new DB();
        HashClass hash = new HashClass();

        public AuthorizationForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            pictureBox3.Visible = true;
        }

        private void AuthorizationForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        private void pictureBox3_MouseEnter(object sender, EventArgs e) => pictureBox2.BringToFront();

        private void pictureBox2_MouseLeave(object sender, EventArgs e) => pictureBox3.BringToFront();

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введите Ваш логин и пароль, и войдите в свою учётную запись. " +
            "Регистр учитывается.\nЕсли Вы ещё не зарегестрированы, то нажмите по кнопке \"Зарегистрироваться\" и," +
            " после успешной регистрации, войдити в свой аккаунт.\nВажно, если Вы ещё не зарегестрированы, " +
            "то, при регистрации, укажите Вашу настоящую почту, так как " +
            "на неё придёт информация о логине, пароле, и секретном коде." +
            "\nСекретный код будет Вам необходим для того что бы разкодировать Вашу записную книжку, " +
            "привязанную ТОЛЬКО к Вашему аккаунту.\n\nКонтактная информация: TroyHelper@yandex.ru",
            "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isAutoEnter == true)
            {
                work = false;
                autoruser();
            }
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.Font = underlineFont;
            label6.ForeColor = Color.White;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.Font = defFont;
            label6.ForeColor = Color.Silver;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down || e.KeyData == Keys.Enter)
                textBox2.Focus();
            else if (e.KeyData == Keys.Up)
                buttonLogin.Focus();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down)
                buttonLogin.Focus();
            else if (e.KeyData == Keys.Up)
                textBox1.Focus();
            else if (e.KeyData == Keys.Enter)
                this.buttonLogin_Click(sender, e);
        }
        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.Font = underlineFont;
            label2.ForeColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.Font = defFont;
            label2.ForeColor = Color.Silver;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (work == true)
            {
                work = false;
                autoruser();
            }
            else return;
        }

        private async void autoruser()
        {
            pictureBox1.Visible = true;
            bool isAutor = false;
            await Task.Run(() =>
            {
                try
                {
                    string loginField = hash.hashlogin(textBox1.Text);
                    string passField = hash.hashpass(textBox2.Text);

                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE " +
                        "`login` = @uL AND `pass` = @uP", db.getConnection());

                    command.Parameters.Add("uL", MySqlDbType.VarChar).Value = loginField;
                    command.Parameters.Add("uP", MySqlDbType.VarChar).Value = passField;

                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        isAutor = true;
                    }
                    else
                    {
                        Properties.Settings.Default.isAutoEnter = false;
                        Properties.Settings.Default.SecretEnter = false;
                        Properties.Settings.Default.Save();
                        MessageBox.Show("Данные введены неверно. Повторите попытку.", 
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    Properties.Settings.Default.isAutoEnter = false;
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Нету доступа к базе данных. Повторите попытку позже.", 
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
            if (isAutor) {
                // Сериализуется логин и пароль текущего пользователя
                if (Properties.Settings.Default.isAutoEnter != true)
                {
                    Properties.Settings.Default.currLog = textBox1.Text;
                    Properties.Settings.Default.currPass = textBox2.Text;
                } else
                {
                    // Если пользователь войдёт автоматически то данные возьмутся из
                    // логина и пароля для автовхода.
                    Properties.Settings.Default.currLog = Properties.Settings.Default.deafLog;
                    Properties.Settings.Default.currPass = Properties.Settings.Default.deafPass; 
                    
                }

                // Запись логина и пароля на автовход
                if (checkBox1.Checked == true)
                {
                    Properties.Settings.Default.isAutoEnter = true;
                    Properties.Settings.Default.deafLog = textBox1.Text;
                    Properties.Settings.Default.deafPass = textBox2.Text;
                }

                // Сериализуем
                Properties.Settings.Default.Save();

                // Открытие формы. Обязательно, как новое окно
                this.Hide();
                AdGuard adGuard = new AdGuard();
                adGuard.ShowDialog();
                this.Close();
            }
            pictureBox1.Visible = false;
            work = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (work == true)
            {
                foreach(Form form in Application.OpenForms)
                {
                    if (form.Name == "RegistrationForm")
                    {
                        this.Hide();
                        form.Show();
                        return;
                    }
                }
                this.Hide();
                RegistrationForm regform = new RegistrationForm();
                regform.Show();
            }
        }

        private void buttonLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down)
                textBox1.Focus();
            else if (e.KeyData == Keys.Up)
                textBox2.Focus();
            else if (e.KeyData == Keys.Enter)
                this.buttonLogin_Click(sender, e);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (work == true)
            {
                Properties.Settings.Default.isAutoEnter = false;
                Properties.Settings.Default.SecretEnter = false;
                Properties.Settings.Default.Save();
                this.Hide();
                OfflineAdGuard offlineAdGuard = new OfflineAdGuard();
                offlineAdGuard.ShowDialog();
                this.Close();
            }
        }
    }
}
