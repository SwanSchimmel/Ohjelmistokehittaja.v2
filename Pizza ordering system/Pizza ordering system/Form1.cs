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

        private void Form1_Load(object sender, EventArgs e)
        {
            CONNECT test = new CONNECT();
            try
            {
                test.openConnection();
                MessageBox.Show("Подключение к MySQL успешно!", "Успех");
                test.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Form2 menuForm = new Form2();
            menuForm.Show();
        }

        private void buttonCart_Click(object sender, EventArgs e)
        {
            CartForm cartForm = new CartForm();
            cartForm.Show();
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            PaymentForm paymentForm = new PaymentForm();
            paymentForm.Show();
        }

        

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
