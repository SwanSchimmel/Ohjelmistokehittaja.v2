namespace _3._Harjoitus
{
    public partial class Laskin : Form
    {
        public Laskin()
        {
            InitializeComponent();
        }

        private void LukuYksiTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(LukuYksiTB.Text, out double luku1) ||
                !double.TryParse(LukuKaksiTB.Text, out double luku2))
            {
                VastausLB.Text = "Virheellinen luku!";
                VastausLB.Visible = true;
                return;
            }

            if (string.IsNullOrEmpty(LaskutoimitusCB.Text))
            {
                VastausLB.Text = "Valitse laskutoimitus!";
                VastausLB.Visible = true;
                return;
            }

            double vastaus;

            switch (LaskutoimitusCB.Text)
            {
                case "+":
                    vastaus = luku1 + luku2;
                    break;

                case "-":
                    vastaus = luku1 - luku2;
                    break;

                case "*":
                    vastaus = luku1 * luku2;
                    break;

                case "/":
                    if (luku2 == 0)
                    {
                        VastausLB.Text = "Ei voi jakaa nollalla!";
                        VastausLB.Visible = true;
                        return;
                    }
                    vastaus = luku1 / luku2;
                    break;

                default:
                    VastausLB.Text = "Tuntematon operaattori";
                    VastausLB.Visible = true;
                    return;
            }

            
            VastausLB.Text = vastaus % 1 == 0
                ? vastaus.ToString("0")
                : vastaus.ToString("0.00");

            VastausLB.Visible = true;
        }
    }
}
