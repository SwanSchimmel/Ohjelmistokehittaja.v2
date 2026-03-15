using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hotelliohjelman
{
    internal class RESERVATION
    {
        CONNECT CONNECT = new CONNECT();
        


        public DataTable getAllReserv()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `reservations`", CONNECT.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        public bool addReservation(int number, int clientID, DateTime dateIn, DateTime dateOut)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `reservations`(`roomNumber`, `clientID`, `DateIn`, `DateOut`) VALUES(@rnm, @cid, @din, @dout)";
            command.CommandText = insertQuery;
            command.Connection = CONNECT.getConnection();

            
            command.Parameters.Add("@rnm", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = clientID;
            command.Parameters.Add("@din", MySqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@dout", MySqlDbType.Date).Value = dateOut;

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

        public bool editReservation(int rvid, int roomNumber, int clientID, DateTime dateIn, DateTime dateOut)
        {
            MySqlCommand command = new MySqlCommand();

            String editQuery = "UPDATE `reservations` SET `roomNumber`=@rnm, `clientID`=@cid, `DateIn`=@din, `DateOut`=@dout WHERE `reservID`=@rvid";

            command.CommandText = editQuery;

            command.Connection = CONNECT.getConnection();

            command.Parameters.Add("@rvid", MySqlDbType.Int32).Value = rvid;
            command.Parameters.Add("@rnm", MySqlDbType.Int32).Value = roomNumber;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = clientID;
            command.Parameters.Add("@din", MySqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@dout", MySqlDbType.Date).Value = dateOut;

            CONNECT.openConnection();

            bool removed = command.ExecuteNonQuery() == 1;

            CONNECT.closeConnection();
            return removed;
        }

        public bool removeReservation(int rsv_id)
        {
            MySqlCommand command = new MySqlCommand();
            String deleteQuery = "DELETE FROM `reservations` WHERE `reservID` =@rvid";
            command.CommandText = deleteQuery;
            command.Connection = CONNECT.getConnection();

            command.Parameters.Add("@rvid", MySqlDbType.Int32).Value = rsv_id;

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
