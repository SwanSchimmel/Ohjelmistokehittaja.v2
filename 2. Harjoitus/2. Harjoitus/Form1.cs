namespace _2._Harjoitus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TulostaBT_Click(object sender, EventArgs e)
        {
            string teksti = ViestiTB.Text.Trim();   

            if (string.IsNullOrWhiteSpace(teksti))
            {
                TulostusLB.Text = "Kirjoita jotain!";
            }
            else
            {
                TulostusLB.Text = teksti;
            }

            TulostusLB.Visible = true;
        }
    }
}
