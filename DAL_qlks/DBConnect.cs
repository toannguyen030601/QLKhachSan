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
        public static string connectionString = "Host=hattie.db.elephantsql.com;Port=5432;Database=ajejkikf;Username=ajejkikf;Password=xMYEdEiVT5W-zlDEI2wXYnK7OkauaTg3;";
        protected NpgsqlConnection connection = new NpgsqlConnection(connectionString);
        
        
    }
}
