namespace Autorization
{
    partial class Notebook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notebook));
            this.textBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьИзмененияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВБлокнотИОблакоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьИзмененияВОблакоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.СохранитьТолькоВБлокнотtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выгрузитьСБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загружатьВсегдаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьДанныеСБлокнотаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьОкноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьПриложениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(0, 28);
            this.textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(1077, 733);
            this.textBox.TabIndex = 0;
            this.textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1077, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьИзмененияToolStripMenuItem,
            this.выгрузитьСБДToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.закрытьОкноToolStripMenuItem,
            this.закрытьПриложениеToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // сохранитьИзмененияToolStripMenuItem
            // 
            this.сохранитьИзмененияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьВБлокнотИОблакоToolStripMenuItem,
            this.сохранитьИзмененияВОблакоToolStripMenuItem,
            this.СохранитьТолькоВБлокнотtoolStripMenuItem});
            this.сохранитьИзмененияToolStripMenuItem.Name = "сохранитьИзмененияToolStripMenuItem";
            this.сохранитьИзмененияToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.сохранитьИзмененияToolStripMenuItem.Text = "Сохранить изменения";
            // 
            // сохранитьВБлокнотИОблакоToolStripMenuItem
            // 
            this.сохранитьВБлокнотИОблакоToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сохранитьВБлокнотИОблакоToolStripMenuItem.Name = "сохранитьВБлокнотИОблакоToolStripMenuItem";
            this.сохранитьВБлокнотИОблакоToolStripMenuItem.Size = new System.Drawing.Size(761, 26);
            this.сохранитьВБлокнотИОблакоToolStripMenuItem.Text = "Сохранить в блокнот и облако";
            this.сохранитьВБлокнотИОблакоToolStripMenuItem.Click += new System.EventHandler(this.сохранитьВБлокнотИОблакоToolStripMenuItem_Click);
            // 
            // сохранитьИзмененияВОблакоToolStripMenuItem
            // 
            this.сохранитьИзмененияВОблакоToolStripMenuItem.Name = "сохранитьИзмененияВОблакоToolStripMenuItem";
            this.сохранитьИзмененияВОблакоToolStripMenuItem.Size = new System.Drawing.Size(761, 26);
            this.сохранитьИзмененияВОблакоToolStripMenuItem.Text = "Сохранить изменения только в облако";
            // 
            // СохранитьТолькоВБлокнотtoolStripMenuItem
            // 
            this.СохранитьТолькоВБлокнотtoolStripMenuItem.Name = "СохранитьТолькоВБлокнотtoolStripMenuItem";
            this.СохранитьТолькоВБлокнотtoolStripMenuItem.Size = new System.Drawing.Size(761, 26);
            this.СохранитьТолькоВБлокнотtoolStripMenuItem.Text = "Сохранить только в блокнот (pass.txt). Если блокнот уже есть, то он полностью пер" +
    "езапишеться";
            this.СохранитьТолькоВБлокнотtoolStripMenuItem.Click += new System.EventHandler(this.СохранитьТолькоВБлокнотtoolStripMenuItem_Click);
            // 
            // выгрузитьСБДToolStripMenuItem
            // 
            this.выгрузитьСБДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загружатьВсегдаToolStripMenuItem,
            this.загрузитьДанныеСБлокнотаToolStripMenuItem});
            this.выгрузитьСБДToolStripMenuItem.Name = "выгрузитьСБДToolStripMenuItem";
            this.выгрузитьСБДToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.выгрузитьСБДToolStripMenuItem.Text = "Загрузить данные";
            // 
            // загружатьВсегдаToolStripMenuItem
            // 
            this.загружатьВсегдаToolStripMenuItem.Name = "загружатьВсегдаToolStripMenuItem";
            this.загружатьВсегдаToolStripMenuItem.Size = new System.Drawing.Size(562, 26);
            this.загружатьВсегдаToolStripMenuItem.Text = "Загрузить данные с облака";
            this.загружатьВсегдаToolStripMenuItem.Click += new System.EventHandler(this.загружатьСОблакаToolStripMenuItem_Click);
            // 
            // загрузитьДанныеСБлокнотаToolStripMenuItem
            // 
            this.загрузитьДанныеСБлокнотаToolStripMenuItem.Name = "загрузитьДанныеСБлокнотаToolStripMenuItem";
            this.загрузитьДанныеСБлокнотаToolStripMenuItem.Size = new System.Drawing.Size(562, 26);
            this.загрузитьДанныеСБлокнотаToolStripMenuItem.Text = "Загрузить данные с блокнота (блокнот должен называться pass.txt)";
            this.загрузитьДанныеСБлокнотаToolStripMenuItem.Click += new System.EventHandler(this.загрузитьДанныеСБлокнотаToolStripMenuItem_Click);
            // 
            // закрытьОкноToolStripMenuItem
            // 
            this.закрытьОкноToolStripMenuItem.Name = "закрытьОкноToolStripMenuItem";
            this.закрытьОкноToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.закрытьОкноToolStripMenuItem.Text = "Закрыть окно";
            this.закрытьОкноToolStripMenuItem.Click += new System.EventHandler(this.закрытьОкноToolStripMenuItem_Click);
            // 
            // закрытьПриложениеToolStripMenuItem
            // 
            this.закрытьПриложениеToolStripMenuItem.Name = "закрытьПриложениеToolStripMenuItem";
            this.закрытьПриложениеToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.закрытьПриложениеToolStripMenuItem.Text = "Закрыть приложение";
            this.закрытьПриложениеToolStripMenuItem.Click += new System.EventHandler(this.закрытьПриложениеToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // Notebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 761);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Notebook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notebook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Notebook_FormClosing);
            this.Load += new System.EventHandler(this.Notebook_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИзмененияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выгрузитьСБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загружатьВсегдаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьОкноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьПриложениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИзмененияВОблакоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem СохранитьТолькоВБлокнотtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьДанныеСБлокнотаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВБлокнотИОблакоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    }
}