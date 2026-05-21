using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Pizza_ordering_system
{
    public partial class PaymentForm : Form
    {
        private List<Pizza> cartItems;
        Customer customer = new Customer();

        public PaymentForm(List<Pizza> cart)
        {
            InitializeComponent();
            cartItems = cart ?? new System.Collections.Generic.List<Pizza>();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text))
            {
                MessageBox.Show("Введите имя!", "Ошибка"); textBoxFirstName.Focus(); return;
            }
            if (string.IsNullOrWhiteSpace(textBoxLastName.Text))
            {
                MessageBox.Show("Введите фамилию!", "Ошибка"); textBoxLastName.Focus(); return;
            }
            if (string.IsNullOrWhiteSpace(textBoxAddress.Text))
            {
                MessageBox.Show("Введите адрес!", "Ошибка"); textBoxAddress.Focus(); return;
            }
            //if (string.IsNullOrWhiteSpace(textBoxPhone.Text))
            //{
            //    MessageBox.Show("Введите номер телефона!", "Ошибка"); textBoxPhone.Focus(); return;
            //}

            //if (!IsValidPhone(textBoxPhone.Text))
            //{
            //    MessageBox.Show("Некорректный номер телефона!\nПример: +79161234567", "Ошибка");
            //    textBoxPhone.Focus(); return;
            //}

            //if (cartItems.Count == 0)
            //{
            //    MessageBox.Show("Корзина пуста!"); return;
            //}

            customer.FirstName = textBoxFirstName.Text.Trim();
            customer.LastName = textBoxLastName.Text.Trim();
            customer.Address = textBoxAddress.Text.Trim();
            //customer.Phone = textBoxPhone.Text.Trim();
            //customer.Email = textBoxEmail?.Text.Trim() ?? "";
            customer.PaymentMethod = comboBoxPayment.Text;

            Order order = new Order();
            if (order.SaveOrder(customer, cartItems))
            {
                MessageBox.Show("Заказ успешно оформлен!", "Успех");
                cartItems.Clear();
                new ConfirmForm().Show();
                this.Close();
            }
        }

        private bool IsValidPhone(string phone)
        {
            string digits = Regex.Replace(phone, @"[^\d]", "");
            return digits.Length >= 10 && digits.Length <= 15;
        }
    }
}