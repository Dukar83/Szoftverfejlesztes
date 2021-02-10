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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void termékekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TermekekForm frmTermekek = new TermekekForm();
            frmTermekek.ShowDialog();
        }

        private void mennyiségiEgységekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mek frmMek = new Mek();
            frmMek.Show();
        }

        private void szállitókToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SzallitokForm frmSzallitok = new SzallitokForm();
            frmSzallitok.Show();
        }
    }
}
