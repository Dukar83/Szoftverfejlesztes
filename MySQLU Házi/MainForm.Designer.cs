
namespace MySQLUsers
{
    partial class MainForm
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
            this.tbxID = new System.Windows.Forms.TextBox();
            this.tbxNeve = new System.Windows.Forms.TextBox();
            this.tbxME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxCikkszama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxMennyiseg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxID
            // 
            this.tbxID.Enabled = false;
            this.tbxID.Location = new System.Drawing.Point(37, 60);
            this.tbxID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(148, 26);
            this.tbxID.TabIndex = 0;
            // 
            // tbxNeve
            // 
            this.tbxNeve.Enabled = false;
            this.tbxNeve.Location = new System.Drawing.Point(37, 148);
            this.tbxNeve.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxNeve.Name = "tbxNeve";
            this.tbxNeve.Size = new System.Drawing.Size(148, 26);
            this.tbxNeve.TabIndex = 1;
            // 
            // tbxME
            // 
            this.tbxME.Enabled = false;
            this.tbxME.Location = new System.Drawing.Point(37, 236);
            this.tbxME.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxME.Name = "tbxME";
            this.tbxME.Size = new System.Drawing.Size(148, 26);
            this.tbxME.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cikk azonositó";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(33, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cikk név";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(33, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "ME";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(227, 38);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(148, 48);
            this.btnOpen.TabIndex = 7;
            this.btnOpen.Text = "Kapcsolódás";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnRead
            // 
            this.btnRead.Enabled = false;
            this.btnRead.Location = new System.Drawing.Point(227, 135);
            this.btnRead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(148, 48);
            this.btnRead.TabIndex = 8;
            this.btnRead.Text = "Megnyitás olvasásra";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(227, 230);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(148, 48);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Következő rekord";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Enabled = false;
            this.btnInsert.Location = new System.Drawing.Point(227, 322);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(148, 48);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Beszúrás";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(227, 414);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(148, 48);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Módositás";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(227, 506);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 48);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Törlés";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Enabled = false;
            this.btnClose.Location = new System.Drawing.Point(37, 507);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 48);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Adatbázis bezárása";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(33, 299);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cikkszáma";
            // 
            // tbxCikkszama
            // 
            this.tbxCikkszama.Enabled = false;
            this.tbxCikkszama.Location = new System.Drawing.Point(37, 324);
            this.tbxCikkszama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxCikkszama.Name = "tbxCikkszama";
            this.tbxCikkszama.Size = new System.Drawing.Size(148, 26);
            this.tbxCikkszama.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(35, 387);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Mennyiség";
            // 
            // tbxMennyiseg
            // 
            this.tbxMennyiseg.Enabled = false;
            this.tbxMennyiseg.Location = new System.Drawing.Point(37, 412);
            this.tbxMennyiseg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxMennyiseg.Name = "tbxMennyiseg";
            this.tbxMennyiseg.Size = new System.Drawing.Size(148, 26);
            this.tbxMennyiseg.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(420, 569);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxMennyiseg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxCikkszama);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxME);
            this.Controls.Add(this.tbxNeve);
            this.Controls.Add(this.tbxID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Nyilvántartó lap";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.TextBox tbxNeve;
        private System.Windows.Forms.TextBox tbxME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxCikkszama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxMennyiseg;
    }
}

