using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BruttoNettoRechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rechnen(double preis, double mwst,int rechnung)
        {
            double ergebnis = 0;

            if (rechnung == 1)
            {
                ergebnis = preis * mwst;
            }
            else if (rechnung == 2)
            { 
                ergebnis = preis / mwst;
            }

            textBoxErgebnis.Text = Convert.ToString(ergebnis);
        }

        private void buttonNettoBerechnen_Click(object sender, EventArgs e)
        {
            double preis = Convert.ToDouble(textBoxPreis.Text);

            if (radioButton7prozent.Checked == true)
            {
                rechnen(preis, 1.07,2);
            }
            else if (radioButton19prozent.Checked == true)
            {
                rechnen(preis, 1.19,2);
            }
            else
            {
                MessageBox.Show("Sie müssen noch einen Mehrwertsteuersatz auswählen!");
            }
        }

        private void buttonBruttoBerechnen_Click(object sender, EventArgs e)
        {
            double preis = Convert.ToDouble(textBoxPreis.Text);
            if (radioButton7prozent.Checked == true)
            {
                rechnen(preis, 1.07, 1);
            }
            else if (radioButton19prozent.Checked == true)
            {
                rechnen(preis, 1.19, 1);
            }
            else
            {
                MessageBox.Show("Sie müssen noch einen Mehrwertsteuersatz auswählen!");
            }
        }
    }
}
