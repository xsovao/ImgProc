namespace ImgP
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maxlabel = new System.Windows.Forms.Label();
            this.minlabel = new System.Windows.Forms.Label();
            this.img_hist = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_open = new System.Windows.Forms.ToolStripMenuItem();
            this.originalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fSHSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equalizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writetxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convolveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uniform3x3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diamond13ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplace4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplace8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.x5ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.img_main = new System.Windows.Forms.PictureBox();
            this.numt = new System.Windows.Forms.NumericUpDown();
            this.numsteps = new System.Windows.Forms.NumericUpDown();
            this.numh = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_hist)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numsteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.calc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numh);
            this.groupBox1.Controls.Add(this.numsteps);
            this.groupBox1.Controls.Add(this.numt);
            this.groupBox1.Location = new System.Drawing.Point(671, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(281, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Heat Flux";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maxlabel);
            this.groupBox2.Controls.Add(this.minlabel);
            this.groupBox2.Controls.Add(this.img_hist);
            this.groupBox2.Location = new System.Drawing.Point(671, 337);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(275, 311);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Histogram";
            // 
            // maxlabel
            // 
            this.maxlabel.AutoSize = true;
            this.maxlabel.Location = new System.Drawing.Point(229, 22);
            this.maxlabel.Name = "maxlabel";
            this.maxlabel.Size = new System.Drawing.Size(33, 17);
            this.maxlabel.TabIndex = 2;
            this.maxlabel.Text = "max";
            // 
            // minlabel
            // 
            this.minlabel.AutoSize = true;
            this.minlabel.Location = new System.Drawing.Point(7, 22);
            this.minlabel.Name = "minlabel";
            this.minlabel.Size = new System.Drawing.Size(30, 17);
            this.minlabel.TabIndex = 1;
            this.minlabel.Text = "min";
            // 
            // img_hist
            // 
            this.img_hist.Location = new System.Drawing.Point(5, 49);
            this.img_hist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.img_hist.Name = "img_hist";
            this.img_hist.Size = new System.Drawing.Size(256, 256);
            this.img_hist.TabIndex = 0;
            this.img_hist.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.originalToolStripMenuItem,
            this.operationToolStripMenuItem,
            this.convolveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(957, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_open});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 24);
            this.toolStripMenuItem1.Text = "File";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // menu_open
            // 
            this.menu_open.Name = "menu_open";
            this.menu_open.Size = new System.Drawing.Size(120, 26);
            this.menu_open.Text = "Open";
            this.menu_open.Click += new System.EventHandler(this.menu_open_Click);
            // 
            // originalToolStripMenuItem
            // 
            this.originalToolStripMenuItem.Name = "originalToolStripMenuItem";
            this.originalToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.originalToolStripMenuItem.Text = "Original";
            this.originalToolStripMenuItem.Click += new System.EventHandler(this.originalToolStripMenuItem_Click);
            // 
            // operationToolStripMenuItem
            // 
            this.operationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fSHSToolStripMenuItem,
            this.equalizeToolStripMenuItem,
            this.writetxtToolStripMenuItem});
            this.operationToolStripMenuItem.Name = "operationToolStripMenuItem";
            this.operationToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.operationToolStripMenuItem.Text = "HistOp";
            // 
            // fSHSToolStripMenuItem
            // 
            this.fSHSToolStripMenuItem.Name = "fSHSToolStripMenuItem";
            this.fSHSToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.fSHSToolStripMenuItem.Text = "FSHS";
            this.fSHSToolStripMenuItem.Click += new System.EventHandler(this.fSHSToolStripMenuItem_Click);
            // 
            // equalizeToolStripMenuItem
            // 
            this.equalizeToolStripMenuItem.Name = "equalizeToolStripMenuItem";
            this.equalizeToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.equalizeToolStripMenuItem.Text = "Equalize";
            this.equalizeToolStripMenuItem.Click += new System.EventHandler(this.equalizeToolStripMenuItem_Click);
            // 
            // writetxtToolStripMenuItem
            // 
            this.writetxtToolStripMenuItem.Name = "writetxtToolStripMenuItem";
            this.writetxtToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.writetxtToolStripMenuItem.Text = "Write .txt";
            this.writetxtToolStripMenuItem.Click += new System.EventHandler(this.writetxtToolStripMenuItem_Click);
            // 
            // convolveToolStripMenuItem
            // 
            this.convolveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blurToolStripMenuItem,
            this.sharpenToolStripMenuItem,
            this.edgeDetectToolStripMenuItem,
            this.embossToolStripMenuItem});
            this.convolveToolStripMenuItem.Name = "convolveToolStripMenuItem";
            this.convolveToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.convolveToolStripMenuItem.Text = "Convolve";
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uniform3x3ToolStripMenuItem,
            this.diamond13ToolStripMenuItem});
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.blurToolStripMenuItem.Text = "Blur";
            // 
            // uniform3x3ToolStripMenuItem
            // 
            this.uniform3x3ToolStripMenuItem.Name = "uniform3x3ToolStripMenuItem";
            this.uniform3x3ToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.uniform3x3ToolStripMenuItem.Text = "uniform 3x3 ";
            this.uniform3x3ToolStripMenuItem.Click += new System.EventHandler(this.uniform3x3ToolStripMenuItem_Click);
            // 
            // diamond13ToolStripMenuItem
            // 
            this.diamond13ToolStripMenuItem.Name = "diamond13ToolStripMenuItem";
            this.diamond13ToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.diamond13ToolStripMenuItem.Text = "diamond /13";
            this.diamond13ToolStripMenuItem.Click += new System.EventHandler(this.diamond13ToolStripMenuItem_Click);
            // 
            // sharpenToolStripMenuItem
            // 
            this.sharpenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x3ToolStripMenuItem,
            this.x5ToolStripMenuItem});
            this.sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            this.sharpenToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.sharpenToolStripMenuItem.Text = "Sharpen";
            // 
            // x3ToolStripMenuItem
            // 
            this.x3ToolStripMenuItem.Name = "x3ToolStripMenuItem";
            this.x3ToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.x3ToolStripMenuItem.Text = "[3x3]";
            this.x3ToolStripMenuItem.Click += new System.EventHandler(this.x3ToolStripMenuItem_Click);
            // 
            // x5ToolStripMenuItem
            // 
            this.x5ToolStripMenuItem.Name = "x5ToolStripMenuItem";
            this.x5ToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.x5ToolStripMenuItem.Text = "[5x5]";
            this.x5ToolStripMenuItem.Click += new System.EventHandler(this.x5ToolStripMenuItem_Click);
            // 
            // edgeDetectToolStripMenuItem
            // 
            this.edgeDetectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laplace4ToolStripMenuItem,
            this.laplace8ToolStripMenuItem,
            this.sobelToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.diagonalToolStripMenuItem});
            this.edgeDetectToolStripMenuItem.Name = "edgeDetectToolStripMenuItem";
            this.edgeDetectToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.edgeDetectToolStripMenuItem.Text = "Edge Detect";
            // 
            // laplace4ToolStripMenuItem
            // 
            this.laplace4ToolStripMenuItem.Name = "laplace4ToolStripMenuItem";
            this.laplace4ToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.laplace4ToolStripMenuItem.Text = "Laplace 4";
            this.laplace4ToolStripMenuItem.Click += new System.EventHandler(this.laplace4ToolStripMenuItem_Click);
            // 
            // laplace8ToolStripMenuItem
            // 
            this.laplace8ToolStripMenuItem.Name = "laplace8ToolStripMenuItem";
            this.laplace8ToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.laplace8ToolStripMenuItem.Text = "Laplace 8";
            this.laplace8ToolStripMenuItem.Click += new System.EventHandler(this.laplace8ToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.sobelToolStripMenuItem.Text = "Sobel";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.sobelToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // diagonalToolStripMenuItem
            // 
            this.diagonalToolStripMenuItem.Name = "diagonalToolStripMenuItem";
            this.diagonalToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.diagonalToolStripMenuItem.Text = "Diagonal";
            this.diagonalToolStripMenuItem.Click += new System.EventHandler(this.diagonalToolStripMenuItem_Click);
            // 
            // embossToolStripMenuItem
            // 
            this.embossToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x3ToolStripMenuItem1,
            this.x5ToolStripMenuItem1});
            this.embossToolStripMenuItem.Name = "embossToolStripMenuItem";
            this.embossToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.embossToolStripMenuItem.Text = "Emboss";
            // 
            // x3ToolStripMenuItem1
            // 
            this.x3ToolStripMenuItem1.Name = "x3ToolStripMenuItem1";
            this.x3ToolStripMenuItem1.Size = new System.Drawing.Size(117, 26);
            this.x3ToolStripMenuItem1.Text = "[3x3]";
            this.x3ToolStripMenuItem1.Click += new System.EventHandler(this.x3ToolStripMenuItem1_Click);
            // 
            // x5ToolStripMenuItem1
            // 
            this.x5ToolStripMenuItem1.Name = "x5ToolStripMenuItem1";
            this.x5ToolStripMenuItem1.Size = new System.Drawing.Size(117, 26);
            this.x5ToolStripMenuItem1.Text = "[5x5]";
            this.x5ToolStripMenuItem1.Click += new System.EventHandler(this.x5ToolStripMenuItem1_Click);
            // 
            // img_main
            // 
            this.img_main.BackColor = System.Drawing.SystemColors.ControlDark;
            this.img_main.Location = new System.Drawing.Point(13, 32);
            this.img_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.img_main.Name = "img_main";
            this.img_main.Size = new System.Drawing.Size(652, 615);
            this.img_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_main.TabIndex = 3;
            this.img_main.TabStop = false;
            // 
            // numt
            // 
            this.numt.DecimalPlaces = 2;
            this.numt.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numt.Location = new System.Drawing.Point(57, 29);
            this.numt.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numt.Name = "numt";
            this.numt.Size = new System.Drawing.Size(80, 22);
            this.numt.TabIndex = 0;
            this.numt.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // numsteps
            // 
            this.numsteps.Location = new System.Drawing.Point(57, 85);
            this.numsteps.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.numsteps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numsteps.Name = "numsteps";
            this.numsteps.Size = new System.Drawing.Size(80, 22);
            this.numsteps.TabIndex = 1;
            this.numsteps.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numh
            // 
            this.numh.DecimalPlaces = 2;
            this.numh.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numh.Location = new System.Drawing.Point(57, 57);
            this.numh.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numh.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numh.Name = "numh";
            this.numh.Size = new System.Drawing.Size(80, 22);
            this.numh.TabIndex = 2;
            this.numh.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "t";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "h";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "steps";
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(12, 114);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(124, 23);
            this.calc.TabIndex = 6;
            this.calc.Text = "calculate";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 660);
            this.Controls.Add(this.img_main);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "IMG_Sova";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_hist)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numsteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menu_open;
        private System.Windows.Forms.PictureBox img_hist;
        private System.Windows.Forms.PictureBox img_main;
        private System.Windows.Forms.ToolStripMenuItem operationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fSHSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equalizeToolStripMenuItem;
        private System.Windows.Forms.Label maxlabel;
        private System.Windows.Forms.Label minlabel;
        private System.Windows.Forms.ToolStripMenuItem convolveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uniform3x3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diamond13ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplace4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplace8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embossToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x3ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem x5ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem originalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writetxtToolStripMenuItem;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numh;
        private System.Windows.Forms.NumericUpDown numsteps;
        private System.Windows.Forms.NumericUpDown numt;
    }
}

