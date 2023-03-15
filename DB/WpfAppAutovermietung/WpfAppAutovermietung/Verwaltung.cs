using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Controls;

namespace WpfAppAutovermietung
{
    public class Verwaltung:INotifyPropertyChanged
    {
        OleDbConnection con;
        OleDbDataAdapter adapter;
        DataSet ds;
        private ObservableCollection<Kunde> kunden;

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Kunde> Kunden { get => kunden; set => kunden = value; }
        public DataSet Ds { get => ds; set => ds = value; }

        public void OnPropertyChangedEventHandler(PropertyChangedEventArgs e)
        { 
            if(PropertyChanged != null)
                PropertyChanged(this,e);
        }

        public Verwaltung()
        { 
            con = new OleDbConnection(Properties.Settings.Default.DBPath);
            kunden = new ObservableCollection<Kunde>();
            ds = new DataSet();
        }

        public void AdapterErstellen()
        { 
            adapter = new OleDbDataAdapter("Select * from tKunde;",con);
            MessageBox.Show("Adaper ist erstellt!");
        }

        public void DataSetFuellenMietvertrag()
        {
            adapter = new OleDbDataAdapter("Select * from tMietvertrag", con);
            adapter.Fill(ds,"MIETVERTRAG");
        }

        public void DataSetFuellen()
        {
            ds = new DataSet();
            adapter.Fill(ds,"KUNDE");
            MessageBox.Show("DataSet wurde gefüllt!");
        }

        internal void Mietvertraege()
        {
            OleDbCommandBuilder cmdBld = new OleDbCommandBuilder();
            adapter.DeleteCommand = cmdBld.GetDeleteCommand();
            adapter.InsertCommand = cmdBld.GetInsertCommand();
            adapter.UpdateCommand = cmdBld.GetUpdateCommand();
            adapter.Update(ds.Tables["MIETVERTRAG"]);
        }

        public void DataSetAuslesen()
        {
            DataTableReader dtr = ds.Tables["KUNDE"].CreateDataReader();
            
            while (dtr.Read())
            { 
                int i = 0;
                Kunde k = new Kunde();
                k.Id = Convert.ToInt32(check(dtr[i++]));
                k.Name = Convert.ToString(check(dtr[i++]));
                k.Vorname = Convert.ToString(check(dtr[i++]));
                k.Strasse = Convert.ToString(check(dtr[i++]));
                k.Plz = Convert.ToInt32(check(dtr[i++]));
                k.Ort = Convert.ToString(check(dtr[i++]));
                k.Telefon = Convert.ToString(check(dtr[i++]));
                k.Ausweisnummer = Convert.ToString(check((dtr[i++])));
                kunden.Add(k);
            }
            dtr.Close();
            OnPropertyChangedEventHandler(new PropertyChangedEventArgs("Kunden"));
        }

        private object check(object p)
        {
            if (p == DBNull.Value)
            {
                return null;
            }
            else
            { 
                return p;
            }
        }
    }
}
