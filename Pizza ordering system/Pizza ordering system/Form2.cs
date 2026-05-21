using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pizza_ordering_system
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // PIZZA TYPES
            comboBoxPizza.Items.Add("Pepperoni");
            comboBoxPizza.Items.Add("Hawaii");
            comboBoxPizza.Items.Add("BBQ Chicken");

            // SIZES
            comboBoxSize.Items.Add("Small");
            comboBoxSize.Items.Add("Medium");
            comboBoxSize.Items.Add("Large");

            // TOPPINGS
            checkedListBoxToppings.Items.Add("Extra Cheese");
            checkedListBoxToppings.Items.Add("Mushrooms");
            checkedListBoxToppings.Items.Add("Olives");
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxPizza.Text) || string.IsNullOrEmpty(comboBoxSize.Text))
            {
                MessageBox.Show("Выберите тип пиццы и размер!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Pizza pizza = new Pizza
            {
                Name = comboBoxPizza.Text,
                Size = comboBoxSize.Text,
                Quantity = (int)numericUpDownQty.Value,
                Toppings = new List<string>()
            };

            foreach (var item in checkedListBoxToppings.CheckedItems)
            {
                pizza.Toppings.Add(item.ToString());
            }

            pizza.Price = CalculatePrice(pizza);

            Cart.Items.Add(pizza);                    // ← ИСПРАВЛЕНО

            MessageBox.Show("Пицца добавлена в корзину!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Опционально: очистить выбор
            // checkedListBoxToppings.ClearSelected();
        }

        private double CalculatePrice(Pizza pizza)
        {
            double price = 0;

            if (pizza.Size == "Small") price = 8;
            else if (pizza.Size == "Medium") price = 10;
            else if (pizza.Size == "Large") price = 12;

            price += pizza.Toppings.Count * 1.5;
            price *= pizza.Quantity;

            return price;
        }
    }
}