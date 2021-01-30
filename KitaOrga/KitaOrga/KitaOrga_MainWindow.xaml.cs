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
using System.Windows.Shapes;
using System.Diagnostics.SymbolStore;
using System.Security.Cryptography.X509Certificates;
using MySql.Data.MySqlClient;

namespace KitaOrga
{
    /// <summary>
    /// Interaktionslogik für KitaOrga_MainWindow.xaml
    /// </summary>
    public partial class KitaOrga_MainWindow : Window
    {

        public KitaOrga_MainWindow()
        {
            InitializeComponent();
        }


        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void bt_Mitarbeiter_hinzufügen_Click(object sender, RoutedEventArgs e)
        {
            
            Mitarbeiter_hinzufügen _Hinzufügen = new Mitarbeiter_hinzufügen();
            _Hinzufügen.Show();
            
        }

        class Kitaorga
        {

        }
    }
}
