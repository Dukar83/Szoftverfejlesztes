using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
              < Grid >
        < TextBlock HorizontalAlignment = "Center" VerticalAlignment = "Center" FontSize = "72" >
                 Hello, WPF!
             </ TextBlock >


         </ Grid >
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
