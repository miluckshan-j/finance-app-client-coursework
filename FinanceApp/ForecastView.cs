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

        private void forecast(object sender, EventArgs e)
        {
            // TODO: Aggregate past records or use service to predict
            Random random = new Random();
            lblExpectedIncome.Text = Math.Round(random.NextDouble() * 100, 2) + " $";
            lblExpectedExpense.Text = Math.Round(random.NextDouble() * 100, 2)  + " $";
        }
    }
}
