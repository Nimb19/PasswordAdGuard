using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Autorization
{
    public partial class OfflineAdGuard : Form
    {
        string atlantall = "123456789%*?@#$abcdefghijklmnopqrstuvwxyz%*?@#$ABCDEFGHIJKLMNOPQRSTUVWXYZ%*?@#$",
               atlant1 = "123456789",
               atlant2 = "abcdefghijklmnopqrstuvwxyz",
               atlant3 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
               atlant4 = "%*?@#$",
               atlantjir = "";
        string pass = "pass.txt";

        Font underlineFont = new Font("Century Gothic", 12, FontStyle.Bold | FontStyle.Underline);
        Font defFont = new Font("Century Gothic", 12, FontStyle.Bold);

        ToolTip copysuccess = new ToolTip();

        public OfflineAdGuard()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            helperLogin();
            copysuccess.SetToolTip(pictureBox1, "Скопировать");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text.Replace(" ", string.Empty) == "")
            {
                DialogResult dialogResult = MessageBox.Show("Хотите ли вы вписать идентификатор (например, сайт), для того что бы быстрее найти свой пароль?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (dialogResult == DialogResult.Yes)
                {
                    comboBox3.Focus();
                    return;
                }
            }

            using (StreamWriter stream = new StreamWriter(pass, true))
            {
                stream.WriteLine("");
                stream.WriteLine("Идентификатор(сайт):   " + comboBox3.Text);
                if (comboBox2.Text != "")
                    stream.WriteLine("Логин:                 " + comboBox2.Text);
                stream.WriteLine("Пароль:                " + comboBox4.Text);
                stream.WriteLine();
                stream.WriteLine(string.Concat(Enumerable.Repeat("=", 50)));
            }
            if (comboBox2.Items.IndexOf(comboBox2.Text) == -1 && comboBox2.Text.Replace(" ", string.Empty) == "")
                comboBox2.Items.Add(comboBox2.Text);
            MessageBox.Show("Данные успешно записаны!");
            helperLogin();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (Clipboard.GetText() == comboBox4.Text)
            {
                copysuccess.SetToolTip(pictureBox1, "Успешно скопировано!");
                return;
            }
            copysuccess.SetToolTip(pictureBox1, "Скопировать");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (comboBox4.Text.Replace(" ", string.Empty) == "")
            {
                return;
            }
            Clipboard.SetText(comboBox4.Text);
            if (Clipboard.GetText() == comboBox4.Text)
                copysuccess.SetToolTip(pictureBox1, "Успешно скопировано!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.button5_Click(this, e);
            comboBox3.Text = "";
            if (comboBox2.Items.IndexOf(comboBox2.Text) == -1 && comboBox2.Text == "")
                comboBox2.Items.Add(comboBox2.Text);
            comboBox2.Text = "";
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

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var rand = new Random(); int i; comboBox4.Text = "";

            if (this.comboBox1.Text == "") { return; }

            if (this.checkBox1.Checked == true && this.checkBox2.Checked == true && this.checkBox3.Checked == true && this.checkBox4.Checked == true)
            {
                for (i = 1; i <= Convert.ToInt32(comboBox1.Text); i++)
                {
                    comboBox4.Text += Convert.ToString(atlantall[1 + rand.Next(78)]);
                }
                return;
            }

            if (this.checkBox1.Checked == true && this.checkBox2.Checked == true && this.checkBox3.Checked == true && this.checkBox4.Checked == false)
            {
                atlantjir = atlant1 + atlant2 + atlant3;
                for (i = 1; i <= Convert.ToInt32(comboBox1.Text); i++)
                {
                    comboBox4.Text += Convert.ToString(atlantjir[rand.Next(atlantjir.Length - 1) + 1]);
                }
                return;
            }
            //1
            if (this.checkBox1.Checked == true && this.checkBox2.Checked == true && this.checkBox3.Checked == false && this.checkBox4.Checked == true)
            {
                atlantjir = atlant1 + atlant2 + atlant4;
                for (i = 1; i <= Convert.ToInt32(comboBox1.Text); i++)
                {
                    comboBox4.Text += Convert.ToString(atlantjir[rand.Next(atlantjir.Length - 1) + 1]);
                }
                return;
            }

            if (this.checkBox1.Checked == true && this.checkBox2.Checked == true && this.checkBox3.Checked == false && this.checkBox4.Checked == false)
            {
                atlantjir = atlant1 + atlant2;
                for (i = 1; i <= Convert.ToInt32(comboBox1.Text); i++)
                {
                    comboBox4.Text += Convert.ToString(atlantjir[rand.Next(atlantjir.Length - 1) + 1]);
                }
                return;
            }
            //2
            if (this.checkBox1.Checked == true && this.checkBox2.Checked == false && this.checkBox3.Checked == true && this.checkBox4.Checked == true)
            {
                atlantjir = atlant1 + atlant4 + atlant3;
                for (i = 1; i <= Convert.ToInt32(comboBox1.Text); i++)
                {
                    comboBox4.Text += Convert.ToString(atlantjir[rand.Next(atlantjir.Length - 1) + 1]);
                }
                return;
            }

            if (this.checkBox1.Checked == true && this.checkBox2.Checked == false && this.checkBox3.Checked == true && this.checkBox4.Checked == false)
            {
                atlantjir = atlant1 + atlant3;
                for (i = 1; i <= Convert.ToInt32(comboBox1.Text); i++)
                {
                    comboBox4.Text += Convert.ToString(atlantjir[rand.Next(atlantjir.Length - 1) + 1]);
                }
                return;
            }
            //3
            if (this.checkBox1.Checked == true && this.checkBox2.Checked == false && this.checkBox3.Checked == false && this.checkBox4.Checked == true)
            {
                atlantjir = atlant1 + atlant4;
                for (i = 1; i <= Convert.ToInt32(comboBox1.Text); i++)
                {
                    comboBox4.Text += Convert.ToString(atlantjir[rand.Next(atlantjir.Length - 1) + 1]);
                }
                return;
            }

            if (this.checkBox1.Checked == true && this.checkBox2.Checked == false && this.checkBox3.Checked == false && this.checkBox4.Checked == false)
            {
                for (i = 1; i <= Convert.ToInt32(comboBox1.Text); i++)
                {
                    comboBox4.Text += Convert.ToString(atlant1[rand.Next(atlant1.Length - 1) + 1]);
                }
                return;
            }
            //4
            if (this.checkBox1.Checked == false && this.checkBox2.Checked == true && this.checkBox3.Checked == true && this.checkBox4.Checked == true)
            {
                atlantjir = atlant4 + atlant2 + atlant3;
                for (i = 1; i <= Convert.ToInt32(comboBox1.Text); i++)
                {
                    comboBox4.Text += Convert.ToString(atlantjir[rand.Next(atlantjir.Length - 1) + 1]);
                }
                return;
            }
            if (this.checkBox1.Checked == false && this.checkBox2.Checked == true && this.checkBox3.Checked == true && this.checkBox4.Checked == false)
            {
                atlantjir = atlant2 + atlant3;
                for (i = 1; i <= Convert.ToInt32(comboBox1.Text); i++)
                {
                    comboBox4.Text += Convert.ToString(atlantjir[rand.Next(atlantjir.Length - 1) + 1]);
                }
                return;
            }
            //5
            if (this.checkBox1.Checked == false && this.checkBox2.Checked == true && this.checkBox3.Checked == false && this.checkBox4.Checked == true)
            {
                atlantjir = atlant4 + atlant2;
                for (i = 1; i <= Convert.ToInt32(comboBox1.Text); i++)
                {
                    comboBox4.Text += Convert.ToString(atlantjir[rand.Next(atlantjir.Length - 1) + 1]);
                }
                return;
            }
            if (this.checkBox1.Checked == false && this.checkBox2.Checked == true && this.checkBox3.Checked == false && this.checkBox4.Checked == false)
            {
                for (i = 1; i <= Convert.ToInt32(comboBox1.Text); i++)
                {
                    comboBox4.Text += Convert.ToString(atlant2[rand.Next(atlant2.Length - 1) + 1]);
                }
                return;
            }
            //6
            if (this.checkBox1.Checked == false && this.checkBox2.Checked == false && this.checkBox3.Checked == true && this.checkBox4.Checked == true)
            {
                atlantjir = atlant4 + atlant3;
                for (i = 1; i <= Convert.ToInt32(comboBox1.Text); i++)
                {
                    comboBox4.Text += Convert.ToString(atlantjir[rand.Next(atlantjir.Length - 1) + 1]);
                }
                return;
            }
            if (this.checkBox1.Checked == false && this.checkBox2.Checked == false && this.checkBox3.Checked == true && this.checkBox4.Checked == false)
            {
                for (i = 1; i <= Convert.ToInt32(comboBox1.Text); i++)
                {
                    comboBox4.Text += Convert.ToString(atlant3[rand.Next(atlant3.Length - 1) + 1]);
                }
                return;
            }
            //7
            if (this.checkBox1.Checked == false && this.checkBox2.Checked == false && this.checkBox3.Checked == false && this.checkBox4.Checked == true)
            {
                for (i = 1; i <= Convert.ToInt32(comboBox1.Text); i++)
                {
                    comboBox4.Text += Convert.ToString(atlant4[rand.Next(atlant4.Length - 1) + 1]);
                }
                return;
            }
            return;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("pass.txt") == true)
            {
                System.Diagnostics.Process.Start(pass);
            }
            else
            {
                MessageBox.Show("Блокнот ещё не создан. Вы можете записать пароль для того, что бы автоматически создать блокнот.");
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            this.button5_Click(this, e);
        }

        private void OfflineAdGuard_Load(object sender, EventArgs e)
        {
            this.button5_Click(sender, e);
            comboBox2.Items.Add("В офлайн версии недоступно");
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void helperLogin()
        {
            comboBox2.Items.Contains("Прошлые логины недоступны в этой версии");
        }
    }
}
