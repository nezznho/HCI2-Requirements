using HCI2_Requirements;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessibleMealPlanner.DAL
{
    public class UserDAO
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();

        // Encapsulated method to get a user
        /*
        public UserModel GetUserByID(int userId)
        {
            UserModel user = null;
            string query = "SELECT * FROM Users WHERE UserID = @id";

            using (MySqlConnection conn = _dbHelper.GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", userId);
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new UserModel
                            {
                                // Directly map data to the Model properties
                                UserID = reader.GetInt32("UserID"),
                                Name = reader.GetString("Name"),
                                // ... populate other properties
                            };
                        }
                    }
                }
            }
            return user;
        }
        */

        // Add Encapsulated methods for InsertUser, UpdateUser, etc.
    }
}