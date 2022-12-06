namespace WinFormsAppHaustierVorlage
{
    public partial class Form1 : Form
    {
        Mensch mensch;
        Haustier haustier;
        public Form1()
        {
            InitializeComponent();
            mensch = new Mensch();
            haustier = new Haustier();
            mensch.schlechteLaune = beiSchlecherLauneMensch;
            mensch.guteLaune = beiGuterLauneMensch;
            haustier.schlechteLaune = beiSchlechterLauneHausTier;
            haustier.guteLaune = beiGuterLauneHausTier;
        }

        private void buttonArbeiten_Click(object sender, EventArgs e)
        {
            mensch.Arbeiten();
            haustier.MenschArbeitet();
        }

        private void beiSchlecherLauneMensch()
        {
            labelMenschLaune.BackColor = Color.Red;
            labelMenschLaune.Text = "Schlechte Laune";
        }

        private void beiGuterLauneMensch()
        { 
            labelMenschLaune.BackColor= Color.Green;
            labelMenschLaune.Text = "Gute Laune";
        }

        private void buttonHomeoffice_Click(object sender, EventArgs e)
        {
            mensch.Arbeiten();
            haustier.Homeoffice();
        }

        private void buttonUrlaub_Click(object sender, EventArgs e)
        {
            mensch.Urlaub();
            haustier.Urlaub();
        }

        private void buttonFuettern_Click(object sender, EventArgs e)
        {
            mensch.Fuettern();
            haustier.Fuettern();
        }

        private void buttonSaubermachen_Click(object sender, EventArgs e)
        {
            mensch.SauberMachen();
            haustier.SauberMachen();
        }

        private void beiSchlechterLauneHausTier()
        {

            labelTierLaune.BackColor = Color.Red;
            labelTierLaune.Text = "Schlechte Laune";
        }

        private void beiGuterLauneHausTier()
        {
            labelTierLaune.BackColor = Color.Green;
            labelTierLaune.Text = "Gute Laune";
        }
    }
}