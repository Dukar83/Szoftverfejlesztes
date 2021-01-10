using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MySQLUsers
{
    
    public partial class MainForm : Form
    {
        // Kapcsolati property
        private MySqlConnection msqlConn;
        private MySqlDataReader msqlDr;

        private string CikkTeljesLista = "CikkTeljesLista";
        private string CikkInsert = "CikkInsert";
        private string CikkUpdate = "CikkUpdate";
        private string CikkDelete = "CikkDelete";

        // Álllapotokat hozunk létre ezzel a listával hogy éppen milyen módban vagyunk
        private enum FormState
        {
            Closed, // Zárva, nincs csatlakozva
            Opened, // Adatbázishoz csatlakozva, de olvasásra nincs megnyitva
            Reading, // Olvasás közben
            EditInsert, // Beszúrás adatainak beirásának közben
            EditUpdate // Rekord szerkesztése közben
        }
        
        // alapból Closed státuszról inditunk
        private FormState formState = FormState.Closed;

        // a gombokon változni fog a szöveg, erre a lehetséges tartalmakat egy-egy string változóba kiszervezzük
        private string insBasic = "Beszúrás";
        private string insEdit = "Szerkesztés vége";
        private string updBasic = "Módositás";
        private string updEdit = "Módositás vége";

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            mySQLConnect();
        }

        private void mySQLConnect()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();

            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "készlet";

            try
            {
                msqlConn = new MySqlConnection(sb.ToString());
                msqlConn.Open();
                MessageBox.Show("Sikeres kapcsolódás!");

                formState = FormState.Opened;
                buttonSwitch(formState);
            }
            catch (MySqlException)
            {
                MessageBox.Show("Kapcsolódás az adatbázishoz nem sikerült!");
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            using (MySqlCommand sqlComm = new MySqlCommand(CikkTeljesLista, msqlConn))
            {
                sqlComm.CommandType = CommandType.StoredProcedure;

                try
                {
                    // Olvasás a táblából
                    msqlDr = sqlComm.ExecuteReader();
                    MessageBox.Show("Az olvasás megkezdődhet!");

                    formState = FormState.Reading;
                    buttonSwitch(formState);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            NextCikk();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            msqlConn.Close();
            MessageBox.Show("Az adatbázis bezárva");

            formState = FormState.Closed;
            buttonSwitch(formState);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (msqlConn != null)
            {
                msqlConn.Close();

                formState = FormState.Closed;
                buttonSwitch(formState);
                
                MessageBox.Show("Az adatbázis bezárva");
            }else
            {
                buttonSwitch(FormState.Closed);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            NextCikk();
        }

        private void NextCikk()
        {
            // A következő rekord olvasása
            msqlDr.Read();
            tbxID.Text = msqlDr[0].ToString().Trim();
            tbxNeve.Text = msqlDr[1].ToString().Trim();
            tbxME.Text = msqlDr[2].ToString().Trim();
            tbxCikkszama.Text = msqlDr[3].ToString().Trim();
            tbxMennyiseg.Text = msqlDr[4].ToString().Trim();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            switch (formState)
            {
                case FormState.Closed:
                    break;
                case FormState.Opened:
                    formState = FormState.EditInsert; // maradok csatlakozásban
                    buttonSwitch(formState); // gombok utóállitása az előző sori formstate változás miatt
                    break;
                case FormState.Reading:
                    msqlDr.Close(); //reading bezárás
                    formState = FormState.EditInsert;
                    buttonSwitch(formState); 
                    break;
                case FormState.EditInsert:
                    InsertCikk(tbxNeve.Text, Convert.ToInt32(tbxME.Text), tbxCikkszama.Text, Convert.ToInt32(tbxMennyiseg.Text)); //IDE pME not found in the collection
                    formState = FormState.Opened; // Beszúrás után átváltunk opened státuszra
                    buttonSwitch(formState); // a gombokat utána állitjuk
                    break;
            }
        }

        private void InsertCikk(string pNeve, int pME, string pCikkszáma, int pMennyiség)
        {
            using (MySqlCommand sqlComm = new MySqlCommand(CikkInsert, msqlConn))
            {
                sqlComm.CommandType = CommandType.StoredProcedure;

                // Paraméterek beállitása - első paraméter
                MySqlParameter p = new MySqlParameter();
                p.ParameterName = "pNeve";
                p.Value = pNeve;
                p.MySqlDbType = MySqlDbType.String;
                sqlComm.Parameters.Add(p);

                // az egyszerübb verzió az addwithvalue - a mardék két paraméter
                sqlComm.Parameters.AddWithValue("ME", pME); // HIBÁRA FUT: PARAMETER pME not found in the collection pedig passzol
                sqlComm.Parameters.AddWithValue("Cikkszáma", pCikkszáma);
                sqlComm.Parameters.AddWithValue("Mennyiség", pMennyiség);

                try
                {
                    // Beszúrás a táblába, itt nonquery! mivel nem lekérdezéses adatbázisparancs
                    sqlComm.ExecuteNonQuery();
                    MessageBox.Show("Az új rekord felvétele sikeres!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            switch (formState)
            {
                case FormState.Opened:
                    formState = FormState.EditUpdate;
                    buttonSwitch(formState);
                    break;
                case FormState.Reading:
                    msqlDr.Close();
                    formState = FormState.EditUpdate;
                    buttonSwitch(formState);
                    break;
                case FormState.EditUpdate:
                    UpdateCikk(Convert.ToInt32(tbxID.Text), tbxNeve.Text, Convert.ToInt32(tbxME.Text), tbxCikkszama.Text, Convert.ToInt32(tbxMennyiseg.Text));
                    formState = FormState.Reading;
                    buttonSwitch(formState);
                    break;
            } 
        }

        private void UpdateCikk(int pID, string pNeve, int pME, string pCikkszáma, int pMennyiség)
        {
            using (MySqlCommand sqlComm = new MySqlCommand(CikkUpdate, msqlConn))
            {
                sqlComm.CommandType = CommandType.StoredProcedure;

                // Paraméterek beállitása
                sqlComm.Parameters.AddWithValue("ID", pID);

               MySqlParameter p = new MySqlParameter();
                p.ParameterName = "Neve";
                p.Value = pNeve;
                p.MySqlDbType = MySqlDbType.String;
                sqlComm.Parameters.Add(p);

                sqlComm.Parameters.AddWithValue("ME", pME);
                sqlComm.Parameters.AddWithValue("Cikkszáma", pCikkszáma);
                sqlComm.Parameters.AddWithValue("Mennyiség", pMennyiség);

                try
                {
                    // Update
                    sqlComm.ExecuteNonQuery();
                    MessageBox.Show("A rekord módositása sikeres!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Ha még reading státusz volt akkor le kell zárnunk először az adatbázis kapcsolatot és a formstate-et átállitani Opened-re
            if (formState == FormState.Reading)
            {
                msqlDr.Close();
                formState = FormState.Opened;
                buttonSwitch(formState);
            }
            DeleteCikk(Convert.ToInt32(tbxID.Text));
        }

        private void DeleteCikk(int ID_cikkek) 
        {
            using (MySqlCommand sqlComm = new MySqlCommand(CikkDelete, msqlConn))
            {
                sqlComm.CommandType = CommandType.StoredProcedure;

                //Paraméterek beállitása
                sqlComm.Parameters.AddWithValue("ID", ID_cikkek);

                try
                {
                    // Törlés a táblában
                    sqlComm.ExecuteNonQuery(); // HIBÁRA FUT: FOREIGN KEY CONSTRAINT FAILS
                    MessageBox.Show("A törlés megtörtént!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        private void buttonSwitch(FormState fs)
        {
            switch (fs)
            {
                case FormState.Closed:
                    btnOpen.Enabled = true;                    btnRead.Enabled = false;                    btnNext.Enabled = false;
                    btnInsert.Enabled = false;                    btnUpdate.Enabled = false;                    btnDelete.Enabled = false;
                    btnClose.Enabled = false;
                    break;
                case FormState.Opened:
                    btnOpen.Enabled = false;                    btnRead.Enabled = true;                    btnNext.Enabled = false;
                    btnInsert.Enabled = true;                    btnUpdate.Enabled = true;                    btnDelete.Enabled = true;
                    btnClose.Enabled = true;

                    // textboxokat false-ra rakjuk open esetén
                    tbxID.Enabled = false;                    tbxNeve.Enabled = false;                    tbxME.Enabled = false;
                    tbxCikkszama.Enabled = false;             tbxMennyiseg.Enabled = false;

                    // gombok feliratát beállitjuk a státusznak megfelelően
                    btnInsert.Text = insBasic;                    btnUpdate.Text = updBasic;
                    break;
                case FormState.Reading:
                    btnOpen.Enabled = false;                    btnRead.Enabled = false;                    btnNext.Enabled = true;
                    btnInsert.Enabled = true;                    btnUpdate.Enabled = true;                    btnDelete.Enabled = true;
                    btnClose.Enabled = true;
                    break;
                case FormState.EditInsert:
                    btnOpen.Enabled = false;                    btnRead.Enabled = false;                    btnNext.Enabled = false;
                    btnInsert.Enabled = true;                    btnUpdate.Enabled = false;                    btnDelete.Enabled = false;
                    btnClose.Enabled = true;

                    // Beviteli mezők elérhetősége
                    tbxNeve.Enabled = true;                    tbxME.Enabled = true;                        tbxCikkszama.Enabled = true; tbxMennyiseg.Enabled = true;


                    // Beszúrásnál ki is üritjük a beviteli mezőket
                    tbxNeve.Text = string.Empty;                     tbxME.Text = string.Empty;
                    tbxCikkszama.Text = string.Empty;                    tbxMennyiseg.Text = string.Empty;


                    btnInsert.Text = insEdit;
                    break;
                case FormState.EditUpdate:
                    btnOpen.Enabled = false;                    btnRead.Enabled = false;                    btnNext.Enabled = false;
                    btnInsert.Enabled = false;                    btnUpdate.Enabled = true;                    btnDelete.Enabled = false;
                    btnClose.Enabled = true;

                    tbxNeve.Enabled = true;                    tbxME.Enabled = true;
                    tbxCikkszama.Enabled = true;                     tbxMennyiseg.Enabled = true;

                    btnUpdate.Text = updEdit;
                    break;
            }      
        }
    }
}
