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
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void loginUser(object sender, EventArgs e)
        {
            //UserManagementModel userManagemenModel = new UserManagementModel();
            usermanagement.service.UserManagementServiceSoapClient client = new usermanagement.service.UserManagementServiceSoapClient();
            client.Endpoint.Address = new System.ServiceModel.EndpointAddress("https://localhost:44337/service/UserManagement");
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            //var response = userManagemenModel.loginUser(username, password);
            var response = client.loginUser(username, password);

            if (response==1)
            {
                clearValues();
                this.Hide();
                TransactionView transactionView = new TransactionView();
                transactionView.Show();
            }
            else
            {
                MessageBox.Show("USER LOGIN FAILED");
            }
        }

        private void clearValues()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void showRegisterForm(object sender, EventArgs e)
        {
            
            RegisterView registerView= new RegisterView();
            registerView.Show();
            this.Hide();
        }
    }
}
