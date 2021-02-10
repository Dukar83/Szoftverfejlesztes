
namespace Dolgozat2021Feb10
{
    partial class Hataridos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hataridos));
            this.gyartouzemDataSet = new Dolgozat2021Feb10.GyartouzemDataSet();
            this.fejlecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fejlecTableAdapter = new Dolgozat2021Feb10.GyartouzemDataSetTableAdapters.FejlecTableAdapter();
            this.tableAdapterManager = new Dolgozat2021Feb10.GyartouzemDataSetTableAdapters.TableAdapterManager();
            this.tetelsorokTableAdapter = new Dolgozat2021Feb10.GyartouzemDataSetTableAdapters.TetelsorokTableAdapter();
            this.fejlecBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fejlecBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fejlecDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tetelsorokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tetelsorokDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gyartouzemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fejlecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fejlecBindingNavigator)).BeginInit();
            this.fejlecBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fejlecDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetelsorokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetelsorokDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gyartouzemDataSet
            // 
            this.gyartouzemDataSet.DataSetName = "GyartouzemDataSet";
            this.gyartouzemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fejlecBindingSource
            // 
            this.fejlecBindingSource.DataMember = "Fejlec";
            this.fejlecBindingSource.DataSource = this.gyartouzemDataSet;
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
            this.tableAdapterManager.UpdateOrder = Dolgozat2021Feb10.GyartouzemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tetelsorokTableAdapter
            // 
            this.tetelsorokTableAdapter.ClearBeforeFill = true;
            // 
            // fejlecBindingNavigator
            // 
            this.fejlecBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fejlecBindingNavigator.BindingSource = this.fejlecBindingSource;
            this.fejlecBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fejlecBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fejlecBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.fejlecBindingNavigatorSaveItem});
            this.fejlecBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.fejlecBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fejlecBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fejlecBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fejlecBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fejlecBindingNavigator.Name = "fejlecBindingNavigator";
            this.fejlecBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fejlecBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.fejlecBindingNavigator.TabIndex = 0;
            this.fejlecBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // fejlecBindingNavigatorSaveItem
            // 
            this.fejlecBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fejlecBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fejlecBindingNavigatorSaveItem.Image")));
            this.fejlecBindingNavigatorSaveItem.Name = "fejlecBindingNavigatorSaveItem";
            this.fejlecBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.fejlecBindingNavigatorSaveItem.Text = "Save Data";
            this.fejlecBindingNavigatorSaveItem.Click += new System.EventHandler(this.fejlecBindingNavigatorSaveItem_Click_1);
            // 
            // fejlecDataGridView
            // 
            this.fejlecDataGridView.AutoGenerateColumns = false;
            this.fejlecDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fejlecDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.fejlecDataGridView.DataSource = this.fejlecBindingSource;
            this.fejlecDataGridView.Location = new System.Drawing.Point(0, 28);
            this.fejlecDataGridView.Name = "fejlecDataGridView";
            this.fejlecDataGridView.Size = new System.Drawing.Size(800, 144);
            this.fejlecDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Fejlec";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Fejlec";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Megrendeles szama";
            this.dataGridViewTextBoxColumn2.HeaderText = "Megrendeles szama";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Rendeles datuma";
            this.dataGridViewTextBoxColumn3.HeaderText = "Rendeles datuma";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Szallitas napja";
            this.dataGridViewTextBoxColumn4.HeaderText = "Szallitas napja";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "VevoID";
            this.dataGridViewTextBoxColumn5.HeaderText = "VevoID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // tetelsorokBindingSource
            // 
            this.tetelsorokBindingSource.DataMember = "Tetelsorok";
            this.tetelsorokBindingSource.DataSource = this.gyartouzemDataSet;
            // 
            // tetelsorokDataGridView
            // 
            this.tetelsorokDataGridView.AutoGenerateColumns = false;
            this.tetelsorokDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tetelsorokDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.tetelsorokDataGridView.DataSource = this.tetelsorokBindingSource;
            this.tetelsorokDataGridView.Location = new System.Drawing.Point(0, 293);
            this.tetelsorokDataGridView.Name = "tetelsorokDataGridView";
            this.tetelsorokDataGridView.Size = new System.Drawing.Size(800, 220);
            this.tetelsorokDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID_Tetelsorok";
            this.dataGridViewTextBoxColumn6.HeaderText = "ID_Tetelsorok";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TermekID";
            this.dataGridViewTextBoxColumn7.HeaderText = "TermekID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Mennyiseg";
            this.dataGridViewTextBoxColumn8.HeaderText = "Mennyiseg";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Mennyisegi egyseg";
            this.dataGridViewTextBoxColumn9.HeaderText = "Mennyisegi egyseg";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "klikkelj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(29, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Másik form:";
            // 
            // Hataridos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tetelsorokDataGridView);
            this.Controls.Add(this.fejlecDataGridView);
            this.Controls.Add(this.fejlecBindingNavigator);
            this.Name = "Hataridos";
            this.Text = "Határidős form";
            this.Load += new System.EventHandler(this.Hataridos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gyartouzemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fejlecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fejlecBindingNavigator)).EndInit();
            this.fejlecBindingNavigator.ResumeLayout(false);
            this.fejlecBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fejlecDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetelsorokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetelsorokDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GyartouzemDataSet gyartouzemDataSet;
        private System.Windows.Forms.BindingSource fejlecBindingSource;
        private GyartouzemDataSetTableAdapters.FejlecTableAdapter fejlecTableAdapter;
        private GyartouzemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator fejlecBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton fejlecBindingNavigatorSaveItem;
        private GyartouzemDataSetTableAdapters.TetelsorokTableAdapter tetelsorokTableAdapter;
        private System.Windows.Forms.DataGridView fejlecDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource tetelsorokBindingSource;
        private System.Windows.Forms.DataGridView tetelsorokDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}