using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceApp
{
    public partial class ForecastView : Form
    {
        public ForecastView()
        {
            InitializeComponent();
        }

        private async void forecast(object sender, EventArgs e)
        {
            prediction.service.PredictionServiceSoapClient client = new prediction.service.PredictionServiceSoapClient();
            client.Endpoint.Address = new System.ServiceModel.EndpointAddress("https://localhost:44337/service/Prediction");

            var start = DateTime.Now.ToString("yyyy-MM-dd");
            var end = dtForecast.Value.ToString("yyyy-MM-dd");
            var response = await client.RetrievePredictionsAsync(start, end);

            foreach (DataRow row in response.Rows)
            {
                double value = Math.Round(double.Parse(row["amount"].ToString()) / double.Parse(row["count"].ToString()), 2);

                if (row["type"].ToString() == "income")
                {
                    lblExpectedIncome.Text = value + " $";
                }

                if (row["type"].ToString() == "expense")
                {
                    lblExpectedExpense.Text = value + " $";
                }

            }

        }
    }
}
