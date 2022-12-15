using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppQuiz
{
    public partial class Form1 : Form
    {
        private FrageVerwaltung frageVerwaltung;
        public Form1()
        {
            InitializeComponent();
            frageVerwaltung = new FrageVerwaltung();
            comboBoxFragen.DataSource = frageVerwaltung.Fragen;
        }

        private void comboBoxFragen_SelectedIndexChanged(object sender, EventArgs e)
        {
            Frage fragen = (Frage) comboBoxFragen.SelectedItem;
            listBoxAntworten.DataSource = fragen.Antworten;
        }
    }
}
