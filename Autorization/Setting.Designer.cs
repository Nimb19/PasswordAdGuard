namespace Autorization
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.gradientPanel1 = new Autorization.GradientPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxBase = new System.Windows.Forms.CheckBox();
            this.checkBoxTxt = new System.Windows.Forms.CheckBox();
            this.checkBoxIsAutoRun = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonNotAuto = new System.Windows.Forms.RadioButton();
            this.radioButtonBase = new System.Windows.Forms.RadioButton();
            this.radioButtonTxt = new System.Windows.Forms.RadioButton();
            this.checkBoxSecretEnter = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gradientPanel1.Controls.Add(this.groupBox2);
            this.gradientPanel1.Controls.Add(this.groupBox1);
            this.gradientPanel1.Controls.Add(this.checkBoxSecretEnter);
            this.gradientPanel1.Controls.Add(this.pictureBox3);
            this.gradientPanel1.Controls.Add(this.pictureBox2);
            this.gradientPanel1.Controls.Add(this.buttonSave);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.ForeColor = System.Drawing.Color.Black;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(631, 337);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.checkBoxBase);
            this.groupBox2.Controls.Add(this.checkBoxTxt);
            this.groupBox2.Controls.Add(this.checkBoxIsAutoRun);
            this.groupBox2.Location = new System.Drawing.Point(19, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 159);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройки записи:";
            // 
            // checkBoxBase
            // 
            this.checkBoxBase.AutoSize = true;
            this.checkBoxBase.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxBase.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxBase.Location = new System.Drawing.Point(6, 39);
            this.checkBoxBase.Name = "checkBoxBase";
            this.checkBoxBase.Size = new System.Drawing.Size(265, 25);
            this.checkBoxBase.TabIndex = 0;
            this.checkBoxBase.Text = "Записывать данные в облако.";
            this.checkBoxBase.UseVisualStyleBackColor = false;
            // 
            // checkBoxTxt
            // 
            this.checkBoxTxt.AutoSize = true;
            this.checkBoxTxt.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxTxt.Location = new System.Drawing.Point(6, 81);
            this.checkBoxTxt.Name = "checkBoxTxt";
            this.checkBoxTxt.Size = new System.Drawing.Size(270, 25);
            this.checkBoxTxt.TabIndex = 2;
            this.checkBoxTxt.Text = "Записывать данные в блокнот.";
            this.checkBoxTxt.UseVisualStyleBackColor = false;
            // 
            // checkBoxIsAutoRun
            // 
            this.checkBoxIsAutoRun.AutoSize = true;
            this.checkBoxIsAutoRun.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxIsAutoRun.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxIsAutoRun.Location = new System.Drawing.Point(6, 125);
            this.checkBoxIsAutoRun.Name = "checkBoxIsAutoRun";
            this.checkBoxIsAutoRun.Size = new System.Drawing.Size(275, 25);
            this.checkBoxIsAutoRun.TabIndex = 6;
            this.checkBoxIsAutoRun.Text = "Автозагрузка в учётную запись.";
            this.checkBoxIsAutoRun.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButtonNotAuto);
            this.groupBox1.Controls.Add(this.radioButtonBase);
            this.groupBox1.Controls.Add(this.radioButtonTxt);
            this.groupBox1.Location = new System.Drawing.Point(317, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 159);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Автоматически подгружать в блокнот данные";
            // 
            // radioButtonNotAuto
            // 
            this.radioButtonNotAuto.AutoSize = true;
            this.radioButtonNotAuto.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonNotAuto.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.radioButtonNotAuto.Location = new System.Drawing.Point(6, 125);
            this.radioButtonNotAuto.Name = "radioButtonNotAuto";
            this.radioButtonNotAuto.Size = new System.Drawing.Size(270, 25);
            this.radioButtonNotAuto.TabIndex = 19;
            this.radioButtonNotAuto.TabStop = true;
            this.radioButtonNotAuto.Text = "не подгружать автоматически.";
            this.radioButtonNotAuto.UseVisualStyleBackColor = false;
            // 
            // radioButtonBase
            // 
            this.radioButtonBase.AutoSize = true;
            this.radioButtonBase.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonBase.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.radioButtonBase.Location = new System.Drawing.Point(6, 39);
            this.radioButtonBase.Name = "radioButtonBase";
            this.radioButtonBase.Size = new System.Drawing.Size(113, 25);
            this.radioButtonBase.TabIndex = 17;
            this.radioButtonBase.TabStop = true;
            this.radioButtonBase.Text = "из облака.";
            this.radioButtonBase.UseVisualStyleBackColor = false;
            // 
            // radioButtonTxt
            // 
            this.radioButtonTxt.AutoSize = true;
            this.radioButtonTxt.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonTxt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.radioButtonTxt.Location = new System.Drawing.Point(6, 81);
            this.radioButtonTxt.Name = "radioButtonTxt";
            this.radioButtonTxt.Size = new System.Drawing.Size(128, 25);
            this.radioButtonTxt.TabIndex = 18;
            this.radioButtonTxt.TabStop = true;
            this.radioButtonTxt.Text = "из блокнота.";
            this.radioButtonTxt.UseVisualStyleBackColor = false;
            // 
            // checkBoxSecretEnter
            // 
            this.checkBoxSecretEnter.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxSecretEnter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxSecretEnter.Location = new System.Drawing.Point(151, 234);
            this.checkBoxSecretEnter.Name = "checkBoxSecretEnter";
            this.checkBoxSecretEnter.Size = new System.Drawing.Size(342, 23);
            this.checkBoxSecretEnter.TabIndex = 16;
            this.checkBoxSecretEnter.Text = "Выполнять автовход в записную книжку.";
            this.checkBoxSecretEnter.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Autorization.Properties.Resources.infoleave;
            this.pictureBox3.Location = new System.Drawing.Point(2, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Autorization.Properties.Resources.infoenter;
            this.pictureBox2.Location = new System.Drawing.Point(2, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSave.FlatAppearance.BorderSize = 2;
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(151, 263);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(325, 61);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Сохранить изменения";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(226, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Настройки:";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 337);
            this.Controls.Add(this.gradientPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Setting_FormClosing);
            this.Load += new System.EventHandler(this.Setting_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.CheckBox checkBoxTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxBase;
        private System.Windows.Forms.CheckBox checkBoxIsAutoRun;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkBoxSecretEnter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonNotAuto;
        private System.Windows.Forms.RadioButton radioButtonBase;
        private System.Windows.Forms.RadioButton radioButtonTxt;
    }
}