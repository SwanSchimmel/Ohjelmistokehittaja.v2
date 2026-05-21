using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pizza_ordering_system
{
    public partial class Form2 : Form
    {
        private List<Pizza> cartItems;

        public Form2(List<Pizza> cart)
        {
            InitializeComponent();
            cartItems = cart ?? new List<Pizza>();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBoxPizza.Items.AddRange(new[] { "Pepperoni", "Hawaii", "BBQ Chicken" });
            comboBoxSize.Items.AddRange(new[] { "Small", "Medium", "Large" });
            checkedListBoxToppings.Items.AddRange(new[] { "Extra Cheese", "Mushrooms", "Olives" });
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxPizza.Text) || string.IsNullOrEmpty(comboBoxSize.Text))
            {
                MessageBox.Show("Выберите тип пиццы и размер!", "Ошибка");
                return;
            }

            int quantity = (int)numericUpDownQty.Value;
            if (quantity <= 0)
            {
                MessageBox.Show("Выберите количество больше 0!", "Ошибка");
                return;
            }

            Pizza pizza = new Pizza
            {
                Name = comboBoxPizza.Text,
                Size = comboBoxSize.Text,
                Quantity = quantity,
                Toppings = new List<string>()
            };

            foreach (var item in checkedListBoxToppings.CheckedItems)
                pizza.Toppings.Add(item.ToString());

            pizza.Price = CalculatePrice(pizza);

            cartItems.Add(pizza);

            MessageBox.Show("Пицца добавлена в корзину!");

            // Открываем CartForm сразу после добавления
            CartForm cartForm = new CartForm(cartItems);
            cartForm.Show();
            this.Hide();
        }

        private double CalculatePrice(Pizza pizza)
        {
            double price = pizza.Size == "Small" ? 8 : pizza.Size == "Medium" ? 10 : 12;
            price += pizza.Toppings.Count * 1.5;
            price *= pizza.Quantity;
            return price;
        }
    }
}