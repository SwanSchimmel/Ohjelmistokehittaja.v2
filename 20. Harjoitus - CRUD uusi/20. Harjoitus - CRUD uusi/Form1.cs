using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20.Harjoitus___CRUD_uusi
{
    public partial class TietotauluForm : Form
    {
        TietotauluDG.DataSource = OPISKELIJA.haeOpiskelijat();
        public TietotauluForm()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            bool onnistui = OPISKELIJA.lisääOpiskelija(
                EtunimiTB.Text,
                SukunimiTB.Text,
                PuhelinTB.Text,
                SähköpostiTB.Text,
                int.TryParse(IDTB.Text, out int nro) ? nro : 0
            );

            if (onnistui)
            {
                TietotauluDG.DataSource = OPISKELIJA.haeOpiskelijat();
                MessageBox.Show("Opiskelija lisätty!");
            }
            else
            {   
                MessageBox.Show("Lisäys epäonnistui.");
            }

            string enimi = EtunimiTB.Text.Trim();
            string snimi = SukunimiTB.Text.Trim();
            string puhelin = PuhelinTB.Text.Trim();
            string email = SähköpostiTB.Text.Trim();

            if (string.IsNullOrWhiteSpace(enimi) ||
                string.IsNullOrWhiteSpace(snimi) ||
                string.IsNullOrWhiteSpace(puhelin) ||
                string.IsNullOrWhiteSpace(email) ||
                !int.TryParse(ONroTB.Text.Trim(), out int oNro))
            {
                MessageBox.Show(
                    "Kaikki kentät ovat pakollisia!\nEtu- ja sukunimi, puhelin, sähköposti ja opiskelijanumero.",
                    "Virhe – tyhjiä kenttiä",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool onnistui = OPISKELIJA.lisääOpiskelija(enimi, snimi, puhelin, email, oNro);

            if (onnistui)
            {
                TietotauluDG.DataSource = OPISKELIJA.haeOpiskelijat();
                MessageBox.Show("Uusi opiskelija lisätty onnistuneesti!",
                    "Lisäys onnistui", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TyhjennäBT.PerformClick(); // очищаем поля после успеха
            }
            else
            {
                MessageBox.Show("Opiskelijan lisäys epäonnistui.",
                    "Virhe lisäyksessä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TyhjennäBT_Click(object sender, EventArgs e)
        {
            EtunimiTB.Text = "";
            SukunimiTB.Text = "";
            PuhelinTB.Text = "";
            SähköpostiTB.Text = "";
            ONroTB.Text = "";
            // Если есть поле для ID при редактировании
            if (IDTB != null) IDTB.Text = "";
        }

        private void PäivitäBT_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(IDTB?.Text.Trim(), out int oid) || oid <= 0)
            {
                MessageBox.Show("Valitse ensin rivi taulukosta (ID puuttuu tai virheellinen).",
                    "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string enimi = EtunimiTB.Text.Trim();
            string snimi = SukunimiTB.Text.Trim();
            string puhelin = PuhelinTB.Text.Trim();
            string email = SähköpostiTB.Text.Trim();

            if (string.IsNullOrWhiteSpace(enimi) ||
                string.IsNullOrWhiteSpace(snimi) ||
                string.IsNullOrWhiteSpace(puhelin) ||
                string.IsNullOrWhiteSpace(email) ||
                !int.TryParse(ONroTB.Text.Trim(), out int oNro))
            {
                MessageBox.Show("Kaikki kentät ovat pakollisia!",
                    "Virhe – tyhjiä kenttiä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool onnistui = OPISKELIJA.muokkaaOpiskelijaa(oid, enimi, snimi, puhelin, email, oNro);

            if (onnistui)
            {
                TietotauluDG.DataSource = OPISKELIJA.haeOpiskelijat();
                MessageBox.Show("Opiskelijan tiedot päivitetty onnistuneesti!",
                    "Päivitys onnistui", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TyhjennäBT.PerformClick();
            }
            else
            {
                MessageBox.Show("Päivitys epäonnistui.",
                    "Virhe päivityksessä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PoistaBT_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(IDTB?.Text.Trim(), out int oid) || oid <= 0)
            {
                MessageBox.Show("Valitse ensin poistettava opiskelija taulukosta.",
                    "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Haluatko varmasti poistaa opiskelijan?",
                "Vahvista poisto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool onnistui = OPISKELIJA.poistaOpiskelija(oid);

                if (onnistui)
                {
                    TietotauluDG.DataSource = OPISKELIJA.haeOpiskelijat();
                    MessageBox.Show("Opiskelija poistettu onnistuneesti.",
                        "Poisto onnistui", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TyhjennäBT.PerformClick();
                }
                else
                {
                    MessageBox.Show("Poisto epäonnistui.",
                        "Virhe poistossa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   
        }
    }
}
