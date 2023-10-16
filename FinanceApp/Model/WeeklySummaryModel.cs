using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.Model
{
    class WeeklySummaryModel
    {
        SQLiteConnection con = new SQLiteConnection("Data Source=test8;Mode=Memory;Cache=Shared");
        SQLiteCommand cmd;
        SQLiteDataAdapter adapter;

        public DataTable RetrieveWeeklySummary()
        {
            // Calculate first and last day of week
            DateTime baseDate = DateTime.Today;
            var weekStart = baseDate.AddDays(-(int)baseDate.DayOfWeek);
            var weekEnd = weekStart.AddDays(7).AddSeconds(-1);

            Console.WriteLine("Start: " + weekStart);
            Console.WriteLine("End: " + weekEnd);

            DataTable datatable = new DataTable();

            // Retrieve Weekly Transactions Summary
            con.Open();
            string query = "SELECT type, SUM(amount) AS amount FROM transactions WHERE date BETWEEN '" + weekStart.ToString("yyyy-MM-dd") + "' AND '" + weekEnd.ToString("yyyy-MM-dd") + "' GROUP BY type";
            adapter = new SQLiteDataAdapter(query, con);

            // TODO: Handle empty table scenario
            adapter.Fill(datatable);

            con.Close();

            //test
            foreach (DataRow dataRow in datatable.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Console.WriteLine(item);
                }
            }


            return datatable;
        }
    }
}
