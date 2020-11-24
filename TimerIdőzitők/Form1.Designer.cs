
namespace TimerIdőzitők
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
            this.components = new System.ComponentModel.Container();
            this.timerEgesz = new System.Windows.Forms.Timer(this.components);
            this.btnMehet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timerUj = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timerEgesz
            // 
            this.timerEgesz.Interval = 120000;
            this.timerEgesz.Tick += new System.EventHandler(this.timerEgesz_Tick);
            // 
            // btnMehet
            // 
            this.btnMehet.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.btnMehet.Location = new System.Drawing.Point(296, 188);
            this.btnMehet.Name = "btnMehet";
            this.btnMehet.Size = new System.Drawing.Size(138, 60);
            this.btnMehet.TabIndex = 0;
            this.btnMehet.Text = "Induljon!";
            this.btnMehet.UseVisualStyleBackColor = true;
            this.btnMehet.Click += new System.EventHandler(this.btnMehet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(141, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "10 másodpercenként új ablak ugrik fel 2 percig";
            // 
            // timerUj
            // 
            this.timerUj.Interval = 5000;
            this.timerUj.Tick += new System.EventHandler(this.timerUj_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMehet);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerEgesz;
        private System.Windows.Forms.Button btnMehet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerUj;
    }
}

