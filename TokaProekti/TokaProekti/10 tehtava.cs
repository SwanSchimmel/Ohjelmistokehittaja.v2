using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokaProekti
{
    public partial class BMIForm : Form
    {
        public BMIForm()
        {
            InitializeComponent();
        }

        private void _10_tehtava_Load(object sender, EventArgs e)
        {

        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0, painoindeksi;
            paino = Convert.ToDouble(painoTB.Text);
            pituus = Convert.ToDouble(pituusTB.Text);
            painoindeksi = Math.Round(paino / (pituus * pituus), 2);
            if (painoindeksi < 18.5)
            {
                
            }
            else if (painoindeksi >= 18.5 && painoindeksi < 25)
            {
                label3.Text = $"Painoindeksisi on {painoindeksi} ja painosi on normaalipainoinen.";
            }
            else if (painoindeksi >= 25 && painoindeksi < 30)
            {
                label3.Text = $"Painoindeksisi on {painoindeksi} ja olet ylipainoinen.";
            }
            else
            {
                label3.Text = $"Painoindeksisi on {painoindeksi} ja olet lihava.";
            }
        }
    }
}
