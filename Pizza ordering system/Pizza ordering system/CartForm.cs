using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pizza_ordering_system
{
    public partial class CartForm : Form
    {
        private List<Pizza> cartItems;

        public CartForm(List<Pizza> cart)
        {
            InitializeComponent();
            cartItems = cart ?? new List<Pizza>();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            listViewCart.FullRowSelect = true;
            listViewCart.MultiSelect = false;
            listViewCart.HideSelection = false;

            LoadCart();
        }

        private void LoadCart()
        {
            listViewCart.Items.Clear();

            // Ensure columns exist (designer usually creates them)
            if (listViewCart.Columns.Count == 0)
            {
                listViewCart.Columns.Add("Пицца", 200);
                listViewCart.Columns.Add("Размер", 100);
                listViewCart.Columns.Add("Кол-во", 80);
                listViewCart.Columns.Add("Добавки", 250);
                listViewCart.Columns.Add("Цена", 100);
            }

            foreach (var pizza in cartItems)
            {
                ListViewItem item = new ListViewItem(pizza.Name);
                item.SubItems.Add(pizza.Size);
                item.SubItems.Add(pizza.Quantity.ToString());
                item.SubItems.Add(pizza.Toppings.Count > 0 ? string.Join(", ", pizza.Toppings) : "Без добавок");
                item.SubItems.Add(pizza.Price.ToString("0.00"));

                listViewCart.Items.Add(item);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listViewCart.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите пиццу для удаления!");
                return;
            }

            int index = listViewCart.SelectedItems[0].Index;
            if (index >= 0 && index < cartItems.Count)
            {
                cartItems.RemoveAt(index);
                LoadCart();
            }
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            if (cartItems.Count == 0)
            {
                MessageBox.Show("Корзина пуста!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PaymentForm paymentForm = new PaymentForm(cartItems);
            paymentForm.Show();
            this.Hide();
        }
    }
}
