using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppBibliothek
{
    public partial class FormBibliothek : Form
    {
        private BibVerwaltung verwaltung;
        public FormBibliothek()
        {
            InitializeComponent();

            verwaltung = new BibVerwaltung();
            comboBoxBücher.DataSource = verwaltung.Bücherliste;
        }

        private void buttonAusleihen_Click(object sender, EventArgs e)
        {
            Buch b = (Buch)comboBoxBücher.SelectedItem;
            b.Ausleihen();
            MessageBox.Show("Buch wurde erfolgreich ausgeliehen");
        }

        private void buttonZurückgeben_Click(object sender, EventArgs e)
        {
            Buch b = (Buch)comboBoxBücher.SelectedItem;
            b.Zurückgeben();
            MessageBox.Show("Buch wurde erfolgreich zurückgegeben");
        }

        private void comboBoxBücher_SelectedIndexChanged(object sender, EventArgs e)
        {
            Buch b = (Buch)comboBoxBücher.SelectedItem;

            if (b.Ausgeliehen == true)
            {
                labelVerliehen.Text = "nicht verfügbar";
                buttonAusleihen.Enabled = false;
                buttonZurückgeben.Enabled = true;
            }
            else
            {
                labelVerliehen.Text = "verfügbar";
                buttonAusleihen.Enabled = true;
                buttonZurückgeben.Enabled = false;
            }
        }
    }
}
