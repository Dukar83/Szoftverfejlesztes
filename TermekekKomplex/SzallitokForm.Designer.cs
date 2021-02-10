
namespace TermekekKomplex
{
    partial class SzallitokForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SzallitokForm));
            System.Windows.Forms.Label id_SzallitoLabel;
            System.Windows.Forms.Label nevLabel;
            System.Windows.Forms.Label varosLabel;
            System.Windows.Forms.Label cimLabel;
            System.Windows.Forms.Label iRSZLabel;
            this.szallitokDataSet = new TermekekKomplex.SzallitokDataSet();
            this.szallitokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.szallitokTableAdapter = new TermekekKomplex.SzallitokDataSetTableAdapters.SzallitokTableAdapter();
            this.tableAdapterManager = new TermekekKomplex.SzallitokDataSetTableAdapters.TableAdapterManager();
            this.szallitokBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.szallitokBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_SzallitoTextBox = new System.Windows.Forms.TextBox();
            this.nevTextBox = new System.Windows.Forms.TextBox();
            this.varosTextBox = new System.Windows.Forms.TextBox();
            this.cimTextBox = new System.Windows.Forms.TextBox();
            this.iRSZTextBox = new System.Windows.Forms.TextBox();
            this.szallitokDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id_SzallitoLabel = new System.Windows.Forms.Label();
            nevLabel = new System.Windows.Forms.Label();
            varosLabel = new System.Windows.Forms.Label();
            cimLabel = new System.Windows.Forms.Label();
            iRSZLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.szallitokDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szallitokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szallitokBindingNavigator)).BeginInit();
            this.szallitokBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.szallitokDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // szallitokDataSet
            // 
            this.szallitokDataSet.DataSetName = "SzallitokDataSet";
            this.szallitokDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // szallitokBindingSource
            // 
            this.szallitokBindingSource.DataMember = "Szallitok";
            this.szallitokBindingSource.DataSource = this.szallitokDataSet;
            // 
            // szallitokTableAdapter
            // 
            this.szallitokTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SzallitokTableAdapter = this.szallitokTableAdapter;
            this.tableAdapterManager.UpdateOrder = TermekekKomplex.SzallitokDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // szallitokBindingNavigator
            // 
            this.szallitokBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.szallitokBindingNavigator.BindingSource = this.szallitokBindingSource;
            this.szallitokBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.szallitokBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.szallitokBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.szallitokBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.szallitokBindingNavigatorSaveItem});
            this.szallitokBindingNavigator.Location = new System.Drawing.Point(0, 480);
            this.szallitokBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.szallitokBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.szallitokBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.szallitokBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.szallitokBindingNavigator.Name = "szallitokBindingNavigator";
            this.szallitokBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.szallitokBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.szallitokBindingNavigator.TabIndex = 0;
            this.szallitokBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // szallitokBindingNavigatorSaveItem
            // 
            this.szallitokBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.szallitokBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("szallitokBindingNavigatorSaveItem.Image")));
            this.szallitokBindingNavigatorSaveItem.Name = "szallitokBindingNavigatorSaveItem";
            this.szallitokBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.szallitokBindingNavigatorSaveItem.Text = "Save Data";
            this.szallitokBindingNavigatorSaveItem.Click += new System.EventHandler(this.szallitokBindingNavigatorSaveItem_Click);
            // 
            // id_SzallitoLabel
            // 
            id_SzallitoLabel.AutoSize = true;
            id_SzallitoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            id_SzallitoLabel.Location = new System.Drawing.Point(12, 27);
            id_SzallitoLabel.Name = "id_SzallitoLabel";
            id_SzallitoLabel.Size = new System.Drawing.Size(88, 20);
            id_SzallitoLabel.TabIndex = 1;
            id_SzallitoLabel.Text = "Azonositó:";
            // 
            // id_SzallitoTextBox
            // 
            this.id_SzallitoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.szallitokBindingSource, "Id_Szallito", true));
            this.id_SzallitoTextBox.Location = new System.Drawing.Point(112, 29);
            this.id_SzallitoTextBox.Name = "id_SzallitoTextBox";
            this.id_SzallitoTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_SzallitoTextBox.TabIndex = 2;
            // 
            // nevLabel
            // 
            nevLabel.AutoSize = true;
            nevLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            nevLabel.Location = new System.Drawing.Point(56, 53);
            nevLabel.Name = "nevLabel";
            nevLabel.Size = new System.Drawing.Size(43, 20);
            nevLabel.TabIndex = 3;
            nevLabel.Text = "Név:";
            // 
            // nevTextBox
            // 
            this.nevTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.szallitokBindingSource, "Nev", true));
            this.nevTextBox.Location = new System.Drawing.Point(112, 55);
            this.nevTextBox.Name = "nevTextBox";
            this.nevTextBox.Size = new System.Drawing.Size(100, 20);
            this.nevTextBox.TabIndex = 4;
            // 
            // varosLabel
            // 
            varosLabel.AutoSize = true;
            varosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            varosLabel.Location = new System.Drawing.Point(41, 79);
            varosLabel.Name = "varosLabel";
            varosLabel.Size = new System.Drawing.Size(58, 20);
            varosLabel.TabIndex = 5;
            varosLabel.Text = "Város:";
            // 
            // varosTextBox
            // 
            this.varosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.szallitokBindingSource, "Varos", true));
            this.varosTextBox.Location = new System.Drawing.Point(112, 81);
            this.varosTextBox.Name = "varosTextBox";
            this.varosTextBox.Size = new System.Drawing.Size(100, 20);
            this.varosTextBox.TabIndex = 6;
            // 
            // cimLabel
            // 
            cimLabel.AutoSize = true;
            cimLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            cimLabel.Location = new System.Drawing.Point(55, 105);
            cimLabel.Name = "cimLabel";
            cimLabel.Size = new System.Drawing.Size(44, 20);
            cimLabel.TabIndex = 7;
            cimLabel.Text = "Cim:";
            // 
            // cimTextBox
            // 
            this.cimTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.szallitokBindingSource, "Cim", true));
            this.cimTextBox.Location = new System.Drawing.Point(112, 107);
            this.cimTextBox.Name = "cimTextBox";
            this.cimTextBox.Size = new System.Drawing.Size(100, 20);
            this.cimTextBox.TabIndex = 8;
            // 
            // iRSZLabel
            // 
            iRSZLabel.AutoSize = true;
            iRSZLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            iRSZLabel.Location = new System.Drawing.Point(49, 131);
            iRSZLabel.Name = "iRSZLabel";
            iRSZLabel.Size = new System.Drawing.Size(50, 20);
            iRSZLabel.TabIndex = 9;
            iRSZLabel.Text = "IRSZ:";
            // 
            // iRSZTextBox
            // 
            this.iRSZTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.szallitokBindingSource, "IRSZ", true));
            this.iRSZTextBox.Location = new System.Drawing.Point(112, 133);
            this.iRSZTextBox.Name = "iRSZTextBox";
            this.iRSZTextBox.Size = new System.Drawing.Size(100, 20);
            this.iRSZTextBox.TabIndex = 10;
            // 
            // szallitokDataGridView
            // 
            this.szallitokDataGridView.AutoGenerateColumns = false;
            this.szallitokDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.szallitokDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.szallitokDataGridView.DataSource = this.szallitokBindingSource;
            this.szallitokDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.szallitokDataGridView.Location = new System.Drawing.Point(0, 190);
            this.szallitokDataGridView.Name = "szallitokDataGridView";
            this.szallitokDataGridView.Size = new System.Drawing.Size(800, 290);
            this.szallitokDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Szallito";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Szallito";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nev";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nev";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Varos";
            this.dataGridViewTextBoxColumn3.HeaderText = "Varos";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cim";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cim";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IRSZ";
            this.dataGridViewTextBoxColumn5.HeaderText = "IRSZ";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // SzallitokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.szallitokDataGridView);
            this.Controls.Add(id_SzallitoLabel);
            this.Controls.Add(this.id_SzallitoTextBox);
            this.Controls.Add(nevLabel);
            this.Controls.Add(this.nevTextBox);
            this.Controls.Add(varosLabel);
            this.Controls.Add(this.varosTextBox);
            this.Controls.Add(cimLabel);
            this.Controls.Add(this.cimTextBox);
            this.Controls.Add(iRSZLabel);
            this.Controls.Add(this.iRSZTextBox);
            this.Controls.Add(this.szallitokBindingNavigator);
            this.Name = "SzallitokForm";
            this.Text = "Szallitók";
            this.Load += new System.EventHandler(this.SzallitokForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.szallitokDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szallitokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szallitokBindingNavigator)).EndInit();
            this.szallitokBindingNavigator.ResumeLayout(false);
            this.szallitokBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.szallitokDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SzallitokDataSet szallitokDataSet;
        private System.Windows.Forms.BindingSource szallitokBindingSource;
        private SzallitokDataSetTableAdapters.SzallitokTableAdapter szallitokTableAdapter;
        private SzallitokDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator szallitokBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton szallitokBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_SzallitoTextBox;
        private System.Windows.Forms.TextBox nevTextBox;
        private System.Windows.Forms.TextBox varosTextBox;
        private System.Windows.Forms.TextBox cimTextBox;
        private System.Windows.Forms.TextBox iRSZTextBox;
        private System.Windows.Forms.DataGridView szallitokDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}