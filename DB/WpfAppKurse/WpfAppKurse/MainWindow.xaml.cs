﻿using System;
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

namespace WpfAppKurse
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Kursverwaltung kursverwaltung;
        public MainWindow()
        {
            InitializeComponent();
            kursverwaltung = (Kursverwaltung)this.DataContext;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            kursverwaltung.lesen();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            kursverwaltung.serializeTeilnehmer(((Kurs)ComboBoxKurse.SelectedItem).Bezeichnung,((Kurs)ComboBoxKurse.SelectedItem).Teilnehmer);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            kursverwaltung.serializeKurse((Kurs)ComboBoxKurse.SelectedItem);
        }
    }
}