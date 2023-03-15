using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Data.OleDb;
using System.ComponentModel;
using System.Data;

namespace WpfAppDB1
{
    public class ArtikelVerwaltung:INotifyPropertyChanged
    {
        private ObservableCollection<Artikel> artikels;
        OleDbCommand command;
        OleDbDataReader reader;
        OleDbConnection connection;

        public ArtikelVerwaltung()
        { 
            connection = new OleDbConnection(Properties.Settings.Default.DBPath);
        }

        public ObservableCollection<Artikel> Artikels { get => artikels; set => artikels = value; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        { 
            if(PropertyChanged != null)
                PropertyChanged(this, e);
        }

        public void aufnehmen(string name, decimal preis)
        { 
            connection.Open();

            command = connection.CreateCommand();
            command.CommandText = "Insert into Artikel (Artikel, Preis) values ('" + name + "','" + preis + "');";
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();

            connection.Close();            

            DatenLaden();
        }

        public void aendern(Artikel zuaendern)
        {
            connection.Open();

            command = connection.CreateCommand();
            command.CommandText = "Update Artikel set Artikel = '" + zuaendern.Name + "', Preis = '" + zuaendern.Preis + "' where Id = " + zuaendern.Id;
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();

            connection.Close ();

            DatenLaden ();
        }

        public void loeschen(int id)
        {
            connection.Open();

            command = connection.CreateCommand();
            command.CommandText = "Delete from Artikel where ID = " + id ;
            command.CommandType = System.Data.CommandType.Text;
            command.ExecuteNonQuery();

            connection.Close();

            DatenLaden();
        }

        public void DatenLaden()
        {
            artikels = new ObservableCollection<Artikel>();
            connection.Open();

            command = connection.CreateCommand();
            command.CommandText = "Select * from Artikel";
            command.CommandType = System.Data.CommandType.Text;

            reader = command.ExecuteReader();

            while (reader.Read())
            { 
                Artikel a = new Artikel(Convert.ToInt32(reader["ID"]),Convert.ToString(reader["Artikel"]),Convert.ToDecimal(reader["Preis"]));
                artikels.Add(a);
            }

            reader.Close();
            connection.Close();
            OnPropertyChanged(new PropertyChangedEventArgs("Artikels"));
        }
    }
}
