using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
     Írjon programot, mely generál egy 3x3 mátrixot olyan véletlen számokból, melyek 1 és 20 közé esnek. Határozza meg a mátrix transzponáltját, a skalárszorosát és a mátrix legkisebb és legnagyobb értékét is válassza ki.

 Az egyes mátrixokat és a szélsőértékeket külön lapokon jelenítse meg, de csak egy formot használjon.

Magyarázat: A kezdeti állapotban a program generáljon egy kiinduló mátrixot. Figyeljen oda, hogy a véletlen számok a megadott intervallumba essenek. Megjelenítéshez lehet használni a DataGridView egy megfelelően beállított példányát. 

Skalárszor: egy számmal beszoroz minden tagot egy egész számmal, ez is bekérhető legyen.

Dimenzió és szorzó szám bekér
köv lapion legenerál
köv lapon transz
köv lapon skalár
utolsó oldalon legkisebb legnagyobb érték kiiratás

+ 2 gomb legyen lenn az oldal alján
jobbra tovább balra tovább léptet tabok között

felső x-re kattintva megkérdezi hogy tényleg ki akar e lépni az ember*/

namespace Hazifeladat_2020_nov_11
{
    public partial class Hazi2020nov11 : Form
    {
        Random rnd = new Random();
        public int meret = 3;

        public Hazi2020nov11()
        {
            InitializeComponent();
        }

        private void btnMehet_Click(object sender, EventArgs e)
        {
            /*generál egy 3x3 mátrixot olyan véletlen számokból, melyek 1 és 20 közé esnek.*/

            
            int szam;
            dgvMatrix.Rows.Clear();

            for (int i = 0; i < meret; i++)
            {
                DataGridViewRow r = new DataGridViewRow();
                for (int j = 0; j < meret; j++)
                {
                    szam = rnd.Next(1, 21);
                    DataGridViewCell dc = new DataGridViewTextBoxCell();
                    dc.Value = szam;
                    r.Cells.Add(dc);
                }
                dgvMatrix.Rows.Add(r);
            }


        }

        private void button11_Click(object sender, EventArgs e)
        {

            int szam;
            dgvMatrix.Rows.Clear();

            for (int i = 0; i < meret; i++)
            {
                DataGridViewRow r = new DataGridViewRow();
                for (int j = 0; j < meret; j++)
                {
                    szam = rnd.Next(1, 21);
                    DataGridViewCell dc = new DataGridViewTextBoxCell();
                    dc.Value = szam;
                    r.Cells.Add(dc);
                }
                dgvMatrix.Rows.Add(r); //ez hibára fut és nem találom az okát :(
            }

        }
    }

}
