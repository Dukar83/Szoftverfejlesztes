namespace matrixos
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_Gen = new System.Windows.Forms.Button();
            this.matrix2 = new System.Windows.Forms.DataGridView();
            this.matrix1 = new System.Windows.Forms.DataGridView();
            this.nud1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrix2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.btn_Gen);
            this.panel1.Controls.Add(this.matrix2);
            this.panel1.Controls.Add(this.matrix1);
            this.panel1.Controls.Add(this.nud1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 456);
            this.panel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(47, 342);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(621, 96);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // btn_Gen
            // 
            this.btn_Gen.Location = new System.Drawing.Point(267, 70);
            this.btn_Gen.Name = "btn_Gen";
            this.btn_Gen.Size = new System.Drawing.Size(75, 23);
            this.btn_Gen.TabIndex = 5;
            this.btn_Gen.Text = "Mehet!";
            this.btn_Gen.UseVisualStyleBackColor = true;
            this.btn_Gen.Click += new System.EventHandler(this.btn_Gen_Click);
            // 
            // matrix2
            // 
            this.matrix2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrix2.Location = new System.Drawing.Point(421, 166);
            this.matrix2.Name = "matrix2";
            this.matrix2.Size = new System.Drawing.Size(240, 150);
            this.matrix2.TabIndex = 4;
            // 
            // matrix1
            // 
            this.matrix1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrix1.Location = new System.Drawing.Point(47, 166);
            this.matrix1.Name = "matrix1";
            this.matrix1.Size = new System.Drawing.Size(240, 150);
            this.matrix1.TabIndex = 3;
            // 
            // nud1
            // 
            this.nud1.Location = new System.Drawing.Point(71, 73);
            this.nud1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nud1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(120, 20);
            this.nud1.TabIndex = 2;
            this.nud1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "5-15 közötti szám bekérése";
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
            ((System.ComponentModel.ISupportInitialize)(this.matrix2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView matrix1;
        private System.Windows.Forms.NumericUpDown nud1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView matrix2;
        private System.Windows.Forms.Button btn_Gen;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

