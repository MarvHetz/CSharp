using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMIrechner
{
    public partial class FormGUI : Form
    {
        public FormGUI()
        {
            InitializeComponent();
        }

        private void buttonBerechnen_Click(object sender, EventArgs e)
        {
            float gewicht = Convert.ToSingle(textBoxGewicht.Text);
            float groesse = Convert.ToSingle(textBoxGröße.Text);

            float bmi = gewicht / (groesse * groesse);

            if (bmi < 20)
            { 
                textBoxErgebnis.Text = "Sie sind untergewichtig: "+Convert.ToString(bmi);
                pictureBoxBild.Image = Image.FromFile(@"H:\C#\Formübungen\BMIrechner\Bilder\untergewicht.jpg");
            }
            else if (bmi > 25)
            {
                textBoxErgebnis.Text = "Sie sind übergewichtig: " + Convert.ToString(bmi);
                MessageBox.Show("Sie sind übergewichtig!");
                pictureBoxBild.ClientSize = new Size(200, 200);
                pictureBoxBild.Image = Image.FromFile(@"H:\C#\Formübungen\BMIrechner\Bilder\übergewicht.jpg");
            }
            else
            {
                textBoxErgebnis.Text = "Sie sind Normal gewichtig: " + Convert.ToString(bmi);
            }
        }
    }
}
