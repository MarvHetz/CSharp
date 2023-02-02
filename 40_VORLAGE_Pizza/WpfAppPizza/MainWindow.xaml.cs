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
using System.Data.OleDb;
using System.Collections.ObjectModel;

namespace WpfAppPizza
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
   
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();           

        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            Pizzeria p = (Pizzeria)DataContext;
            p.NeueBestellung((Kunde)comboKunde.SelectedItem);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Pizzeria p = (Pizzeria)this.DataContext;
            p.Bestellung.AddBestellposition(new BestellPosition((Pizza)comboPizza.SelectedItem,Convert.ToInt32(TextBoxMenge.Text)));
            txtBoxGesamtWert.Text = p.Bestellung.Bestellwert.ToString();
        }
    }
}
