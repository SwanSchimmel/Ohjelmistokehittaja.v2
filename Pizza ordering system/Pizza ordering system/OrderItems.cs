using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_ordering_system
{
    internal class OrderItems
    {
        private CONNECT connect = new CONNECT();

        public void AddItem(int orderId, Pizza pizza)
        {
            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO order_items(`order_id`, `pizza_name`, `pizza_size`, `toppings`, `quantity`, `item_price`) VALUES(@oid,@pn,@ps,@tp,@qt,@pr)",
                connect.getConnection()
            );

            cmd.Parameters.Add("@oid", MySqlDbType.Int32).Value = orderId;
            cmd.Parameters.Add("@pn", MySqlDbType.VarChar).Value = pizza.Name;
            cmd.Parameters.Add("@ps", MySqlDbType.VarChar).Value = pizza.Size;
            cmd.Parameters.Add("@tp", MySqlDbType.Text).Value = string.Join(",", pizza.Toppings);
            cmd.Parameters.Add("@qt", MySqlDbType.Int32).Value = pizza.Quantity;
            cmd.Parameters.Add("@pr", MySqlDbType.Double).Value = pizza.Price;

            connect.openConnection();
            cmd.ExecuteNonQuery();
            connect.closeConnection();
        }

        public DataTable GetCart(int orderId)
        {
            MySqlCommand cmd = new MySqlCommand(
                "SELECT * FROM order_items WHERE order_id=@oid",
                connect.getConnection()
            );

            cmd.Parameters.Add("@oid", MySqlDbType.Int32).Value = orderId;

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        public void RemoveItem(int itemId)
        {
            MySqlCommand cmd = new MySqlCommand(
                "DELETE FROM order_items WHERE item_id=@id",
                connect.getConnection()
            );

            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = itemId;

            connect.openConnection();
            cmd.ExecuteNonQuery();
            connect.closeConnection();
        }
    }
}
