using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfAppListen
{
    public class Person:INotifyPropertyChanged
    {
        private string name;
        private int alter;
        private string Haustier;

        public Person()
        { }

        public Person(string name, int alter, string haustier)
        {
            this.Name = name;
            this.Alter = alter;
            Haustier1 = haustier;
        }

        public string Name { get => name; set => name = value; }
        public int Alter { get => alter; set => alter = value; }
        public string Haustier1 { get => Haustier; set => Haustier = value; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(PropertyChangedEventArgs e)
        { 
            if(PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }

        public void geburtsTag()
        {
            Alter++;
            OnPropertyChanged(new PropertyChangedEventArgs("Alter"));
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
