using System;
using System.Windows.Forms;

namespace Tehtävä_7___Autokululaskuri
{
    public partial class KilometrikulutuslaskuriFM : Form
    {
        public KilometrikulutuslaskuriFM()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double laina, nesteet, vakuutus, pesut, huollot, renkaat, muut, kilometrit, energia, kustannukset;

            laina = Convert.ToDouble(LainaTB.Text);
            nesteet = Convert.ToDouble(NesteetTB.Text);
            vakuutus = Convert.ToDouble(VakuutuksetTB.Text);
            pesut = Convert.ToDouble(PesutTB.Text);
            huollot = Convert.ToDouble(HuollotTB.Text);
            renkaat = Convert.ToDouble(RenkaatTB.Text);
            muut = Convert.ToDouble(MuutTB.Text);
            energia = Convert.ToDouble(PolttonesteTB.Text);
            kilometrit = Convert.ToDouble(KilometriCB.Text);

            kustannukset = (laina + nesteet + vakuutus + pesut + huollot + renkaat + energia + muut) / (kilometrit / 12);

            VastausLB.Text = "Kustannukset kilometriä kohti ovat: " + kustannukset;
            VastausLB.Visible = true;
        }
    }
}
