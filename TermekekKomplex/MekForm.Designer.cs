
namespace TermekekKomplex
{
    partial class Mek
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
            System.Windows.Forms.Label id_meLabel;
            System.Windows.Forms.Label kodLabel;
            System.Windows.Forms.Label leirasLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mek));
            this.mekDataSet = new TermekekKomplex.MekDataSet();
            this.mekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mekTableAdapter = new TermekekKomplex.MekDataSetTableAdapters.mekTableAdapter();
            this.tableAdapterManager = new TermekekKomplex.MekDataSetTableAdapters.TableAdapterManager();
            this.mekBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.mekBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_meTextBox = new System.Windows.Forms.TextBox();
            this.kodTextBox = new System.Windows.Forms.TextBox();
            this.leirasTextBox = new System.Windows.Forms.TextBox();
            id_meLabel = new System.Windows.Forms.Label();
            kodLabel = new System.Windows.Forms.Label();
            leirasLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mekBindingNavigator)).BeginInit();
            this.mekBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_meLabel
            // 
            id_meLabel.AutoSize = true;
            id_meLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            id_meLabel.Location = new System.Drawing.Point(23, 40);
            id_meLabel.Name = "id_meLabel";
            id_meLabel.Size = new System.Drawing.Size(88, 20);
            id_meLabel.TabIndex = 1;
            id_meLabel.Text = "Azonositó:";
            // 
            // kodLabel
            // 
            kodLabel.AutoSize = true;
            kodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            kodLabel.Location = new System.Drawing.Point(50, 66);
            kodLabel.Name = "kodLabel";
            kodLabel.Size = new System.Drawing.Size(45, 20);
            kodLabel.TabIndex = 3;
            kodLabel.Text = "Jele:";
            // 
            // leirasLabel
            // 
            leirasLabel.AutoSize = true;
            leirasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            leirasLabel.Location = new System.Drawing.Point(41, 92);
            leirasLabel.Name = "leirasLabel";
            leirasLabel.Size = new System.Drawing.Size(61, 20);
            leirasLabel.TabIndex = 5;
            leirasLabel.Text = "Leirás:";
            // 
            // mekDataSet
            // 
            this.mekDataSet.DataSetName = "MekDataSet";
            this.mekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mekBindingSource
            // 
            this.mekBindingSource.DataMember = "mek";
            this.mekBindingSource.DataSource = this.mekDataSet;
            // 
            // mekTableAdapter
            // 
            this.mekTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.mekTableAdapter = this.mekTableAdapter;
            this.tableAdapterManager.UpdateOrder = TermekekKomplex.MekDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mekBindingNavigator
            // 
            this.mekBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mekBindingNavigator.BindingSource = this.mekBindingSource;
            this.mekBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mekBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mekBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mekBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.mekBindingNavigatorSaveItem});
            this.mekBindingNavigator.Location = new System.Drawing.Point(0, 180);
            this.mekBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mekBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mekBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mekBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mekBindingNavigator.Name = "mekBindingNavigator";
            this.mekBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mekBindingNavigator.Size = new System.Drawing.Size(377, 25);
            this.mekBindingNavigator.TabIndex = 0;
            this.mekBindingNavigator.Text = "bindingNavigator1";
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
            // mekBindingNavigatorSaveItem
            // 
            this.mekBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mekBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mekBindingNavigatorSaveItem.Image")));
            this.mekBindingNavigatorSaveItem.Name = "mekBindingNavigatorSaveItem";
            this.mekBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.mekBindingNavigatorSaveItem.Text = "Save Data";
            this.mekBindingNavigatorSaveItem.Click += new System.EventHandler(this.mekBindingNavigatorSaveItem_Click);
            // 
            // id_meTextBox
            // 
            this.id_meTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mekBindingSource, "Id_me", true));
            this.id_meTextBox.Location = new System.Drawing.Point(117, 42);
            this.id_meTextBox.Name = "id_meTextBox";
            this.id_meTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_meTextBox.TabIndex = 2;
            // 
            // kodTextBox
            // 
            this.kodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mekBindingSource, "Kod", true));
            this.kodTextBox.Location = new System.Drawing.Point(117, 68);
            this.kodTextBox.Name = "kodTextBox";
            this.kodTextBox.Size = new System.Drawing.Size(100, 20);
            this.kodTextBox.TabIndex = 4;
            // 
            // leirasTextBox
            // 
            this.leirasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mekBindingSource, "Leiras", true));
            this.leirasTextBox.Location = new System.Drawing.Point(117, 94);
            this.leirasTextBox.Name = "leirasTextBox";
            this.leirasTextBox.Size = new System.Drawing.Size(100, 20);
            this.leirasTextBox.TabIndex = 6;
            // 
            // Mek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(377, 205);
            this.Controls.Add(id_meLabel);
            this.Controls.Add(this.id_meTextBox);
            this.Controls.Add(kodLabel);
            this.Controls.Add(this.kodTextBox);
            this.Controls.Add(leirasLabel);
            this.Controls.Add(this.leirasTextBox);
            this.Controls.Add(this.mekBindingNavigator);
            this.Name = "Mek";
            this.Text = "Mennyiségi Egységek";
            this.Load += new System.EventHandler(this.Mek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mekBindingNavigator)).EndInit();
            this.mekBindingNavigator.ResumeLayout(false);
            this.mekBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MekDataSet mekDataSet;
        private System.Windows.Forms.BindingSource mekBindingSource;
        private MekDataSetTableAdapters.mekTableAdapter mekTableAdapter;
        private MekDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mekBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton mekBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_meTextBox;
        private System.Windows.Forms.TextBox kodTextBox;
        private System.Windows.Forms.TextBox leirasTextBox;
    }
}