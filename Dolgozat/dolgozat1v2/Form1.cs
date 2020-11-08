using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrixos
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void AdatokFeltoltm1(int sor, int oszlop) //mind2 matrixot létrehozom ezzel
        {
            matrix1.Columns.Clear();            
            matrix1.Rows.Clear();
        
            for (int i = 0; i < oszlop; i++) //Oszlopok deklarálása
            {
                matrix1.Columns.Add(String.Empty, String.Empty); 
                matrix1.Columns[i].Width = 35;
            }
   
            for (int i = 0; i < sor; i++) //Sorok létrehozása
            {
                object[] intTomb = new object[oszlop]; 
                for (int j = 0; j < oszlop; j++)
                {
                    intTomb[j] = random.Next(-100, 100); //random számot generálunk bele a példa kedvéért -100 és 100 között
                }
                matrix1.Rows.Add(intTomb); 
            }
        }

        private void AdatokFeltoltm2(int sor, int oszlop) //mind2 matrixot létrehozom ezzel
        {
            matrix2.Columns.Clear(); 
            matrix2.Rows.Clear();

            for (int i = 0; i < oszlop; i++) //Oszlopok deklarálása
            {
                matrix2.Columns.Add(String.Empty, String.Empty);
                matrix2.Columns[i].Width = 35;
            }

            for (int i = 0; i < sor; i++) //Sorok létrehozása
            {
                object[] intTomb = new object[oszlop];
                for (int j = 0; j < oszlop; j++)
                {
                    intTomb[j] = random.Next(-100, 100); //random szám a példa kedvéért -100 és 100 között
                }
                matrix2.Rows.Add(intTomb);
            }
        }

        private void btn_Gen_Click(object sender, EventArgs e)
        {
            AdatokFeltoltm1(Convert.ToInt32(nud1.Value), Convert.ToInt32(nud1.Value));
            AdatokFeltoltm2(Convert.ToInt32(nud1.Value), Convert.ToInt32(nud1.Value));
            EredmenyKiir();
        }

        private void EredmenyKiir()
        {
            richTextBox1.ResetText(); // a.) a két mátrix skaláris szorzatát iratjuk ki - EZ JÓ
            if (skalaris() > 0) { richTextBox1.ForeColor = Color.Blue; }
            richTextBox1.ForeColor = Color.Red;
            richTextBox1.AppendText(String.Format("Az elso skalárszorzat eredménye: {0} \n", skalaris()));

           if (skalarisvissza() > 0) { richTextBox1.ForeColor = Color.Blue; } //  // b.) a két mátrix fordított skaláris szorzatát.  - EZ MÉG NEM JÓ
            richTextBox1.ForeColor = Color.Red;
            richTextBox1.AppendText(String.Format("Az elso skalárszorzat eredménye: {0} \n", skalarisvissza()));

            if (skalarAtlo() > 0) { richTextBox1.ForeColor = Color.Blue; } // c.) a két mátrix átlóösszegét és vonja ki egymásból.  - EZ JÓ
            richTextBox1.ForeColor = Color.Red;
            richTextBox1.AppendText(String.Format("A skalár átlószorzat eredménye: {0} \n", skalarAtlo()));

            /*
            if (skalarAtloFelett() > 0) { richTextBox1.ForeColor = Color.Blue; } // d.) az első mátrix két átlója feletti terület számainak összegét.egymásból. - EZ MÉG NEM JÓ
            richTextBox1.ForeColor = Color.Red;
            richTextBox1.AppendText(String.Format("A skalár átlószorzat eredménye: {0} \n", skalarAtloFelett()));
            */
        }

        private int skalaris()//a sima skalár szorzat
        {
            int skalarOsszeg = 0;
            int sor = Convert.ToInt32(nud1.Value);

            for (int i = 0; i < sor; i++)
            {
                for (int j = 0; j < sor; j++)
                {
                    skalarOsszeg += Convert.ToInt32(matrix1[i,j].Value) * Convert.ToInt32(matrix2[i,j].Value); // ezt nem értem miért problémás! azt mondja nem lehet overloadolni
                }
            }
            return skalarOsszeg;
        }

        private int skalarisvissza() //b forditott skalár szorzat
        {
            int skalarOsszeg = 0;
            int sor = Convert.ToInt32(nud1.Value);
            int matrix2sor = sor;
            int matrix2oszlop = sor;

            for (int i = 0; i < sor; i++)
            {
                for (int j = 0; j < sor; j++)
                {
                    skalarOsszeg += Convert.ToInt32(matrix1[i,j].Value) * Convert.ToInt32(matrix2[matrix2sor,matrix2oszlop].Value); //Itt összeomlik
                    matrix2oszlop--;
                }
                matrix2oszlop = sor-1;
                matrix2sor--;
            }
            return skalarOsszeg;
        }

        private int skalarAtlo() //c. a két mátrix átlóösszegét és vonja ki egymásból.
        {
            int skalarOsszeg = 0;
            int sor = Convert.ToInt32(nud1.Value);
            int matrix1AtloOsszeg = 0;
            int matrix2AtloOsszeg = 0;

            for (int i = 0; i < sor; i++)
            {
                for (int j = 0; j < sor; j++)
                {
                    matrix1AtloOsszeg += Convert.ToInt32(matrix1[i, i].Value);
                }
            }

            for (int i = 0; i < sor; i++)
            {
                for (int j = 0; j < sor; j++)
                {
                    matrix2AtloOsszeg += Convert.ToInt32(matrix2[i, i].Value);
                }
            }

            skalarOsszeg = matrix1AtloOsszeg - matrix2AtloOsszeg;
            return skalarOsszeg;
        }

        //  d.) az első mátrix két átlója feletti terület számainak összegét.
        private int skalarAtloFelett() //a két mátrix átlóösszegét és vonja ki egymásból.
        {
            int skalarOsszeg = 0;
            int sor = Convert.ToInt32(nud1.Value);

            for (int i = 1; i < sor; i++)
            {
                skalarOsszeg += Convert.ToInt32(matrix1[i-1, i].Value); //vagy valami hasonló mivel nem futott le nem tudtam letesztelni rendesen
            } 
            return skalarOsszeg;
        }

    }
}