namespace _6._Harjoitus_salasana
{
    public partial class SalasananTarkastus : Form
    {
        public SalasananTarkastus()
        {
            InitializeComponent();
        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if(KayttajaTB.Text == "Jyri" && SalasanaTB.Text == "Ja@kk0Kulta")

            {

                SalasanaPanel.Visible = false;

                SalasanaOikeinPanel.Visible = true;

            }

            else

            {

                VirheviestiLB.Text = "Käyttäjätunnus tai salasana on virheellinen!";

                VirheviestiLB.Visible = true;

            }
        }
    }
}
