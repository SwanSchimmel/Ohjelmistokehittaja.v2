using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _5._Harjoitus
{
    public partial class LukujenJarjestysFM : Form
    {

        // хранение введённых чисел
        private List<int> jono = new List<int>();
        public LukujenJarjestysFM()
        {
            InitializeComponent();
        }
        private void uusiLukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Пользователь нажал Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;  // убираем стандартный "бип" Windows

                string syote = uusiLukuTB.Text.Trim();

                if (syote == "-999")
                {
                    // Режим завершения → сортируем и показываем
                    VastausLB.Text = "";  // очищаем предыдущий результат

                    int[] taulukko = jono.ToArray();     // копируем список в массив
                    Array.Sort(taulukko);                // сортируем по возрастанию

                    foreach (var jasen in taulukko)
                    {
                        VastausLB.Text = "Список пустой";
                    }
                    else
                    {
                        // Преобразуем список в массив и сортируем
                        int[] taulukko = jono.ToArray();
                        Array.Sort(taulukko);

                        // Формируем строку для вывода
                        VastausLB.Text = "Отсортировано: " + string.Join("  ", taulukko);
                    }

                    VastausLB.Visible = true;
                    // Можно очистить список после вывода (по желанию)
                    // jono.Clear();
                }
                else
                {
                    if (int.TryParse(syote, out int luku))
                    {
                        jono.Add(luku);
                        uusiLukuTB.Clear();           // очищаем поле после добавления
                    }
                    else
                    {
                        MessageBox.Show("Введите целое число!", "Ошибка");
                    }
                }
            }
            // Дополнительно — Esc очищает поле
            else if (e.KeyChar == (char)Keys.Escape)
            {
                uusiLukuTB.Clear();
                e.Handled = true;
            }
        }
    }
}



