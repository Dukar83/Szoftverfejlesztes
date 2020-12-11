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
using System.Media;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            player.Load();
            player.Play();
            
        }

        SoundPlayer player = new SoundPlayer(@"c:\bgmusic1.wav");           

        private void lb_Loaded(object sender, RoutedEventArgs e){
            Label labelek = sender as Label;
            labelek.Content = ""; }

        private void btn0_Button_Click(object sender, RoutedEventArgs e)
        {
            //választ gomb klikk -> megmutatja a bossokat     
            lb_Pamela.Content = "Pamela";
            lb_Satish.Content = "Satish";
            lb_X.Content = "Mr X";
        }
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            //ezzel indul majd a játék, de kell csekk hogy volt e választás
            //illetve villogjon mint az árkádban ha event megvolt - https://stackoverflow.com/questions/24481700/c-sharp-wpf-pulsing-button
            // ráklikkeléskor egy hangeffektet nyomni
        }


    }
}
