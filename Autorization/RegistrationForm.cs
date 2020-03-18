using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Autorization // дописать: защита от брута
{
    public partial class RegistrationForm : Form
    {
        Font underlineFont = new Font("Century Gothic", 12, FontStyle.Bold | FontStyle.Underline);
        Font defFont = new Font("Century Gothic", 12, FontStyle.Bold);

        bool work = true;
        string SecretPass = "";

        DB db = new DB();
        HashClass hash = new HashClass();
        Random rnd = new Random();

        public RegistrationForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            pictureBox3.Visible = true;
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

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            if (work == true)
            {
                work = false;
                reguser();
            }
            else return;
        }

        private async void reguser()
        {
            pictureBox1.Visible = true;
            await Task.Run(() =>
            {
                bool mailotpravka = false;

                if (!checkFields())
                    return;
                if (!checkUser())
                    return;
                if (!checkEmail())
                    return;
                if (!checkEmailValidation())
                    return;

                SecretPass = Convert.ToString(rnd.Next(1000, 9999));
                string hashcode = hash.codeparse(SecretPass); ;
                string logField = hash.hashlogin(textBox1.Text);
                string passField = hash.hashpass(textBox2.Text);
                string emailField = hash.hashemail(textBox3.Text);

                try
                {
                    MySqlCommand commandsignup = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, " +
                        "`email`, `code`) VALUES (@log, @pass, @em, @hash);", db.getConnection());
                    commandsignup.Parameters.Add("@log", MySqlDbType.VarChar).Value = logField;
                    commandsignup.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField;
                    commandsignup.Parameters.Add("@em", MySqlDbType.VarChar).Value = emailField;
                    commandsignup.Parameters.Add("@hash", MySqlDbType.VarChar).Value = hashcode;

                    db.openCoonection();

                    if (commandsignup.ExecuteNonQuery() == 1)
                        mailotpravka = true;
                    else
                        MessageBox.Show("Аккаунт не был создан. Произошла ошибка.", 
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    db.closeConnection();
                }
                catch
                {
                    if (otmenaoperacii())
                        MessageBox.Show("Отсутсвует подключение к базе данных. " +
                            "Повторите попытку позже.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (mailotpravka)
                {
                    bool kkk = otpravkapochta();
                    if (kkk)
                    {
                        MessageBox.Show("Поздравляем! Регистрация завершена успешно!\n" +
                            "На Вашу почту отправлено письмо с секретным кодом.", "Успешно!", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (!kkk)
                    {
                        if (otmenaoperacii())
                            MessageBox.Show("Письмо регистрации не было доставлено по неизвестным причинам." +
                                "\nВозможно указан неверный адрес электронной почты. Регистрация отменена.", 
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            });
            pictureBox1.Visible = false;
            work = true;
        }

        private bool checkEmailValidation()
        {
            bool bar = false;
            int k = 0;
            string milo = "";
            if (new EmailAddressAttribute().IsValid(textBox3.Text))
                bar = true;
            else
            {
                MessageBox.Show("Введённый Email недопустим.\nДоступные сервера почт: " +
                    "Mail.ru, Yandex.ru, Gmail.com", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (bar)
            {
                for (k = 0; k < textBox3.Text.Length; k++)
                    if (textBox3.Text[k] == '@')
                        break;
                if (k == textBox3.Text.Length - 1)
                {
                    MessageBox.Show("Введённый Email недопустим.\nДоступные сервера почт: " +
                        "Mail.ru, Yandex.ru, Gmail.com", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                for (int txt = k; txt < textBox3.Text.Length; txt++)
                    milo += textBox3.Text[txt];
                try
                {
                    milo = milo.ToLower();
                }
                catch
                {
                    MessageBox.Show("Введённый Email недопустим.\nДоступные сервера почт: Mail.ru, " +
                        "Yandex.ru, Gmail.com", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (milo == "@mail.ru" || milo == "@gmail.com" || milo == "@inbox.ru" || milo == "@list.ru" 
                    || milo == "@bk.ru" || milo == "@yandex.ru")
                {
                    if (letterreg())
                        return true;
                }
                else
                {
                    MessageBox.Show("Введённый Email недопустим.\nДоступные сервера почт: Mail.ru, " +
                        "Yandex.ru, Gmail.com", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Введённый Email недопустим.\nДоступные сервера почт: Mail.ru, " +
                    "Yandex.ru, Gmail.com", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            MessageBox.Show("Введённый Email недопустим или не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;

        }

        private bool letterreg()
        {
            try
            {
                MailAddress From1 = new MailAddress("TroyHelper@yandex.ru", "Поддержка PasswordAdGuard");
                MailAddress To1 = new MailAddress(textBox3.Text);
                MailMessage msg1 = new MailMessage(From1, To1);
                msg1.Subject = "Добро пожаловать " + textBox1.Text + " !";
                msg1.Body = "<p>Регистрация проходит успешно!</p><p>Скоро придёт " +
                    "сообщение с секретным ключём.</p><p></p><p>" +
                    "Если возникнут вопросы пишите на данную почту- TroyHelper@yandex.ru</p><p>" +
                    "С уважением, поддержка PassGenerator!</p>";
                msg1.IsBodyHtml = true;
                SmtpClient smtp1 = new SmtpClient("smtp.yandex.ru", 587);
                smtp1.Credentials = new NetworkCredential("TroyHelper@yandex.ru", "W%yRhX?clUNC");
                smtp1.EnableSsl = true;
                msg1.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                smtp1.Send(msg1);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool otmenaoperacii()
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                string loginField = textBox1.Text;

                MySqlCommand command2 = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @eL", db.getConnection());

                command2.Parameters.Add("eL", MySqlDbType.VarChar).Value = loginField;

                adapter.SelectCommand = command2;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MySqlCommand command3 = new MySqlCommand("DELETE FROM `users` WHERE `login` = @eL", db.getConnection());
                    command3.Parameters.Add("eL", MySqlDbType.VarChar).Value = loginField;
                    db.openCoonection();

                    if (command3.ExecuteNonQuery() == 1)
                    {
                        db.closeConnection();
                        return true;
                    }
                    else
                    {
                        db.closeConnection();
                        MessageBox.Show("Нет доступа к базе данных. Данные не удалены из базы данных," +
                            " или удалены частично.\nОбратитесь в службу поддержки или создайте другой аккаунт.", 
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                MessageBox.Show("Нет доступа к базе данных. Данные не удалены из базы данных, или удалены частично." +
                    "\nОбратитесь в службу поддержки или создайте другой аккаунт.", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool otpravkapochta()
        {
            try
            {
                MailAddress From1 = new MailAddress("TroyHelper@yandex.ru", "Поддержка PasswordAdGuard");
                MailAddress To1 = new MailAddress(textBox3.Text);
                MailMessage msg1 = new MailMessage(From1, To1);
                msg1.Subject = "Информация о регистрации и секретный код";
                msg1.Body = "<p>Спасибо за регистрацию!</p><p>Ваш логин: " + textBox1.Text + 
                    "</p></p><p>Ваш пароль: " + textBox2.Text + "</p></p><p>Ваш секретный код: " + 
                    SecretPass + "</p><p>Если возникнут вопросы пишите на данную почту - " +
                    "TroyHelper@yandex.ru</p><p>С уважением, поддержка PassGenerator!</p>";
                msg1.IsBodyHtml = true;
                SmtpClient smtp1 = new SmtpClient("smtp.yandex.ru", 587);
                smtp1.Credentials = new NetworkCredential("TroyHelper@yandex.ru", "W%yRhX?clUNC");
                smtp1.EnableSsl = true;
                msg1.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                smtp1.Send(msg1);
                return true;
            }
            catch
            {
                MessageBox.Show("Письмо с секретным кодом не было доставлено по неизвестным причинам. " +
                    "Возможно указан неверный адрес электронной почты. Операция регистрации отменена.", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool checkEmail()
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                string emailField = textBox3.Text;

                MySqlCommand command2 = new MySqlCommand("SELECT * FROM `users` WHERE `email` = @eL", db.getConnection());

                command2.Parameters.Add("eL", MySqlDbType.VarChar).Value = emailField;

                adapter.SelectCommand = command2;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Данный почтовый адрес уже используется. " +
                        "Измените его и повторите попытку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                MessageBox.Show("Нет доступа к базе данных. Повторите попытку позже.", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private Boolean checkUser()
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                string loginField = textBox1.Text;

                MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());

                command.Parameters.Add("uL", MySqlDbType.VarChar).Value = loginField;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Данное имя пользователя уже используется. Измените " +
                        "его и повторите попытку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                MessageBox.Show("Нет доступа к базе данных. Повторите попытку позже.", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private Boolean checkFields()
        {
            string logField = textBox1.Text;
            string passField = textBox2.Text;
            string emailField = textBox3.Text;
            string alfavit = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZабвгдеёжзийклм" +
                "нопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ1234567890!@#$%^&*()_+=-?.";

            for (int j = 0; j < logField.Length; j++)
            {
                string btv = Convert.ToString(logField[j]);
                if (!alfavit.Contains(btv))
                {
                    MessageBox.Show("В полях не должно быть пробелов, так же поля не должны быть " +
                        "пустыми. Пароль должен состоять из букв английского или русского алфавита, " +
                        "могут вставляться цифры и некоторые символы (!@#$%^&*()_+=-?.). Попробуйте " +
                        "снова.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }

            for (int j = 0; j < passField.Length; j++)
            {
                string btv = Convert.ToString(passField[j]);
                if (!alfavit.Contains(btv))
                {
                    MessageBox.Show("В полях не должно быть пробелов, так же поля не должны быть пустыми. " +
                        "Пароль должен состоять из букв английского или русского алфавита, могут вставляться " +
                        "цифры и некоторые символы (!@#$%^&*()_+=-?.). Попробуйте снова.", "Ошибка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }

            if (emailField.Replace(" ", string.Empty) == "")
            {
                MessageBox.Show("В полях не должно быть пробелов, так же поля не должны быть пустыми. " +
                    "Пароль должен состоять из букв английского или русского алфавита, могут вставляться " +
                    "цифры и некоторые символы (!@#$%^&*()_+=-?.). Попробуйте снова.", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (logField.Length > 64 || logField.Length < 4)
            {
                MessageBox.Show("Логин должен иметь минимальную длину в 4 символа, максимум в 64 символа.", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (passField.Length > 64 || passField.Length < 4)
            {
                MessageBox.Show("Пароль должен иметь минимальную длину в 4 символа, максимум в 64 символа.", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (emailField.Length > 64 || emailField.Length < 8)
            {
                MessageBox.Show("Email должен иметь минимальную длину в 8 символов, максимум в 64 символа.", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (work == true)
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == "AuthorizationForm")
                    {
                        this.Hide();
                        form.Show();
                        return;
                    }
                }
                this.Hide();
                AuthorizationForm form1 = new AuthorizationForm();
                form1.Show();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down || e.KeyData == Keys.Enter)
                textBox2.Focus();
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Логин и пароль нужны для того что бы обезопасить ваш аккаунт от " +
                "взлома. Регистр учитывается.\nВажно! Укажите Вашу настоящую почту, так как на " +
                "неё придёт информация о логине, пароле, и секретном коде.\nСекретный код будет " +
                "Вам необходим для того что бы разкодировать Вашу записную книжку, привязанную " +
                "ТОЛЬКО к Вашему аккаунту.\nПриложение хорошо защищено от взлома, поэтому Вы " +
                "можете заполнить поля логина и пароля запоминающимися данными.\n\nПомните! На " +
                "каждый компьютер возможно только 10 регистраций.\n\nКонтактная информация: " +
                "TroyHelper@yandex.ru", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down || e.KeyData == Keys.Enter)
                textBox3.Focus();
            if (e.KeyData == Keys.Up)
                textBox1.Focus();
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down)
                buttonRegistration.Focus();
            if (e.KeyData == Keys.Up)
                textBox2.Focus();
            if (e.KeyData == Keys.Enter)
                this.buttonRegistration_Click(sender, e);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e) => pictureBox2.BringToFront();

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
    }
}
