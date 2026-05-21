using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Pizza_ordering_system
{
    internal class Order
    {
        CONNECT connect = new CONNECT();

        public bool SaveOrder(Customer customer, string paymentMethod)
        {
            try
            {
                connect.openConnection();

                // 1. Добавляем клиента
                MySqlCommand cmdCustomer = new MySqlCommand(
                    "INSERT INTO customers(first_name, last_name, address, phone, email) " +
                    "VALUES(@fn, @ln, @ad, @ph, @em)", connect.getConnection());

                cmdCustomer.Parameters.Add("@fn", MySqlDbType.VarChar).Value = customer.FirstName;
                cmdCustomer.Parameters.Add("@ln", MySqlDbType.VarChar).Value = customer.LastName;
                cmdCustomer.Parameters.Add("@ad", MySqlDbType.VarChar).Value = customer.Address;
                cmdCustomer.Parameters.Add("@ph", MySqlDbType.VarChar).Value = customer.Phone ?? "";
                cmdCustomer.Parameters.Add("@em", MySqlDbType.VarChar).Value = customer.Email ?? "";

                cmdCustomer.ExecuteNonQuery();
                int customerID = Convert.ToInt32(cmdCustomer.LastInsertedId);

                // 2. Сумма заказа
                double totalPrice = 0;
                foreach (Pizza p in Cart.Items)
                    totalPrice += p.Price;

                // 3. Создаём заказ
                MySqlCommand cmdOrder = new MySqlCommand(
                    "INSERT INTO orders(customer_id, total_price, payment_method, order_date) " +
                    "VALUES(@cid, @tp, @pm, @od)", connect.getConnection());

                cmdOrder.Parameters.Add("@cid", MySqlDbType.Int32).Value = customerID;
                cmdOrder.Parameters.Add("@tp", MySqlDbType.Double).Value = totalPrice;
                cmdOrder.Parameters.Add("@pm", MySqlDbType.VarChar).Value = paymentMethod;
                cmdOrder.Parameters.Add("@od", MySqlDbType.DateTime).Value = DateTime.Now;

                cmdOrder.ExecuteNonQuery();
                int orderID = Convert.ToInt32(cmdOrder.LastInsertedId);

                // 4. Добавляем позиции заказа
                foreach (Pizza pizza in Cart.Items)
                {
                    MySqlCommand cmdItem = new MySqlCommand(
                        "INSERT INTO order_items(`order_id`, `pizza_name`, `pizza_size`, `toppings`, `quantity`, `item_price`) VALUES(@oid, @pn, @ps, @tp, @qt, @pr)", connect.getConnection());

                    cmdItem.Parameters.Add("@oid", MySqlDbType.Int32).Value = orderID;
                    cmdItem.Parameters.Add("@pn", MySqlDbType.VarChar).Value = pizza.Name;
                    cmdItem.Parameters.Add("@ps", MySqlDbType.VarChar).Value = pizza.Size;
                    cmdItem.Parameters.Add("@tp", MySqlDbType.Text).Value = string.Join(",", pizza.Toppings);
                    cmdItem.Parameters.Add("@qt", MySqlDbType.Int32).Value = pizza.Quantity;
                    cmdItem.Parameters.Add("@pr", MySqlDbType.Double).Value = pizza.Price;

                    cmdItem.ExecuteNonQuery();
                }

                connect.closeConnection();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении заказа:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connect.closeConnection();
                return false;
            }
        }
    }
}