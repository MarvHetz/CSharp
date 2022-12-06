using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HausTierManager
{
    public partial class Form1 : Form
    {
        Controller controller;
        public Form1()
        {
            InitializeComponent();
            controller = new Controller();
            update();
        }

        private void buttonFüttern_Click(object sender, EventArgs e)
        {

        }

        private void buttonImpfen_Click(object sender, EventArgs e)
        {
            Tier tier = (Tier)comboBoxTiere.SelectedItem;
            try
            {
                controller.Impfen(tier);
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonNeuesTier_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            double gewicht = Convert.ToDouble(textBoxGewicht.Text);
            int typ;
            int hundesteuernummer;

            if (radioButtonHund.Checked == true)
            {
                typ = 0;
                hundesteuernummer = Convert.ToInt32(textBoxHundesteuer.Text);
            }
            else if (radioKatze.Checked == true)
            {
                typ = 1;
                hundesteuernummer = 0;
            }
            else
            {
                typ = 2;
                hundesteuernummer = 0;
            }

            controller.tierHinzufuegen(name, gewicht, hundesteuernummer, typ);
            update();
        }

        private void comboBoxTiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxTiere.Items.Clear();
            Tier tier = (Tier) comboBoxTiere.SelectedItem;
            listBoxTiere.Items.Add(controller.AnzeigenTier(tier));
        }

        private void update()
        {
            comboBoxTiere.DataSource = null;
            comboBoxTiere.DataSource = controller.TierList;
        }

        private void radioButtonHund_CheckedChanged(object sender, EventArgs e)
        {
            textBoxHundesteuer.Enabled = true;
        }

        private void radioKatze_CheckedChanged(object sender, EventArgs e)
        {
            textBoxHundesteuer.Enabled = false;
        }

        private void radioButtonRasseKatze_CheckedChanged(object sender, EventArgs e)
        {
            textBoxHundesteuer.Enabled = false;
        }
    }
}
