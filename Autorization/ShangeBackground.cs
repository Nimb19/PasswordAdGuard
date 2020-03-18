using System;
using System.Drawing;
using System.Windows.Forms;

namespace Autorization
{
    public partial class ChangeBackground : Form
    {
        Random random = new Random();
        public ChangeBackground()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                panel1.BackColor = colorDialog1.Color;
                gradientPanel2.TopColor = panel1.BackColor;
                gradientPanel2.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                panel2.BackColor = colorDialog2.Color;
                gradientPanel2.BottomColor = panel2.BackColor;
                gradientPanel2.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                    textBox1.Text = "0";
                gradientPanel2.Angle = Convert.ToInt32(textBox1.Text);
                gradientPanel2.Refresh();
            }
            catch
            {
                MessageBox.Show("Некорректно задан угол градиента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                this.button3_Click(sender, e);
        }

        public void button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                AdGuard adGuard = new AdGuard();
                adGuard.gradientPanel1.TopColor = gradientPanel2.TopColor;
                adGuard.gradientPanel1.BottomColor = gradientPanel2.BottomColor;
                adGuard.gradientPanel1.Angle = gradientPanel2.Angle;
                adGuard.gradientPanel1.Refresh();
                if (checkBox1.Checked == true)
                {
                    Properties.Settings.Default.AutoTop = gradientPanel2.TopColor;
                    Properties.Settings.Default.AutoBottom = gradientPanel2.BottomColor;
                    Properties.Settings.Default.AutoAngle = gradientPanel2.Angle;
                    Properties.Settings.Default.Save();
                    adGuard.isLoad = false;
                } else adGuard.isLoad = true;
                adGuard.ShowDialog();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Что то пошло не так", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdGuard adGuard = new AdGuard();
            adGuard.gradientPanel1.TopColor = Color.Crimson;
            adGuard.gradientPanel1.BottomColor = Color.FromArgb(64, 0, 0);
            adGuard.gradientPanel1.Angle = 60;
            adGuard.gradientPanel1.Refresh();
            if (checkBox2.Checked == true)
            {
                Properties.Settings.Default.AutoTop = Color.Crimson;
                Properties.Settings.Default.AutoBottom = Color.FromArgb(64, 0, 0);
                Properties.Settings.Default.AutoAngle = 60;
                Properties.Settings.Default.Save();
                adGuard.isLoad = false;
            }
            else adGuard.isLoad = true;
            adGuard.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdGuard adGuard = new AdGuard();
            adGuard.isLoad = false;
            adGuard.ShowDialog();
            this.Close();
        }

        private void ChangeBackground_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Properties.Settings.Default.AutoTop;
            gradientPanel2.TopColor = panel1.BackColor;

            panel2.BackColor = Properties.Settings.Default.AutoBottom;
            gradientPanel2.BottomColor = panel2.BackColor;

            textBox1.Text = Convert.ToString(Properties.Settings.Default.AutoAngle);
            gradientPanel2.Angle = Convert.ToInt32(textBox1.Text);

            gradientPanel2.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(random.Next(1, 255), random.Next(1, 255), random.Next(1, 255));
            gradientPanel2.TopColor = panel1.BackColor;

            panel2.BackColor = Color.FromArgb(random.Next(1, 255), random.Next(1, 255), random.Next(1, 255));
            gradientPanel2.BottomColor = panel2.BackColor;

            textBox1.Text = Convert.ToString(random.Next(0, 360));
            gradientPanel2.Angle = Convert.ToInt32(textBox1.Text);

            gradientPanel2.Refresh();
        }
    }
}
