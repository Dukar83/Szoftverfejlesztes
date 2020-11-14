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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        /*
         Írjon programot, mely bekér két egész számot külön külön egy TabControl egyik lapján. Majd kiszámolja a két szám számtani közepét, amit kiír egy másik lapra, aminek a címkéje legyen: eredmények. 

        A bekéréskor ügyeljen a kivételkezelésre! A programból való kilépéskor kérdezzen rá, hogy biztos ki akar-e lépni a felhasználó, és a válasznak megfelelően járjon el.
         */

        private void tbxA_Leave(object sender, EventArgs e)
        {
        }

        private void Ellenoriz(object sender, EventArgs e)
        {
            //Ellenörző metódus
            if (true)
            {
                // Ha jó, akkor tovább léptet
            }
            else
            {
                // Ha nem, akkor vissza adja a fókuszt hibaüzenettel


            }
        }
    }
}
