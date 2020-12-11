namespace uj
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
            this.listboxEredmeny = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSZK = new System.Windows.Forms.Button();
            this.btnMK = new System.Windows.Forms.Button();
            this.btnHK = new System.Windows.Forms.Button();
            this.btnLE = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.nud1 = new System.Windows.Forms.NumericUpDown();
            this.nud2 = new System.Windows.Forms.NumericUpDown();
            this.nud3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud3)).BeginInit();
            this.SuspendLayout();
            // 
            // listboxEredmeny
            // 
            this.listboxEredmeny.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.listboxEredmeny.FormattingEnabled = true;
            this.listboxEredmeny.Items.AddRange(new object[] {
            "Eredmeny ide jön"});
            this.listboxEredmeny.Location = new System.Drawing.Point(106, 152);
            this.listboxEredmeny.Name = "listboxEredmeny";
            this.listboxEredmeny.Size = new System.Drawing.Size(371, 238);
            this.listboxEredmeny.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnSZK
            // 
            this.btnSZK.Location = new System.Drawing.Point(0, -2);
            this.btnSZK.Name = "btnSZK";
            this.btnSZK.Size = new System.Drawing.Size(98, 23);
            this.btnSZK.TabIndex = 2;
            this.btnSZK.Text = "Számtani közép";
            this.btnSZK.UseVisualStyleBackColor = true;
            this.btnSZK.Click += new System.EventHandler(this.btnSZK_Click);
            // 
            // btnMK
            // 
            this.btnMK.Location = new System.Drawing.Point(117, -2);
            this.btnMK.Name = "btnMK";
            this.btnMK.Size = new System.Drawing.Size(98, 23);
            this.btnMK.TabIndex = 3;
            this.btnMK.Text = "Mértani közép";
            this.btnMK.UseVisualStyleBackColor = true;
            // 
            // btnHK
            // 
            this.btnHK.Location = new System.Drawing.Point(250, -2);
            this.btnHK.Name = "btnHK";
            this.btnHK.Size = new System.Drawing.Size(112, 23);
            this.btnHK.TabIndex = 4;
            this.btnHK.Text = "Harmonikus közép";
            this.btnHK.UseVisualStyleBackColor = true;
            // 
            // btnLE
            // 
            this.btnLE.Location = new System.Drawing.Point(389, -2);
            this.btnLE.Name = "btnLE";
            this.btnLE.Size = new System.Drawing.Size(112, 23);
            this.btnLE.TabIndex = 5;
            this.btnLE.Text = "Legnagyobb érték";
            this.btnLE.UseVisualStyleBackColor = true;
            this.btnLE.Click += new System.EventHandler(this.btnLE_Click);
            // 
            // btnTorles
            // 
            this.btnTorles.Location = new System.Drawing.Point(531, -2);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(98, 23);
            this.btnTorles.TabIndex = 9;
            this.btnTorles.Text = "Törlés";
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Click += new System.EventHandler(this.btnTorles_Click);
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(690, -2);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(98, 23);
            this.btnKilepes.TabIndex = 10;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // nud1
            // 
            this.nud1.Location = new System.Drawing.Point(117, 72);
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(120, 20);
            this.nud1.TabIndex = 11;
            // 
            // nud2
            // 
            this.nud2.Location = new System.Drawing.Point(288, 72);
            this.nud2.Name = "nud2";
            this.nud2.Size = new System.Drawing.Size(120, 20);
            this.nud2.TabIndex = 12;
            // 
            // nud3
            // 
            this.nud3.Location = new System.Drawing.Point(452, 72);
            this.nud3.Name = "nud3";
            this.nud3.Size = new System.Drawing.Size(120, 20);
            this.nud3.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nud3);
            this.Controls.Add(this.nud2);
            this.Controls.Add(this.nud1);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.btnLE);
            this.Controls.Add(this.btnHK);
            this.Controls.Add(this.btnMK);
            this.Controls.Add(this.btnSZK);
            this.Controls.Add(this.listboxEredmeny);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listboxEredmeny;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnSZK;
        private System.Windows.Forms.Button btnMK;
        private System.Windows.Forms.Button btnHK;
        private System.Windows.Forms.Button btnLE;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.NumericUpDown nud1;
        private System.Windows.Forms.NumericUpDown nud2;
        private System.Windows.Forms.NumericUpDown nud3;
    }
}

