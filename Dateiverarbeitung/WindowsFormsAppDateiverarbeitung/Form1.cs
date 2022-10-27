using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDateiverarbeitung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLaden_Click(object sender, EventArgs e)
        {

            try
            {
                //StreamReader sr = new StreamReader("test.txt", Encoding.UTF8);

                //while (sr.EndOfStream == false)
                //{
                //    string temp = sr.ReadLine();
                //    listBoxInhalt.Items.Add(temp);
                //}
                //sr.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Es ist was beim einlesen schief gelauften");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datei konnte nicht gelesen werden");
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            listBoxInhalt.Items.Add(textBoxEingabe.Text);
            textBoxEingabe.Text = null;
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("test.txt",true,Encoding.UTF8);

                for (int i = 0;  i < listBoxInhalt.Items.Count; i++)
                {
                    sw.WriteLine(listBoxInhalt.Items[i]);
                }
                sw.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Es ist was beim einlesen schief gelauften");
            }
        }
    }
}
