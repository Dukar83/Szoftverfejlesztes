
namespace Dolgozat2021Feb10
{
    partial class Első
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
            System.Windows.Forms.Label szallitas_napjaLabel;
            System.Windows.Forms.Label iD_TetelsorokLabel2;
            System.Windows.Forms.Label termekIDLabel2;
            System.Windows.Forms.Label mennyisegLabel2;
            System.Windows.Forms.Label mennyisegi_egysegLabel2;
            this.gyartouzemDataSet1 = new Dolgozat2021Feb10.GyartouzemDataSet1();
            this.fejlecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fejlecTableAdapter = new Dolgozat2021Feb10.GyartouzemDataSet1TableAdapters.FejlecTableAdapter();
            this.tableAdapterManager = new Dolgozat2021Feb10.GyartouzemDataSet1TableAdapters.TableAdapterManager();
            this.tetelsorokTableAdapter = new Dolgozat2021Feb10.GyartouzemDataSet1TableAdapters.TetelsorokTableAdapter();
            this.szallitas_napjaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tetelsorokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tetelsorokBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iD_TetelsorokTextBox2 = new System.Windows.Forms.TextBox();
            this.termekIDTextBox2 = new System.Windows.Forms.TextBox();
            this.mennyisegTextBox2 = new System.Windows.Forms.TextBox();
            this.mennyisegi_egysegTextBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            szallitas_napjaLabel = new System.Windows.Forms.Label();
            iD_TetelsorokLabel2 = new System.Windows.Forms.Label();
            termekIDLabel2 = new System.Windows.Forms.Label();
            mennyisegLabel2 = new System.Windows.Forms.Label();
            mennyisegi_egysegLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gyartouzemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fejlecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetelsorokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetelsorokBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // szallitas_napjaLabel
            // 
            szallitas_napjaLabel.AutoSize = true;
            szallitas_napjaLabel.Location = new System.Drawing.Point(12, 20);
            szallitas_napjaLabel.Name = "szallitas_napjaLabel";
            szallitas_napjaLabel.Size = new System.Drawing.Size(77, 13);
            szallitas_napjaLabel.TabIndex = 1;
            szallitas_napjaLabel.Text = "Szallitas napja:";
            // 
            // iD_TetelsorokLabel2
            // 
            iD_TetelsorokLabel2.AutoSize = true;
            iD_TetelsorokLabel2.Location = new System.Drawing.Point(45, 105);
            iD_TetelsorokLabel2.Name = "iD_TetelsorokLabel2";
            iD_TetelsorokLabel2.Size = new System.Drawing.Size(74, 13);
            iD_TetelsorokLabel2.TabIndex = 24;
            iD_TetelsorokLabel2.Text = "ID Tetelsorok:";
            // 
            // termekIDLabel2
            // 
            termekIDLabel2.AutoSize = true;
            termekIDLabel2.Location = new System.Drawing.Point(45, 131);
            termekIDLabel2.Name = "termekIDLabel2";
            termekIDLabel2.Size = new System.Drawing.Size(60, 13);
            termekIDLabel2.TabIndex = 26;
            termekIDLabel2.Text = "Termek ID:";
            // 
            // mennyisegLabel2
            // 
            mennyisegLabel2.AutoSize = true;
            mennyisegLabel2.Location = new System.Drawing.Point(45, 157);
            mennyisegLabel2.Name = "mennyisegLabel2";
            mennyisegLabel2.Size = new System.Drawing.Size(61, 13);
            mennyisegLabel2.TabIndex = 28;
            mennyisegLabel2.Text = "Mennyiseg:";
            // 
            // mennyisegi_egysegLabel2
            // 
            mennyisegi_egysegLabel2.AutoSize = true;
            mennyisegi_egysegLabel2.Location = new System.Drawing.Point(45, 183);
            mennyisegi_egysegLabel2.Name = "mennyisegi_egysegLabel2";
            mennyisegi_egysegLabel2.Size = new System.Drawing.Size(100, 13);
            mennyisegi_egysegLabel2.TabIndex = 30;
            mennyisegi_egysegLabel2.Text = "Mennyisegi egyseg:";
            // 
            // gyartouzemDataSet1
            // 
            this.gyartouzemDataSet1.DataSetName = "GyartouzemDataSet1";
            this.gyartouzemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fejlecBindingSource
            // 
            this.fejlecBindingSource.DataMember = "Fejlec";
            this.fejlecBindingSource.DataSource = this.gyartouzemDataSet1;
            // 
            // fejlecTableAdapter
            // 
            this.fejlecTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FejlecTableAdapter = this.fejlecTableAdapter;
            this.tableAdapterManager.TetelsorokTableAdapter = this.tetelsorokTableAdapter;
            this.tableAdapterManager.UpdateOrder = Dolgozat2021Feb10.GyartouzemDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tetelsorokTableAdapter
            // 
            this.tetelsorokTableAdapter.ClearBeforeFill = true;
            // 
            // szallitas_napjaDateTimePicker
            // 
            this.szallitas_napjaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.fejlecBindingSource, "Szallitas napja", true));
            this.szallitas_napjaDateTimePicker.Location = new System.Drawing.Point(95, 16);
            this.szallitas_napjaDateTimePicker.Name = "szallitas_napjaDateTimePicker";
            this.szallitas_napjaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.szallitas_napjaDateTimePicker.TabIndex = 2;
            // 
            // tetelsorokBindingSource
            // 
            this.tetelsorokBindingSource.DataMember = "Tetelsorok";
            this.tetelsorokBindingSource.DataSource = this.gyartouzemDataSet1;
            // 
            // tetelsorokBindingSource1
            // 
            this.tetelsorokBindingSource1.DataMember = "FK_Tetelsorok_Fejlec_Megrendeles szama";
            this.tetelsorokBindingSource1.DataSource = this.fejlecBindingSource;
            this.tetelsorokBindingSource1.CurrentChanged += new System.EventHandler(this.tetelsorokBindingSource1_CurrentChanged);
            // 
            // iD_TetelsorokTextBox2
            // 
            this.iD_TetelsorokTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tetelsorokBindingSource, "ID_Tetelsorok", true));
            this.iD_TetelsorokTextBox2.Location = new System.Drawing.Point(151, 102);
            this.iD_TetelsorokTextBox2.Name = "iD_TetelsorokTextBox2";
            this.iD_TetelsorokTextBox2.Size = new System.Drawing.Size(100, 20);
            this.iD_TetelsorokTextBox2.TabIndex = 25;
            // 
            // termekIDTextBox2
            // 
            this.termekIDTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tetelsorokBindingSource, "TermekID", true));
            this.termekIDTextBox2.Location = new System.Drawing.Point(151, 128);
            this.termekIDTextBox2.Name = "termekIDTextBox2";
            this.termekIDTextBox2.Size = new System.Drawing.Size(100, 20);
            this.termekIDTextBox2.TabIndex = 27;
            // 
            // mennyisegTextBox2
            // 
            this.mennyisegTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tetelsorokBindingSource, "Mennyiseg", true));
            this.mennyisegTextBox2.Location = new System.Drawing.Point(151, 154);
            this.mennyisegTextBox2.Name = "mennyisegTextBox2";
            this.mennyisegTextBox2.Size = new System.Drawing.Size(100, 20);
            this.mennyisegTextBox2.TabIndex = 29;
            // 
            // mennyisegi_egysegTextBox2
            // 
            this.mennyisegi_egysegTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tetelsorokBindingSource, "Mennyisegi egyseg", true));
            this.mennyisegi_egysegTextBox2.Location = new System.Drawing.Point(151, 180);
            this.mennyisegi_egysegTextBox2.Name = "mennyisegi_egysegTextBox2";
            this.mennyisegi_egysegTextBox2.Size = new System.Drawing.Size(100, 20);
            this.mennyisegi_egysegTextBox2.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(61, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Másik form:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "klikkelj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Első
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_TetelsorokLabel2);
            this.Controls.Add(this.iD_TetelsorokTextBox2);
            this.Controls.Add(termekIDLabel2);
            this.Controls.Add(this.termekIDTextBox2);
            this.Controls.Add(mennyisegLabel2);
            this.Controls.Add(this.mennyisegTextBox2);
            this.Controls.Add(mennyisegi_egysegLabel2);
            this.Controls.Add(this.mennyisegi_egysegTextBox2);
            this.Controls.Add(szallitas_napjaLabel);
            this.Controls.Add(this.szallitas_napjaDateTimePicker);
            this.Name = "Első";
            this.Text = "Áttekintő form";
            this.Load += new System.EventHandler(this.Első_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gyartouzemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fejlecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetelsorokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetelsorokBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GyartouzemDataSet1 gyartouzemDataSet1;
        private System.Windows.Forms.BindingSource fejlecBindingSource;
        private GyartouzemDataSet1TableAdapters.FejlecTableAdapter fejlecTableAdapter;
        private GyartouzemDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private GyartouzemDataSet1TableAdapters.TetelsorokTableAdapter tetelsorokTableAdapter;
        private System.Windows.Forms.DateTimePicker szallitas_napjaDateTimePicker;
        private System.Windows.Forms.BindingSource tetelsorokBindingSource;
        private System.Windows.Forms.BindingSource tetelsorokBindingSource1;
        private System.Windows.Forms.TextBox iD_TetelsorokTextBox2;
        private System.Windows.Forms.TextBox termekIDTextBox2;
        private System.Windows.Forms.TextBox mennyisegTextBox2;
        private System.Windows.Forms.TextBox mennyisegi_egysegTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

