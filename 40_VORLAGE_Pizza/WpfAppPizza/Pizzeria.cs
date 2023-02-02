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
    public class Pizzeria: INotifyPropertyChanged
    {
        private Bestellung bestellung = new Bestellung();
        ObservableCollection<Pizza> pizzen = new ObservableCollection<Pizza>();
        ObservableCollection<Kunde> kunden = new ObservableCollection<Kunde>();

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChnaged(PropertyChangedEventArgs e)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }

        public Bestellung Bestellung { get => bestellung; set => bestellung = value; }
        public ObservableCollection<Pizza> Pizzen { get => pizzen; set => pizzen = value; }
        public ObservableCollection<Kunde> Kunden { get => kunden; set => kunden = value; }

        public Pizzeria()
        {
            PizzenLesen();
            KundenLesen();
        }

        public void PizzenLesen()
        {
            XmlSerializer serialzer = new XmlSerializer(typeof(ObservableCollection<Pizza>));
            TextReader reader = new StreamReader("Pizza.xml");
            pizzen = (ObservableCollection<Pizza>)serialzer.Deserialize(reader);
            reader.Close();
        }

        public void KundenLesen()
        {
            XmlSerializer serialzer = new XmlSerializer(typeof(ObservableCollection<Kunde>));
            TextReader reader = new StreamReader("Kunde.xml");
            kunden = (ObservableCollection<Kunde>)serialzer.Deserialize(reader);
            reader.Close();
        }

        public void NeueBestellung(Kunde kunde)
        {
            bestellung.Kunde = kunde;
            bestellung.Datum = System.DateTime.Now;
            OnPropertyChnaged(new PropertyChangedEventArgs("Bestellung"));

        }

    }
}
