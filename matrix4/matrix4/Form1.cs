using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrix4
{
    public partial class Form1 : Form
    {
        Random random = new Random;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMehet_Click(object sender, EventArgs e)
        {
            int ertek = random.Next(1001);

            for (int i = 0; i < nudSor.Value; i++)
            {
                for (int j = 0; j < nudOszlop.Value; j++)
                {

                }
            }

        }
    }
}
