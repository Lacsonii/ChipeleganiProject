using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ChipeleganiProject
{
    class databaseconnection
    {
        MySqlConnection connection = new MySqlConnection("Server = localhost; userID = root; password=; database = chipeleganyu");

            public MySqlConnection getconnection()
            {
                return connection;
            }

            public void openconnect()
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                connection.Open();
                }
            }
            public void closeconnect()
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                connection.Close();
                }

            }
    }
}

