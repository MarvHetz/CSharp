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
        Eimer eimer = new Eimer(10);
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHinzufuegen_Click(object sender, EventArgs e)
        {
            int hinzufuegen = Convert.ToInt32(textBoxEingabe.Text);


        }

        private void buttonEimerLeeren_Click(object sender, EventArgs e)
        {

        }
    }
}
