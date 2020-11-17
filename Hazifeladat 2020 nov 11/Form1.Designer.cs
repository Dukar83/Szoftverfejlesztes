
namespace Hazifeladat_2020_nov_11
{
    partial class Hazi2020nov11
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
            this.tpBeker = new System.Windows.Forms.TabPage();
            this.tpMatrix = new System.Windows.Forms.TabPage();
            this.tpTransz = new System.Windows.Forms.TabPage();
            this.tpSkalar = new System.Windows.Forms.TabPage();
            this.tpKisNagy = new System.Windows.Forms.TabPage();
            this.btnMehet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMatrix = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.tbc.SuspendLayout();
            this.tpBeker.SuspendLayout();
            this.tpMatrix.SuspendLayout();
            this.tpTransz.SuspendLayout();
            this.tpSkalar.SuspendLayout();
            this.tpKisNagy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // tbc
            // 
            this.tbc.Controls.Add(this.tpBeker);
            this.tbc.Controls.Add(this.tpMatrix);
            this.tbc.Controls.Add(this.tpTransz);
            this.tbc.Controls.Add(this.tpSkalar);
            this.tbc.Controls.Add(this.tpKisNagy);
            this.tbc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc.Location = new System.Drawing.Point(0, 0);
            this.tbc.Name = "tbc";
            this.tbc.SelectedIndex = 0;
            this.tbc.Size = new System.Drawing.Size(800, 450);
            this.tbc.TabIndex = 0;
            // 
            // tpBeker
            // 
            this.tpBeker.BackColor = System.Drawing.Color.Turquoise;
            this.tpBeker.Controls.Add(this.button2);
            this.tpBeker.Controls.Add(this.button1);
            this.tpBeker.Controls.Add(this.label1);
            this.tpBeker.Controls.Add(this.btnMehet);
            this.tpBeker.Location = new System.Drawing.Point(4, 22);
            this.tpBeker.Name = "tpBeker";
            this.tpBeker.Padding = new System.Windows.Forms.Padding(3);
            this.tpBeker.Size = new System.Drawing.Size(792, 424);
            this.tpBeker.TabIndex = 0;
            this.tpBeker.Text = "Bekér";
            // 
            // tpMatrix
            // 
            this.tpMatrix.BackColor = System.Drawing.Color.Turquoise;
            this.tpMatrix.Controls.Add(this.button11);
            this.tpMatrix.Controls.Add(this.button3);
            this.tpMatrix.Controls.Add(this.button4);
            this.tpMatrix.Controls.Add(this.dgvMatrix);
            this.tpMatrix.Location = new System.Drawing.Point(4, 22);
            this.tpMatrix.Name = "tpMatrix";
            this.tpMatrix.Padding = new System.Windows.Forms.Padding(3);
            this.tpMatrix.Size = new System.Drawing.Size(792, 424);
            this.tpMatrix.TabIndex = 1;
            this.tpMatrix.Text = "Matrix";
            // 
            // tpTransz
            // 
            this.tpTransz.BackColor = System.Drawing.Color.Turquoise;
            this.tpTransz.Controls.Add(this.button5);
            this.tpTransz.Controls.Add(this.button6);
            this.tpTransz.Location = new System.Drawing.Point(4, 22);
            this.tpTransz.Name = "tpTransz";
            this.tpTransz.Padding = new System.Windows.Forms.Padding(3);
            this.tpTransz.Size = new System.Drawing.Size(792, 424);
            this.tpTransz.TabIndex = 2;
            this.tpTransz.Text = "Transz";
            // 
            // tpSkalar
            // 
            this.tpSkalar.BackColor = System.Drawing.Color.Turquoise;
            this.tpSkalar.Controls.Add(this.button7);
            this.tpSkalar.Controls.Add(this.button8);
            this.tpSkalar.Location = new System.Drawing.Point(4, 22);
            this.tpSkalar.Name = "tpSkalar";
            this.tpSkalar.Padding = new System.Windows.Forms.Padding(3);
            this.tpSkalar.Size = new System.Drawing.Size(792, 424);
            this.tpSkalar.TabIndex = 3;
            this.tpSkalar.Text = "Skalár";
            // 
            // tpKisNagy
            // 
            this.tpKisNagy.BackColor = System.Drawing.Color.Turquoise;
            this.tpKisNagy.Controls.Add(this.button9);
            this.tpKisNagy.Controls.Add(this.button10);
            this.tpKisNagy.Location = new System.Drawing.Point(4, 22);
            this.tpKisNagy.Name = "tpKisNagy";
            this.tpKisNagy.Padding = new System.Windows.Forms.Padding(3);
            this.tpKisNagy.Size = new System.Drawing.Size(792, 424);
            this.tpKisNagy.TabIndex = 4;
            this.tpKisNagy.Text = "Legkisebb Legnagyobb";
            // 
            // btnMehet
            // 
            this.btnMehet.Location = new System.Drawing.Point(372, 176);
            this.btnMehet.Name = "btnMehet";
            this.btnMehet.Size = new System.Drawing.Size(75, 23);
            this.btnMehet.TabIndex = 0;
            this.btnMehet.Text = "Mehet!";
            this.btnMehet.UseVisualStyleBackColor = true;
            this.btnMehet.Click += new System.EventHandler(this.btnMehet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Generálunk egy 3x3as mátrixot";
            // 
            // dgvMatrix
            // 
            this.dgvMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrix.Location = new System.Drawing.Point(219, 105);
            this.dgvMatrix.Name = "dgvMatrix";
            this.dgvMatrix.Size = new System.Drawing.Size(375, 188);
            this.dgvMatrix.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Balra tovább";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(465, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Jobbra tovább";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(463, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Jobbra tovább";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(258, 366);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Balra tovább";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(441, 369);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Jobbra tovább";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(236, 369);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "Balra tovább";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(446, 368);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(87, 23);
            this.button7.TabIndex = 5;
            this.button7.Text = "Jobbra tovább";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(241, 368);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 4;
            this.button8.Text = "Balra tovább";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(441, 369);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(87, 23);
            this.button9.TabIndex = 5;
            this.button9.Text = "Jobbra tovább";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(236, 369);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 4;
            this.button10.Text = "Balra tovább";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(51, 162);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 6;
            this.button11.Text = "Mehet!";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Hazi2020nov11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbc);
            this.Name = "Hazi2020nov11";
            this.Text = "Hazi2020nov11";
            this.tbc.ResumeLayout(false);
            this.tpBeker.ResumeLayout(false);
            this.tpBeker.PerformLayout();
            this.tpMatrix.ResumeLayout(false);
            this.tpTransz.ResumeLayout(false);
            this.tpSkalar.ResumeLayout(false);
            this.tpKisNagy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc;
        private System.Windows.Forms.TabPage tpBeker;
        private System.Windows.Forms.TabPage tpMatrix;
        private System.Windows.Forms.TabPage tpTransz;
        private System.Windows.Forms.TabPage tpSkalar;
        private System.Windows.Forms.TabPage tpKisNagy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMehet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvMatrix;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
    }
}

