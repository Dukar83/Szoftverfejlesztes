
namespace Utnyilvantartas_hazifeladat
{
    partial class Belepes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPass = new System.Windows.Forms.TextBox();
            this.btnMehet = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.belépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bevitelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kimutatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.usersDS = new Utnyilvantartas_hazifeladat.usersDS();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Utnyilvantartas_hazifeladat.usersDSTableAdapters.usersTableAdapter();
            this.tableAdapterManager = new Utnyilvantartas_hazifeladat.usersDSTableAdapters.TableAdapterManager();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(273, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lépj be!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(172, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jelszó:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(92, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Felhasználónév:";
            // 
            // tbxUsername
            // 
            this.tbxUsername.BackColor = System.Drawing.Color.AliceBlue;
            this.tbxUsername.Location = new System.Drawing.Point(276, 121);
            this.tbxUsername.Multiline = true;
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(100, 20);
            this.tbxUsername.TabIndex = 3;
            this.tbxUsername.TextChanged += new System.EventHandler(this.tbxUsername_TextChanged);
            // 
            // tbxPass
            // 
            this.tbxPass.BackColor = System.Drawing.Color.AliceBlue;
            this.tbxPass.Location = new System.Drawing.Point(276, 186);
            this.tbxPass.Multiline = true;
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.Size = new System.Drawing.Size(100, 20);
            this.tbxPass.TabIndex = 4;
            this.tbxPass.TextChanged += new System.EventHandler(this.tbxUsername_TextChanged);
            // 
            // btnMehet
            // 
            this.btnMehet.Enabled = false;
            this.btnMehet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnMehet.Location = new System.Drawing.Point(414, 137);
            this.btnMehet.Name = "btnMehet";
            this.btnMehet.Size = new System.Drawing.Size(133, 51);
            this.btnMehet.TabIndex = 5;
            this.btnMehet.Text = "Tovább az adatbevitelhez";
            this.btnMehet.UseVisualStyleBackColor = true;
            this.btnMehet.Click += new System.EventHandler(this.btnMehet_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.belépésToolStripMenuItem,
            this.bevitelToolStripMenuItem,
            this.kimutatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // belépésToolStripMenuItem
            // 
            this.belépésToolStripMenuItem.Name = "belépésToolStripMenuItem";
            this.belépésToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.belépésToolStripMenuItem.Text = "Belépés";
            // 
            // bevitelToolStripMenuItem
            // 
            this.bevitelToolStripMenuItem.Name = "bevitelToolStripMenuItem";
            this.bevitelToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.bevitelToolStripMenuItem.Text = "Bevitel";
            // 
            // kimutatToolStripMenuItem
            // 
            this.kimutatToolStripMenuItem.Name = "kimutatToolStripMenuItem";
            this.kimutatToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.kimutatToolStripMenuItem.Text = "Kimutat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(92, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(631, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "2021jan13as videoban 2 óra:33percnél van kapcsoaltkiépités lekérdezések";
            // 
            // usersDS
            // 
            this.usersDS.DataSetName = "usersDS";
            this.usersDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.usersDS;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Utnyilvantartas_hazifeladat.usersDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = this.usersTableAdapter;
            // 
            // Belepes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnMehet);
            this.Controls.Add(this.tbxPass);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Belepes";
            this.Text = "Útnyilvántartó";
            this.Load += new System.EventHandler(this.Utnyilvantartas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxPass;
        private System.Windows.Forms.Button btnMehet;
        private usersDS usersDS;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private usersDSTableAdapters.usersTableAdapter usersTableAdapter;
        private usersDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem belépésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bevitelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kimutatToolStripMenuItem;
        private System.Windows.Forms.Label label4;
    }
}

