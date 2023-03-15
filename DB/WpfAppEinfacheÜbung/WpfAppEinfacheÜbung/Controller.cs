using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppEinfacheÜbung
{
    public class Controller : INotifyPropertyChanged
    {
        OleDbConnection con;
        OleDbCommand command;
        OleDbDataReader reader;

        private List<Tier> tierList;

        public List<Tier> TierList { get => tierList; set => tierList = value; }

        public Controller()
        { 
            tierList = new List<Tier>();
            con = new OleDbConnection(Properties.Settings.Default.DBPath);
            auslesen();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }

        public void auslesen()
        {
            con.Open();
            command = con.CreateCommand();
            command.CommandText = "Select * from Tiere";
            command.CommandType = CommandType.Text;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                tierList.Add(new Tier(Convert.ToInt32(reader["ID"]), Convert.ToString(reader["art"]), Convert.ToString(reader["Tiername"]), Convert.ToInt32(reader["Tieralter"]), Convert.ToBoolean(reader["vermittelt"])));
            }
            reader.Close();
            con.Close();
            OnPropertyChanged(new PropertyChangedEventArgs("TierList"));
        }
    }
}
