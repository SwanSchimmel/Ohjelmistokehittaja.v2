namespace _10_kysymystä
{
    public partial class VastauslomakeForm : Form
    {
        string[] vastaukset = new string[11]; // 0..10, 0 не используется
        string[] oikeat = new string[] { "", "B", "D", "A", "A", "C", "A", "B", "A", "C", "D" };
        int laskuri = 0;
        int oikea = 0;

        public VastauslomakeForm()
        {
            InitializeComponent();

            // Подписываем ВСЕ радиокнопки на ОДИН обработчик
            VastausARB.CheckedChanged += radioButton_CheckedChanged;
            VastausBRB.CheckedChanged += radioButton_CheckedChanged;
            VastausCRB.CheckedChanged += radioButton_CheckedChanged;
            VastausDRB.CheckedChanged += radioButton_CheckedChanged;

            // Начальный текст вопроса
            KysymysLB.Text = "Vastaus 1. kysymykseen:";
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Проверяем, что событие вызвано именно выбором (Checked == true)
            if (sender is RadioButton radioButton && radioButton.Checked && laskuri < 10)
            {
                // Сохраняем ответ (A, B, C или D)
                vastaukset[laskuri] = radioButton.Text;

                // Переходим к следующему вопросу
                laskuri++;

                // Обновляем текст вопроса
                if (laskuri < 10)
                {
                    KysymysLB.Text = "Vastaus " + (laskuri + 1) + ". kysymykseen:";
                }

                // Очищаем выбор для следующего вопроса
                TyhjäVastaus();  // снимаем галочку, но НЕ уменьшаем laskuri
            }

            // Когда ответов стало 10 — показываем результат
            if (laskuri >= 10)
            {
                VastausARB.Enabled = false;
                VastausBRB.Enabled = false;
                VastausCRB.Enabled = false;
                VastausDRB.Enabled = false;

                // Считаем правильные
                for (int j = 0; j < 10; j++)  // лучше с 0 по 9
                {
                    if (vastaukset[j] == oikeat[j + 1])  // т.к. oikeat[1] — первый вопрос
                    {
                        oikea++;
                    }
                }

                VastausLB.Text = "Oikeita vastauksia oli: " + oikea + " / 10";
                VastausLB.Visible = true;
                KysymysLB.Text = "Testi loppui!";
            }
        }

        private void TyhjäVastaus()
        {
            // Только снимаем галочку — НЕ трогаем laskuri!
            if (VastausARB.Checked) VastausARB.Checked = false;
            if (VastausBRB.Checked) VastausBRB.Checked = false;
            if (VastausCRB.Checked) VastausCRB.Checked = false;
            if (VastausDRB.Checked) VastausDRB.Checked = false;
        }

        // Пустые обработчики, которые генерирует дизайнер — можно оставить
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void VastauslomakeForm_Load(object sender, EventArgs e) { }
    }
}