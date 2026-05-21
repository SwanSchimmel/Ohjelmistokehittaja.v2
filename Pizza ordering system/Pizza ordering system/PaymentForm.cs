using System;
using System.Windows.Forms;

namespace Pizza_ordering_system
{
    public partial class PaymentForm : Form
    {
        Customer customer = new Customer();

        public PaymentForm()
        {
            InitializeComponent();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
                string.IsNullOrWhiteSpace(textBoxLastName.Text) ||
                string.IsNullOrWhiteSpace(textBoxAddress.Text))
            {
                MessageBox.Show("Заполните все обязательные поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            customer.FirstName = textBoxFirstName.Text;
            customer.LastName = textBoxLastName.Text;
            customer.Address = textBoxAddress.Text;
            customer.Phone = "";      // можно добавить поля
            customer.Email = "";
            customer.PaymentMethod = comboBoxPayment.Text;

            Order order = new Order();

            if (order.SaveOrder(customer, customer.PaymentMethod))
            {
                MessageBox.Show("Заказ успешно оформлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Cart.Clear(); // очищаем корзину

                ConfirmForm confirmForm = new ConfirmForm();
                confirmForm.Show();
                this.Close();
            }
        }
    }
}