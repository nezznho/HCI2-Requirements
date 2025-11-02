
//SQL
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AccessibleMealPlanner.DAL
{
    public class DatabaseHelper
    {
        private readonly string _connectionString = "Server=localhost;Database=AccessibleMealDB;Uid=root;Pwd=JOHNZENDATABASE;";

        // This method encapsulates the connection setup
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }
    }
}