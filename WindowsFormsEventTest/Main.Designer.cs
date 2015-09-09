namespace WindowsFormsEventTest
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.notifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.observerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notifierToolStripMenuItem,
            this.observerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // notifierToolStripMenuItem
            // 
            this.notifierToolStripMenuItem.Name = "notifierToolStripMenuItem";
            this.notifierToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.notifierToolStripMenuItem.Text = "Notifier";
            this.notifierToolStripMenuItem.Click += new System.EventHandler(this.notifierToolStripMenuItem_Click);
            // 
            // observerToolStripMenuItem
            // 
            this.observerToolStripMenuItem.Name = "observerToolStripMenuItem";
            this.observerToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.observerToolStripMenuItem.Text = "Observer";
            this.observerToolStripMenuItem.Click += new System.EventHandler(this.observerToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem notifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem observerToolStripMenuItem;
    }
}