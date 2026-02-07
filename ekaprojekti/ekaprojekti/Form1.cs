namespace ekaprojekti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
               textiLB.Text = "button";
               if(textiLB.Text == "button")
               {
                   textiLB.Text = "muuttui";
            }
        }
    }
}
