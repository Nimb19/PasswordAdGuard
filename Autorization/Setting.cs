using System;
using System.Windows.Forms;

namespace Autorization
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e) => pictureBox2.BringToFront();

        private void pictureBox2_MouseLeave(object sender, EventArgs e) => pictureBox3.BringToFront();

        private void pictureBox2_Click(object sender, EventArgs e) =>
            MessageBox.Show("Все настройки применимы только к данному устройству. За подробной информацией пишите в тех. поддержку." +
                "\n\nКонтактная информация:\nTroyHelper@yandex.ru", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        

        private void Setting_Load(object sender, EventArgs e)
        {
            // Base
            if (Properties.Settings.Default.EnterBase == false)
                checkBoxBase.Checked = false;
            else
                checkBoxBase.Checked = true;

            // Txt
            if (Properties.Settings.Default.EnterTxt == false)
                checkBoxTxt.Checked = false;
            else
                checkBoxTxt.Checked = true;

            // AutoEnter
            if (Properties.Settings.Default.isAutoEnter == false)
                checkBoxIsAutoRun.Checked = false;
            else
                checkBoxIsAutoRun.Checked = true;

            // SecretEnter
            if (Properties.Settings.Default.SecretEnter == true)
            {
                checkBoxSecretEnter.Visible = true;
                checkBoxSecretEnter.Checked = true;
            }
            else
            {
                checkBoxSecretEnter.Visible = false;
                checkBoxSecretEnter.Checked = false;
            }

            //radioBtn
            if (Properties.Settings.Default.radioNote == 1) // 1 - открывать из БД; 2 - открывать из блкнота; 3 - не открывать автоматически.
                radioButtonBase.Checked = true;
            else if (Properties.Settings.Default.radioNote == 2)
                radioButtonTxt.Checked = true;
            else
                radioButtonNotAuto.Checked = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            changeSettings();
            this.Text = "Settings (настройки сохранены)";
        }

        private void Setting_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isChanges())
            {
                DialogResult msg = MessageBox.Show("Хотите ли Вы сохранить изменения в настройках?", "Информация о закрытии", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    changeSettings();
                    e.Cancel = false;
                } else if (msg == DialogResult.No)
                {
                    e.Cancel = false;
                } else
                {
                    e.Cancel = true;
                }
            }
        }

        private void changeSettings() // Сохраняет настройки
        {
            // Base
            if (Properties.Settings.Default.EnterBase == false && checkBoxBase.Checked == true)
                Properties.Settings.Default.EnterBase = true;
            else if (Properties.Settings.Default.EnterBase == true && checkBoxBase.Checked == false)
                Properties.Settings.Default.EnterBase = false;

            // Txt
            if (Properties.Settings.Default.EnterTxt == false && checkBoxTxt.Checked == true)
                Properties.Settings.Default.EnterTxt = true;
            else if (Properties.Settings.Default.EnterTxt == true && checkBoxTxt.Checked == false)
                Properties.Settings.Default.EnterTxt = false;

            // AutoEnter
            if (Properties.Settings.Default.isAutoEnter == false && checkBoxIsAutoRun.Checked == true)
            {
                Properties.Settings.Default.deafLog = Properties.Settings.Default.currLog; 
                Properties.Settings.Default.deafPass = Properties.Settings.Default.currPass;
                Properties.Settings.Default.isAutoEnter = true;
            }
            else if (Properties.Settings.Default.isAutoEnter == true && checkBoxIsAutoRun.Checked == false)
                Properties.Settings.Default.isAutoEnter = false;

            // SecretEnter
            if (Properties.Settings.Default.SecretEnter == true && checkBoxSecretEnter.Checked == false)
                Properties.Settings.Default.SecretEnter = false;

            //radioBtn. Проверки на изменённость, конкретно в этом методе, не добавил ради понятного кода.
            if (radioButtonBase.Checked == true)
                Properties.Settings.Default.radioNote = 1;  // 1 - открывать из БД;

            else if (radioButtonTxt.Checked == true)
                Properties.Settings.Default.radioNote = 2;  // 2 - открывать из блкнота;

            else if (radioButtonNotAuto.Checked == true)
                Properties.Settings.Default.radioNote = 3;  // 3 - не открывать автоматически.

            // Сериализуем
            Properties.Settings.Default.Save();

            // Если после сохранения настроек окно не закроется, то удалится чекбокс, с галкой захода без пароля в блокнот (с доступом к базе данных).
            if (Properties.Settings.Default.SecretEnter == true) 
                checkBoxSecretEnter.Visible = true;
            else
                checkBoxSecretEnter.Visible = false;
        }

        private bool isChanges() // Проверяет были ли изменения в настройках
        {
            // Base
            if (Properties.Settings.Default.EnterBase == false && checkBoxBase.Checked == true)
                return true;
            else if (Properties.Settings.Default.EnterBase == true && checkBoxBase.Checked == false)
                return true;

            // Txt
            if (Properties.Settings.Default.EnterTxt == false && checkBoxTxt.Checked == true)
                return true;
            else if (Properties.Settings.Default.EnterTxt == true && checkBoxTxt.Checked == false)
                return true;

            // AutoEnter
            if (Properties.Settings.Default.isAutoEnter == false && checkBoxIsAutoRun.Checked == true)
                return true;
            else if (Properties.Settings.Default.isAutoEnter == true && checkBoxIsAutoRun.Checked == false)
                return true;

            // SecretEnter
            if (Properties.Settings.Default.SecretEnter == true && checkBoxSecretEnter.Checked == false)
                return true;

            //radioBtn
            if (Properties.Settings.Default.radioNote == 1 && radioButtonBase.Checked != true)          // 1 - открывать из БД;
                return true;
            else if (Properties.Settings.Default.radioNote == 2 && radioButtonTxt.Checked != true)      // 2 - открывать из блкнота;
                return true;
            else if (Properties.Settings.Default.radioNote == 3 && radioButtonNotAuto.Checked != true)  // 3 - не открывать автоматически.
                return true;

            return false;
        }
    }
}
