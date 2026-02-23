using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _13_14_tehtava
{
    public partial class _13_Tehtävä___koodi : Form
    {
        public _13_Tehtävä___koodi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VastausLB.Text = "";
            VastausLB.Visible = false;

            string nimi = NimiTB.Text.Trim();  // убираем лишние пробелы

            if (string.IsNullOrWhiteSpace(nimi))
            {
                VastausLB.Text = "Anna nimi ensin!";
                VastausLB.Visible = true;
                return;
            }

            try
            {
                string[] pojat = File.ReadAllLines("C:/Users/jyrili/source/repos/keudaope/Ohjelmoinninopiskelu/pojat.txt");
                string[] tytot = File.ReadAllLines("C:/Users/jyrili/source/repos/keudaope/Ohjelmoinninopiskelu/tytot.txt");

                int sijoitusP = 1;   // позиция среди мальчиков
                int sijoitusT = 1;   // позиция среди девочек

                bool loytyi = false;

                // Поиск среди мальчиков
                foreach (string poika in pojat)
                {
                    if (string.Equals(nimi, poika.Trim(), StringComparison.OrdinalIgnoreCase))
                    {
                        VastausLB.Text = $"Nimesi on {sijoitusP}. suosituin poikien nimi vuonna 2020";
                        VastausLB.Visible = true;
                        loytyi = true;
                        break;  // нашли → дальше не ищем
                    }
                    sijoitusP++;
                }

                // Поиск среди девочек (только если не нашли среди мальчиков)
                if (!loytyi)
                {
                    foreach (string tyttö in tytot)
                    {
                        if (string.Equals(nimi, tyttö.Trim(), StringComparison.OrdinalIgnoreCase))
                        {
                            VastausLB.Text = $"Nimesi on {sijoitusT}. suosituin tyttöjen nimi vuonna 2020";
                            VastausLB.Visible = true;
                            loytyi = true;
                            break;
                        }
                        sijoitusT++;
                    }
                }

                // Если вообще нигде не нашли
                if (!loytyi)
                {
                    VastausLB.Text = "Nimesi ei löydy suosituimpien nimien joukosta! :-(";
                    VastausLB.Visible = true;
                }
            }
            catch (Exception ex)
            {
                VastausLB.Text = "Virhe tiedoston lukemisessa: " + ex.Message;
                VastausLB.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
