namespace Tehtävät_9___Celcius_to_Fahrenheit
{
    public partial class AsteMuuninForm : Form
    {
        public AsteMuuninForm()
        {
            InitializeComponent();
        }

        private void muunaBT_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(AsteetTB.Text.Replace(",", "."), out double asteet))
            {
                VastausLB.Text = "Syötä kelvollinen luku (esim. 23.5 tai 23,5)";
                VastausLB.ForeColor = Color.Red;
                VastausLB.Visible = true;
                return;
            }

            double tulos;
            string yksikkoAlku, yksikkoLoppu;

            if (CelsiusRB.Checked)
            {
                tulos = asteet * 1.8 + 32;
                yksikkoAlku = "°C";
                yksikkoLoppu = "°F";
            }
            else if (FahrenheitRB.Checked)
            {
                tulos = (asteet - 32) / 1.8;
                yksikkoAlku = "°F";
                yksikkoLoppu = "°C";
            }
            else
            {
                VastausLB.Text = "Valitse muunnossuunta!";
                VastausLB.ForeColor = Color.DarkOrange;
                VastausLB.Visible = true;
                return;
            }

            VastausLB.Text = $"{asteet:F1} {yksikkoAlku} = {tulos:F1} {yksikkoLoppu}";
            VastausLB.ForeColor = Color.Navy;
            VastausLB.Visible = true;
        }
    }
}
