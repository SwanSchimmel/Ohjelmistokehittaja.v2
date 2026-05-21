using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pizza_ordering_system
{
    public partial class CartForm : Form
    {
        public CartForm()
        {
            InitializeComponent();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"В корзине товаров: {Cart.Items.Count}", "Отладка");
            LoadCart();
        }

        private void LoadCart()
        {
            dataGridViewCart.DataSource = null;   // сбрасываем источник

            if (Cart.Items.Count == 0)
            {
                // Показываем сообщение, если корзина пуста
                // dataGridViewCart.Visible = false; // можно скрыть, если хочешь
                return;
            }

            dataGridViewCart.AutoGenerateColumns = true;
            dataGridViewCart.DataSource = Cart.Items;

            // Настройка колонок
            SetupGridColumns();
        }

        private void SetupGridColumns()
        {
            // Скрываем некрасивые колонки
            if (dataGridViewCart.Columns["Toppings"] != null)
                dataGridViewCart.Columns["Toppings"].Visible = false;

            // Красивые заголовки
            if (dataGridViewCart.Columns["Name"] != null)
                dataGridViewCart.Columns["Name"].HeaderText = "Название пиццы";

            if (dataGridViewCart.Columns["Size"] != null)
                dataGridViewCart.Columns["Size"].HeaderText = "Размер";

            if (dataGridViewCart.Columns["Quantity"] != null)
                dataGridViewCart.Columns["Quantity"].HeaderText = "Кол-во";

            if (dataGridViewCart.Columns["Price"] != null)
                dataGridViewCart.Columns["Price"].HeaderText = "Цена";

            dataGridViewCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewCart.CurrentRow == null || Cart.Items.Count == 0)
                return;

            int index = dataGridViewCart.CurrentRow.Index;
            if (index >= 0 && index < Cart.Items.Count)
            {
                Cart.Items.RemoveAt(index);
                LoadCart();
            }
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            if (Cart.Items.Count == 0)
            {
                MessageBox.Show("Корзина пуста!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PaymentForm paymentForm = new PaymentForm();
            paymentForm.Show();
            this.Hide();
        }
    }
}