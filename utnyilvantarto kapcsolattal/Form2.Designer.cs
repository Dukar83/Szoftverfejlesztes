
namespace utnyilvantarto_kapcsolattal
{
    partial class FormRogzit
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
            this.tpKimutat = new System.Windows.Forms.TabPage();
            this.btnSzures = new System.Windows.Forms.Button();
            this.tbxHovaSzures = new System.Windows.Forms.TextBox();
            this.tbxHonnanSzures = new System.Windows.Forms.TextBox();
            this.lblHova = new System.Windows.Forms.Label();
            this.lblHonnan = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRogzit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.nudKm = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxHova = new System.Windows.Forms.TextBox();
            this.tbxHonnan = new System.Windows.Forms.TextBox();
            this.dtDatum = new System.Windows.Forms.DateTimePicker();
            this.tbcmain = new System.Windows.Forms.TabControl();
            this.dgvKimutat = new System.Windows.Forms.DataGridView();
            this.tpKimutat.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKm)).BeginInit();
            this.tbcmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKimutat)).BeginInit();
            this.SuspendLayout();
            // 
            // tpKimutat
            // 
            this.tpKimutat.BackColor = System.Drawing.Color.Turquoise;
            this.tpKimutat.Controls.Add(this.dgvKimutat);
            this.tpKimutat.Controls.Add(this.btnSzures);
            this.tpKimutat.Controls.Add(this.tbxHovaSzures);
            this.tpKimutat.Controls.Add(this.tbxHonnanSzures);
            this.tpKimutat.Controls.Add(this.lblHova);
            this.tpKimutat.Controls.Add(this.lblHonnan);
            this.tpKimutat.Location = new System.Drawing.Point(4, 22);
            this.tpKimutat.Name = "tpKimutat";
            this.tpKimutat.Padding = new System.Windows.Forms.Padding(3);
            this.tpKimutat.Size = new System.Drawing.Size(792, 422);
            this.tpKimutat.TabIndex = 1;
            this.tpKimutat.Text = "tpKimutat";
            // 
            // btnSzures
            // 
            this.btnSzures.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnSzures.Location = new System.Drawing.Point(338, 94);
            this.btnSzures.Name = "btnSzures";
            this.btnSzures.Size = new System.Drawing.Size(84, 30);
            this.btnSzures.TabIndex = 34;
            this.btnSzures.Text = "Szürés";
            this.btnSzures.UseVisualStyleBackColor = true;
            this.btnSzures.Click += new System.EventHandler(this.btnSzures_Click);
            // 
            // tbxHovaSzures
            // 
            this.tbxHovaSzures.Location = new System.Drawing.Point(427, 56);
            this.tbxHovaSzures.Name = "tbxHovaSzures";
            this.tbxHovaSzures.Size = new System.Drawing.Size(100, 20);
            this.tbxHovaSzures.TabIndex = 2;
            // 
            // tbxHonnanSzures
            // 
            this.tbxHonnanSzures.Location = new System.Drawing.Point(242, 56);
            this.tbxHonnanSzures.Name = "tbxHonnanSzures";
            this.tbxHonnanSzures.Size = new System.Drawing.Size(100, 20);
            this.tbxHonnanSzures.TabIndex = 1;
            // 
            // lblHova
            // 
            this.lblHova.AutoSize = true;
            this.lblHova.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblHova.Location = new System.Drawing.Point(424, 22);
            this.lblHova.Name = "lblHova";
            this.lblHova.Size = new System.Drawing.Size(54, 24);
            this.lblHova.TabIndex = 3;
            this.lblHova.Text = "Hová";
            // 
            // lblHonnan
            // 
            this.lblHonnan.AutoSize = true;
            this.lblHonnan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblHonnan.Location = new System.Drawing.Point(239, 22);
            this.lblHonnan.Name = "lblHonnan";
            this.lblHonnan.Size = new System.Drawing.Size(78, 24);
            this.lblHonnan.TabIndex = 0;
            this.lblHonnan.Text = "Honnan";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Turquoise;
            this.tabPage1.Controls.Add(this.btnRogzit);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lblID);
            this.tabPage1.Controls.Add(this.nudKm);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbxHova);
            this.tabPage1.Controls.Add(this.tbxHonnan);
            this.tabPage1.Controls.Add(this.dtDatum);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tpRogzit";
            // 
            // btnRogzit
            // 
            this.btnRogzit.Location = new System.Drawing.Point(402, 358);
            this.btnRogzit.Name = "btnRogzit";
            this.btnRogzit.Size = new System.Drawing.Size(75, 23);
            this.btnRogzit.TabIndex = 25;
            this.btnRogzit.Text = "Bevitel";
            this.btnRogzit.UseVisualStyleBackColor = true;
            this.btnRogzit.Click += new System.EventHandler(this.btnRogzit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(228, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Km";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblID.Location = new System.Drawing.Point(228, 90);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(76, 24);
            this.lblID.TabIndex = 23;
            this.lblID.Text = "User ID:";
            // 
            // nudKm
            // 
            this.nudKm.Location = new System.Drawing.Point(340, 298);
            this.nudKm.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudKm.Name = "nudKm";
            this.nudKm.Size = new System.Drawing.Size(200, 20);
            this.nudKm.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(228, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Hová:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(228, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Honnan:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(228, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Dátum:";
            // 
            // tbxHova
            // 
            this.tbxHova.Location = new System.Drawing.Point(340, 244);
            this.tbxHova.Name = "tbxHova";
            this.tbxHova.Size = new System.Drawing.Size(200, 20);
            this.tbxHova.TabIndex = 18;
            // 
            // tbxHonnan
            // 
            this.tbxHonnan.Location = new System.Drawing.Point(340, 206);
            this.tbxHonnan.Name = "tbxHonnan";
            this.tbxHonnan.Size = new System.Drawing.Size(200, 20);
            this.tbxHonnan.TabIndex = 17;
            // 
            // dtDatum
            // 
            this.dtDatum.Location = new System.Drawing.Point(340, 159);
            this.dtDatum.Name = "dtDatum";
            this.dtDatum.Size = new System.Drawing.Size(200, 20);
            this.dtDatum.TabIndex = 16;
            // 
            // tbcmain
            // 
            this.tbcmain.Controls.Add(this.tabPage1);
            this.tbcmain.Controls.Add(this.tpKimutat);
            this.tbcmain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbcmain.Location = new System.Drawing.Point(0, 0);
            this.tbcmain.Name = "tbcmain";
            this.tbcmain.SelectedIndex = 0;
            this.tbcmain.Size = new System.Drawing.Size(800, 448);
            this.tbcmain.TabIndex = 12;
            // 
            // dgvKimutat
            // 
            this.dgvKimutat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKimutat.Location = new System.Drawing.Point(77, 171);
            this.dgvKimutat.Name = "dgvKimutat";
            this.dgvKimutat.Size = new System.Drawing.Size(659, 245);
            this.dgvKimutat.TabIndex = 35;
            // 
            // FormRogzit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcmain);
            this.Name = "FormRogzit";
            this.Text = "Rogzit";
            this.tpKimutat.ResumeLayout(false);
            this.tpKimutat.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKm)).EndInit();
            this.tbcmain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKimutat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpKimutat;
        private System.Windows.Forms.Button btnSzures;
        private System.Windows.Forms.TextBox tbxHovaSzures;
        private System.Windows.Forms.TextBox tbxHonnanSzures;
        private System.Windows.Forms.Label lblHova;
        private System.Windows.Forms.Label lblHonnan;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnRogzit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.NumericUpDown nudKm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxHova;
        private System.Windows.Forms.TextBox tbxHonnan;
        private System.Windows.Forms.DateTimePicker dtDatum;
        private System.Windows.Forms.TabControl tbcmain;
        private System.Windows.Forms.DataGridView dgvKimutat;
    }
}