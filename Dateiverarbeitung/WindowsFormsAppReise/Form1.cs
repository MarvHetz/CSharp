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
        }

        private void buttonNeuerTeilnehmer_Click(object sender, EventArgs e)
        {
            Reise temp = (Reise) comboBoxReise.SelectedItem;
            listBoxReisen.DataSource = verwaltung.neuerTeilnehmer(temp, Convert.ToString(textBoxVorname), Convert.ToString(textBoxEmail), Convert.ToString(textBoxNachname));
        }

        private void comboBoxReise_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reise neueReise = (Reise) comboBoxReise.SelectedItem;
            listBoxReisen.DataSource = verwaltung.neueReiseLaden(neueReise);
        }
    }
}
