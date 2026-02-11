using System.IO;

namespace _13_14_tehtava
{
    public partial class DiaryForm : Form
    {
        public DiaryForm()
        {
            InitializeComponent();
            string teksti = "";
            paivakirjaTB.Text = teksti;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string teksti = "";

            teksti += paivakirjaTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";

            TextWriter text = new StreamWriter("C:/Temp/paivakirja.txt");
            text.Write(teksti);
            text.Close();
            Application.Exit();
        }
    }
}
