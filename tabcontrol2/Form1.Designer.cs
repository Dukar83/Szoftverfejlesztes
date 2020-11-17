namespace tabcontrol2
{
    partial class Tabcontrol2
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
            this.tbc = new System.Windows.Forms.TabControl();
            this.tbcAdatok = new System.Windows.Forms.TabPage();
            this.btnAdatOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxB = new System.Windows.Forms.TextBox();
            this.tbxA = new System.Windows.Forms.TextBox();
            this.tbcEredmeny = new System.Windows.Forms.TabPage();
            this.lblEredm = new System.Windows.Forms.Label();
            this.tbc.SuspendLayout();
            this.tbcAdatok.SuspendLayout();
            this.tbcEredmeny.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc
            // 
            this.tbc.Controls.Add(this.tbcAdatok);
            this.tbc.Controls.Add(this.tbcEredmeny);
            this.tbc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc.Location = new System.Drawing.Point(0, 0);
            this.tbc.Name = "tbc";
            this.tbc.SelectedIndex = 0;
            this.tbc.Size = new System.Drawing.Size(236, 288);
            this.tbc.TabIndex = 0;
            // 
            // tbcAdatok
            // 
            this.tbcAdatok.Controls.Add(this.btnAdatOK);
            this.tbcAdatok.Controls.Add(this.label1);
            this.tbcAdatok.Controls.Add(this.tbxB);
            this.tbcAdatok.Controls.Add(this.tbxA);
            this.tbcAdatok.Location = new System.Drawing.Point(4, 22);
            this.tbcAdatok.Name = "tbcAdatok";
            this.tbcAdatok.Padding = new System.Windows.Forms.Padding(3);
            this.tbcAdatok.Size = new System.Drawing.Size(228, 262);
            this.tbcAdatok.TabIndex = 0;
            this.tbcAdatok.Text = "Adatok";
            this.tbcAdatok.UseVisualStyleBackColor = true;
            // 
            // btnAdatOK
            // 
            this.btnAdatOK.Location = new System.Drawing.Point(33, 207);
            this.btnAdatOK.Name = "btnAdatOK";
            this.btnAdatOK.Size = new System.Drawing.Size(75, 23);
            this.btnAdatOK.TabIndex = 7;
            this.btnAdatOK.Text = "OK";
            this.btnAdatOK.UseVisualStyleBackColor = true;
            this.btnAdatOK.Click += new System.EventHandler(this.btnAdatOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kérem adjon meg két egész számot:";
            // 
            // tbxB
            // 
            this.tbxB.Location = new System.Drawing.Point(20, 136);
            this.tbxB.Name = "tbxB";
            this.tbxB.Size = new System.Drawing.Size(100, 20);
            this.tbxB.TabIndex = 5;
            // 
            // tbxA
            // 
            this.tbxA.Location = new System.Drawing.Point(20, 80);
            this.tbxA.Name = "tbxA";
            this.tbxA.Size = new System.Drawing.Size(100, 20);
            this.tbxA.TabIndex = 4;
            // 
            // tbcEredmeny
            // 
            this.tbcEredmeny.Controls.Add(this.lblEredm);
            this.tbcEredmeny.Location = new System.Drawing.Point(4, 22);
            this.tbcEredmeny.Name = "tbcEredmeny";
            this.tbcEredmeny.Padding = new System.Windows.Forms.Padding(3);
            this.tbcEredmeny.Size = new System.Drawing.Size(228, 262);
            this.tbcEredmeny.TabIndex = 1;
            this.tbcEredmeny.Text = "Eredmények";
            this.tbcEredmeny.UseVisualStyleBackColor = true;
            // 
            // lblEredm
            // 
            this.lblEredm.AutoSize = true;
            this.lblEredm.Location = new System.Drawing.Point(33, 47);
            this.lblEredm.Name = "lblEredm";
            this.lblEredm.Size = new System.Drawing.Size(57, 13);
            this.lblEredm.TabIndex = 1;
            this.lblEredm.Text = "Eredmény:";
            // 
            // Tabcontrol2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(236, 288);
            this.Controls.Add(this.tbc);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Tabcontrol2";
            this.Text = "Tabcontrol2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tabcontrol2_FormClosing);
            this.tbc.ResumeLayout(false);
            this.tbcAdatok.ResumeLayout(false);
            this.tbcAdatok.PerformLayout();
            this.tbcEredmeny.ResumeLayout(false);
            this.tbcEredmeny.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc;
        private System.Windows.Forms.TabPage tbcAdatok;
        private System.Windows.Forms.Button btnAdatOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxB;
        private System.Windows.Forms.TextBox tbxA;
        private System.Windows.Forms.TabPage tbcEredmeny;
        private System.Windows.Forms.Label lblEredm;
    }
}

