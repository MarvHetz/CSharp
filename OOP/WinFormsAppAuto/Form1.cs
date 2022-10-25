namespace WinFormsAppAuto
{
    public partial class FormAutos : Form
    {
        AutoVerwaltung verwaltung;
        int index;
        Auto temp;
        public FormAutos()
        {
            InitializeComponent();
            verwaltung = new AutoVerwaltung();
        }

        private void buttonAutoErzeugen_Click(object sender, EventArgs e)
        {
            string kz = textBoxKZ.Text;
            int kilometerstand = Convert.ToInt32(textBoxKM.Text);
            double maxFuellmenge = Convert.ToDouble(textBoxFüllmenge.Text);
            double verbrauch = Convert.ToDouble(textBoxVerbrauch.Text);

            verwaltung.Erzeugen(kz,kilometerstand, maxFuellmenge, verbrauch);
            listBoxAutos.DataSource = null;
            listBoxAutos.DataSource = verwaltung.Autos;

            textBoxKZ.Text = null;
            textBoxFüllmenge.Text = null;
            textBoxKM.Text = null;
            textBoxVerbrauch.Text = null;
        }

        private void buttonAutoAnzeigen_Click(object sender, EventArgs e)
        {
            temp = verwaltung.Ausgabe(index);
            textBoxKZ.Text = temp.Kz;
            textBoxFüllmenge.Text = Convert.ToString(temp.MaxFuellmenge);
            textBoxKM.Text = Convert.ToString(temp.Kilometerstand);
            textBoxVerbrauch.Text = Convert.ToString(temp.Verbrauch);
        }

        private void listBoxAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = listBoxAutos.SelectedIndex;
        }
    }
}