using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;

namespace Hotelliohjelman
{
    class CONNECT
    {
        private MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=Hotelliohjelmandb;");

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
        if (connection.State == ConnectionState.Open)
        {
            connection.Close();
        }
        
        }
    }
}
