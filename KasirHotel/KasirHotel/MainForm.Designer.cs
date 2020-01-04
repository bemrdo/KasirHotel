namespace KasirHotel
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cHECKINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHECKOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANAGERESERVATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cHECKINToolStripMenuItem,
            this.cHECKOUTToolStripMenuItem,
            this.mANAGERESERVATIONToolStripMenuItem,
            this.lOGOUTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(773, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cHECKINToolStripMenuItem
            // 
            this.cHECKINToolStripMenuItem.Font = new System.Drawing.Font("NCAA Baylor Bears Football", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cHECKINToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.cHECKINToolStripMenuItem.Name = "cHECKINToolStripMenuItem";
            this.cHECKINToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.cHECKINToolStripMenuItem.Text = "CHECK IN";
            this.cHECKINToolStripMenuItem.Click += new System.EventHandler(this.cHECKINToolStripMenuItem_Click);
            // 
            // cHECKOUTToolStripMenuItem
            // 
            this.cHECKOUTToolStripMenuItem.Font = new System.Drawing.Font("NCAA Baylor Bears Football", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cHECKOUTToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.cHECKOUTToolStripMenuItem.Name = "cHECKOUTToolStripMenuItem";
            this.cHECKOUTToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.cHECKOUTToolStripMenuItem.Text = "CHECK OUT";
            this.cHECKOUTToolStripMenuItem.Click += new System.EventHandler(this.cHECKOUTToolStripMenuItem_Click);
            // 
            // mANAGERESERVATIONToolStripMenuItem
            // 
            this.mANAGERESERVATIONToolStripMenuItem.Font = new System.Drawing.Font("NCAA Baylor Bears Football", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mANAGERESERVATIONToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.mANAGERESERVATIONToolStripMenuItem.Name = "mANAGERESERVATIONToolStripMenuItem";
            this.mANAGERESERVATIONToolStripMenuItem.Size = new System.Drawing.Size(191, 20);
            this.mANAGERESERVATIONToolStripMenuItem.Text = "MANAGE RESERVATION";
            this.mANAGERESERVATIONToolStripMenuItem.Click += new System.EventHandler(this.mANAGERESERVATIONToolStripMenuItem_Click);
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Font = new System.Drawing.Font("NCAA Baylor Bears Football", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOGOUTToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.lOGOUTToolStripMenuItem.Text = "LOGOUT";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 455);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cHECKINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cHECKOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANAGERESERVATIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
    }
}