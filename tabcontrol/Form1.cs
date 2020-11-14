using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabcontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] szoveg = new string[8];

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbxVezNev.Text = "";
            tbxKeresztNev.Text = "";
            tbxVaros.Text = "";
            tbxLakcim.Text = "";
            for (int i = 0; i < 4; i++)
            {
                szoveg[i] = "";
            }
        }

        private void btnMegse_Click(object sender, EventArgs e)
        {
            tbxAdoSzam.Text = "";
            tbxSzemSzam.Text = "";
            tbxJogositvany.Text = "";
            tbxUtlevel.Text = "";
            for (int i = 4; i < 8; i++)
            {
                szoveg[i] = "";
            }
        }

        private void btnOkSza_Click(object sender, EventArgs e)
        {
            szoveg[0] = tbxVezNev.Text;
            szoveg[1] = tbxKeresztNev.Text;
            szoveg[2] = tbxVaros.Text;
            szoveg[3] = tbxLakcim.Text;
        }

        private void btnOkAzon_Click(object sender, EventArgs e)
        {
            szoveg[4] = tbxAdoSzam.Text;
            szoveg[5] = tbxSzemSzam.Text;
            szoveg[6] = tbxJogositvany.Text;
            szoveg[7] = tbxUtlevel.Text;
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < szoveg.Length ; i++)
            {
                lblEredmeny.Text += szoveg[i] + "\n";
            }
        }
    }
}
