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
            if (sql.Connection.State == ConnectionState.Closed)
            { sql.Connection.Open(); /*azért kell megint megnyitni mert lezárom a kapcsolatot ha a listázásra lő az ember*/ }

            string nev = txbNev.Text;
            string email = txbEmail.Text;
            string jelszo = txbJelszo.Text;
               string osszeg = "5000"; /*hagytam 5kn*/

                 sql.CommandText = "INSERT INTO `users` (`ID`, `name`, `Email`, `password`, `balance`, `ID_Deleted_User`) VALUES(NULL, '"+nev+"', '"+email+"', '"+jelszo+"', '"+osszeg+"', '2');";
                sql.ExecuteReader();

            MessageBox.Show("Regisztráció(INSERT) folyamat befejeződött");
        }

        private void button2_Click(object sender, EventArgs e) /*DELETE*/
        {
          if (sql.Connection.State == ConnectionState.Closed)
            { sql.Connection.Open(); /*azért kell megint megnyitni mert lezárom a kapcsolatot ha a listázásra lő az ember*/ }
            
            string azonosito = txbTorol.Text;

            MessageBox.Show("Az azonosito: " + azonosito);

            sql.CommandText = "DELETE FROM `users` WHERE `users`.`ID` = "+azonosito+";";
            sql.ExecuteReader();
            MessageBox.Show("Törlés(DELETE) folyamat befejeződött");
        }

        private void button4_Click(object sender, EventArgs e)/*UPDATE CSAK EZ NEM MEGY*/
        {
            if (sql.Connection.State == ConnectionState.Closed)
            { sql.Connection.Open(); /*azért kell megint megnyitni mert lezárom a kapcsolatot ha a listázásra lő az ember*/ }

            string emailcim = txbEmail.Text;
           
            sql.CommandText = "UPDATE `users` SET 'Email`= "+emailcim+" WHERE `ID` = '1';"; /*fázoltánnak email cimét akarnám felülirni*/
          //  sql.ExecuteReader(); //hibára fut
                                   sql.ExecuteNonQuery();  //elvileg ezt is lehetne használni de ez is hibára fut
            MessageBox.Show("Email cim frissités(UPDATE) folyamat befejeződött");
        }

        private void button1_Click(object sender, EventArgs e)/*READ\SELECT LISTÁZÁS*/
        {
            dataGridView1.DataSource = null;
            sql.Connection.Close(); //ez a két sor azért kell hogyha többször is használni akarom a listázást, pl regisztráció vagy törlés előtt és után

      //      sql.CommandText = "SELECT * FROM `users`";
       //     sql.ExecuteReader(); ezt itt ki kell! kommentálni mivel a mysqladapter is nyit egy kapcsolatot és a kettő ütné egymást, illetve egy elég és ide a SELECT-hez az kell
       
            MySqlDataAdapter da = new MySqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;  //ez a négy sor egy módszer arra hogy kiolvassuk a SELECTből visszatérő infokat és beleirjuk a datagridviewba

            MessageBox.Show("Users tábla listázása(READ) folyamat befejeződött");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) /*ha bezárul a fomr lezárjuk az adatb kapcsolatot, nem volt rá szükség de elvileg nem árt*/
        {
      /*    sql.Connection.Close(); /*C# könyv alapján adtam hozzá
            sql.Connection.Dispose();*/
        }
    }
}
