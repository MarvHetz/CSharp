using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfAppBestellung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Lager lager;
        public MainWindow()
        {
            InitializeComponent();
            lager = (Lager)DataContext;
            lager.LagerDatenAuslesen();
            lager.KundenLaden();
            KundenData.ItemsSource = lager.Ds.Tables["Kunde"].AsDataView();
        }

        private void btnNeuenArtikelAufnehmen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lager.KundenUpdate();
        }
    }
}
