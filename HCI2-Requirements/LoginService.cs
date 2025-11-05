using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace HCI2_Requirements
{
    public class LoginService
    {
        private readonly string _connectionString = "server=localhost; user id=user; password=123456789; database=basemanage";
         // Connection mo johnzen> "server=localhost;database=AccessibleMealPlannerDB;uid=root;pwd=JOHNZENDATABASE;";

        // Authentication method (compare raw password directly; no hashing/encryption)
        public bool AuthenticateUser(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM credential WHERE username=@u AND password=@p";
                //Connection mo johnzen > "SELECT COUNT(*) FROM userr WHERE username=@u AND password_hash=@p"
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@u", username ?? string.Empty);
                    cmd.Parameters.AddWithValue("@p", password ?? string.Empty);

                    object result = cmd.ExecuteScalar();
                    int count = (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : 0;
                    return count > 0;
                }
            }
        }
    }
}
