namespace _4._Harjoitus
{
    public partial class IkaLaskuriFM : Form
    {
        public IkaLaskuriFM()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            DateTime synttari = SynttariDTP.Value;
            DateTime nyt = DateTime.Now;

            if (synttari > nyt)
            {
                MessageBox.Show("Syntymäaika ei voi olla tulevaisuudessa!", "Virhe");
                return;
            }

            TimeSpan ero = nyt - synttari;

            double paivat = ero.TotalDays;
            double vuodet = Math.Floor(paivat / 365.2425);
            double kuukaudet = Math.Floor(paivat / 30.436875);
            double tunnit = ero.TotalHours;
            double minuutit = ero.TotalMinutes;
            double sekunnit = ero.TotalSeconds;

            VuosinaLB.Text = $"{vuodet:F0} vuotta";
            KuukausinaLB.Text = $"{kuukaudet:F0} kuukautta";
            PaivinaLB.Text = $"{Math.Floor(paivat):F0} päivää";
            TunteinaLB.Text = $"{Math.Floor(tunnit):N0} tuntia";
            MinuutteinaLB.Text = $"{Math.Floor(minuutit):N0} minuuttia";
            SekunteinaLB.Text = $"{Math.Floor(sekunnit):N0} sekuntia";
        }

        private void MinuutteinaLB_Click(object sender, EventArgs e)
        {

        }
    }
}
