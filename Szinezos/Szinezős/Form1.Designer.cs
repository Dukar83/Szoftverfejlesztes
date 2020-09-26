namespace Szinezős
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hScrollBarKek = new System.Windows.Forms.HScrollBar();
            this.hScrollBarZold = new System.Windows.Forms.HScrollBar();
            this.hScrollBarPiros = new System.Windows.Forms.HScrollBar();
            this.hScrollBarNegyzet = new System.Windows.Forms.HScrollBar();
            this.labelNegyzet = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelNegyzet);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.hScrollBarKek);
            this.panel1.Controls.Add(this.hScrollBarZold);
            this.panel1.Controls.Add(this.hScrollBarPiros);
            this.panel1.Controls.Add(this.hScrollBarNegyzet);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 450);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(137, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Negyzet oldala";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(138, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Kék";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(138, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Zöld";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(138, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Piros";
            // 
            // hScrollBarKek
            // 
            this.hScrollBarKek.Location = new System.Drawing.Point(370, 366);
            this.hScrollBarKek.Maximum = 255;
            this.hScrollBarKek.Name = "hScrollBarKek";
            this.hScrollBarKek.Size = new System.Drawing.Size(219, 33);
            this.hScrollBarKek.TabIndex = 11;
            this.hScrollBarKek.ValueChanged += new System.EventHandler(this.hScrollBarKek_ValueChanged);
            // 
            // hScrollBarZold
            // 
            this.hScrollBarZold.Location = new System.Drawing.Point(370, 297);
            this.hScrollBarZold.Maximum = 255;
            this.hScrollBarZold.Name = "hScrollBarZold";
            this.hScrollBarZold.Size = new System.Drawing.Size(219, 33);
            this.hScrollBarZold.TabIndex = 10;
            this.hScrollBarZold.ValueChanged += new System.EventHandler(this.hScrollBarZold_ValueChanged);
            // 
            // hScrollBarPiros
            // 
            this.hScrollBarPiros.Location = new System.Drawing.Point(370, 229);
            this.hScrollBarPiros.Maximum = 255;
            this.hScrollBarPiros.Name = "hScrollBarPiros";
            this.hScrollBarPiros.Size = new System.Drawing.Size(219, 33);
            this.hScrollBarPiros.TabIndex = 9;
            this.hScrollBarPiros.ValueChanged += new System.EventHandler(this.hScrollBarPiros_ValueChanged);
            // 
            // hScrollBarNegyzet
            // 
            this.hScrollBarNegyzet.Location = new System.Drawing.Point(370, 43);
            this.hScrollBarNegyzet.Maximum = 255;
            this.hScrollBarNegyzet.Name = "hScrollBarNegyzet";
            this.hScrollBarNegyzet.Size = new System.Drawing.Size(219, 33);
            this.hScrollBarNegyzet.TabIndex = 8;
            this.hScrollBarNegyzet.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarNegyzet_Scroll);
            // 
            // labelNegyzet
            // 
            this.labelNegyzet.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelNegyzet.Location = new System.Drawing.Point(404, 127);
            this.labelNegyzet.Name = "labelNegyzet";
            this.labelNegyzet.Size = new System.Drawing.Size(100, 23);
            this.labelNegyzet.TabIndex = 17;
            this.labelNegyzet.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar hScrollBarKek;
        private System.Windows.Forms.HScrollBar hScrollBarZold;
        private System.Windows.Forms.HScrollBar hScrollBarPiros;
        private System.Windows.Forms.HScrollBar hScrollBarNegyzet;
        private System.Windows.Forms.Label labelNegyzet;
    }
}

