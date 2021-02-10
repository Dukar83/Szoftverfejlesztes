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
    public partial class TermekekForm : Form
    {
        public TermekekForm()
        {
            InitializeComponent();
        }

        private void szallitokBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.szallitokBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.termekekDataSet);

        }

        private void TermekekForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'termekekDataSet.Termekek' table. You can move, or remove it, as needed.
            this.termekekTableAdapter.Fill(this.termekekDataSet.Termekek);
            // TODO: This line of code loads data into the 'termekekDataSet.Szallitok' table. You can move, or remove it, as needed.
            this.szallitokTableAdapter.Fill(this.termekekDataSet.Szallitok);

        }
    }
}
