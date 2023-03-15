using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace WpfAppKurse
{
    public class Kursverwaltung :INotifyPropertyChanged
    {
        private OleDbConnection con;
        private OleDbCommand command;
        private OleDbDataReader reader;
        private List<Kurs> kurse;
        public Kursverwaltung()
        {
            con = new OleDbConnection(Properties.Settings.Default.DBPath);
            Kurse = new List<Kurs>();
        }

        public List<Kurs> Kurse { get => kurse; set => kurse = value; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        { 
            if(PropertyChanged != null)
                PropertyChanged(this,e);
        }

        public void lesen()
        {
            con.Open();

            command = con.CreateCommand();
            command.CommandText = "Select * from tKurs";
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                Kurse.Add(new Kurs(Convert.ToString(checkNull(reader["Bezeichnung"])), Convert.ToDateTime(checkNull(reader["datum"])),Convert.ToInt32(checkNull(reader["id"]))));
            }

            reader.Close();

            command = con.CreateCommand();
            command.CommandText = "Select * from tTeilnehmer";
            reader = command.ExecuteReader();

            List<Teilnehmer> teilnehmerTemp = new List<Teilnehmer>();

            while (reader.Read())
            {
                teilnehmerTemp.Add(new Teilnehmer(Convert.ToString(checkNull(reader["email"])), Convert.ToInt32(checkNull(reader["ID"])), Convert.ToString(checkNull(reader["Nachname"])), Convert.ToString(checkNull(reader["vorname"]))));
            }

            reader.Close ();

            command = con.CreateCommand();
            command.CommandText = "Select * from tKurszuTeilnehmer";
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                Kurse.ElementAt(Convert.ToInt32(checkNull(reader["KursID"])) - 1).Teilnehmer.Add(teilnehmerTemp.ElementAt(Convert.ToInt32(checkNull(reader["TeilnehmerID"])) - 1));
            }

            reader.Close () ;
            con.Close ();

            OnPropertyChanged(new PropertyChangedEventArgs("Kurse"));
        }

        public void serializeKurse(Kurs kurs)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Kurs));

            TextWriter writer = new StreamWriter("Kurs" + kurs.Bezeichnung + ".xml");

            serializer.Serialize(writer, kurs);

            writer.Close();
        }

        public void serializeTeilnehmer(string bezeichnung, List<Teilnehmer> teilnehmer)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Teilnehmer>));

            TextWriter writer = new StreamWriter("Teilnehmer"+bezeichnung+".xml");

            serializer.Serialize(writer, teilnehmer);

            writer.Close ();
        }

        public object checkNull(object v)
        {
            if (v == DBNull.Value)
            {
                return null;
            }
            else 
            {
                return v;
            }

        }
    }
}
