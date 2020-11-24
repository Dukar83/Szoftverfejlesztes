
namespace Modális
{
    partial class Modalis
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
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Józsa János",
            "uj12",
            "1956.12.23"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Window, null);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "Kiss Gergő",
            "fg12",
            "1956.11.10"}, -1);
            this.ltvAdatok = new System.Windows.Forms.ListView();
            this.btnBevitel = new System.Windows.Forms.Button();
            this.btnModositas = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            this.btnBeolvas = new System.Windows.Forms.Button();
            this.btnMentes = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.chNev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAzonosito = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSzulDatum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // ltvAdatok
            // 
            this.ltvAdatok.BackColor = System.Drawing.Color.White;
            this.ltvAdatok.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNev,
            this.chAzonosito,
            this.chSzulDatum});
            this.ltvAdatok.GridLines = true;
            this.ltvAdatok.HideSelection = false;
            listViewItem7.StateImageIndex = 0;
            this.ltvAdatok.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8});
            this.ltvAdatok.Location = new System.Drawing.Point(12, 12);
            this.ltvAdatok.Name = "ltvAdatok";
            this.ltvAdatok.Size = new System.Drawing.Size(415, 315);
            this.ltvAdatok.TabIndex = 6;
            this.ltvAdatok.UseCompatibleStateImageBehavior = false;
            this.ltvAdatok.View = System.Windows.Forms.View.Details;
            // 
            // btnBevitel
            // 
            this.btnBevitel.Location = new System.Drawing.Point(437, 12);
            this.btnBevitel.Name = "btnBevitel";
            this.btnBevitel.Size = new System.Drawing.Size(96, 34);
            this.btnBevitel.TabIndex = 7;
            this.btnBevitel.Text = "Felvitel";
            this.btnBevitel.UseVisualStyleBackColor = true;
            this.btnBevitel.Click += new System.EventHandler(this.btnBevitel_Click);
            // 
            // btnModositas
            // 
            this.btnModositas.Location = new System.Drawing.Point(437, 82);
            this.btnModositas.Name = "btnModositas";
            this.btnModositas.Size = new System.Drawing.Size(96, 34);
            this.btnModositas.TabIndex = 8;
            this.btnModositas.Text = "Módositás";
            this.btnModositas.UseVisualStyleBackColor = true;
            this.btnModositas.Click += new System.EventHandler(this.btnModositas_Click);
            // 
            // btnTorles
            // 
            this.btnTorles.Location = new System.Drawing.Point(437, 152);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(96, 34);
            this.btnTorles.TabIndex = 9;
            this.btnTorles.Text = "Törlés";
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Click += new System.EventHandler(this.btnTorles_Click);
            // 
            // btnBeolvas
            // 
            this.btnBeolvas.Location = new System.Drawing.Point(437, 222);
            this.btnBeolvas.Name = "btnBeolvas";
            this.btnBeolvas.Size = new System.Drawing.Size(96, 34);
            this.btnBeolvas.TabIndex = 10;
            this.btnBeolvas.Text = "Beolvasás";
            this.btnBeolvas.UseVisualStyleBackColor = true;
            this.btnBeolvas.Click += new System.EventHandler(this.btnBeolvas_Click);
            // 
            // btnMentes
            // 
            this.btnMentes.Location = new System.Drawing.Point(433, 292);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(96, 34);
            this.btnMentes.TabIndex = 11;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // chNev
            // 
            this.chNev.Text = "Név";
            this.chNev.Width = 87;
            // 
            // chAzonosito
            // 
            this.chAzonosito.Text = "Azonositó";
            this.chAzonosito.Width = 89;
            // 
            // chSzulDatum
            // 
            this.chSzulDatum.Text = "Születési Dátum";
            this.chSzulDatum.Width = 114;
            // 
            // Modalis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.btnBeolvas);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.btnModositas);
            this.Controls.Add(this.btnBevitel);
            this.Controls.Add(this.ltvAdatok);
            this.Name = "Modalis";
            this.Text = "Modális";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Modalis_FormClosing);
            this.Load += new System.EventHandler(this.Modalis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView ltvAdatok;
        private System.Windows.Forms.Button btnBevitel;
        private System.Windows.Forms.Button btnModositas;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.Button btnBeolvas;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ColumnHeader chNev;
        private System.Windows.Forms.ColumnHeader chAzonosito;
        private System.Windows.Forms.ColumnHeader chSzulDatum;
    }
}

