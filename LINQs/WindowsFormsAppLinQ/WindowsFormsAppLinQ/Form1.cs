using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLinQ
{
    public partial class Form1 : Form
    {
        private List<int> noten;
        public Form1()
        {
            InitializeComponent();
            noten = new List<int>();
            sotiere();
        }

        private void sotiere()
        {
            var groesser3 = from n in noten where n > 3 select n;
            listBoxGroesser3.Items.Add(groesser3);
            var kleinerGleich3 = from n in noten where n <= 3 select n;
            listBoxKleinerGleich3.Items.Add(kleinerGleich3);
        }
    }
}
