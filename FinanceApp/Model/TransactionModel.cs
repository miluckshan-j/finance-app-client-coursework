using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace FinanceApp.Model
{
    class TransactionModel
    {
        SQLiteConnection con = new SQLiteConnection("Data Source=test8;Mode=Memory;Cache=Shared");
        SQLiteCommand cmd;
        SQLiteDataAdapter adapter;
        //ID variable used in Updating and Deleting Record  
        int ID = 0;

        public bool InsertTransaction(string type, double amount, string date)
        {
            int rows;

            // Insert Transaction 
            cmd = new SQLiteCommand(con);
            con.Open();
            cmd.CommandText = "INSERT INTO transactions (type, amount, date) VALUES(@type, @amount, @date)";
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@date", date);
            rows = cmd.ExecuteNonQuery();
            con.Close();

            return (rows > 0) ? true : false;

        }

        public bool UpdateTransaction(int id, double amount)
        {
            int rows;

            // Update Transaction 
            cmd = new SQLiteCommand(con);
            con.Open();
            cmd.CommandText = "UPDATE transactions SET amount=@amount WHERE id=@id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@amount", amount);
            rows = cmd.ExecuteNonQuery();
            con.Close();

            return (rows > 0) ? true : false;
        }

        public DataTable RetrieveTransactions()
        {
            DataTable datatable = new DataTable();

            // Retrieve Transactions
            con.Open();
            adapter = new SQLiteDataAdapter("SELECT * FROM transactions", con);

            // TODO: Handle empty table scenario
            adapter.Fill(datatable);

            return datatable;
        }

        public bool DeleteTransaction(int id)
        {
            int rows;

            // Delete Transaction 
            cmd = new SQLiteCommand(con);
            con.Open();
            cmd.CommandText = "DELETE FROM transactions WHERE id=@id";
            cmd.Parameters.AddWithValue("@id", id);
            rows = cmd.ExecuteNonQuery();
            con.Close();

            return (rows > 0) ? true : false;
        }

    }
}
