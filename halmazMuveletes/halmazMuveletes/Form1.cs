using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace halmazMuveletes
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMehet_Click(object sender, EventArgs e)
        {
            int aELEM = rnd.Next(100);
            int bELEM = rnd.Next(100);

            for (int j = 0; j < numericUpDown1.Value; j++)
            {
                aELEM = rnd.Next(100);
                lbA.Items.Add(aELEM);
                lbAuB.Items.Add(aELEM);
            }

            for (int j = 0; j < numericUpDown2.Value; j++)
            {
                bELEM = rnd.Next(100);
                lbB.Items.Add(bELEM);
                lbAuB.Items.Add(bELEM);
            }

            int nagyobb = 0;
            if (lbA.Items.Count > lbB.Items.Count)
            {
                nagyobb = lbA.Items.Count;
            }   nagyobb = lbB.Items.Count;

            
            

        }
    }
}
