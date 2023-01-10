using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.ObjectModel;
using System.Xml.Serialization;


namespace WpfAppApotheke
{
    public class Kauf
    {
        private ObservableCollection<Medikament> alleMedikamente;
        private ObservableCollection<Medikament> auswahlMedikamente;


        public decimal Gesamtpreis { get => gesamtpreis;
            set  { gesamtpreis = value;   }
        }

        public ObservableCollection<Medikament> AlleMedikamente { get => alleMedikamente; set => alleMedikamente = value; }
        public ObservableCollection<Medikament> AuswahlMedikamente { get => auswahlMedikamente; set => auswahlMedikamente = value; }
        public delegate void RezeptVorhanden();
        public RezeptVorhanden OnRezeptVorhanden = null;

        private decimal gesamtpreis;


        public Kauf ()
        {
            Gesamtpreis = 0;
            AlleDeserialisieren();
            auswahlMedikamente = new ObservableCollection<Medikament>();
        }

        public void MedikamentHinzufuegen(Medikament medikament, bool kassenrezept, bool privatrezept)
        {
            if (medikament.Rezeptpflichtig)
            {
                if (!kassenrezept && !privatrezept)
                {
                    if (OnRezeptVorhanden != null)
                    {
                        OnRezeptVorhanden();
                    }
                }
                else
                {
                    Gesamtpreis += medikament.ZuzahlungBerechnen(kassenrezept);
                    auswahlMedikamente.Add(medikament);
                }
            }
            else
            {
                Gesamtpreis += medikament.ZuzahlungBerechnen(kassenrezept);
                auswahlMedikamente.Add(medikament);
            }
        }

        public decimal Kaufen()
        {
            return gesamtpreis;
        }

        public ObservableCollection<Medikament> AlleDeserialisieren()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Medikament>));
            StreamReader reader = new StreamReader("Auswahl.xml");
            alleMedikamente = (ObservableCollection<Medikament>)serializer.Deserialize(reader);
            return alleMedikamente;
        }
    }
}
