using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.Model
{
    class UserManagementModel
    {
        SQLiteConnection con = new SQLiteConnection("Data Source=test8;Mode=Memory;Cache=Shared");
        SQLiteCommand cmd;

        public bool registerUser(string username, string password)
        {
            int rows;

            // Insert User 
            cmd = new SQLiteCommand(con);
            con.Open();
            cmd.CommandText = "INSERT INTO users (username, password) VALUES(@username, @password)";
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            rows = cmd.ExecuteNonQuery();
            con.Close();

            return (rows > 0) ? true : false;

        }

        public int loginUser(string username, string password)
        {
            // Check User 
            cmd = new SQLiteCommand(con);
            con.Open();
            cmd.CommandText = "SELECT COUNT(*) FROM users WHERE username=@username AND password=@password";
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            var response = cmd.ExecuteScalar();

            con.Close();

            return Convert.ToInt32(response);

        }

    }
}
