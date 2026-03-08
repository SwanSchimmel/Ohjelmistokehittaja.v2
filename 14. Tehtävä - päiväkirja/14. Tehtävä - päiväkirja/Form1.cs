using System;
using System.IO;

namespace _14._Tehtävä___päiväkirja
{
    public partial class PaivakirjaForm : Form
    {
        public PaivakirjaForm()
        {
            InitializeComponent();
            string teksti = File.ReadAllText(@"C:\Users\swans\Documents\GitHub\source\repos\NewRepo\14. Tehtävä - päiväkirja\TEXT.txt");
            SyottoTB.Text = teksti;
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = "";
            teksti += SyottoTB.Text;
            teksti += DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";

            TextWriter text = new StreamWriter(@"C:\Users\swans\Documents\GitHub\source\repos\NewRepo\14. Tehtävä - päiväkirja\TEXT.txt");
            text.Write(teksti);
            text.Close();
            Application.Exit();
        }
    }
}
