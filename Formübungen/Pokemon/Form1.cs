using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Pokemon
{
    public partial class Form1 : Form
    {
        string[] array;
        SoundPlayer sPlayer = new SoundPlayer(@"Musik/Pummeluff.wav");
        public Form1()
        {
            InitializeComponent();
            foreach (EnumPokemon pokemon in Enum.GetValues(typeof(EnumPokemon)))
            { 
                comboBoxPokemons.Items.Add(pokemon);
            }
            array = new string[4] { @"Bilder/pummeluff.png", @"Bilder/karnimani.png",@"Bilder/felilou.png",@"Bilder/pikachu.png"};
        }

        private void comboBoxPokemons_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(comboBoxPokemons.SelectedIndex);

            pictureBoxPokemons.Image = Image.FromFile(array[index]);

            pictureBoxPokemons.SizeMode = PictureBoxSizeMode.StretchImage;

            if ((EnumPokemon)comboBoxPokemons.SelectedItem == EnumPokemon.Pummeluff)
            {
                sPlayer.Play();
            }
            else
            {
                sPlayer.Stop();

            }
        }
    }
}
