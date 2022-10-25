using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppListen
{
    public partial class Form1 : Form
    {
        List<Schüler> schüler;
        public int index = 0;
        Schüler temp;
        public Form1()
        {
            InitializeComponent();
            schüler = new List<Schüler>();
        }

        private void buttonAufnehmen_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            DateTime geb = Convert.ToDateTime(textBoxGeb.Text);
            string wohnort = textBoxWohnort.Text;

            schüler.Add(new Schüler(name,geb,wohnort));


            listSchüler.DataSource = null;
            listSchüler.DataSource = schüler;

            textBoxName.Text = null;
            textBoxGeb.Text = null;
            textBoxWohnort.Text = null;
        }

        private void buttonEntlassen_Click(object sender, EventArgs e)
        {
            schüler.RemoveAt(index);

            listSchüler.DataSource = null;
            listSchüler.DataSource = schüler;
        }

        private void listSchüler_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = listSchüler.SelectedIndex;
            temp = (Schüler)listSchüler.SelectedItem;

            textBoxName.Text = temp.Name;
            textBoxGeb.Text = Convert.ToString(temp.Geb);
            textBoxWohnort.Text = temp.Wohnort;
        }
    }
}
