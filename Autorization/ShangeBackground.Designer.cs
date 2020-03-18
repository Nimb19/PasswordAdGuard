namespace Autorization
{
    partial class ChangeBackground
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeBackground));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.gradientPanel2 = new Autorization.GradientPanel();
            this.gradientPanel1 = new Autorization.GradientPanel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button7 = new System.Windows.Forms.Button();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Задать первый цвет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(206, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 37);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(206, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(96, 37);
            this.panel2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Задать второй цвет";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 38);
            this.button3.TabIndex = 4;
            this.button3.Text = "Задать угол (в градусах):";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(206, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 36);
            this.textBox1.TabIndex = 5;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(235, 244);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 40);
            this.button4.TabIndex = 7;
            this.button4.Text = "Задать фон";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(37, 244);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(176, 40);
            this.button5.TabIndex = 9;
            this.button5.Text = "Сбросить фон по умолчанию";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(432, 244);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(176, 40);
            this.button6.TabIndex = 11;
            this.button6.Text = "Вернутся на главную форму";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Angle = 0F;
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel2.BottomColor = System.Drawing.Color.White;
            this.gradientPanel2.Location = new System.Drawing.Point(332, 48);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(291, 162);
            this.gradientPanel2.TabIndex = 6;
            this.gradientPanel2.TopColor = System.Drawing.Color.White;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 60F;
            this.gradientPanel1.BottomColor = System.Drawing.Color.RoyalBlue;
            this.gradientPanel1.Controls.Add(this.button7);
            this.gradientPanel1.Controls.Add(this.checkBox2);
            this.gradientPanel1.Controls.Add(this.checkBox1);
            this.gradientPanel1.Controls.Add(this.button5);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(644, 325);
            this.gradientPanel1.TabIndex = 12;
            this.gradientPanel1.TopColor = System.Drawing.Color.SlateBlue;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(60, 294);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(133, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Сохранить результат";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(257, 294);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(133, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Сохранить результат";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(342, 8);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(269, 34);
            this.button7.TabIndex = 10;
            this.button7.Text = "Задать цвета случайно";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // ChangeBackground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(644, 325);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.gradientPanel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeBackground";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BackgroundColor";
            this.Load += new System.EventHandler(this.ChangeBackground_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private GradientPanel gradientPanel2;
        private System.Windows.Forms.Button button6;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button7;
    }
}