using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Vorbereitung1FPA
{
    public partial class Form1 : Form
    {
        private Lager lager;
        private bool deselect = false;
        public Form1()
        {
            InitializeComponent();
            lager = new Lager();

        }

        private void buttonAufnehmen_Click(object sender, EventArgs e)
        {
            deselect = true;
            String bezeichnung = textBoxArtikelbezeichnung.Text;
            decimal preis = Convert.ToDecimal(textBoxPreis.Text);
            lager.ArtikelAufnehmen(bezeichnung, preis);
            textBoxArtikelbezeichnung.Clear();
            textBoxPreis.Clear();
            aktualisieren();
            deselect = false;
        }

        private void aktualisieren()
        {
            comboBoxArtikel.DataSource = null;
            comboBoxArtikel.DataSource = lager.ListArtikel;
            textBoxArtikelanzahl.Text = Convert.ToString(lager.Anzahl);
        }

        private void buttonLoeschen_Click(object sender, EventArgs e)
        {
            deselect = true;
            Artikel zuLoeschen = (Artikel)comboBoxArtikel.SelectedItem;
            lager.ArtikelLoeschen(zuLoeschen);
            aktualisieren();
            deselect=false;
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            lager.ArtikelSpeichern();
        }

        private void buttonLaden_Click(object sender, EventArgs e)
        {
            lager.ArtikelLaden();
            aktualisieren();
        }

        private void comboBoxArtikel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (deselect == false)
                {
                    Artikel anzeigen = (Artikel)comboBoxArtikel.SelectedItem;
                    textBoxArtikelbezeichnung.Text = anzeigen.Bezeichung;
                    textBoxArtikelnummer.Text = Convert.ToString(anzeigen.Nummer);
                    textBoxPreis.Text = Convert.ToString(anzeigen.Preis);
                }

            }
            catch (Exception ex)
            { }
        }
    }
}
