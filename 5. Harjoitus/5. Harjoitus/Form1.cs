using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading.Tasks;   
using System.Text;

namespace _5._Harjoitus
{
    public partial class LukujenJarjestysFM : Form
    {
        List<int> jono = new List<int>();

        public LukujenJarjestysFM()
        {
            InitializeComponent();
        }

        private void uusiLukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (uusiLukuTB.Text == "-999")
                {
                    VastausLB.Text = "";

                    int[] array = jono.ToArray();

                    Array.Sort(array);

                    foreach (var member in array)
                    {
                        VastausLB.Text += member + " ";
                    }

                    VastausLB.Visible = true;
                }
                else
                {
                    jono.Add(Int32.Parse(uusiLukuTB.Text));
                    uusiLukuTB.Text = ""; 
                }
            }

            if (e.KeyChar == (char)Keys.Escape)
            {
                EmptyForm();
            }
        }

        private void EmptyForm()
        {
            uusiLukuTB.Text = "";
        }
    }
}