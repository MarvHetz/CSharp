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

namespace WpfAppDB1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ArtikelVerwaltung artikelVerwaltung;
        public MainWindow()
        {

            InitializeComponent();
            artikelVerwaltung = (ArtikelVerwaltung)this.DataContext;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            artikelVerwaltung.DatenLaden();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            artikelVerwaltung.aufnehmen(Convert.ToString(txtName.Text),Convert.ToDecimal(txtPreis.Text));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Artikel zuaendern = ((Artikel)this.listBoxArtikel.SelectedItem);

            artikelVerwaltung.aendern(new Artikel(zuaendern.Id, txtName.Text, Convert.ToDecimal(txtPreis.Text)));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int id = ((Artikel)this.listBoxArtikel.SelectedItem).Id;

            artikelVerwaltung.loeschen(id);
        }
    }
}
