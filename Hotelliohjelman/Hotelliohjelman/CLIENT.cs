using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Hotelliohjelman
{
    internal class CLIENT
    {
        CONNECT CONNECT = new CONNECT();

        public bool insertClient(String fname, String lname, String phone, String country)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `clients`(`first_name`, `last_name`, `phone`, `country`) VALUES (@fnm,@lnm,@phn,@cnt)";
            command.CommandText = insertQuery;
            command.Connection = CONNECT.getConnection();

            //@fnm,@lnm,@phn,@cnt
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@cnt", MySqlDbType.VarChar).Value = country;

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

        public DataTable getClients()
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

        public bool editClient(int id, String fname, String lname, String phone, String country)
        {
            MySqlCommand command = new MySqlCommand();
            String updateQuery = "UPDATE `clients` SET `first_name`=@fnm, `last_name`=@lnm, `phone`=@phn, `country`=@cnt WHERE `id`=@id";
            command.CommandText = updateQuery;
            command.Connection = CONNECT.getConnection();

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@cnt", MySqlDbType.VarChar).Value = country;

            CONNECT.openConnection();

            bool updated = command.ExecuteNonQuery() == 1;

            CONNECT.closeConnection();
            return updated;
        }

        public bool removeClient(int id)
        {
            MySqlCommand command = new MySqlCommand();
            String deleteQuery = "DELETE FROM `clients` WHERE `id`=@id";
            command.CommandText = deleteQuery;
            command.Connection = CONNECT.getConnection();

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            CONNECT.openConnection();

            bool removed = command.ExecuteNonQuery() == 1;

            CONNECT.closeConnection();
            return removed;
        }
    }
}
