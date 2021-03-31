using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace utnyilvantarto_kapcsolattal
{
    public partial class FormRogzit : Form
    {
        private int UserID;
        private MySqlConnection conn;
        public FormRogzit(int ID)
        {
            InitializeComponent();
            mysqlkapcsolodas();
            lblID.Text += ID;
            UserID = ID;
        }
        
        private void btnRogzit_Click(object sender, EventArgs e)
        {
            if ((tbxHonnan.Text !="") && (tbxHova.Text != "") && (nudKm.Value != 0))
            {
                using (MySqlCommand insert = new MySqlCommand($"INSERT INTO `utak`(`ID_user`, `Datum`, `Honnan`, `Hova`, `km`) VALUES(@UserID, @dtDatum, @tbxHonnan, @tbxHova, @nudKm )", conn))
                {
                    insert.Parameters.Add("@UserID", MySqlDbType.Int32).Value = UserID;
                    insert.Parameters.Add("@dtDatum", MySqlDbType.Date).Value = dtDatum.Value.Date;
                    insert.Parameters.Add("@tbxHonnan", MySqlDbType.String).Value = tbxHonnan.Text;
                    insert.Parameters.Add("@tbxHova", MySqlDbType.String).Value = tbxHova.Text;
                    insert.Parameters.Add("@nudKm", MySqlDbType.Int32).Value = nudKm.Value;

                    insert.ExecuteNonQuery();
                    MessageBox.Show("Bevitel megtörtént!");
                }
            }
        }

        private void mysqlkapcsolodas()
        {
            MySqlConnectionStringBuilder db = new MySqlConnectionStringBuilder();
            db.Server = "localhost";
            db.Database = "utnyilvantartas";
            db.UserID = "root";
            db.Password = "";

            conn = new MySqlConnection(db.ToString());
            conn.Open();
        }

        private void btnSzures_Click(object sender, EventArgs e)
        {
            if ((tbxHonnanSzures.Text != "") && (tbxHovaSzures.Text != ""))
            {

                using (MySqlCommand olvas = new MySqlCommand($"SELECT `Datum`, `Honnan`, `Hova`, `km` FROM `utak` WHERE `ID_user` = @UserID AND `Honnan` = @tbxHonnan AND `Hova` = @tbxHova", conn))
                {
                    olvas.Parameters.Add("@UserID", MySqlDbType.Int32).Value = UserID;
                    olvas.Parameters.Add("@tbxHonnan", MySqlDbType.String).Value = tbxHonnanSzures.Text;
                    olvas.Parameters.Add("@tbxHova", MySqlDbType.String).Value = tbxHovaSzures.Text;

                    try
                    {
                        // datatable létrehozása
                        DataTable kimutat = new DataTable();
                        // readert inditunk, az olvas execture reader átvétele
                        MySqlDataReader dr = olvas.ExecuteReader();
                        // dr betöltése
                        kimutat.Load(dr);
                        // dr lezárása
                        dr.Close();
                        // data grid view source-ba kimutat data table összekötése
                        dgvKimutat.DataSource = kimutat;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }
    }
}
