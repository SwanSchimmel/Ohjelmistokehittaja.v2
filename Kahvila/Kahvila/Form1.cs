namespace Kahvila
{
    public partial class ruokalistaForm : Form
    {
        public ruokalistaForm()
        {
            InitializeComponent();
        }

        private void meitsaBT_Click(object sender, EventArgs e)
        {
            meistaLB.Visible = true;
            ruoatBT.Visible = false;
            juomatBT.Visible = false;
            herkutBT.Visible = false;
            koriBT.Visible = false;
        }

        private void ruoatBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruoatPL.Visible = true;
            juomatPL.Visible = false;
            herkutPL.Visible = false;
            koriPL.Visible = false;
        }

        private void juomatBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruoatPL.Visible = false;
            juomatPL.Visible = true;
            herkutPL.Visible = false;
            koriPL.Visible = false;
        }

        private void herkutBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruoatPL.Visible = false;
            juomatPL.Visible = false;
            herkutPL.Visible = true;
            koriPL.Visible = false;
        }

        private void koriBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruoatPL.Visible = false;
            juomatPL.Visible = false;
            herkutPL.Visible = false;
            koriPL.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        
    }
}
