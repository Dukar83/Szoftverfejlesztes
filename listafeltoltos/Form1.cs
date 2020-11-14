using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listafeltoltos
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void generálásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <10 ; i++)
            {
                listBox1.Items.Add(rnd.Next(10, 21));
            }

            int darabszam = 0;
            for (int i = 0; i < listBox1.Items.Count ; i++)
            {
                darabszam++;
            }

            tsElemszam.Text = "Elemszám:" + darabszam.ToString();

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void felvitelToolStripMenuItem_Click(object sender, EventArgs e)
        {

          /* int a = (int)txtFelvitel.Text.ToString();

            if ((int)txtFelvitel.Text >= 10 && (int)txtFelvitel.Text <= 20)
            {
                listBox1.Items.Add(txtFelvitel.Text);
            }
            */
        }
    }
}
