namespace tablap
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
            this.tbcElso = new System.Windows.Forms.TabControl();
            this.tbpSzemadatok = new System.Windows.Forms.TabPage();
            this.tbpBirsagok = new System.Windows.Forms.TabPage();
            this.tbcElso.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcElso
            // 
            this.tbcElso.Controls.Add(this.tbpSzemadatok);
            this.tbcElso.Controls.Add(this.tbpBirsagok);
            this.tbcElso.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.tbcElso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcElso.Location = new System.Drawing.Point(0, 0);
            this.tbcElso.Name = "tbcElso";
            this.tbcElso.SelectedIndex = 0;
            this.tbcElso.Size = new System.Drawing.Size(800, 450);
            this.tbcElso.TabIndex = 0;
            // 
            // tbpSzemadatok
            // 
            this.tbpSzemadatok.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbpSzemadatok.Location = new System.Drawing.Point(4, 22);
            this.tbpSzemadatok.Name = "tbpSzemadatok";
            this.tbpSzemadatok.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSzemadatok.Size = new System.Drawing.Size(792, 424);
            this.tbpSzemadatok.TabIndex = 0;
            this.tbpSzemadatok.Text = "Személyi Adatok";
            // 
            // tbpBirsagok
            // 
            this.tbpBirsagok.BackColor = System.Drawing.Color.Turquoise;
            this.tbpBirsagok.Location = new System.Drawing.Point(4, 22);
            this.tbpBirsagok.Name = "tbpBirsagok";
            this.tbpBirsagok.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBirsagok.Size = new System.Drawing.Size(792, 424);
            this.tbpBirsagok.TabIndex = 1;
            this.tbpBirsagok.Text = "Birságok";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcElso);
            this.Name = "Form1";
            this.Text = "Tablap";
            this.tbcElso.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcElso;
        private System.Windows.Forms.TabPage tbpSzemadatok;
        private System.Windows.Forms.TabPage tbpBirsagok;
    }
}

