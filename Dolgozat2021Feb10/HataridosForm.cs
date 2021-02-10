using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dolgozat2021Feb10
{
    public partial class Hataridos : Form
    {
        public Hataridos()
        {
            InitializeComponent();
        }

        private void fejlecBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fejlecBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gyartouzemDataSet);

        }

        private void fejlecBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.fejlecBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gyartouzemDataSet);

        }

        private void Hataridos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gyartouzemDataSet.Tetelsorok' table. You can move, or remove it, as needed.
            this.tetelsorokTableAdapter.Fill(this.gyartouzemDataSet.Tetelsorok);
            // TODO: This line of code loads data into the 'gyartouzemDataSet.Fejlec' table. You can move, or remove it, as needed.
            this.fejlecTableAdapter.Fill(this.gyartouzemDataSet.Fejlec);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Első át = new Első();
            át.Show();

        }
    }
}
