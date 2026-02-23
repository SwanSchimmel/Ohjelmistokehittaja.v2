using System.IO;

namespace _14._Tehtävä___päiväkirja
{
    public partial class PaivakirjaForm : Form
    {
        public PaivakirjaForm()
        {
            InitializeComponent();
            string teksti = File.ReadAllText("#");
            SyottoTB.Text = teksti;
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = "";
            teksti += SyottoTB.Text;
            teksti += DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";

            TextWriter text = new StreamWriter("#");
            text.Write(teksti);
            text.Close();
            Application.Exit();
        }
    }
}
