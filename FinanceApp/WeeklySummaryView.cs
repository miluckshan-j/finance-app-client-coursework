using FinanceApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FinanceApp
{
    public partial class WeeklySummaryView : Form
    {
        public WeeklySummaryView()
        {
            InitializeComponent();
            chart1.Series.Clear();
            chart1.Legends.Clear();
        }

        private async void showWeeklySummary(object sender, EventArgs e)
        {
            //WeeklySummaryModel weeklySummaryModel = new WeeklySummaryModel();
            transaction.service.TransactionServiceSoapClient client = new transaction.service.TransactionServiceSoapClient();
            client.Endpoint.Address = new System.ServiceModel.EndpointAddress("https://localhost:44337/service/Transaction");

            //DataTable response = weeklySummaryModel.RetrieveWeeklySummary();
            DataTable response = await client.RetrieveWeeklySummaryAsync();

            chart1.Series.Clear();
            chart1.Legends.Clear();

            chart1.Legends.Add("Weekly Summary");
            chart1.Legends[0].Alignment = StringAlignment.Center;
            chart1.Legends[0].Title = "MyTitle";
            chart1.Legends[0].BorderColor = Color.Black;

            string seriesname = "MySeriesName";
            chart1.Series.Add(seriesname);
            chart1.Series[seriesname].ChartType = SeriesChartType.Pie;

            foreach (DataRow row in response.Rows)
            {
                chart1.Series[seriesname].Points.AddXY(row["type"].ToString(), Convert.ToInt32(row["amount"]));
            }

        }
    }
}
