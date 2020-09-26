using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szinezős
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBarNegyzet_Scroll(object sender, ScrollEventArgs e)
        {
            labelNegyzet.Height = hScrollBarNegyzet.Value;
            labelNegyzet.Width = hScrollBarNegyzet.Value;
        }

        private void hScrollBarPiros_ValueChanged(object sender, EventArgs e)
        {
            labelNegyzet.BackColor = Color.FromArgb(hScrollBarPiros.Value, hScrollBarZold.Value, hScrollBarKek.Value);
        }

        private void hScrollBarZold_ValueChanged(object sender, EventArgs e)
        {
            labelNegyzet.BackColor = Color.FromArgb(hScrollBarPiros.Value, hScrollBarZold.Value, hScrollBarKek.Value);
        }

        private void hScrollBarKek_ValueChanged(object sender, EventArgs e)
        {
            labelNegyzet.BackColor = Color.FromArgb(hScrollBarPiros.Value, hScrollBarZold.Value, hScrollBarKek.Value);
        }
    }
}
