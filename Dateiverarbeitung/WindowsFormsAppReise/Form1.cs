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
            comboBoxReise.DataSource = verwaltung.Reisen;
        }

        private void buttonNeuerTeilnehmer_Click(object sender, EventArgs e)
        {
            Reise temp = (Reise) comboBoxReise.SelectedItem;
            aktualisieren(verwaltung.neuerTeilnehmer(temp, Convert.ToString(textBoxVorname.Text), Convert.ToString(textBoxEmail.Text), Convert.ToString(textBoxNachname.Text)));
        }

        private void comboBoxReise_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reise neueReise = (Reise) comboBoxReise.SelectedItem;
            listBoxTeilnehmer.DataSource = verwaltung.neueReiseLaden(neueReise);
        }

        private void aktualisieren(Reise reise)
        {
            listBoxTeilnehmer.DataSource = null;
            listBoxTeilnehmer.DataSource = reise.LstTeilnehmer;
        }

        private void buttonLöschen_Click(object sender, EventArgs e)
        {
            Teilnehmer zuLoeschen = (Teilnehmer)listBoxTeilnehmer.SelectedItem;
            Reise reise = (Reise)(comboBoxReise.SelectedItem);
            aktualisieren(verwaltung.teilnehmerLoeschen(reise,zuLoeschen));
        }
    }
}
