using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_qlks
{
    public class DBConnect
    {
        static string connectionString = "Host=hattie.db.elephantsql.com;Port=5432;Database=ajejkikf;Username=ajejkikf;Password=xMYEdEiVT5W-zlDEI2wXYnK7OkauaTg3;";
        protected NpgsqlConnection connection;
        public DBConnect()
        {
            connection = new NpgsqlConnection(connectionString);
        }

        public NpgsqlConnection OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed || connection.State == System.Data.ConnectionState.Broken)
            {
                connection.Open();
            }
            return connection;
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
