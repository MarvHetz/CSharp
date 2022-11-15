using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppReise
{
    public partial class ReiseUI : Form
    {
        private Verwaltung verwaltung;
        public ReiseUI()
        {
            InitializeComponent();
            verwaltung = new Verwaltung();
            verwaltung.alleReisenLaden();
            listBoxReisen.DataSource = verwaltung.Reisen;
        }

        private void buttonNeuerTeilnehmer_Click(object sender, EventArgs e)
        {
            Reise temp = (Reise) listBoxReisen.SelectedItem;
            aktualisierenTeilnehmer(verwaltung.neuerTeilnehmer(temp, Convert.ToString(textBoxVorname.Text), Convert.ToString(textBoxEmail.Text), Convert.ToString(textBoxNachname.Text)));
        }

        private void aktualisierenTeilnehmer(Reise reise)
        {
            listBoxTeilnehmer.DataSource = null;
            listBoxTeilnehmer.DataSource = reise.LstTeilnehmer;
        }

        private void buttonLöschen_Click(object sender, EventArgs e)
        {
            Teilnehmer zuLoeschen = (Teilnehmer)listBoxTeilnehmer.SelectedItem;
            Reise reise = (Reise)(listBoxReisen.SelectedItem);
            aktualisierenTeilnehmer(verwaltung.teilnehmerLoeschen(reise,zuLoeschen));
        }
        
        private void listBoxReisen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxReisen.SelectedIndex != -1)
            {
                Reise neueReise = (Reise)listBoxReisen.SelectedItem;
                listBoxTeilnehmer.DataSource = verwaltung.neueReiseLaden(neueReise);
                textBoxZiel.Text = Convert.ToString(neueReise.Ziel);
                textBoxMaxTN.Text = Convert.ToString(neueReise.MaxTeilnehmer);
                textBoxPreis.Text = Convert.ToString(neueReise.Preis);
                textBoxBis.Text = Convert.ToString(neueReise.Bis);
                textBoxVon.Text = Convert.ToString(neueReise.Von);
            }
        }

        private void aktualisierenReisen()
        {
            listBoxReisen.DataSource = null;
            listBoxReisen.DataSource = verwaltung.Reisen;
        }

        private void buttonReiseHinzufuegen_Click(object sender, EventArgs e)
        {
            verwaltung.neueReise(Convert.ToDateTime(textBoxBis),Convert.ToInt32(textBoxMaxTN),Convert.ToDecimal(textBoxPreis.Text),Convert.ToDateTime(textBoxVon.Text),Convert.ToString(textBoxZiel.Text));
            aktualisierenReisen();
        }

        private void buttonReiseLoeschen_Click(object sender, EventArgs e)
        {
            Reise zuLoeschen = (Reise)listBoxReisen.SelectedItem;
            verwaltung.reiseLoeschen(zuLoeschen);
            aktualisierenReisen();
        }
    }
}
