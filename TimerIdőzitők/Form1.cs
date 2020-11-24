using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerIdőzitők
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        //Képernyő felbontás
        private int felbX = 800, felbY = 600;

        public Form1()
        {
            InitializeComponent();
        }

        DateTime kezdido = new DateTime();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMehet_Click(object sender, EventArgs e)
        {
            timerEgesz.Enabled = true;
            timerUj.Enabled = true;
            kezdido = DateTime.Now;
        }

        private void timerEgesz_Tick(object sender, EventArgs e)
        {
            timerEgesz.Stop();
            timerUj.Stop();
        }

        private void timerUj_Tick(object sender, EventArgs e)
        {
            Form2 frm = new Form2();

            Label lblEredm = new Label(); 
            lblEredm.Text = DateTime.Now.ToLongTimeString(); /*nem irja ki*/
            
           /* frm.Top = rnd.Next() % felbY;
            frm.Left = rnd.Next() % felbX; ilyen próba volt */

            frm.Show();
        }
    }
}

/*
     Készítsünk alkalmazást, melyben a főformon levő gombra kattintva elindul új ablakok megnyitása.

     Minden új ablakra a következők érvényesek:
     - Az ablakok 5 másodpercenként követik egymást.
     - Mindegyik ablak 10 másodpercig él, aztán megsemmisül.
     - Az egész folyamat 2 percig tart.
      */

/*    Form masodikForm = new Form();
      masodikForm.Show();  csak kisérlet volt igy   lehet  kézzel üres formot létrehozni és megmutatni  */