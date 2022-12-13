using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEimer
{
    public partial class Form1 : Form
    {
        Eimer eimer;
        public Form1()
        {
            InitializeComponent();
            eimer = new Eimer(10);
            eimer.onFillError += FillErrorMessage;
            textBox1.Text = Convert.ToString(eimer.AktFuellmenge);
        }

        private void buttonHinzufuegen_Click(object sender, EventArgs e)
        {
            int hinzufuegen = Convert.ToInt32(textBoxEingabe.Text);
            panelFuellstand.Height -= (panelMaxFuellstand.Height / eimer.MaxFuellmenge) * hinzufuegen;
            eimer.Einfuellen(hinzufuegen);
            textBox1.Text = Convert.ToString(eimer.AktFuellmenge);

        }

        private void buttonEimerLeeren_Click(object sender, EventArgs e)
        {
            panelFuellstand.Height = panelMaxFuellstand.Height;
        }

        private void FillErrorMessage(string fehlermeldung)
        {
            MessageBox.Show(fehlermeldung);
        }
    }
}
