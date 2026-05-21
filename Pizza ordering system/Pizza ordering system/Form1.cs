using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_ordering_system
{
    public partial class Form1 : Form
    {
        public List<Pizza> CartItems { get; set; } = new List<Pizza>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Form2 menuForm = new Form2(CartItems);
            menuForm.Show();
        }

        private void buttonCart_Click(object sender, EventArgs e)
        {
            CartForm cartForm = new CartForm(CartItems);
            cartForm.Show();
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            if (CartItems.Count == 0)
            {
                MessageBox.Show("Корзина пуста!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PaymentForm paymentForm = new PaymentForm(CartItems);
            paymentForm.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}