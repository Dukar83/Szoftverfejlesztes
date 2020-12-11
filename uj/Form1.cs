using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uj
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private bool Joszamok()
        {
            if (nud1.Value > 0 && nud2.Value > 0 && nud3.Value > 0)
            {
                return true;
            }
            else
            {
                //        MessageBox.Show("Három egész számot kértem", "Hiba..", MessageBox.OK , MessageBox.Error); return false;
                return false;
            }

        }

        private void generáljToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void btnTorles_Click(object sender, EventArgs e)
        {
        
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLE_Click(object sender, EventArgs e)
        {



        }

        private void btnSZK_Click(object sender, EventArgs e)
        {
            if (Joszamok())
            {
                listboxEredmeny.Items.Add("Számtani közép: " + (nud1.Value + nud2.Value + nud3.Value) / 3);
            }
        }
    }
}
