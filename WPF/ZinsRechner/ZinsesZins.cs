using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ZinsRechner
{
    public class ZinsesZins: INotifyPropertyChanged
    {
        private double kapital;
        private double zinssatz;
        private int laufzeit;
        private double endKapital;

        public ZinsesZins()
        { }

        public double Kapital { get => kapital; set => kapital = value; }
        public double Zinssatz { get => zinssatz; set => zinssatz = value; }
        public int Laufzeit { get => laufzeit; set => laufzeit = value; }
        public double EndKapital { get => endKapital; set { endKapital = value; OnPropertyChanged(new PropertyChangedEventArgs("EndKapital")); } }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(PropertyChangedEventArgs e)
        { 
            if(PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }

        public void berechneEndKapital()
        {
            for (int i = 0; i < Laufzeit; i++)
            { 
                Kapital *= 1+zinssatz/100;
            }
            EndKapital = kapital;
        }
    }
}
