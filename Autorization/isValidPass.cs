using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Autorization
{
    public partial class isValidPass : Form
    {
        bool show = true;
        DB db = new DB();
        HashClass hash = new HashClass();

        public isValidPass()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }
        private void pictureBox3_MouseEnter(object sender, EventArgs e) => pictureBox2.BringToFront();

        private void pictureBox2_MouseLeave(object sender, EventArgs e) => pictureBox3.BringToFront();

        private void isValidPass_FormClosed(object sender, FormClosedEventArgs e) => GC.Collect();

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e) =>
            MessageBox.Show("Ваш секретный пароль был отправлен на Вашу почту при регистрации.\n\n" +
                "Если Вы не можете по каким либо причинам получить доступ к секретному паролю, то напишите в тех. " +
                "поддержку:\n\nTroyHelper@yandex.ru", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (show)
            {
                string Code;
                try
                {
                    int.Parse(textBox2.Text);
                    Code = textBox2.Text;
                }
                catch
                {
                    MessageBox.Show("Некорректное значение. Код должен состоять из четырёх цифр.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                show = false;
                Verification(Code);
            }
            else return;
        }

        private async void Verification(string code)
        {
            bool MyResult = false;
            labelLoad.Visible = true;
            await Task.Run(() =>
            {
                try
                {
                    string name = hash.hashlogin(Properties.Settings.Default.currLog);
                    string hashpass = hash.codeparse(code);

                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `code` = @uC", db.getConnection());

                    command.Parameters.Add("uL", MySqlDbType.VarChar).Value = name;
                    command.Parameters.Add("uC", MySqlDbType.VarChar).Value = hashpass;

                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        MyResult = true;
                    }
                    else
                    {
                        Properties.Settings.Default.SecretEnter = false;
                        Properties.Settings.Default.Save();
                        MessageBox.Show("Данные введены неверно. Повторите попытку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    Properties.Settings.Default.SecretEnter = false;
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Нету доступа к базе данных. Повторите попытку позже.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
            if (MyResult)
            {
                if (checkBox1.Checked == true)
                {
                    Properties.Settings.Default.SecretEnter = true;
                    Properties.Settings.Default.Save();
                }
                this.Hide();
                Notebook notebook = new Notebook();
                notebook.ShowDialog();
                this.Close();
            }
            labelLoad.Visible = false;
            show = true;
        }
    }
}
