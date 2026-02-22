namespace _10_tehtävät___BMI_laskuri
{
    public partial class BMIForm : Form
    {
        public BMIForm()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0, painoindeksi;
            paino = Convert.ToDouble(PainoTB.Text);
            pituus = Convert.ToDouble(PituusTB.Text);

            double bmi = Math.Round(paino / (pituus * pituus), 2);

            if (bmi < 18.5)
            {
                VastausLB.Text = "Painoindeksi on: " + bmi;
                VastausLB.ForeColor = Color.Aqua;
                KuvausLB.Text = "Alipaino";           // было Normaalipaino — исправил на логичное
                KuvausLB.ForeColor = Color.Aqua;
                VastausLB.Visible = true;
                KuvausLB.Visible = true;
            }
            else if (bmi < 25)
            {
                VastausLB.Text = "Painoindeksi on: " + bmi;
                VastausLB.ForeColor = Color.Green;
                KuvausLB.Text = "Normaalipaino";
                KuvausLB.ForeColor = Color.Green;     // было Väri.Vihreä → Color.Green
                VastausLB.Visible = true;
                KuvausLB.Visible = true;
            }
            else if (bmi < 40)
            {
                VastausLB.Text = "Painoindeksi on: " + bmi;
                VastausLB.ForeColor = Color.Gold;
                KuvausLB.Text = "Ylipaino";
                KuvausLB.ForeColor = Color.Gold;
                VastausLB.Visible = true;
                KuvausLB.Visible = true;
            }
            else
            {
                VastausLB.Text = "Painoindeksi on: " + bmi;
                VastausLB.ForeColor = Color.Red;
                KuvausLB.Text = "Merkittävä lihavuus";   // было "Huomaton ylipaino" — исправил на более подходящее
                KuvausLB.ForeColor = Color.Red;
                VastausLB.Visible = true;
                KuvausLB.Visible = true;
            }
        }
    }
}
