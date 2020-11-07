namespace matrix4
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudSor = new System.Windows.Forms.NumericUpDown();
            this.nudOszlop = new System.Windows.Forms.NumericUpDown();
            this.dgvMatrix = new System.Windows.Forms.DataGridView();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnMehet = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOszlop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMehet);
            this.panel1.Controls.Add(this.listBox);
            this.panel1.Controls.Add(this.dgvMatrix);
            this.panel1.Controls.Add(this.nudOszlop);
            this.panel1.Controls.Add(this.nudSor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Oszlop:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Eredmények:";
            // 
            // nudSor
            // 
            this.nudSor.Location = new System.Drawing.Point(98, 26);
            this.nudSor.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSor.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSor.Name = "nudSor";
            this.nudSor.Size = new System.Drawing.Size(40, 20);
            this.nudSor.TabIndex = 3;
            this.nudSor.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nudOszlop
            // 
            this.nudOszlop.Location = new System.Drawing.Point(239, 26);
            this.nudOszlop.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudOszlop.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudOszlop.Name = "nudOszlop";
            this.nudOszlop.Size = new System.Drawing.Size(39, 20);
            this.nudOszlop.TabIndex = 4;
            this.nudOszlop.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // dgvMatrix
            // 
            this.dgvMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrix.ColumnHeadersVisible = false;
            this.dgvMatrix.Location = new System.Drawing.Point(22, 132);
            this.dgvMatrix.Name = "dgvMatrix";
            this.dgvMatrix.RowHeadersVisible = false;
            this.dgvMatrix.Size = new System.Drawing.Size(360, 306);
            this.dgvMatrix.TabIndex = 5;
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(418, 133);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(343, 303);
            this.listBox.TabIndex = 6;
            // 
            // btnMehet
            // 
            this.btnMehet.Location = new System.Drawing.Point(307, 26);
            this.btnMehet.Name = "btnMehet";
            this.btnMehet.Size = new System.Drawing.Size(75, 23);
            this.btnMehet.TabIndex = 7;
            this.btnMehet.Text = "Mehet!";
            this.btnMehet.UseVisualStyleBackColor = true;
            this.btnMehet.Click += new System.EventHandler(this.btnMehet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOszlop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMatrix;
        private System.Windows.Forms.NumericUpDown nudOszlop;
        private System.Windows.Forms.NumericUpDown nudSor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnMehet;
    }
}

