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
        private readonly string _connectionString =
           "server=localhost;database=AccessibleMealPlannerDB;uid=root;pwd=JOHNZENDATABASE;";

        // Hash function (encapsulation of logic)
        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        // Authentication method
        public bool AuthenticateUser(string username, string password)
        {
            string hashed = HashPassword(password);

            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM userr WHERE username=@u AND password_hash=@p";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", hashed);
                    object result = cmd.ExecuteScalar();
                    int count = (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : 0;
                    return count > 0;
                }
            }
        }
    }
}
