namespace Datalus
{
    partial class MainForm
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
            this.MyStatusStrip = new ReaLTaiizor.Controls.CrownStatusStrip();
            this.MyStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.MyMenuStrip = new ReaLTaiizor.Controls.CrownMenuStrip();
            this.MyToolStrip = new ReaLTaiizor.Controls.CrownToolStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyStatusStrip.SuspendLayout();
            this.MyMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MyStatusStrip
            // 
            this.MyStatusStrip.AutoSize = false;
            this.MyStatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MyStatusStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MyStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MyStatusText});
            this.MyStatusStrip.Location = new System.Drawing.Point(0, 417);
            this.MyStatusStrip.Name = "MyStatusStrip";
            this.MyStatusStrip.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.MyStatusStrip.Size = new System.Drawing.Size(800, 33);
            this.MyStatusStrip.SizingGrip = false;
            this.MyStatusStrip.TabIndex = 0;
            this.MyStatusStrip.Text = "crownStatusStrip1";
            // 
            // MyStatusText
            // 
            this.MyStatusText.Name = "MyStatusText";
            this.MyStatusText.Size = new System.Drawing.Size(800, 20);
            this.MyStatusText.Spring = true;
            this.MyStatusText.Text = "Initializing...";
            this.MyStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MyMenuStrip
            // 
            this.MyMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MyMenuStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MyMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu});
            this.MyMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MyMenuStrip.Name = "MyMenuStrip";
            this.MyMenuStrip.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.MyMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MyMenuStrip.TabIndex = 1;
            this.MyMenuStrip.Text = "crownMenuStrip1";
            // 
            // MyToolStrip
            // 
            this.MyToolStrip.AutoSize = false;
            this.MyToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MyToolStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MyToolStrip.Location = new System.Drawing.Point(0, 24);
            this.MyToolStrip.Name = "MyToolStrip";
            this.MyToolStrip.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.MyToolStrip.Size = new System.Drawing.Size(800, 28);
            this.MyToolStrip.TabIndex = 2;
            this.MyToolStrip.Text = "crownToolStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveMenuItem,
            this.ExitMenuSeparator,
            this.ExitMenuItem});
            this.FileMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(37, 20);
            this.FileMenu.Text = "&File";
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ExitMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitMenuItem.Text = "E&xit";
            // 
            // ExitMenuSeparator
            // 
            this.ExitMenuSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ExitMenuSeparator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ExitMenuSeparator.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.ExitMenuSeparator.Name = "ExitMenuSeparator";
            this.ExitMenuSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.SaveMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveMenuItem.Text = "&Save";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MyToolStrip);
            this.Controls.Add(this.MyStatusStrip);
            this.Controls.Add(this.MyMenuStrip);
            this.MainMenuStrip = this.MyMenuStrip;
            this.Name = "MainForm";
            this.Text = "Datalus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.MyStatusStrip.ResumeLayout(false);
            this.MyStatusStrip.PerformLayout();
            this.MyMenuStrip.ResumeLayout(false);
            this.MyMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.CrownStatusStrip MyStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel MyStatusText;
        private ReaLTaiizor.Controls.CrownMenuStrip MyMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripSeparator ExitMenuSeparator;
        private ReaLTaiizor.Controls.CrownToolStrip MyToolStrip;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
    }
}

