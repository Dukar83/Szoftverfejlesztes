using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabcontrol2
{
    public partial class Tabcontrol2 : Form
    {
        public Tabcontrol2()
        {
            InitializeComponent();
        }
        
        /*
         Írjon programot, mely bekér két egész számot külön külön egy TabControl egyik lapján. Majd kiszámolja a két szám számtani közepét, amit kiír egy másik lapra, aminek a címkéje legyen: eredmények. 

        A bekéréskor ügyeljen a kivételkezelésre! A programból való kilépéskor kérdezzen rá, hogy biztos ki akar-e lépni a felhasználó, és a válasznak megfelelően járjon el.
         */

        private void Ellenoriz()
        {
            //Ellenörző metódus
            if (tbxA.Text=="")
            {
                MessageBox.Show("A üres! Tölsd ki");
                tbxA.Focus();
            }
            else if (tbxB.Text == "")
            {
                MessageBox.Show("B üres! Tölsd ki");
                tbxB.Focus();
            }
            else
            {
                // Ha minden jó akkor számolunk
                lblEredm.Text = "A számtani közép eredménye: " + Convert.ToString(((Convert.ToInt32(tbxA.Text) + Convert.ToInt32(tbxB.Text)) / 2));
            }
        }

        private void btnAdatOK_Click(object sender, EventArgs e)
        {
            Ellenoriz();
        }

        private void Tabcontrol2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kilep = MessageBox.Show("Kilépsz?", "Bezár Ablak?", MessageBoxButtons.YesNo);
            if (kilep == DialogResult.Yes) Application.Exit();
            else e.Cancel = true;
        }
    }
}
