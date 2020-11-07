using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020.Nov._04.Menukezeles
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void sorokbanLévőElemekÖsszegeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dgvEredeti.Columns.Clear();
            dgvEredeti.Rows.Clear();

            for (int i = 0; i < 3; i++)
            {
             DataGridViewRow row = new DataGridViewRow(),
             row.CreateCells(this.dgvEredeti);

                for (int j = 0; j < 3; j++)
                {
                    row.Cells[j].Value = rnd.Next(10, 21);
                }
                this.dgvEredeti.Rows.Add(row);
            }
            
        }
    }
}
