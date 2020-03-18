namespace Autorization
{
    partial class AdGuard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdGuard));
            this.buttonOpenNote = new System.Windows.Forms.Button();
            this.checkBoxBadges = new System.Windows.Forms.CheckBox();
            this.checkBoxUppercase = new System.Windows.Forms.CheckBox();
            this.checkBoxLowerCase = new System.Windows.Forms.CheckBox();
            this.checkBoxNum = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCountPass = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxCopy = new System.Windows.Forms.PictureBox();
            this.comboBoxLogin = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.comboBoxPassword = new System.Windows.Forms.ComboBox();
            this.comboBoxId = new System.Windows.Forms.ComboBox();
            this.gradientPanel1 = new Autorization.GradientPanel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.аккаунтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиИзУчётнойЗаписиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьПриложениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьФонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCopy)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenNote
            // 
            this.buttonOpenNote.BackColor = System.Drawing.Color.White;
            this.buttonOpenNote.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonOpenNote.Location = new System.Drawing.Point(207, 25);
            this.buttonOpenNote.Name = "buttonOpenNote";
            this.buttonOpenNote.Size = new System.Drawing.Size(166, 76);
            this.buttonOpenNote.TabIndex = 7;
            this.buttonOpenNote.Text = "Открыть записную книжку";
            this.buttonOpenNote.UseVisualStyleBackColor = false;
            this.buttonOpenNote.Click += new System.EventHandler(this.buttonOpenNote_Click);
            // 
            // checkBoxBadges
            // 
            this.checkBoxBadges.AutoSize = true;
            this.checkBoxBadges.Checked = true;
            this.checkBoxBadges.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBadges.Font = new System.Drawing.Font("Calibri", 12.6F);
            this.checkBoxBadges.Location = new System.Drawing.Point(21, 128);
            this.checkBoxBadges.Name = "checkBoxBadges";
            this.checkBoxBadges.Size = new System.Drawing.Size(267, 25);
            this.checkBoxBadges.TabIndex = 6;
            this.checkBoxBadges.Text = "Спецсимволы ( %, *, ?, @, #, $, ~ )";
            this.checkBoxBadges.UseVisualStyleBackColor = true;
            this.checkBoxBadges.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // checkBoxUppercase
            // 
            this.checkBoxUppercase.AutoSize = true;
            this.checkBoxUppercase.Checked = true;
            this.checkBoxUppercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUppercase.Font = new System.Drawing.Font("Calibri", 12.6F);
            this.checkBoxUppercase.Location = new System.Drawing.Point(21, 101);
            this.checkBoxUppercase.Name = "checkBoxUppercase";
            this.checkBoxUppercase.Size = new System.Drawing.Size(147, 25);
            this.checkBoxUppercase.TabIndex = 5;
            this.checkBoxUppercase.Text = "Строчные бкувы";
            this.checkBoxUppercase.UseVisualStyleBackColor = true;
            this.checkBoxUppercase.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // checkBoxLowerCase
            // 
            this.checkBoxLowerCase.AutoSize = true;
            this.checkBoxLowerCase.Checked = true;
            this.checkBoxLowerCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLowerCase.Font = new System.Drawing.Font("Calibri", 12.6F);
            this.checkBoxLowerCase.Location = new System.Drawing.Point(21, 74);
            this.checkBoxLowerCase.Name = "checkBoxLowerCase";
            this.checkBoxLowerCase.Size = new System.Drawing.Size(159, 25);
            this.checkBoxLowerCase.TabIndex = 4;
            this.checkBoxLowerCase.Text = "Прописные буквы";
            this.checkBoxLowerCase.UseVisualStyleBackColor = true;
            this.checkBoxLowerCase.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // checkBoxNum
            // 
            this.checkBoxNum.AutoSize = true;
            this.checkBoxNum.Checked = true;
            this.checkBoxNum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNum.Font = new System.Drawing.Font("Calibri", 12.6F);
            this.checkBoxNum.Location = new System.Drawing.Point(21, 47);
            this.checkBoxNum.Name = "checkBoxNum";
            this.checkBoxNum.Size = new System.Drawing.Size(80, 25);
            this.checkBoxNum.TabIndex = 3;
            this.checkBoxNum.Text = "Цифры";
            this.checkBoxNum.UseVisualStyleBackColor = true;
            this.checkBoxNum.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(92, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "- количество символов пароля.";
            // 
            // comboBoxCountPass
            // 
            this.comboBoxCountPass.DropDownHeight = 150;
            this.comboBoxCountPass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCountPass.FormattingEnabled = true;
            this.comboBoxCountPass.IntegralHeight = false;
            this.comboBoxCountPass.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64"});
            this.comboBoxCountPass.Location = new System.Drawing.Point(20, 177);
            this.comboBoxCountPass.MaxLength = 2;
            this.comboBoxCountPass.Name = "comboBoxCountPass";
            this.comboBoxCountPass.Size = new System.Drawing.Size(66, 28);
            this.comboBoxCountPass.TabIndex = 0;
            this.comboBoxCountPass.Text = "12";
            this.comboBoxCountPass.TextChanged += new System.EventHandler(this.comboBoxCountPass_TextChanged);
            this.comboBoxCountPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxCountPass_KeyPress);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.White;
            this.buttonClear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.ForeColor = System.Drawing.Color.Black;
            this.buttonClear.Location = new System.Drawing.Point(185, 51);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(98, 28);
            this.buttonClear.TabIndex = 22;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(37, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "От 0 до 64 символов";
            // 
            // pictureBoxCopy
            // 
            this.pictureBoxCopy.BackColor = System.Drawing.Color.White;
            this.pictureBoxCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCopy.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCopy.Image")));
            this.pictureBoxCopy.Location = new System.Drawing.Point(257, 182);
            this.pictureBoxCopy.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.pictureBoxCopy.Name = "pictureBoxCopy";
            this.pictureBoxCopy.Size = new System.Drawing.Size(23, 27);
            this.pictureBoxCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCopy.TabIndex = 21;
            this.pictureBoxCopy.TabStop = false;
            this.pictureBoxCopy.Click += new System.EventHandler(this.pictureBoxCopy_Click);
            this.pictureBoxCopy.MouseEnter += new System.EventHandler(this.pictureBoxCopy_MouseEnter);
            // 
            // comboBoxLogin
            // 
            this.comboBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxLogin.Font = new System.Drawing.Font("Calibri", 13F);
            this.comboBoxLogin.FormattingEnabled = true;
            this.comboBoxLogin.IntegralHeight = false;
            this.comboBoxLogin.ItemHeight = 21;
            this.comboBoxLogin.Location = new System.Drawing.Point(28, 131);
            this.comboBoxLogin.Name = "comboBoxLogin";
            this.comboBoxLogin.Size = new System.Drawing.Size(255, 29);
            this.comboBoxLogin.TabIndex = 20;
            this.comboBoxLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxLogin_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonOpenNote);
            this.groupBox1.Controls.Add(this.checkBoxBadges);
            this.groupBox1.Controls.Add(this.checkBoxUppercase);
            this.groupBox1.Controls.Add(this.checkBoxLowerCase);
            this.groupBox1.Controls.Add(this.checkBoxNum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxCountPass);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(302, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 235);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройка генератора:";
            // 
            // buttonWrite
            // 
            this.buttonWrite.BackColor = System.Drawing.Color.White;
            this.buttonWrite.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWrite.Location = new System.Drawing.Point(185, 228);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(98, 58);
            this.buttonWrite.TabIndex = 18;
            this.buttonWrite.Text = "Записать";
            this.buttonWrite.UseVisualStyleBackColor = false;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // comboBoxPassword
            // 
            this.comboBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxPassword.Font = new System.Drawing.Font("Calibri", 13F);
            this.comboBoxPassword.FormattingEnabled = true;
            this.comboBoxPassword.IntegralHeight = false;
            this.comboBoxPassword.ItemHeight = 21;
            this.comboBoxPassword.Location = new System.Drawing.Point(28, 181);
            this.comboBoxPassword.Name = "comboBoxPassword";
            this.comboBoxPassword.Size = new System.Drawing.Size(255, 29);
            this.comboBoxPassword.TabIndex = 28;
            this.comboBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxPassword_KeyDown);
            // 
            // comboBoxId
            // 
            this.comboBoxId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxId.Font = new System.Drawing.Font("Calibri", 13F);
            this.comboBoxId.FormattingEnabled = true;
            this.comboBoxId.IntegralHeight = false;
            this.comboBoxId.ItemHeight = 21;
            this.comboBoxId.Items.AddRange(new object[] {
            "Google.com",
            "Yandex.ru",
            "YouTube.com",
            "VK.com",
            "Mail.ru",
            "Ok.ru",
            "Instagram.com",
            "Facebook.com"});
            this.comboBoxId.Location = new System.Drawing.Point(28, 81);
            this.comboBoxId.Name = "comboBoxId";
            this.comboBoxId.Size = new System.Drawing.Size(255, 29);
            this.comboBoxId.TabIndex = 25;
            this.comboBoxId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxId_KeyDown);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.BackColor = System.Drawing.Color.White;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanel1.Controls.Add(this.buttonUpdate);
            this.gradientPanel1.Controls.Add(this.label6);
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.menuStrip1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(722, 320);
            this.gradientPanel1.TabIndex = 29;
            this.gradientPanel1.TopColor = System.Drawing.Color.Empty;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.White;
            this.buttonUpdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(28, 227);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(151, 58);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Обновить пароль";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(-2, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Аккаунт пользователя: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Пароль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Логин:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Идентификатор:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.аккаунтToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(720, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // аккаунтToolStripMenuItem
            // 
            this.аккаунтToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выйтиИзУчётнойЗаписиToolStripMenuItem,
            this.закрытьПриложениеToolStripMenuItem});
            this.аккаунтToolStripMenuItem.Name = "аккаунтToolStripMenuItem";
            this.аккаунтToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.аккаунтToolStripMenuItem.Text = "Аккаунт";
            // 
            // выйтиИзУчётнойЗаписиToolStripMenuItem
            // 
            this.выйтиИзУчётнойЗаписиToolStripMenuItem.Name = "выйтиИзУчётнойЗаписиToolStripMenuItem";
            this.выйтиИзУчётнойЗаписиToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.выйтиИзУчётнойЗаписиToolStripMenuItem.Text = "Выйти из учётной записи";
            this.выйтиИзУчётнойЗаписиToolStripMenuItem.Click += new System.EventHandler(this.выйтиИзУчётнойЗаписиToolStripMenuItem_Click);
            // 
            // закрытьПриложениеToolStripMenuItem
            // 
            this.закрытьПриложениеToolStripMenuItem.Name = "закрытьПриложениеToolStripMenuItem";
            this.закрытьПриложениеToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.закрытьПриложениеToolStripMenuItem.Text = "Закрыть приложение";
            this.закрытьПриложениеToolStripMenuItem.Click += new System.EventHandler(this.закрытьПриложениеToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменитьФонToolStripMenuItem,
            this.настройкиToolStripMenuItem1});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.настройкиToolStripMenuItem.Text = "Параметры";
            // 
            // сменитьФонToolStripMenuItem
            // 
            this.сменитьФонToolStripMenuItem.Name = "сменитьФонToolStripMenuItem";
            this.сменитьФонToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.сменитьФонToolStripMenuItem.Text = "Сменить фон";
            this.сменитьФонToolStripMenuItem.Click += new System.EventHandler(this.сменитьФонToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem1
            // 
            this.настройкиToolStripMenuItem1.Name = "настройкиToolStripMenuItem1";
            this.настройкиToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.настройкиToolStripMenuItem1.Text = "Настройки";
            this.настройкиToolStripMenuItem1.Click += new System.EventHandler(this.настройкиToolStripMenuItem1_Click);
            // 
            // AdGuard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 320);
            this.Controls.Add(this.comboBoxId);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.pictureBoxCopy);
            this.Controls.Add(this.comboBoxLogin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.comboBoxPassword);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdGuard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PasswordAdGuard";
            this.Load += new System.EventHandler(this.AdGuard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCopy)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonOpenNote;
        private System.Windows.Forms.CheckBox checkBoxBadges;
        private System.Windows.Forms.CheckBox checkBoxUppercase;
        private System.Windows.Forms.CheckBox checkBoxLowerCase;
        private System.Windows.Forms.CheckBox checkBoxNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCountPass;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxCopy;
        private System.Windows.Forms.ComboBox comboBoxLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.ComboBox comboBoxPassword;
        private System.Windows.Forms.ComboBox comboBoxId;
        internal GradientPanel gradientPanel1;
        private System.Windows.Forms.Button buttonUpdate;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem аккаунтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиИзУчётнойЗаписиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьПриложениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьФонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem1;
    }
}