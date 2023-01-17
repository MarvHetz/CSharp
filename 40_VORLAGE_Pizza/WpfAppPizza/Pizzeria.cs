using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using System.IO;

namespace WpfAppPizza
{
    public class Pizzeria
    {
        private Bestellung bestellung;
        ObservableCollection<Pizza> pizzen;
        ObservableCollection<Kunde> kunden;

        public Bestellung Bestellung { get => bestellung; set => bestellung = value; }
        public ObservableCollection<Pizza> Pizzen { get => pizzen; set => pizzen = value; }
        public ObservableCollection<Kunde> Kunden { get => kunden; set => kunden = value; }

        public Pizzeria()
        {
            deserializeKunden();
            deserializePizzen();
        }

        private void deserializeKunden()
        {
            XmlSerializer seriliazer = new XmlSerializer(typeof(ObservableCollection<Kunde>));
            StreamReader sr = new StreamReader("Kunde.xml");
            Kunden = (ObservableCollection<Kunde>)seriliazer.Deserialize(sr);
            sr.Close();
        }

        private void deserializePizzen()
        {
            XmlSerializer seriliazer = new XmlSerializer(typeof(ObservableCollection<Pizza>));
            StreamReader sr = new StreamReader("Pizza.xml");
            Pizzen = (ObservableCollection<Pizza>)seriliazer.Deserialize(sr);
            sr.Close();
        }
    }
}
