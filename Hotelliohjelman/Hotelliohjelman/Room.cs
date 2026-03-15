using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;

namespace Hotelliohjelman
{
    internal class Room
    {
        CONNECT CONNECT = new CONNECT();

        public DataTable roomTypeList()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `clients`", CONNECT.getConnection());

            adapter.SelectCommand = command;

            CONNECT.openConnection();
            adapter.Fill(table);
            CONNECT.closeConnection();

            return table;
        }

        // create a function to edit the selected room

        public bool editRoom(int number, int type, string phone, string free)
        {
            MySqlCommand command = new MySqlCommand();

            String editQuery = "UPDATE `rooms` SET `type`=@tp, `phone`=@phn, `free`=@fr WHERE `number`=@num";

            command.CommandText = editQuery;

            command.Connection = CONNECT.getConnection();

            // @num,@tp,@phn,@fr
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@tp", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@fr", MySqlDbType.VarChar).Value = free;

            CONNECT.openConnection();

            bool removed = command.ExecuteNonQuery() == 1;

            CONNECT.closeConnection();
            return removed;
        }

        internal bool buttonAddNewRoom(int number, int type, string phone, string free)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `rooms`(`number`, `type`, `phone`, `free`) VALUES (@num,@tp,@phn,@fr)";
            command.CommandText = insertQuery;
            command.Connection = CONNECT.getConnection();

            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@tp", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@fr", MySqlDbType.VarChar).Value = free;

            CONNECT.openConnection();

            bool inserted = command.ExecuteNonQuery() == 1;

            CONNECT.closeConnection();
            return inserted;
        }


        public bool addRoom(String number, String type, String phone, String free)
        {
            MySqlCommand command = new MySqlCommand();
            String updateQuery = "INSERT INTO `rooms`(`number`, `type`, `phone`, `free`) VALUES (@num,@tp,@phn,@fr)";
            command.CommandText = updateQuery;
            command.Connection = CONNECT.getConnection();

           
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@tp", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@fr", MySqlDbType.VarChar).Value = free;

            CONNECT.openConnection();

            bool updated = command.ExecuteNonQuery() == 1;

            CONNECT.closeConnection();
            return updated;
        }

        // Return all rooms as a DataTable (used to bind to DataGridView)
        public DataTable addRoom()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `rooms`", CONNECT.getConnection());

            adapter.SelectCommand = command;

            CONNECT.openConnection();
            adapter.Fill(table);
            CONNECT.closeConnection();

            return table;
        }

        // Alias to get the rooms list
        public DataTable getRooms()
        {
            return addRoom();
        }

        public bool removeRoom(int number)
        {
            MySqlCommand command = new MySqlCommand();
            String deleteQuery = "DELETE FROM `rooms` WHERE `number`=@num";
            command.CommandText = deleteQuery;
            command.Connection = CONNECT.getConnection();

            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;

            CONNECT.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                CONNECT.closeConnection();
                return true;
            }
            else
            {
                CONNECT.closeConnection();
                return false;
            }
        }
    }
}
