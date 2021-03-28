using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// FONTOS: a solution explorerben ráálunk a cs-re, jobb egérbomb. Manage NUGET packages. A nuget-be rákeresünk a mysql-re és hozzáadjuk első találatot. Ez azért kell hogy az sqlclient névteret be tudjuk emelni, ez kell az adatbázisos metódusokhoz, osztályokhoz:
using MySql.Data.MySqlClient;

namespace Utnyilvantartas_hazifeladat
{
    public partial class Belepes : Form
    {
        // ki kell ide hozni a kapcsolódás objetumot,hogy majd máshonnan is elérhető legyen
        private MySqlConnection conn;
        // a beolvasást is osztály szintre ki kell emelni hasonló okokból
        private MySqlDataReader sorok;

        public Belepes()
        {
            InitializeComponent();
            // a form betöltésekor meghivjuk a kapcsolatot kiépitő metódusunkat
            mysqlkapcsolodas();
        }

        private void Utnyilvantartas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDS.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.usersDS.users);
        }

        private void tbxUsername_TextChanged(object sender, EventArgs e)
        {
            // Folyamatosan nézzük hogy username és pw tbx tartalom megegyezik e azzal ami az adatbázisban van. HA egyezés van akkor a gomb enable lesz.

            // Tovább megyünk és a lekérdezéseinket is lefuttatjuk itt. Using-ba rakjuk a commandot. A using azt csinálja hogy a benne megadott objektumokat amikor nincs rá felszabaditja. A usingban hozzuk létre a commandot. Ezután ebbe egy try catchel futtatjuk meg a lekérdezést
            using (MySqlCommand olvas = new MySqlCommand("SELECT `Nev` FROM `users`", conn))
            {
                try
                {                   
                    // egy reader objektumba olvassuk ki a lekérdezés ereményét. 1. lépés: megnyitjuk olvasásra:
                    sorok = olvas.ExecuteReader();
                    sorok.Read();

                    if (sorok[0].ToString() == tbxUsername.Text)
                    {
                        btnMehet.Enabled = true;
                        sorok.Close();
                        conn.Close();
                    }
                    tbxPass.Text = sorok[0].ToString();
                    sorok.Close();
                    conn.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usersDS);
        }

        private void btnMehet_Click(object sender, EventArgs e)
        {
            // második menübe átugrunk ha klikkelés volt


            /* majd a beiratás

            using(új mysqlcommand mint a másik)
            try catchben
            beszuras.executenon();

            */
        }

        private void mysqlkapcsolodas()
        {
            // két dolog kell a kapcsolódáshoz 1.: egy connection string amit a connectionstringbuilderből hozunk létre majd paraméterezünk fel az adatbázis cimével, nevével, az azt elérő felhasználó nevével, jelszavával
            // FONTOS ez az adatbázis a XAMPP phpmyadmin adatbázisokat használja!!!
            MySqlConnectionStringBuilder db = new MySqlConnectionStringBuilder();
            db.Server = "localhost";
            db.Database = "utnyilvantartas";
            db.UserID = "root";
            db.Password = "";

            // és 2.: egy connection objektum aminek átadjuk ezt a stringet átvesszük
            conn = new MySqlConnection(db.ToString());
            // majd kinyitjuk a kapcsolatot az open metódussal conn.Open(); ez lehet itt vagy akár egy try catchben
            conn.Open();
        }
    }
}
