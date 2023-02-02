using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace WpfAppPizza
{
    public class Bestellung
    {
        private DateTime datum;
        private Decimal bestellwert;
        private Kunde kunde;
        private ObservableCollection<BestellPosition> lstpositionen = new ObservableCollection<BestellPosition>();

        public DateTime Datum { get => datum; set => datum = value; }
        public decimal Bestellwert { get => bestellwert; set => bestellwert = value; }
        public Kunde Kunde { get => kunde; set => kunde = value; }
        public ObservableCollection<BestellPosition> Lstpositionen { get => lstpositionen; set => lstpositionen = value; }

        public Bestellung()
        {
            bestellwert = 0;
        }        

        public void AddBestellposition(BestellPosition bestellpos)
        {
            lstpositionen.Add(bestellpos);
            bestellwert += bestellpos.NeuePizza.Preis * bestellpos.Menge;
        }

        public override string ToString()
        {
            return kunde + ": " + datum;
        }
    }
}
