using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modális
{
    public partial class Modalis : Form
    {
        FormAdat frm = new FormAdat();

        public Modalis()
        {
            InitializeComponent();
            frm.Hide();
        }

        private void btnBeolvas_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == DialogResult.OK)
            {
                ltvAdatok.Items.Clear();
                BinaryReader br = new BinaryReader(File.Open(of.FileName, FileMode.Open));

                try
                {
                    if (File.Exists(of.FileName))
                    {
                        long len1 = br.BaseStream.Length;
                        while (br.BaseStream.Position < len1)
                        {
                            ListViewItem li = new ListViewItem(br.ReadString());
                            li.SubItems.Add(br.ReadString());
                            li.SubItems.Add(br.ReadString());
                        }
                        ltvAdatok.Items.Add(li); /*azt hiszi hogy a li nem létezik pedig 4 sorral feljebb létrehoztam!*/
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hiba a fileban.");
                }
                finally
                {
                    br.Close();
                }

            }

        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog()==DialogResult.OK)
            {
                BinaryReader br = new BinaryReader(File.Open(sfd.FileName, FileMode.Create));
                try
                {
                    for (int i = 0; i < ltvAdatok.Items.Count; i++)
                    {
                        br.Write(ltvAdatok.Items[i].Text); /*write nem megy, hiába van a using IO*/
                        br.Write(ltvAdatok.Items[i].SubItems[1]. Text);
                        br.Write(ltvAdatok.Items[i].SubItems[2].Text);
                    }
                    br.Flush();
                }
                catch (Exception)
                {
                    MessageBox.Show("Hiba a mentésben.");
                }
                finally
                {
                    br.Close(); 
                }
            }


        }

        private void Modalis_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBevitel_Click(object sender, EventArgs e)
        {
            frm.ShowDialog();
            if (frm.getNev() != "")
            {
                ListViewItem lvi;
                lvi = ltvAdatok.Items.Add(frm.getNev());
                lvi.SubItems.Add(frm.getAzon());
                lvi.SubItems.Add(frm.getSzulDat().ToString());
            }
        }

        private void Modalis_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztosan kilép?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) e.Cancel = true;
        }

        private void btnModositas_Click(object sender, EventArgs e)
        {
            //Ellenőrizzük, hogy van-e kijelölt elem
            if (ltvAdatok.SelectedItems.Count>0)
            {
                //Adat form feltöltése
                frm.setNev(ltvAdatok.SelectedItems[0].Text);
                frm.setAzon(ltvAdatok.SelectedItems[0].SubItems[1].Text);
                frm.setSzulDatum(Convert.ToDateTime(ltvAdatok.SelectedItems[0].SubItems[2].Text));

                //Megjelenitjük és az eredményt visszairjuk
                frm.ShowDialog();
                if (frm.getNev() != "")
                {
                    ltvAdatok.SelectedItems[0].Text = frm.getNev();
                    ltvAdatok.SelectedItems[1].SubItems[1].Text = frm.getAzon();
                    ltvAdatok.SelectedItems[0].SubItems[2].Text = frm.getSzulDat().ToString();
                }
            }
        }

        private void btnTorles_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ltvAdatok.SelectedItems.Count-1; i++)
            {
                ltvAdatok.Items.Remove(ltvAdatok.SelectedItems[0]);
            }
        }

            /*Készítsen egy programot, melyben egy csapat tagjainak adatait tudjuk nyilvántartani. A tagokról a következőket kell letárolni: 
- nevüket,
- azonosítójukat, 
- születési dátumukat.
 
A főformon a következő funkciók érhetők el:
- Adatbevitel (modális form segítségével)
- Módosítás
- Adattörlés
- Beolvasás fájlból (windows dialógus ablak használatával)
- Mentés fájlba (windows dialógus ablak használatával)

Az adatokat táblázatos formában jelenítsük meg (ListView). 
Tudjunk adatot menteni és visszatölteni file-ból.

modális: modalra állitani viewban amig fokusz ott van nem lehet elhagyni

Show() modális
ShowDialog() nem modális

sartPosition = CenterScreen*/

            /*       string mentesText = textBoxBe.Text;
            SaveFileDialog sfd = new SaveFileDialog();
            if (DialogResult.OK == sfd.Show())
                File.WriteAllText(sfd.FileName, mentesText);*/
            /*
             OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog(); //hibára fut a Show();!!!
            string text = File.ReadAllText(ofd.FileName, Encoding.UTF8);
        //listview-ba belepakol még nincs meg!
             */
        }
}
