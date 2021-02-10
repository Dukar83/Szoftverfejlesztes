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
    public partial class Első : Form
    {
        public Első()
        {
            InitializeComponent();
        }

        private void fejlecBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fejlecBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gyartouzemDataSet1);

        }

        private void Első_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gyartouzemDataSet1.Tetelsorok' table. You can move, or remove it, as needed.
            this.tetelsorokTableAdapter.Fill(this.gyartouzemDataSet1.Tetelsorok);
            // TODO: This line of code loads data into the 'gyartouzemDataSet1.Fejlec' table. You can move, or remove it, as needed.
            this.fejlecTableAdapter.Fill(this.gyartouzemDataSet1.Fejlec);

        }

        private void tetelsorokBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hataridos atmegy = new Hataridos();
            atmegy.Show();
        }
    }
}
