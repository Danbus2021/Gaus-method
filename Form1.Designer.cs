namespace Gaus
{
    partial class Gaus
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gaus));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculationLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeCalculatiobLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.SLAU = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.methodGaus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Random = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bigMatrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество уравнений:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(191, 37);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            32575,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(94, 27);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1005, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.printToolStripMenuItem,
            this.calculationLogToolStripMenuItem,
            this.writeCalculatiobLogToolStripMenuItem,
            this.bigMatrixToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.openFileToolStripMenuItem.Text = "Open file";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.saveFileToolStripMenuItem.Text = "Save file";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // calculationLogToolStripMenuItem
            // 
            this.calculationLogToolStripMenuItem.Name = "calculationLogToolStripMenuItem";
            this.calculationLogToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.calculationLogToolStripMenuItem.Text = "Calculation log";
            this.calculationLogToolStripMenuItem.Click += new System.EventHandler(this.calculationLogToolStripMenuItem_Click);
            // 
            // writeCalculatiobLogToolStripMenuItem
            // 
            this.writeCalculatiobLogToolStripMenuItem.Name = "writeCalculatiobLogToolStripMenuItem";
            this.writeCalculatiobLogToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.writeCalculatiobLogToolStripMenuItem.Text = "Write calculation log";
            this.writeCalculatiobLogToolStripMenuItem.Click += new System.EventHandler(this.writeCalculatiobLogToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(579, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Решить СЛАУ методом Гаусса";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SLAU
            // 
            this.SLAU.Location = new System.Drawing.Point(440, 31);
            this.SLAU.Name = "SLAU";
            this.SLAU.Size = new System.Drawing.Size(133, 29);
            this.SLAU.TabIndex = 4;
            this.SLAU.Text = "Добавить СЛАУ";
            this.SLAU.UseVisualStyleBackColor = true;
            this.SLAU.Click += new System.EventHandler(this.SLAU_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(440, 63);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(133, 29);
            this.delete.TabIndex = 5;
            this.delete.Text = "Удалить СЛАУ";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // methodGaus
            // 
            this.methodGaus.Location = new System.Drawing.Point(719, 48);
            this.methodGaus.Name = "methodGaus";
            this.methodGaus.Size = new System.Drawing.Size(94, 29);
            this.methodGaus.TabIndex = 6;
            this.methodGaus.Text = "Ответ";
            this.methodGaus.UseVisualStyleBackColor = true;
            this.methodGaus.Click += new System.EventHandler(this.methodGaus_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(111, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Система уравнений:";
            // 
            // Random
            // 
            this.Random.Location = new System.Drawing.Point(291, 37);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(137, 48);
            this.Random.TabIndex = 8;
            this.Random.Text = "Случайное заполнение";
            this.Random.UseVisualStyleBackColor = true;
            this.Random.Click += new System.EventHandler(this.Random_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.progressBar1.ForeColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(819, 48);
            this.progressBar1.Maximum = 10000000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(174, 29);
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(828, 83);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(154, 24);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Вывести на экран";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // bigMatrixToolStripMenuItem
            // 
            this.bigMatrixToolStripMenuItem.Name = "bigMatrixToolStripMenuItem";
            this.bigMatrixToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.bigMatrixToolStripMenuItem.Text = "Big Matrix";
            this.bigMatrixToolStripMenuItem.Click += new System.EventHandler(this.bigMatrixToolStripMenuItem_Click);
            // 
            // Gaus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1005, 566);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Random);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.methodGaus);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.SLAU);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Gaus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gaus";
            this.Load += new System.EventHandler(this.Gaus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private Button button1;
        private Button SLAU;
        private Button delete;
        private Button methodGaus;
        private Label label2;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Button Random;
        private ToolStripMenuItem printToolStripMenuItem;
        private ProgressBar progressBar1;
        private ToolStripMenuItem stopToolStripMenuItem;
        private ToolStripMenuItem calculationLogToolStripMenuItem;
        private ToolStripMenuItem writeCalculatiobLogToolStripMenuItem;
        private CheckBox checkBox1;
        private ToolStripMenuItem bigMatrixToolStripMenuItem;
    }
}