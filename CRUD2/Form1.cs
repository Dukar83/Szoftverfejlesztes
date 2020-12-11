using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.Common;
using MySql.Data.MySqlClient;

namespace CRUD2
{
    public partial class Form1 : Form
    {
        MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
        MySqlCommand sql = new MySqlCommand();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "usertest"; /*kiselőadást lemásoltam ékezet nélküli DB-be*/

            try
            {
                MySqlConnection conn = new MySqlConnection(sb.ToString());
                conn.Open();
                sql = conn.CreateCommand();

                if (conn.State == ConnectionState.Open)
                {
                    lblKapcsolodott.Text = "Kapcsolódott";
                    lblKapcsolodott.ForeColor = Color.Green;
                }
                else
                {
                    lblKapcsolodott.Text = "Nem kapcsolódott";
                    lblKapcsolodott.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }

        private void btnRegeles_Click_1(object sender, EventArgs e)/*CREATE*/
        {
               string nev = "bela";
               string email = "bela@hu.hu";
               string jelszo = "belajelszo";
               string osszeg = "5000";

                 sql.CommandText = "INSERT INTO `users` (`ID`, `name`, `Email`, `password`, `balance`, `ID_Deleted_User`) VALUES(NULL, '"+nev+"', '"+email+"', '"+jelszo+"', '"+osszeg+"', '2')";
                 
          /*    sql.CommandText = "INSERT INTO `users` (`ID`, `name`, `Email`, `password`, `balance`, `ID_Deleted_User`) VALUES(NULL, 't3', 't2@t2.s', 't2', '3000', '2')";
            /*ez se megy hiába "; vagy ;"; van a végén, vagy @ az elején*/

            MessageBox.Show("INSERT lement");
        }

        private void button2_Click(object sender, EventArgs e) /*DELETE*/
        {
            sql.CommandText = "DELETE FROM `users` WHERE `users`.`ID` = 9;"; /*marhára nem töröl*/
            MessageBox.Show("DELETE lement");
        }

        private void button4_Click(object sender, EventArgs e)/*UPDATE*/
        {
            /* ql.CommandText = "UPDATE `users` SET `ID`=[value-1],`name`=[value-2],`Email`=[value-3],`password`=[value-4],`balance`=[value-5],`ID_Deleted_User`=[value-6];"; - nyilván az email value-t kiolvasni textboxból és ennyi*/
        }

        private void button1_Click(object sender, EventArgs e)/*READ*/
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) /*ha bezárul a fomr lezárjuk az adatb kapcsolatot*/
        {
            sql.Connection.Close(); /*C# könyv alapján adtam hozzá hátha..*/
            sql.Connection.Dispose();
        }
    }
}
