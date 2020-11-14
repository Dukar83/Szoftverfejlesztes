namespace tabcontrol
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
            this.tbpSzemelyi = new System.Windows.Forms.TabPage();
            this.tbpKodok = new System.Windows.Forms.TabPage();
            this.tbxVezNev = new System.Windows.Forms.TextBox();
            this.tbxKeresztNev = new System.Windows.Forms.TextBox();
            this.tbxVaros = new System.Windows.Forms.TextBox();
            this.tbxLakcim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOkSza = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnMegse = new System.Windows.Forms.Button();
            this.btnOkAzon = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxSzemSzam = new System.Windows.Forms.TextBox();
            this.tbxAdoSzam = new System.Windows.Forms.TextBox();
            this.tbxJogositvany = new System.Windows.Forms.TextBox();
            this.tbxUtlevel = new System.Windows.Forms.TextBox();
            this.tbcEre = new System.Windows.Forms.TabPage();
            this.lblEredmeny = new System.Windows.Forms.Label();
            this.btnLista = new System.Windows.Forms.Button();
            this.tbcElso.SuspendLayout();
            this.tbpSzemelyi.SuspendLayout();
            this.tbpKodok.SuspendLayout();
            this.tbcEre.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcElso
            // 
            this.tbcElso.Controls.Add(this.tbpSzemelyi);
            this.tbcElso.Controls.Add(this.tbpKodok);
            this.tbcElso.Controls.Add(this.tbcEre);
            this.tbcElso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcElso.Location = new System.Drawing.Point(0, 0);
            this.tbcElso.Name = "tbcElso";
            this.tbcElso.SelectedIndex = 0;
            this.tbcElso.Size = new System.Drawing.Size(445, 450);
            this.tbcElso.TabIndex = 0;
            // 
            // tbpSzemelyi
            // 
            this.tbpSzemelyi.Controls.Add(this.btnCancel);
            this.tbpSzemelyi.Controls.Add(this.btnOkSza);
            this.tbpSzemelyi.Controls.Add(this.label4);
            this.tbpSzemelyi.Controls.Add(this.label3);
            this.tbpSzemelyi.Controls.Add(this.label2);
            this.tbpSzemelyi.Controls.Add(this.label1);
            this.tbpSzemelyi.Controls.Add(this.tbxLakcim);
            this.tbpSzemelyi.Controls.Add(this.tbxVaros);
            this.tbpSzemelyi.Controls.Add(this.tbxKeresztNev);
            this.tbpSzemelyi.Controls.Add(this.tbxVezNev);
            this.tbpSzemelyi.Location = new System.Drawing.Point(4, 22);
            this.tbpSzemelyi.Name = "tbpSzemelyi";
            this.tbpSzemelyi.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSzemelyi.Size = new System.Drawing.Size(437, 424);
            this.tbpSzemelyi.TabIndex = 0;
            this.tbpSzemelyi.Text = "Személyi adatok";
            this.tbpSzemelyi.UseVisualStyleBackColor = true;
            // 
            // tbpKodok
            // 
            this.tbpKodok.Controls.Add(this.tbxUtlevel);
            this.tbpKodok.Controls.Add(this.tbxJogositvany);
            this.tbpKodok.Controls.Add(this.tbxAdoSzam);
            this.tbpKodok.Controls.Add(this.tbxSzemSzam);
            this.tbpKodok.Controls.Add(this.label8);
            this.tbpKodok.Controls.Add(this.label7);
            this.tbpKodok.Controls.Add(this.label6);
            this.tbpKodok.Controls.Add(this.label5);
            this.tbpKodok.Controls.Add(this.btnOkAzon);
            this.tbpKodok.Controls.Add(this.btnMegse);
            this.tbpKodok.Location = new System.Drawing.Point(4, 22);
            this.tbpKodok.Name = "tbpKodok";
            this.tbpKodok.Padding = new System.Windows.Forms.Padding(3);
            this.tbpKodok.Size = new System.Drawing.Size(437, 424);
            this.tbpKodok.TabIndex = 1;
            this.tbpKodok.Text = "Kódok";
            this.tbpKodok.UseVisualStyleBackColor = true;
            // 
            // tbxVezNev
            // 
            this.tbxVezNev.Location = new System.Drawing.Point(123, 46);
            this.tbxVezNev.Name = "tbxVezNev";
            this.tbxVezNev.Size = new System.Drawing.Size(100, 20);
            this.tbxVezNev.TabIndex = 0;
            // 
            // tbxKeresztNev
            // 
            this.tbxKeresztNev.Location = new System.Drawing.Point(123, 105);
            this.tbxKeresztNev.Name = "tbxKeresztNev";
            this.tbxKeresztNev.Size = new System.Drawing.Size(100, 20);
            this.tbxKeresztNev.TabIndex = 1;
            // 
            // tbxVaros
            // 
            this.tbxVaros.Location = new System.Drawing.Point(123, 164);
            this.tbxVaros.Name = "tbxVaros";
            this.tbxVaros.Size = new System.Drawing.Size(100, 20);
            this.tbxVaros.TabIndex = 2;
            // 
            // tbxLakcim
            // 
            this.tbxLakcim.Location = new System.Drawing.Point(123, 223);
            this.tbxLakcim.Name = "tbxLakcim";
            this.tbxLakcim.Size = new System.Drawing.Size(100, 20);
            this.tbxLakcim.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vezeték név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Keresztnév:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lakás, város:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lakcim:";
            // 
            // btnOkSza
            // 
            this.btnOkSza.Location = new System.Drawing.Point(231, 315);
            this.btnOkSza.Name = "btnOkSza";
            this.btnOkSza.Size = new System.Drawing.Size(75, 23);
            this.btnOkSza.TabIndex = 8;
            this.btnOkSza.Text = "OK";
            this.btnOkSza.UseVisualStyleBackColor = true;
            this.btnOkSza.Click += new System.EventHandler(this.btnOkSza_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(31, 315);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Mégse";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnMegse
            // 
            this.btnMegse.Location = new System.Drawing.Point(30, 276);
            this.btnMegse.Name = "btnMegse";
            this.btnMegse.Size = new System.Drawing.Size(75, 23);
            this.btnMegse.TabIndex = 0;
            this.btnMegse.Text = "Megse";
            this.btnMegse.UseVisualStyleBackColor = true;
            this.btnMegse.Click += new System.EventHandler(this.btnMegse_Click);
            // 
            // btnOkAzon
            // 
            this.btnOkAzon.Location = new System.Drawing.Point(159, 276);
            this.btnOkAzon.Name = "btnOkAzon";
            this.btnOkAzon.Size = new System.Drawing.Size(75, 23);
            this.btnOkAzon.TabIndex = 1;
            this.btnOkAzon.Text = "OK";
            this.btnOkAzon.UseVisualStyleBackColor = true;
            this.btnOkAzon.Click += new System.EventHandler(this.btnOkAzon_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Személyi szám:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Adóazonositó:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Jogositvány:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Útlevél:";
            // 
            // tbxSzemSzam
            // 
            this.tbxSzemSzam.Location = new System.Drawing.Point(140, 65);
            this.tbxSzemSzam.Name = "tbxSzemSzam";
            this.tbxSzemSzam.Size = new System.Drawing.Size(100, 20);
            this.tbxSzemSzam.TabIndex = 6;
            // 
            // tbxAdoSzam
            // 
            this.tbxAdoSzam.Location = new System.Drawing.Point(140, 112);
            this.tbxAdoSzam.Name = "tbxAdoSzam";
            this.tbxAdoSzam.Size = new System.Drawing.Size(100, 20);
            this.tbxAdoSzam.TabIndex = 7;
            // 
            // tbxJogositvany
            // 
            this.tbxJogositvany.Location = new System.Drawing.Point(140, 159);
            this.tbxJogositvany.Name = "tbxJogositvany";
            this.tbxJogositvany.Size = new System.Drawing.Size(100, 20);
            this.tbxJogositvany.TabIndex = 8;
            // 
            // tbxUtlevel
            // 
            this.tbxUtlevel.Location = new System.Drawing.Point(140, 206);
            this.tbxUtlevel.Name = "tbxUtlevel";
            this.tbxUtlevel.Size = new System.Drawing.Size(100, 20);
            this.tbxUtlevel.TabIndex = 9;
            // 
            // tbcEre
            // 
            this.tbcEre.Controls.Add(this.btnLista);
            this.tbcEre.Controls.Add(this.lblEredmeny);
            this.tbcEre.Location = new System.Drawing.Point(4, 22);
            this.tbcEre.Name = "tbcEre";
            this.tbcEre.Padding = new System.Windows.Forms.Padding(3);
            this.tbcEre.Size = new System.Drawing.Size(437, 424);
            this.tbcEre.TabIndex = 2;
            this.tbcEre.Text = "Eredmény:";
            this.tbcEre.UseVisualStyleBackColor = true;
            // 
            // lblEredmeny
            // 
            this.lblEredmeny.AutoSize = true;
            this.lblEredmeny.Location = new System.Drawing.Point(30, 25);
            this.lblEredmeny.Name = "lblEredmeny";
            this.lblEredmeny.Size = new System.Drawing.Size(0, 13);
            this.lblEredmeny.TabIndex = 0;
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(168, 317);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(131, 23);
            this.btnLista.TabIndex = 1;
            this.btnLista.Text = "Eredmeny Listázás";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(445, 450);
            this.Controls.Add(this.tbcElso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tbcElso.ResumeLayout(false);
            this.tbpSzemelyi.ResumeLayout(false);
            this.tbpSzemelyi.PerformLayout();
            this.tbpKodok.ResumeLayout(false);
            this.tbpKodok.PerformLayout();
            this.tbcEre.ResumeLayout(false);
            this.tbcEre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcElso;
        private System.Windows.Forms.TabPage tbpSzemelyi;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOkSza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxLakcim;
        private System.Windows.Forms.TextBox tbxVaros;
        private System.Windows.Forms.TextBox tbxKeresztNev;
        private System.Windows.Forms.TextBox tbxVezNev;
        private System.Windows.Forms.TabPage tbpKodok;
        private System.Windows.Forms.TextBox tbxUtlevel;
        private System.Windows.Forms.TextBox tbxJogositvany;
        private System.Windows.Forms.TextBox tbxAdoSzam;
        private System.Windows.Forms.TextBox tbxSzemSzam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOkAzon;
        private System.Windows.Forms.Button btnMegse;
        private System.Windows.Forms.TabPage tbcEre;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Label lblEredmeny;
    }
}

