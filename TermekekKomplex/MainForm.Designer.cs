
namespace TermekekKomplex
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.termékekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szállitókToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mennyiségiEgységekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.termékekToolStripMenuItem,
            this.szállitókToolStripMenuItem,
            this.mennyiségiEgységekToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // termékekToolStripMenuItem
            // 
            this.termékekToolStripMenuItem.Name = "termékekToolStripMenuItem";
            this.termékekToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.termékekToolStripMenuItem.Text = "Termékek";
            this.termékekToolStripMenuItem.Click += new System.EventHandler(this.termékekToolStripMenuItem_Click);
            // 
            // szállitókToolStripMenuItem
            // 
            this.szállitókToolStripMenuItem.Name = "szállitókToolStripMenuItem";
            this.szállitókToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.szállitókToolStripMenuItem.Text = "Szállitók";
            this.szállitókToolStripMenuItem.Click += new System.EventHandler(this.szállitókToolStripMenuItem_Click);
            // 
            // mennyiségiEgységekToolStripMenuItem
            // 
            this.mennyiségiEgységekToolStripMenuItem.Name = "mennyiségiEgységekToolStripMenuItem";
            this.mennyiségiEgységekToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.mennyiségiEgységekToolStripMenuItem.Text = "Mennyiségi egységek";
            this.mennyiségiEgységekToolStripMenuItem.Click += new System.EventHandler(this.mennyiségiEgységekToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Termékek kezelése - komplex 2021.01.26.";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem termékekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szállitókToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mennyiségiEgységekToolStripMenuItem;
    }
}

