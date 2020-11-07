using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egerPozi
{
    public partial class FormFejlec : Form
    {
        public FormFejlec()
        {
            InitializeComponent();
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            lblMeret.Width = lblMeret.Height = hScrollBar1.Value;
        }

        private void hsZold_ValueChanged(object sender, EventArgs e)
        {
            lblMeret.BackColor = Color.FromArgb(hsPiros.Value, hsZold.Value, hsKek.Value);
        }

        private void hsKek_ValueChanged(object sender, EventArgs e)
        {
            lblMeret.BackColor = Color.FromArgb(hsPiros.Value, hsZold.Value, hsKek.Value);
        }

        private void hsPiros_ValueChanged(object sender, EventArgs e)
        {
            lblMeret.BackColor = Color.FromArgb(hsPiros.Value, hsZold.Value, hsKek.Value);
        }
    }
}
