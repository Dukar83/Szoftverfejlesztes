
namespace CRUD2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNev = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbJelszo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRegeles = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblKapcsolodott = new System.Windows.Forms.Label();
            this.txbTorol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(15, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(15, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(16, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email cim:";
            // 
            // txbNev
            // 
            this.txbNev.Location = new System.Drawing.Point(122, 75);
            this.txbNev.Name = "txbNev";
            this.txbNev.Size = new System.Drawing.Size(181, 20);
            this.txbNev.TabIndex = 3;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(126, 218);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(181, 20);
            this.txbEmail.TabIndex = 4;
            // 
            // txbJelszo
            // 
            this.txbJelszo.Location = new System.Drawing.Point(122, 99);
            this.txbJelszo.Name = "txbJelszo";
            this.txbJelszo.Size = new System.Drawing.Size(181, 20);
            this.txbJelszo.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(327, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Listáz (READ\\SELECT)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button2.Location = new System.Drawing.Point(327, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "Töröl (DELETE)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRegeles
            // 
            this.btnRegeles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnRegeles.Location = new System.Drawing.Point(327, 75);
            this.btnRegeles.Name = "btnRegeles";
            this.btnRegeles.Size = new System.Drawing.Size(200, 50);
            this.btnRegeles.TabIndex = 8;
            this.btnRegeles.Text = "Regisztrál (CREATE)";
            this.btnRegeles.UseVisualStyleBackColor = true;
            this.btnRegeles.Click += new System.EventHandler(this.btnRegeles_Click_1);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button4.Location = new System.Drawing.Point(327, 187);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 50);
            this.button4.TabIndex = 9;
            this.button4.Text = "Email felülir (UPDATE)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblKapcsolodott
            // 
            this.lblKapcsolodott.AutoSize = true;
            this.lblKapcsolodott.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblKapcsolodott.Location = new System.Drawing.Point(16, 9);
            this.lblKapcsolodott.Name = "lblKapcsolodott";
            this.lblKapcsolodott.Size = new System.Drawing.Size(60, 24);
            this.lblKapcsolodott.TabIndex = 10;
            this.lblKapcsolodott.Text = "label4";
            // 
            // txbTorol
            // 
            this.txbTorol.Location = new System.Drawing.Point(125, 274);
            this.txbTorol.Name = "txbTorol";
            this.txbTorol.Size = new System.Drawing.Size(181, 20);
            this.txbTorol.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(3, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Törlendő ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(548, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 218);
            this.dataGridView1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txbTorol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblKapcsolodott);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnRegeles);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbJelszo);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbNev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNev;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbJelszo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRegeles;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblKapcsolodott;
        private System.Windows.Forms.TextBox txbTorol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

