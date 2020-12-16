using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.Common;
using MySql.Data.MySqlClient;

namespace adatbazis
{
    /// <summary> solution explorerben jobb egérgomb projectre, NUGET vagy mi browser mysql data telepit
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "kiselőadás";

            MySqlConnection conn = new MySqlConnection(sb.ToString());
            conn.Open();
            /*első rész vége*/

            MySqlCommand sql = new MySqlCommand();
            sql = conn.CreateCommand();


            /*           string nev = "béla";
                      string email = "bela@hu.hu";
                      string jelszo = "12345";
                      string osszeg = "5000";
                      string status = 2;

                     sql.CommandText = "INSERT INTO `users` (`ID`, `name`, `Email`, `password`, `balance`, `ID_Deleted_User`) VALUES(NULL, '"+nev+"', '"+email+"', '"+jelszo+"', '"+osszeg+"', '"+osszeg+"');"  valahogy igy is lehetne manuálisan a végére ;) valami kellhet*/

          /*  regisztracio(sql, nev, email, jelszo, osszeg);
            regisztracio(,,,,,);*/
        }

        private void regisztracio(MySqlCommand sql, string nev, string email, string jelszo, string osszeg)
        {
            sql.CommandText = "INSERT INTO `users` (`ID`, `name`, `Email`, `password`, `balance`, `ID_Deleted_User`) VALUES(NULL, '" + nev + "', '" + email + "', '" + jelszo + "', '" + osszeg + "', '" + osszeg + "');"
        }
    }
}
