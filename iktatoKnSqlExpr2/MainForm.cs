using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iktatoKnSqlExpr2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iktatoDataSet21.letters' table. You can move, or remove it, as needed.
            this.lettersTableAdapter.Fill(this.iktatoDataSet21.letters);
            // TODO: This line of code loads data into the 'iktatoDataSet2.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.iktatoDataSet2.users);

        }
        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            // Megváltozott a sor kijelölése, újra töltjük a letters táblát

        }


    }
}
