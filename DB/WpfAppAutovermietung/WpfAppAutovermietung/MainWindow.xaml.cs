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

namespace WpfAppAutovermietung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Verwaltung verwaltung;
        public MainWindow()
        {
            InitializeComponent();
            verwaltung = (Verwaltung)this.DataContext;
        }

        private void Adapter_Click(object sender, RoutedEventArgs e)
        {
            verwaltung.AdapterErstellen();
        }

        private void DataSetfuellen_Click(object sender, RoutedEventArgs e)
        {
            verwaltung.DataSetFuellen();
        }

        private void DataSetAuslesen_Click(object sender, RoutedEventArgs e)
        {
            verwaltung.DataSetAuslesen();
            dataGrid.ItemsSource = verwaltung.Kunden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            verwaltung.DataSetFuellenMietvertrag();
            DataGridMietvertrag.ItemsSource = verwaltung.Ds.Tables["MIETVERTRAG"].AsDataView();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            verwaltung.Mietvertraege();
        }
    }
}
