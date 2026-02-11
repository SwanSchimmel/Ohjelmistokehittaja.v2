using System.Diagnostics;

namespace _15._Tehtävä___Sekuntikello
{
    public partial class sekkariForm : Form
    {
        private Stopwatch sekkari;
        public sekkariForm()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            sekkari.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sekkari.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sekkari.Reset();
        }

        private void ajanottoTM_Tick(object sender, EventArgs e)
        {
            aikaLB.Text = sekkari.Elapsed.ToString(@"hh\:mm\:ss\.fff");
        }

        private void sekkariForm_Load(object sender, EventArgs e)
        {
            sekkari = new Stopwatch();
        }
    }
}
