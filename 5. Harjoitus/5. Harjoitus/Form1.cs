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

        


        // Событие срабатывает при каждом нажатии клавиши в текстовом поле
        private void uusiLukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Реагируем только на Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Предотвращаем звук "динь" и перенос строки
                e.Handled = true;

                string syote = uusiLukuTB.Text.Trim();

                if (syote == "-999")
                {
                    if (jono.Count == 0)
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



