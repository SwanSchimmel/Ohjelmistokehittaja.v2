namespace _16_Tehtävä___Ajastin
{
    public partial class laskuri : Form
    {
        private int kokonaisaika;

        public laskuri()
        {
            InitializeComponent();

            // Populate minute and second combo boxes once to avoid null SelectedItem
            for (int i = 0; i < 60; i++)
            {
                minuutitCB.Items.Add(i.ToString());
                sekunnitCB.Items.Add(i.ToString());
            }
            minuutitCB.SelectedIndex = 0;
            sekunnitCB.SelectedIndex = 10;

            aikaLB.Text = "00:00";
        }



        private void startBT_Click(object sender, EventArgs e)
        {
            startBT.Enabled = false;
            stopBT.Enabled = true;
            int minuutit = int.Parse(minuutitCB.SelectedItem.ToString());
            int sekunnit = int.Parse(sekunnitCB.SelectedItem.ToString());
            kokonaisaika = minuutit * 60 + sekunnit;
            AjastinTM.Enabled = true;
        }

        private void stopBT_Click(object sender, EventArgs e)
        {
            startBT.Enabled = true;
            stopBT.Enabled = false;
            kokonaisaika = 0;
            AjastinTM.Enabled = false;
            aikaLB.Text = "00:00";
        }

        private void AjastinTM_Tick(object sender, EventArgs e)
        {
            if (kokonaisaika > 0)
            {
                kokonaisaika--;
                int minuutit = kokonaisaika / 60;
                int sekunnit = kokonaisaika - (minuutit * 60);
                aikaLB.Text = $"{minuutit:00}:{sekunnit:00}";
            }
            else
            {
                // Stop the timer and reset state
                AjastinTM.Enabled = false;
                kokonaisaika = 0;
                aikaLB.Text = "00:00";
                MessageBox.Show("Aika on kulunut!");
                startBT.Enabled = true;
                stopBT.Enabled = false;
            }
        }

        private void aikaLB_Click(object sender, EventArgs e)
        {
            // Intentionally left blank - comboboxes are populated in the constructor
            stopBT.Enabled = false;
        }

        private void minuutitCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
