using System.IO;          // для работы с файлами
using System.Drawing;     // для шрифтов, кистей
using System.Drawing.Printing;  // для печати

namespace _17._Tehtävä___Muistio
{
    public partial class Muisto : Form
    {
        private string tiedostoPolku = "";
        public Muisto()
        {
            InitializeComponent();
        }

        private void ctrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (rikasTB.Modified)
            {
                DialogResult dr = MessageBox.Show("Сохранить изменения?", "Muistio",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                    tallennaToolStripMenuItem_Click(sender, e);  // вызываем сохранение
                else if (dr == DialogResult.Cancel)
                    return;  // ничего не делаем
            }

            rikasTB.Clear();           // стираем весь текст
            tiedostoPolku = "";        // забываем файл
            this.Text = "Muistio - Новый";  // обновляем заголовок
            rikasTB.Modified = false;
        }



        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog atk = new OpenFileDialog()
            {
                Filter = "Rich Text Format|*.rtf",
                ValidateNames = true,
                Multiselect = false
            })
            {
                if (atk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader vl = new StreamReader(atk.FileName))
                    {
                        tiedostoPolku = atk.FileName;
                        Task<string> teksti = vl.ReadToEndAsync();
                        rikasTB.Rtf = teksti.Result;
                    }
                }
            }
        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tiedostoPolku))
            {
                tallennaNimellaToolStripMenuItem_Click(sender, e);  // если нет имени → "Сохранить как"
                return;
            }

            using (StreamWriter sw = new StreamWriter(tiedostoPolku))
            {
                sw.Write(rikasTB.Rtf);  // снова .Rtf — сохраняем с форматированием
            }

            rikasTB.Modified = false;
            this.Text = this.Text.Replace("*", "");  // убираем звёздочку, если была
        }

        private void tallennaNimellaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void tulostuksenEsikatseluToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tallennaNimelläToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "RTF файлы (*.rtf)|*.rtf|Все файлы (*.*)|*.*";
                sfd.DefaultExt = "rtf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    tiedostoPolku = sfd.FileName;

                    using (StreamWriter sw = new StreamWriter(tiedostoPolku))
                    {
                        sw.Write(rikasTB.Rtf);
                    }

                    this.Text = "Muistio - " + Path.GetFileName(tiedostoPolku);
                    rikasTB.Modified = false;
                }
            }
        }

        private void tulostaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)

            {
                printDocument1.Print();

            }

        }


        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rikasTB.Modified)
            {
                DialogResult dr = MessageBox.Show("Сохранить перед выходом?", "Muistio",
                    MessageBoxButtons.YesNoCancel);

                if (dr == DialogResult.Yes) tallennaToolStripMenuItem_Click(sender, e);
                if (dr == DialogResult.Cancel) return;
            }

            Application.Exit();
        }

        private void kumoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Undo();
        }

        private void teeUudelleenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Redo();
        }

        private void leikkaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Cut();
        }

        // Аналогично для Copy, Paste, SelectAll.
        private void poistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.SelectedText = "";
        }

        private void tietoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "By Me",
                "Tietoa",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
