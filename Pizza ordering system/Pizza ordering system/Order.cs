using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pizza_ordering_system
{
    internal class Order
    {
        private CONNECT connect = new CONNECT();

        public bool SaveOrder(Customer customer, List<Pizza> cartItems)
        {
            try
            {
                connect.openConnection();

                // Customer
                MySqlCommand cmdCustomer = new MySqlCommand(
                    "INSERT INTO customers(first_name,last_name,address,phone,email) VALUES(@fn,@ln,@ad,@ph,@em)",
                    connect.getConnection());

                cmdCustomer.Parameters.Add("@fn", MySqlDbType.VarChar).Value = customer.FirstName;
                cmdCustomer.Parameters.Add("@ln", MySqlDbType.VarChar).Value = customer.LastName;
                cmdCustomer.Parameters.Add("@ad", MySqlDbType.VarChar).Value = customer.Address;
                cmdCustomer.Parameters.Add("@ph", MySqlDbType.VarChar).Value = customer.Phone ?? "";
                cmdCustomer.Parameters.Add("@em", MySqlDbType.VarChar).Value = customer.Email ?? "";

                cmdCustomer.ExecuteNonQuery();
                int customerID = Convert.ToInt32(cmdCustomer.LastInsertedId);

                // Total price
                double totalPrice = 0;
                foreach (var p in cartItems) totalPrice += p.Price;

                // Order
                MySqlCommand cmdOrder = new MySqlCommand(
                    "INSERT INTO orders(customer_id,total_price,payment_method,order_date) VALUES(@cid,@tp,@pm,@od)",
                    connect.getConnection());

                cmdOrder.Parameters.Add("@cid", MySqlDbType.Int32).Value = customerID;
                cmdOrder.Parameters.Add("@tp", MySqlDbType.Double).Value = totalPrice;
                cmdOrder.Parameters.Add("@pm", MySqlDbType.VarChar).Value = customer.PaymentMethod;
                cmdOrder.Parameters.Add("@od", MySqlDbType.DateTime).Value = DateTime.Now;

                cmdOrder.ExecuteNonQuery();
                int orderID = Convert.ToInt32(cmdOrder.LastInsertedId);

                // Order Items
                foreach (var pizza in cartItems)
                {
                    MySqlCommand cmdItem = new MySqlCommand(
                        "INSERT INTO order_items(order_id,pizza_name,pizza_size,toppings,quantity,item_price) " +
                        "VALUES(@oid,@pn,@ps,@tp,@qt,@pr)", connect.getConnection());

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
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
                connect.closeConnection();
                return false;
            }
        }
    }
}