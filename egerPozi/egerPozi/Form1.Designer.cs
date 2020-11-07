namespace egerPozi
{
    partial class FormFejlec
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
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.hsPiros = new System.Windows.Forms.HScrollBar();
            this.hsKek = new System.Windows.Forms.HScrollBar();
            this.hsZold = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMeret = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(61, 59);
            this.hScrollBar1.Maximum = 300;
            this.hScrollBar1.Minimum = 10;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(357, 23);
            this.hScrollBar1.TabIndex = 0;
            this.hScrollBar1.Value = 10;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // hsPiros
            // 
            this.hsPiros.Location = new System.Drawing.Point(61, 254);
            this.hsPiros.Maximum = 255;
            this.hsPiros.Name = "hsPiros";
            this.hsPiros.Size = new System.Drawing.Size(221, 23);
            this.hsPiros.TabIndex = 1;
            this.hsPiros.ValueChanged += new System.EventHandler(this.hsPiros_ValueChanged);
            // 
            // hsKek
            // 
            this.hsKek.Location = new System.Drawing.Point(61, 307);
            this.hsKek.Maximum = 255;
            this.hsKek.Name = "hsKek";
            this.hsKek.Size = new System.Drawing.Size(221, 23);
            this.hsKek.TabIndex = 2;
            this.hsKek.ValueChanged += new System.EventHandler(this.hsKek_ValueChanged);
            // 
            // hsZold
            // 
            this.hsZold.Location = new System.Drawing.Point(61, 362);
            this.hsZold.Maximum = 255;
            this.hsZold.Name = "hsZold";
            this.hsZold.Size = new System.Drawing.Size(221, 23);
            this.hsZold.TabIndex = 3;
            this.hsZold.ValueChanged += new System.EventHandler(this.hsZold_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Piros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kék";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Zöld";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "A négyzet oldala: ";
            // 
            // lblMeret
            // 
            this.lblMeret.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMeret.Location = new System.Drawing.Point(58, 109);
            this.lblMeret.MaximumSize = new System.Drawing.Size(300, 300);
            this.lblMeret.Name = "lblMeret";
            this.lblMeret.Size = new System.Drawing.Size(161, 62);
            this.lblMeret.TabIndex = 8;
            this.lblMeret.Text = "Ez méreteződik";
            // 
            // FormFejlec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMeret);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hsZold);
            this.Controls.Add(this.hsKek);
            this.Controls.Add(this.hsPiros);
            this.Controls.Add(this.hScrollBar1);
            this.Name = "FormFejlec";
            this.Text = "Uj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.HScrollBar hsPiros;
        private System.Windows.Forms.HScrollBar hsKek;
        private System.Windows.Forms.HScrollBar hsZold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMeret;
    }
}

