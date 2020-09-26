using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mozgatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly int meretezo = 5;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnMeretNovel_Click(object sender, EventArgs e)
        {
            Height = Width += 20;
        }

        private void btnMeretCsokkent_Click(object sender, EventArgs e)
        {
            Height = Width -= 20;
        }

        private void btnAtlathatoNovel_Click(object sender, EventArgs e)
        {
            Opacity += 0.1;
        }

        private void btnAtlathatoCsokkent_Click(object sender, EventArgs e)
        {
            Opacity -= 0.1;
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            Top = 0;
            btnUp.Visible = false;
            btnBot.Visible = true;
        }

        private void btnMaxLeft_Click(object sender, EventArgs e)
        {
            Left = 0;
        }

        private void btnBot_Click(object sender, EventArgs e)
        {
            Top = Screen.PrimaryScreen.Bounds.Height - Height;
            btnUp.Visible = true;
            btnBot.Visible = false;
        }

        private void btnMaxRight_Click(object sender, EventArgs e)
        {
            Left = Screen.PrimaryScreen.Bounds.Width - Width;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (Top - meretezo > 0)
            {
                Top -= meretezo;
            }
            
        }

        private void btnDown_Click(object sender, EventArgs e) 
        {
            if (Top + meretezo < Height) //ez túl megy valami miatt de csak ez
            {
                Top += meretezo;
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (Left - meretezo > 0)
            {
                Left -= meretezo;
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (Left + meretezo < Width)
            {
                Left += meretezo;
            }
        }

        // fel le balra jobbra aztán ne lehessen túl scrollozni




    }
}
