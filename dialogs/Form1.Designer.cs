
namespace dialogs
{
    partial class Dialogs
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
            this.lblSzinezos = new System.Windows.Forms.Label();
            this.btnMehet = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.textBoxBe = new System.Windows.Forms.TextBox();
            this.pbKep = new System.Windows.Forms.PictureBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btnSzovegMegnyit = new System.Windows.Forms.Button();
            this.btnMehetKep = new System.Windows.Forms.Button();
            this.lblSzin = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSzovegMentes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbKep)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSzinezos
            // 
            this.lblSzinezos.AutoSize = true;
            this.lblSzinezos.Location = new System.Drawing.Point(57, 153);
            this.lblSzinezos.Name = "lblSzinezos";
            this.lblSzinezos.Size = new System.Drawing.Size(59, 13);
            this.lblSzinezos.TabIndex = 0;
            this.lblSzinezos.Text = "Szinezd át!";
            // 
            // btnMehet
            // 
            this.btnMehet.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMehet.ForeColor = System.Drawing.Color.Transparent;
            this.btnMehet.Location = new System.Drawing.Point(49, 84);
            this.btnMehet.Name = "btnMehet";
            this.btnMehet.Size = new System.Drawing.Size(75, 23);
            this.btnMehet.TabIndex = 1;
            this.btnMehet.Text = "Mehet!";
            this.btnMehet.UseVisualStyleBackColor = false;
            this.btnMehet.Click += new System.EventHandler(this.btnMehet_Click);
            // 
            // textBoxBe
            // 
            this.textBoxBe.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxBe.Location = new System.Drawing.Point(295, 130);
            this.textBoxBe.Multiline = true;
            this.textBoxBe.Name = "textBoxBe";
            this.textBoxBe.Size = new System.Drawing.Size(185, 140);
            this.textBoxBe.TabIndex = 2;
            // 
            // pbKep
            // 
            this.pbKep.Location = new System.Drawing.Point(561, 130);
            this.pbKep.Name = "pbKep";
            this.pbKep.Size = new System.Drawing.Size(227, 140);
            this.pbKep.TabIndex = 3;
            this.pbKep.TabStop = false;
            // 
            // btnSzovegMegnyit
            // 
            this.btnSzovegMegnyit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSzovegMegnyit.Location = new System.Drawing.Point(295, 58);
            this.btnSzovegMegnyit.Name = "btnSzovegMegnyit";
            this.btnSzovegMegnyit.Size = new System.Drawing.Size(75, 23);
            this.btnSzovegMegnyit.TabIndex = 4;
            this.btnSzovegMegnyit.Text = "Megnyitás";
            this.btnSzovegMegnyit.UseVisualStyleBackColor = false;
            this.btnSzovegMegnyit.Click += new System.EventHandler(this.btnMehet2_Click);
            // 
            // btnMehetKep
            // 
            this.btnMehetKep.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMehetKep.Location = new System.Drawing.Point(633, 58);
            this.btnMehetKep.Name = "btnMehetKep";
            this.btnMehetKep.Size = new System.Drawing.Size(75, 23);
            this.btnMehetKep.TabIndex = 5;
            this.btnMehetKep.Text = "Megnyitás";
            this.btnMehetKep.UseVisualStyleBackColor = false;
            this.btnMehetKep.Click += new System.EventHandler(this.btnMehetKep_Click);
            // 
            // lblSzin
            // 
            this.lblSzin.AutoSize = true;
            this.lblSzin.Location = new System.Drawing.Point(43, 212);
            this.lblSzin.Name = "lblSzin";
            this.lblSzin.Size = new System.Drawing.Size(86, 13);
            this.lblSzin.TabIndex = 6;
            this.lblSzin.Text = "A választott szin:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(58, 25);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(57, 13);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = "Átszinezés";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Szöveg beolvasás";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(641, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kép beállitás";
            // 
            // btnSzovegMentes
            // 
            this.btnSzovegMentes.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSzovegMentes.Location = new System.Drawing.Point(405, 58);
            this.btnSzovegMentes.Name = "btnSzovegMentes";
            this.btnSzovegMentes.Size = new System.Drawing.Size(75, 23);
            this.btnSzovegMentes.TabIndex = 10;
            this.btnSzovegMentes.Text = "Mentés";
            this.btnSzovegMentes.UseVisualStyleBackColor = false;
            this.btnSzovegMentes.Click += new System.EventHandler(this.btnSzovegMentes_Click);
            // 
            // Dialogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSzovegMentes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblSzin);
            this.Controls.Add(this.btnMehetKep);
            this.Controls.Add(this.btnSzovegMegnyit);
            this.Controls.Add(this.pbKep);
            this.Controls.Add(this.textBoxBe);
            this.Controls.Add(this.btnMehet);
            this.Controls.Add(this.lblSzinezos);
            this.Name = "Dialogs";
            this.Text = "Dialogs";
            ((System.ComponentModel.ISupportInitialize)(this.pbKep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSzinezos;
        private System.Windows.Forms.Button btnMehet;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox textBoxBe;
        private System.Windows.Forms.PictureBox pbKep;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button btnSzovegMegnyit;
        private System.Windows.Forms.Button btnMehetKep;
        private System.Windows.Forms.Label lblSzin;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSzovegMentes;
    }
}

