using MySql.Data.MySqlClient;
using System;

namespace Pizza_ordering_system
{
    internal class CONNECT
    {
        private MySqlConnection connection = new MySqlConnection(
            "server=localhost;" +
            "port=3306;" +
            "user id=root;" +           // ← важно: user id, а не username
            "password=;" +              // если у root есть пароль — укажи его здесь
            "database=pizza_db;" +
            "charset=utf8mb4;" +
            "AllowZeroDateTime=True;" +
            "Convert Zero Datetime=True"
        );

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public void openConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Ошибка подключения к базе данных:\n" + ex.Message,
                    "Ошибка соединения", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}