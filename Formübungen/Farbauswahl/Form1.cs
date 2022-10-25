using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farbauswahl
{
    public partial class FormFarbauswahl : Form
    {
        public FormFarbauswahl()
        {
            InitializeComponent();
            comboBoxFarbe.Items.Add(EnumFarbe.blau);
            comboBoxFarbe.Items.Add(EnumFarbe.gelb);
            comboBoxFarbe.Items.Add(EnumFarbe.rot);
        }

        private void comboBoxFarbe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((EnumFarbe)comboBoxFarbe.SelectedItem == EnumFarbe.blau)
            {
                this.BackColor = Color.Blue;
            }
            else if ((EnumFarbe)comboBoxFarbe.SelectedItem == EnumFarbe.gelb)
            {
                this.BackColor = Color.Yellow;
            }
            else if ((EnumFarbe)comboBoxFarbe.SelectedItem == EnumFarbe.rot)
            { 
                this.BackColor= Color.Red;
            }
        }
    }
}
