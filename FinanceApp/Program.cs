using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace FinanceApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PreprocessDB();
            Application.Run(new LoginView());
        }

        static void PreprocessDB()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=test8;Mode=Memory;Cache=Shared");
            SQLiteCommand cmd;

            cmd = new SQLiteCommand(con);
            con.Open();

            // Create Transaction Table
            cmd.CommandText = "CREATE TABLE IF NOT EXISTS transactions (id INTEGER PRIMARY KEY AUTOINCREMENT, type TEXT, amount NUMERIC, date TEXT)";
            cmd.ExecuteNonQuery();

            // Create User Table
            cmd.CommandText = "CREATE TABLE IF NOT EXISTS users (id INTEGER PRIMARY KEY AUTOINCREMENT, username TEXT, password TEXT)";
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
