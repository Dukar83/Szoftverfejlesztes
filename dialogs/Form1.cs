using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace dialogs
{
    public partial class Dialogs : Form
    {
        public Dialogs()
        {
            InitializeComponent();
        }

        private void btnMehet_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            lblSzinezos.ForeColor = cd.Color;
            lblSzin.Text = "A választott szin: " + lblSzinezos.ForeColor;
        }

        private void btnMehet2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string text = File.ReadAllText(ofd.FileName, Encoding.UTF8);
            textBoxBe.Text = text;
        }

        private void btnMehetKep_Click(object sender, EventArgs e)
        {
            OpenFileDialog kep = new OpenFileDialog();
            DialogResult kivalasztottKep;
            kivalasztottKep = kep.ShowDialog();

            if (kivalasztottKep==DialogResult.OK)
            {
                pbKep.SizeMode = PictureBoxSizeMode.CenterImage;
                pbKep.Image = new Bitmap(kep.FileName);
            }
        }

        private void btnSzovegMentes_Click(object sender, EventArgs e)
        {
            string mentesText = textBoxBe.Text;
            SaveFileDialog sfd = new SaveFileDialog();
            if (DialogResult.OK == sfd.ShowDialog())
            File.WriteAllText(sfd.FileName, mentesText);
        }
    }
}
