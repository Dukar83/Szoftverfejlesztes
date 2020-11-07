namespace _2020.Nov._04.Menukezeles
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
            this.dgvEredeti = new System.Windows.Forms.DataGridView();
            this.dgvTransz = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müveletekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transzponálásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.páratlanSzámokÖsszegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sorokbanLévőElemekÖsszegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oszlopokbanLévőElemekÖsszegétToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblParatlanOsszeg = new System.Windows.Forms.Label();
            this.lblSorEgyOsszeg = new System.Windows.Forms.Label();
            this.lblSorHaromOsszeg = new System.Windows.Forms.Label();
            this.lblOszlopEgyOsszeg = new System.Windows.Forms.Label();
            this.lblOszlopKettoOsszeg = new System.Windows.Forms.Label();
            this.lblOszlopHaromOsszeg = new System.Windows.Forms.Label();
            this.lblSorKettoOsszeg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEredeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransz)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEredeti
            // 
            this.dgvEredeti.BackgroundColor = System.Drawing.Color.Aqua;
            this.dgvEredeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEredeti.Location = new System.Drawing.Point(12, 65);
            this.dgvEredeti.Name = "dgvEredeti";
            this.dgvEredeti.Size = new System.Drawing.Size(240, 150);
            this.dgvEredeti.TabIndex = 0;
            // 
            // dgvTransz
            // 
            this.dgvTransz.BackgroundColor = System.Drawing.Color.Aqua;
            this.dgvTransz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransz.Location = new System.Drawing.Point(12, 274);
            this.dgvTransz.Name = "dgvTransz";
            this.dgvTransz.Size = new System.Drawing.Size(240, 150);
            this.dgvTransz.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müveletekToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müveletekToolStripMenuItem
            // 
            this.müveletekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transzponálásToolStripMenuItem,
            this.páratlanSzámokÖsszegeToolStripMenuItem,
            this.sorokbanLévőElemekÖsszegeToolStripMenuItem,
            this.oszlopokbanLévőElemekÖsszegétToolStripMenuItem});
            this.müveletekToolStripMenuItem.Name = "müveletekToolStripMenuItem";
            this.müveletekToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.müveletekToolStripMenuItem.Text = "Müveletek";
            // 
            // transzponálásToolStripMenuItem
            // 
            this.transzponálásToolStripMenuItem.Name = "transzponálásToolStripMenuItem";
            this.transzponálásToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.transzponálásToolStripMenuItem.Text = "Transzponálás";
            // 
            // páratlanSzámokÖsszegeToolStripMenuItem
            // 
            this.páratlanSzámokÖsszegeToolStripMenuItem.Name = "páratlanSzámokÖsszegeToolStripMenuItem";
            this.páratlanSzámokÖsszegeToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.páratlanSzámokÖsszegeToolStripMenuItem.Text = "Páratlan számok összege";
            // 
            // sorokbanLévőElemekÖsszegeToolStripMenuItem
            // 
            this.sorokbanLévőElemekÖsszegeToolStripMenuItem.Name = "sorokbanLévőElemekÖsszegeToolStripMenuItem";
            this.sorokbanLévőElemekÖsszegeToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.sorokbanLévőElemekÖsszegeToolStripMenuItem.Text = "Sorokban lévő elemek összege";
            this.sorokbanLévőElemekÖsszegeToolStripMenuItem.Click += new System.EventHandler(this.sorokbanLévőElemekÖsszegeToolStripMenuItem_Click);
            // 
            // oszlopokbanLévőElemekÖsszegétToolStripMenuItem
            // 
            this.oszlopokbanLévőElemekÖsszegétToolStripMenuItem.Name = "oszlopokbanLévőElemekÖsszegétToolStripMenuItem";
            this.oszlopokbanLévőElemekÖsszegétToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.oszlopokbanLévőElemekÖsszegétToolStripMenuItem.Text = "Oszlopokban lévő elemek összegét";
            // 
            // lblParatlanOsszeg
            // 
            this.lblParatlanOsszeg.AutoSize = true;
            this.lblParatlanOsszeg.Location = new System.Drawing.Point(353, 65);
            this.lblParatlanOsszeg.Name = "lblParatlanOsszeg";
            this.lblParatlanOsszeg.Size = new System.Drawing.Size(131, 13);
            this.lblParatlanOsszeg.TabIndex = 3;
            this.lblParatlanOsszeg.Text = "Páratlan elemek összege: ";
            // 
            // lblSorEgyOsszeg
            // 
            this.lblSorEgyOsszeg.AutoSize = true;
            this.lblSorEgyOsszeg.Location = new System.Drawing.Point(353, 226);
            this.lblSorEgyOsszeg.Name = "lblSorEgyOsszeg";
            this.lblSorEgyOsszeg.Size = new System.Drawing.Size(36, 13);
            this.lblSorEgyOsszeg.TabIndex = 4;
            this.lblSorEgyOsszeg.Text = "1. sor:";
            // 
            // lblSorHaromOsszeg
            // 
            this.lblSorHaromOsszeg.AutoSize = true;
            this.lblSorHaromOsszeg.Location = new System.Drawing.Point(353, 290);
            this.lblSorHaromOsszeg.Name = "lblSorHaromOsszeg";
            this.lblSorHaromOsszeg.Size = new System.Drawing.Size(36, 13);
            this.lblSorHaromOsszeg.TabIndex = 6;
            this.lblSorHaromOsszeg.Text = "3. sor:";
            // 
            // lblOszlopEgyOsszeg
            // 
            this.lblOszlopEgyOsszeg.AutoSize = true;
            this.lblOszlopEgyOsszeg.Location = new System.Drawing.Point(555, 229);
            this.lblOszlopEgyOsszeg.Name = "lblOszlopEgyOsszeg";
            this.lblOszlopEgyOsszeg.Size = new System.Drawing.Size(52, 13);
            this.lblOszlopEgyOsszeg.TabIndex = 7;
            this.lblOszlopEgyOsszeg.Text = "1. oszlop:";
            // 
            // lblOszlopKettoOsszeg
            // 
            this.lblOszlopKettoOsszeg.AutoSize = true;
            this.lblOszlopKettoOsszeg.Location = new System.Drawing.Point(555, 261);
            this.lblOszlopKettoOsszeg.Name = "lblOszlopKettoOsszeg";
            this.lblOszlopKettoOsszeg.Size = new System.Drawing.Size(52, 13);
            this.lblOszlopKettoOsszeg.TabIndex = 8;
            this.lblOszlopKettoOsszeg.Text = "2. oszlop:";
            // 
            // lblOszlopHaromOsszeg
            // 
            this.lblOszlopHaromOsszeg.AutoSize = true;
            this.lblOszlopHaromOsszeg.Location = new System.Drawing.Point(555, 290);
            this.lblOszlopHaromOsszeg.Name = "lblOszlopHaromOsszeg";
            this.lblOszlopHaromOsszeg.Size = new System.Drawing.Size(52, 13);
            this.lblOszlopHaromOsszeg.TabIndex = 9;
            this.lblOszlopHaromOsszeg.Text = "3. oszlop:";
            // 
            // lblSorKettoOsszeg
            // 
            this.lblSorKettoOsszeg.AutoSize = true;
            this.lblSorKettoOsszeg.Location = new System.Drawing.Point(353, 260);
            this.lblSorKettoOsszeg.Name = "lblSorKettoOsszeg";
            this.lblSorKettoOsszeg.Size = new System.Drawing.Size(33, 13);
            this.lblSorKettoOsszeg.TabIndex = 10;
            this.lblSorKettoOsszeg.Text = "2.sor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sorok összege:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(555, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Oszlopok összege:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSorKettoOsszeg);
            this.Controls.Add(this.lblOszlopHaromOsszeg);
            this.Controls.Add(this.lblOszlopKettoOsszeg);
            this.Controls.Add(this.lblOszlopEgyOsszeg);
            this.Controls.Add(this.lblSorHaromOsszeg);
            this.Controls.Add(this.lblSorEgyOsszeg);
            this.Controls.Add(this.lblParatlanOsszeg);
            this.Controls.Add(this.dgvTransz);
            this.Controls.Add(this.dgvEredeti);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEredeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransz)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEredeti;
        private System.Windows.Forms.DataGridView dgvTransz;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müveletekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transzponálásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem páratlanSzámokÖsszegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sorokbanLévőElemekÖsszegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oszlopokbanLévőElemekÖsszegétToolStripMenuItem;
        private System.Windows.Forms.Label lblParatlanOsszeg;
        private System.Windows.Forms.Label lblSorEgyOsszeg;
        private System.Windows.Forms.Label lblSorHaromOsszeg;
        private System.Windows.Forms.Label lblOszlopEgyOsszeg;
        private System.Windows.Forms.Label lblOszlopKettoOsszeg;
        private System.Windows.Forms.Label lblOszlopHaromOsszeg;
        private System.Windows.Forms.Label lblSorKettoOsszeg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
    }
}

