using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Hotelliohjelman
{
    internal class RESERVATION
    {
        CONNECT CONNECT = new CONNECT();

        // Получить все бронирования
        public DataTable GetAllReservations()
        {
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `reservations`", CONNECT.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            CONNECT.openConnection();
            adapter.Fill(table);
            CONNECT.closeConnection();

            return table;
        }

        // Добавить бронирование
        public bool AddReservation(int roomNumber, int clientID, DateTime dateIn, DateTime dateOut)
        {
            MySqlCommand command = new MySqlCommand(
                "INSERT INTO `reservations`(`roomNumber`, `clientID`, `DateIn`, `DateOut`) " +
                "VALUES(@rnm, @cid, @din, @dout)", CONNECT.getConnection());

            command.Parameters.Add("@rnm", MySqlDbType.Int32).Value = roomNumber;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = clientID;
            command.Parameters.Add("@din", MySqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@dout", MySqlDbType.Date).Value = dateOut;

            CONNECT.openConnection();
            bool added = command.ExecuteNonQuery() == 1;
            CONNECT.closeConnection();

            return added;
        }

        // Редактировать бронирование
        public bool EditReservation(int reservID, int roomNumber, int clientID, DateTime dateIn, DateTime dateOut)
        {
            MySqlCommand command = new MySqlCommand(
                "UPDATE `reservations` SET `roomNumber`=@rnm, `clientID`=@cid, `DateIn`=@din, `DateOut`=@dout " +
                "WHERE `reservID`=@rvid", CONNECT.getConnection());

            command.Parameters.Add("@rvid", MySqlDbType.Int32).Value = reservID;
            command.Parameters.Add("@rnm", MySqlDbType.Int32).Value = roomNumber;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = clientID;
            command.Parameters.Add("@din", MySqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@dout", MySqlDbType.Date).Value = dateOut;

            CONNECT.openConnection();
            bool edited = command.ExecuteNonQuery() == 1;
            CONNECT.closeConnection();

            return edited;
        }

        // Удалить бронирование
        public bool RemoveReservation(int reservID)
        {
            MySqlCommand command = new MySqlCommand(
                "DELETE FROM `reservations` WHERE `reservID`=@rvid", CONNECT.getConnection());

            command.Parameters.Add("@rvid", MySqlDbType.Int32).Value = reservID;

            CONNECT.openConnection();
            bool removed = command.ExecuteNonQuery() == 1;
            CONNECT.closeConnection();

            return removed;
        }


    }
}