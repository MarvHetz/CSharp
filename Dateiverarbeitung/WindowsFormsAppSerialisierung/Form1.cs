using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppSerialisierung
{
    public partial class Form1 : Form
    {
        Verwaltung verwaltung = new Verwaltung();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLaden_Click(object sender, EventArgs e)
        {
            //try
            //{
                listBoxInhalt.DataSource = verwaltung.lesen();
            //}
            //catch (Exception ex)
            //{ 
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void buttonHinzufügen_Click(object sender, EventArgs e)
        {
            string name = textBoxVorname.Text;
            string nachname = textBoxNachname.Text;
            DateTime geb = Convert.ToDateTime(textBoxGeburtsdatum.Text);
            listBoxInhalt.DataSource = null;
            listBoxInhalt.DataSource = verwaltung.hinzufügen(new Mensch(name, geb, nachname));
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            try
            {
                verwaltung.schreiben();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datei konnte nicht gefunden werden!");
            }
        }
    }
}