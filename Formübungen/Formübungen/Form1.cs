using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formübungen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBerechnen_Click(object sender, EventArgs e)
        {
            int ergebnis = Convert.ToInt32(textBoxEingabe.Text);
            ergebnis *= ergebnis;
            textBoxQuadratzahl.Text = Convert.ToString(ergebnis);
        }
    }
}
