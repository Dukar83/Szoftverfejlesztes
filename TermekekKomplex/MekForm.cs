using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TermekekKomplex
{
    public partial class Mek : Form
    {
        public Mek()
        {
            InitializeComponent();
        }

        private void mekBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mekBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mekDataSet);

        }

        private void Mek_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mekDataSet.mek' table. You can move, or remove it, as needed.
            this.mekTableAdapter.Fill(this.mekDataSet.mek);

        }
    }
}
