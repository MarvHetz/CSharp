using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Data.OleDb;
using System.Data;

namespace WpfAppBestellung
{
    public class Lager
    {
        private ObservableCollection<Artikel> artikel;
        private OleDbConnection con;
        private OleDbCommand command;
        private OleDbDataReader dr;
        private DataSet ds;
        private OleDbDataAdapter adapter;

        public Lager()
        {
            artikel = new ObservableCollection<Artikel>();
            con = new OleDbConnection(Properties.Settings.Default.DBPath);
            con.Open();
        }

        public void LagerDatenAuslesen()
        { 
            command = con.CreateCommand();
            command.CommandText = "Select * from tArtikel";
            command.CommandType = System.Data.CommandType.Text;
            dr = command.ExecuteReader();


            while (dr.Read())
            {
                Artikel neu = new Artikel(Convert.ToString(dr["Artikelnr"]),Convert.ToInt32(dr["ArtikelOid"]),Convert.ToInt32(dr["Bestand"]),Convert.ToString(dr["Bezeichnung"]),Convert.ToInt32(dr["Meldebestand"]),Convert.ToDecimal(dr["VkPreis"]));
                artikel.Add(neu);
            }
            dr.Close();
        }

        internal void KundenUpdate()
        {
            OleDbCommandBuilder command = new OleDbCommandBuilder(adapter);
            adapter.DeleteCommand = command.GetDeleteCommand();
            adapter.InsertCommand = command.GetInsertCommand();
            adapter.UpdateCommand = command.GetUpdateCommand();
            adapter.Update(Ds.Tables["Kunde"]);
        }

        public void KundenLaden()
        { 
            adapter = new OleDbDataAdapter("Select * from tKunde",con);
            Ds = new DataSet();
            adapter.Fill(Ds,"Kunde");
        }

        public ObservableCollection<Artikel> Artikel { get => artikel; set => artikel = value; }
        public DataSet Ds { get => ds; set => ds = value; }
    }
}
