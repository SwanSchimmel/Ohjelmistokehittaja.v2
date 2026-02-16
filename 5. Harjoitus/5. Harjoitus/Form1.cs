
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _5._Harjoitus
{
    public partial class LukujenJarjestysFM : Form
    {
        private readonly List<int> jono = new List<int>();

        public LukujenJarjestysFM()
        {
            InitializeComponent();
        }
        private void uusiLukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;  

                string syote = uusiLukuTB.Text.Trim();

                if (syote == "-999")
                {
                    VastausLB.Text = "";  

                    int[] taulukko = jono.ToArray();     
                    Array.Sort(taulukko);                

                    foreach (var jasen in taulukko)
                    {
                        VastausLB.Text += jasen + "  ";  
                    }

                    VastausLB.Visible = true;            
                    // jono.Clear();                     // ← можно раскомментировать, если нужно очистить после вывода
                }
                else
                {
                    if (int.TryParse(syote, out int luku))
                    {
                        jono.Add(luku);
                        uusiLukuTB.Text = "";        
                    }
                    else
                    {
                        
                        VastausLB.Text = "Virhe: anna kokonaisluku!";
                        VastausLB.Visible = true;
                    }
                }
            }

            
            else if (e.KeyChar == (char)Keys.Escape)
            {
                TyhjaLomake();   
            }
        }

        private void TyhjaLomake()
        {
            uusiLukuTB.Text = "";
           
        }


    }
}
