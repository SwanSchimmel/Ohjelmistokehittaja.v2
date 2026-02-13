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
            vastausLB.Text = string.Empty;
            vastausLB.Visible = false;

            string pojatPath = "C:/Users/jyrili/source/repos/keudaope/Ohjelmoinninopiskelu/pojat.txt";
            string tytotPath = "C:/Users/jyrili/source/repos/keudaope/Ohjelmoinninopiskelu/tytot.txt";

            try
            {
                string[] pojat = File.Exists(pojatPath) ? File.ReadAllLines(pojatPath) : Array.Empty<string>();
                string[] tytot = File.Exists(tytotPath) ? File.ReadAllLines(tytotPath) : Array.Empty<string>();

                string nimi = nimiTB.Text?.Trim() ?? string.Empty;
                if (string.IsNullOrEmpty(nimi))
                {
                    MessageBox.Show("Anna nimi.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                for (int i = 0; i < pojat.Length; i++)
                {
                    if (string.Equals(nimi, pojat[i], StringComparison.OrdinalIgnoreCase))
                    {
                        vastausLB.Text = $"Nimesi on {i + 1}. suosituin poikien nimi vuonna 2020";
                        vastausLB.Visible = true;
                        return;
                    }
                }

                for (int i = 0; i < tytot.Length; i++)
                {
                    if (string.Equals(nimi, tytot[i], StringComparison.OrdinalIgnoreCase))
                    {
                        vastausLB.Text = $"Nimesi on {i + 1}. suosituin tyttöjen nimi vuonna 2020";
                        vastausLB.Visible = true;
                        return;
                    }
                }

                vastausLB.Text = "Nimesi ei löytynyt suosituimpien nimien joukosta! :-(";
                vastausLB.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tiedoston käsittelyssä tapahtui virhe: {ex.Message}", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
