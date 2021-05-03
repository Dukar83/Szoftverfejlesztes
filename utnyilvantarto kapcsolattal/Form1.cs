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
    public partial class MainForm : Form
    {
        private MySqlConnection conn;
        private int UserID;
        public MainForm()
        {
            InitializeComponent();
            mysqlkapcsolodas();
        }

        private void btnMehet_Click(object sender, EventArgs e)
        {
            FormRogzit rogzit = new FormRogzit(UserID);
            rogzit.Show();
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

        private void tbxUsername_Leave(object sender, EventArgs e)
        {
            if ((tbxUsername.Text != "") && (tbxPassword.Text != ""))
            {
                using (MySqlCommand olvas = new MySqlCommand($"SELECT `ID_User` FROM `users` WHERE `Nev` = '{tbxUsername.Text}' AND `Jelszo` = '{tbxPassword.Text}' ", conn))
                {
                    try
                    {
                        UserID = Convert.ToInt32(olvas.ExecuteScalar().ToString());
                        btnMehet.Enabled = true;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }

        private void rogzitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
