using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Hotelliohjelman
{
    internal class Room
    {
        CONNECT CONNECT = new CONNECT();

        // Получить все комнаты
        public DataTable GetRooms()
        {
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `rooms`", CONNECT.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            CONNECT.openConnection();
            adapter.Fill(table);
            CONNECT.closeConnection();

            return table;
        }

        // Получить список типов комнат
        public DataTable GetRoomTypes()
        {
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `rooms_category`", CONNECT.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            CONNECT.openConnection();
            adapter.Fill(table);
            CONNECT.closeConnection();

            return table;
        }

        // Добавить комнату
        public bool AddRoom(int number, int type, string phone, string free)
        {
            MySqlCommand command = new MySqlCommand(
                "INSERT INTO `rooms`(`number`, `type`, `phone`, `free`) VALUES (@num,@tp,@phn,@fr)",
                CONNECT.getConnection());

            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@tp", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@fr", MySqlDbType.VarChar).Value = free;

            CONNECT.openConnection();
            bool inserted = command.ExecuteNonQuery() == 1;
            CONNECT.closeConnection();

            return inserted;
        }

        // Редактировать комнату
        public bool EditRoom(int number, int type, string phone, string free)
        {
            MySqlCommand command = new MySqlCommand(
                "UPDATE `rooms` SET `type`=@tp, `phone`=@phn, `free`=@fr WHERE `number`=@num",
                CONNECT.getConnection());

            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@tp", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@fr", MySqlDbType.VarChar).Value = free;

            CONNECT.openConnection();
            bool updated = command.ExecuteNonQuery() == 1;
            CONNECT.closeConnection();

            return updated;
        }

        // Удалить комнату
        public bool RemoveRoom(int number)
        {
            MySqlCommand command = new MySqlCommand(
                "DELETE FROM `rooms` WHERE `number`=@num",
                CONNECT.getConnection());

            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;

            CONNECT.openConnection();
            bool removed = command.ExecuteNonQuery() == 1;
            CONNECT.closeConnection();

            return removed;
        }

       

        // Установить свободность комнаты: "Yes" или "No"
        public bool SetRoomFree(int roomNumber, string freeStatus)
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = CONNECT.getConnection();
            command.CommandText = "UPDATE `rooms` SET `free`=@status WHERE `number`=@rnum";
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = freeStatus;
            command.Parameters.Add("@rnum", MySqlDbType.Int32).Value = roomNumber;

            CONNECT.openConnection();
            bool result = command.ExecuteNonQuery() == 1;
            CONNECT.closeConnection();
            return result;
        }
    }
}