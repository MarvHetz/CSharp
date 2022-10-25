using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initialize();
        }

        private void initialize()
        { 
            Button b = new Button();
            b.Size = new System.Drawing.Size(59, 50);
            Font f = new Font("Microsoft Sans Serif", 30f);
            b.Font = f;
            
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                { 
                    tableLayoutPanelGameField.Controls.Add(b,i,j);
                }
            }
        }
    }
}
