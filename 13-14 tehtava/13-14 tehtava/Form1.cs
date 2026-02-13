using System;
using System.IO;
using System.Windows.Forms;

namespace _13_14_tehtava
{
    public partial class DiaryForm : Form
    {
        public DiaryForm()
        {
            InitializeComponent();
            paivakirjaTB.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string entry = $"{DateTime.Now:dd.MM.yyyy HH:mm} {paivakirjaTB.Text}";

            string path = "C:/Temp/paivakirja.txt";
            try
            {
                string? dir = Path.GetDirectoryName(path);
                if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

             
                using var writer = new StreamWriter(path, append: true);
                writer.WriteLine(entry);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Virhe tallennettaessa: {ex.Message}", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
