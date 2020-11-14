namespace tabcontrol2
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
            this.tabControlFo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxB = new System.Windows.Forms.TextBox();
            this.tbxA = new System.Windows.Forms.TextBox();
            this.btnAdatOK = new System.Windows.Forms.Button();
            this.lblEredm = new System.Windows.Forms.Label();
            this.tabControlFo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlFo
            // 
            this.tabControlFo.Controls.Add(this.tabPage1);
            this.tabControlFo.Controls.Add(this.tabPage2);
            this.tabControlFo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlFo.Location = new System.Drawing.Point(0, 0);
            this.tabControlFo.Name = "tabControlFo";
            this.tabControlFo.SelectedIndex = 0;
            this.tabControlFo.Size = new System.Drawing.Size(800, 450);
            this.tabControlFo.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAdatOK);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbxB);
            this.tabPage1.Controls.Add(this.tbxA);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adatok";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblEredm);
            this.tabPage2.Controls.Add(this.btnKilepes);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Eredények";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(36, 152);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(75, 23);
            this.btnKilepes.TabIndex = 0;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
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
            this.tbxA.Leave += new System.EventHandler(this.tbxA_Leave);
            // 
            // btnAdatOK
            // 
            this.btnAdatOK.Location = new System.Drawing.Point(33, 207);
            this.btnAdatOK.Name = "btnAdatOK";
            this.btnAdatOK.Size = new System.Drawing.Size(75, 23);
            this.btnAdatOK.TabIndex = 7;
            this.btnAdatOK.Text = "OK";
            this.btnAdatOK.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlFo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControlFo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlFo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAdatOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxB;
        private System.Windows.Forms.TextBox tbxA;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblEredm;
        private System.Windows.Forms.Button btnKilepes;
    }
}

