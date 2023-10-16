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

namespace FinanceApp
{
    public partial class TransactionView : Form
    {
        private int selectedId;

        public TransactionView()
        {
            InitializeComponent();
            //TransactionModel transactionModel = new TransactionModel();
            transaction.service.TransactionServiceSoapClient client = new transaction.service.TransactionServiceSoapClient();
            client.Endpoint.Address = new System.ServiceModel.EndpointAddress("https://localhost:44337/service/Transaction");

            //dgTransactions.DataSource = transactionModel.RetrieveTransactions();
            dgTransactions.DataSource = client.RetrieveTransactionsAsync();

            cmbType.SelectedItem = null;
            cmbType.SelectedText = "-- Select Type --";
        }

        private async void addTransaction(object sender, EventArgs e)
        {
            //TransactionModel transactionModel = new TransactionModel();
            transaction.service.TransactionServiceSoapClient client = new transaction.service.TransactionServiceSoapClient();
            client.Endpoint.Address = new System.ServiceModel.EndpointAddress("https://localhost:44337/service/Transaction");

            var type = cmbType.GetItemText(cmbType.SelectedItem);
            var amount = Convert.ToDouble(txtAmount.Text);
            var date = dtpDate.Value.ToString("yyyy-MM-dd");

            //var response = transactionModel.InsertTransaction(type, amount, date);
            var response = await client.InsertTransactionAsync(type, amount, date);

            clearValues();

            if (response)
            {
                clearValues();
                MessageBox.Show("ADDED SUCESSFULLY");
                dgTransactions.DataSource = client.RetrieveTransactions();
            }
            else
            {
                MessageBox.Show("ADDED FAILED");
            }
        }

        private async void updateTransaction(object sender, EventArgs e)
        {
            //TransactionModel transactionModel = new TransactionModel();
            transaction.service.TransactionServiceSoapClient client = new transaction.service.TransactionServiceSoapClient();
            client.Endpoint.Address = new System.ServiceModel.EndpointAddress("https://localhost:44337/service/Transaction");

            var amount = Convert.ToDouble(txtAmount.Text);

            //var response = transactionModel.UpdateTransaction(selectedId, amount);
            var response = await client.UpdateTransactionAsync(selectedId, amount);

            if (response)
            {
                clearValues();
                MessageBox.Show("UPDATED SUCESSFULLY");
                dgTransactions.DataSource = client.RetrieveTransactions();
            }
            else
            {
                MessageBox.Show("UPDATE FAILED");
            }
        }

        private async void retrieveTransactions(object sender, EventArgs e)
        {
            //TransactionModel transactionModel = new TransactionModel();
            transaction.service.TransactionServiceSoapClient client = new transaction.service.TransactionServiceSoapClient();
            client.Endpoint.Address = new System.ServiceModel.EndpointAddress("https://localhost:44337/service/Transaction");

            //dgTransactions.DataSource = transactionModel.RetrieveTransactions();
            dgTransactions.DataSource = await client.RetrieveTransactionsAsync();
        }

        private async void deleteTransaction(object sender, EventArgs e)
        {
            //TransactionModel transactionModel = new TransactionModel();
            transaction.service.TransactionServiceSoapClient client = new transaction.service.TransactionServiceSoapClient();
            client.Endpoint.Address = new System.ServiceModel.EndpointAddress("https://localhost:44337/service/Transaction");

            //var response = transactionModel.DeleteTransaction(selectedId);
            var response = await client.DeleteTransactionAsync(selectedId);

            if (response)
            {
                clearValues();
                MessageBox.Show("DELETED SUCESSFULLY");
                dgTransactions.DataSource = client.RetrieveTransactions();
            }
            else
            {
                MessageBox.Show("DELETE FAILED");
            }
        }

        private void clearValues()
        {
            cmbType.SelectedItem = null;
            cmbType.Text = "-- Select Type --";
            txtAmount.Text = "";
            dtpDate.Value = DateTime.Now;
        }

        private void clearFields(object sender, EventArgs e)
        {
            clearValues();
        }

        private void dgTransactions_SelectionChanged(object sender, EventArgs e)
        {
            if (dgTransactions.SelectedRows.Count > 0)
            {
                selectedId = Convert.ToInt32(dgTransactions.SelectedRows[0].Cells["id"].Value.ToString());
                cmbType.Text = dgTransactions.SelectedRows[0].Cells["type"].Value.ToString();
                txtAmount.Text = dgTransactions.SelectedRows[0].Cells["amount"].Value.ToString();
                dtpDate.Value = Convert.ToDateTime(dgTransactions.SelectedRows[0].Cells["date"].Value.ToString());
            }
        }

        private void showLoginForm(object sender, EventArgs e)
        {
            this.Dispose();
            LoginView loginView = new LoginView();
            loginView.Show();
        }

        private void showWeeklySummaryForm(object sender, EventArgs e)
        {
            WeeklySummaryView weeklySummary = new WeeklySummaryView();
            weeklySummary.ShowDialog();
        }

        private void showForecastForm(object sender, EventArgs e)
        {
            ForecastView forecastView = new ForecastView();
            forecastView.ShowDialog();
        }
    }
}
