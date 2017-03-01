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
            this.operationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fSHSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equalizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.img_main = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_hist)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_main)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(671, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "_";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maxlabel);
            this.groupBox2.Controls.Add(this.minlabel);
            this.groupBox2.Controls.Add(this.img_hist);
            this.groupBox2.Location = new System.Drawing.Point(671, 337);
            this.groupBox2.Name = "groupBox2";
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
            this.img_hist.Location = new System.Drawing.Point(6, 49);
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
            this.operationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(958, 28);
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
            // 
            // menu_open
            // 
            this.menu_open.Name = "menu_open";
            this.menu_open.Size = new System.Drawing.Size(120, 26);
            this.menu_open.Text = "Open";
            this.menu_open.Click += new System.EventHandler(this.menu_open_Click);
            // 
            // operationToolStripMenuItem
            // 
            this.operationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revertToolStripMenuItem,
            this.fSHSToolStripMenuItem,
            this.equalizeToolStripMenuItem});
            this.operationToolStripMenuItem.Name = "operationToolStripMenuItem";
            this.operationToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.operationToolStripMenuItem.Text = "Operation";
            // 
            // revertToolStripMenuItem
            // 
            this.revertToolStripMenuItem.Name = "revertToolStripMenuItem";
            this.revertToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.revertToolStripMenuItem.Text = "Original";
            this.revertToolStripMenuItem.Click += new System.EventHandler(this.revertToolStripMenuItem_Click);
            // 
            // fSHSToolStripMenuItem
            // 
            this.fSHSToolStripMenuItem.Name = "fSHSToolStripMenuItem";
            this.fSHSToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.fSHSToolStripMenuItem.Text = "FSHS";
            this.fSHSToolStripMenuItem.Click += new System.EventHandler(this.fSHSToolStripMenuItem_Click);
            // 
            // equalizeToolStripMenuItem
            // 
            this.equalizeToolStripMenuItem.Name = "equalizeToolStripMenuItem";
            this.equalizeToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.equalizeToolStripMenuItem.Text = "Equalize";
            this.equalizeToolStripMenuItem.Click += new System.EventHandler(this.equalizeToolStripMenuItem_Click);
            // 
            // img_main
            // 
            this.img_main.BackColor = System.Drawing.SystemColors.ControlDark;
            this.img_main.Location = new System.Drawing.Point(13, 32);
            this.img_main.Name = "img_main";
            this.img_main.Size = new System.Drawing.Size(652, 616);
            this.img_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_main.TabIndex = 3;
            this.img_main.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 660);
            this.Controls.Add(this.img_main);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "IMG_";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_hist)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_main)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem revertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fSHSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equalizeToolStripMenuItem;
        private System.Windows.Forms.Label maxlabel;
        private System.Windows.Forms.Label minlabel;
    }
}

