namespace Tehtävä_8___Roomalaiset_nrot
{
    public partial class RoomalasiksiForm : Form
    {
        public RoomalasiksiForm()
        {
            InitializeComponent();
        }

        private void MuutaBT_Click(object sender, EventArgs e)
        {
            int luku1 = 0, luku2 = 0, luku3 = 0, luku4 = 0;
            string vastaus = "";

            // Проверяем длину ввода (число как строка)
            if (TekstiTB.Text.Length > 3) // Для чисел 1000–3999 (4 цифры)
            {
                luku1 = Convert.ToInt32(TekstiTB.Text.Substring(0, 1)); // Тысячи
                luku2 = Convert.ToInt32(TekstiTB.Text.Substring(1, 1)); // Сотни
                luku3 = Convert.ToInt32(TekstiTB.Text.Substring(2, 1)); // Десятки
                luku4 = Convert.ToInt32(TekstiTB.Text.Substring(3, 1)); // Единицы

                // Для тысяч (M = 1000)
                if (luku1 % 3 == 0 && luku1 != 0)
                {
                    vastaus += "MMM"; // 3000
                }
                else if (luku1 % 2 == 0 && luku1 != 0)
                {
                    vastaus += "MM"; // 2000
                }
                else if (luku1 % 1 == 0 && luku1 != 0)
                {
                    vastaus += "M"; // 1000
                }
                else
                {
                    vastaus += "";
                }

                vastaus += Sataset(luku2); // Добавляем сотни
                vastaus += Kympit(luku3);  // Добавляем десятки
                vastaus += Ykkoset(luku4); // Добавляем единицы
            }
            else if (TekstiTB.Text.Length > 2) // Для чисел 100–999 (3 цифры)
            {
                luku2 = Convert.ToInt32(TekstiTB.Text.Substring(0, 1)); // Сотни
                luku3 = Convert.ToInt32(TekstiTB.Text.Substring(1, 1)); // Десятки
                luku4 = Convert.ToInt32(TekstiTB.Text.Substring(2, 1)); // Единицы

                vastaus += Sataset(luku2);
                vastaus += Kympit(luku3);
                vastaus += Ykkoset(luku4);
            }
            else if (TekstiTB.Text.Length > 1) // Для чисел 10–99 (2 цифры)
            {
                luku3 = Convert.ToInt32(TekstiTB.Text.Substring(0, 1)); // Десятки
                luku4 = Convert.ToInt32(TekstiTB.Text.Substring(1, 1)); // Единицы

                vastaus += Kympit(luku3);
                vastaus += Ykkoset(luku4);
            }
            else if (TekstiTB.Text.Length > 0) // Для чисел 1–9 (1 цифра)
            {
                luku4 = Convert.ToInt32(TekstiTB.Text.Substring(0, 1)); // Единицы

                vastaus += Ykkoset(luku4);
            }

            VastausLB.Text = vastaus;
            VastausLB.Visible = true;
        }

        // Функция для сотен (C=100, D=500)
        private string Sataset(int luku)
        {
            if (luku % 9 == 0 && luku != 0)
            {
                return "CM"; // 900
            }
            else if (luku % 8 == 0 && luku != 0)
            {
                return "DCCC"; // 800
            }
            else if (luku % 7 == 0 && luku != 0)
            {
                return "DCC"; // 700
            }
            else if (luku % 6 == 0 && luku != 0)
            {
                return "DC"; // 600
            }
            else if (luku % 5 == 0 && luku != 0)
            {
                return "D"; // 500
            }
            else if (luku % 4 == 0 && luku != 0)
            {
                return "CD"; // 400
            }
            else if (luku % 3 == 0 && luku != 0)
            {
                return "CCC"; // 300
            }
            else if (luku % 2 == 0 && luku != 0)
            {
                return "CC"; // 200
            }
            else if (luku % 1 == 0 && luku != 0)
            {
                return "C"; // 100
            }
            else
            {
                return "";
            }
        }

        // Функция для десятков (X=10, L=50)
        private string Kympit(int luku)
        {
            if (luku % 9 == 0 && luku != 0)
            {
                return "XC"; // 90
            }
            else if (luku % 8 == 0 && luku != 0)
            {
                return "LXXX"; // 80
            }
            else if (luku % 7 == 0 && luku != 0)
            {
                return "LXX"; // 70
            }
            else if (luku % 6 == 0 && luku != 0)
            {
                return "LX"; // 60
            }
            else if (luku % 5 == 0 && luku != 0)
            {
                return "L"; // 50
            }
            else if (luku % 4 == 0 && luku != 0)
            {
                return "XL"; // 40
            }
            else if (luku % 3 == 0 && luku != 0)
            {
                return "XXX"; // 30
            }
            else if (luku % 2 == 0 && luku != 0)
            {
                return "XX"; // 20
            }
            else if (luku % 1 == 0 && luku != 0)
            {
                return "X"; // 10
            }
            else
            {
                return "";
            }
        }

        // Функция для единиц (I=1, V=5) — аналогично, но не показана в твоём коде, добавлю по логике
        private string Ykkoset(int luku)
        {
            if (luku % 9 == 0 && luku != 0)
            {
                return "IX"; // 9
            }
            else if (luku % 8 == 0 && luku != 0)
            {
                return "VIII"; // 8
            }
            else if (luku % 7 == 0 && luku != 0)
            {
                return "VII"; // 7
            }
            else if (luku % 6 == 0 && luku != 0)
            {
                return "VI"; // 6
            }
            else if (luku % 5 == 0 && luku != 0)
            {
                return "V"; // 5
            }
            else if (luku % 4 == 0 && luku != 0)
            {
                return "IV"; // 4
            }
            else if (luku % 3 == 0 && luku != 0)
            {
                return "III"; // 3
            }
            else if (luku % 2 == 0 && luku != 0)
            {
                return "II"; // 2
            }
            else if (luku % 1 == 0 && luku != 0)
            {
                return "I"; // 1
            }
            else
            {
                return "";
            }
        }
    }
}
