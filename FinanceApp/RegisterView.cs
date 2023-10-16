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
using System.Data.SqlClient;

namespace FinanceApp
{
    public partial class RegisterView : Form
    {
        public RegisterView()
        {
            InitializeComponent();
        }

        private void registerUser(object sender, EventArgs e)
        {

            //UserManagementModel userManagemenModel = new UserManagementModel();
            usermanagement.service.UserManagementServiceSoapClient client = new usermanagement.service.UserManagementServiceSoapClient();
            client.Endpoint.Address = new System.ServiceModel.EndpointAddress("https://localhost:44337/service/UserManagement");
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            //var response = userManagemenModel.registerUser(username, password);
            var response = client.registerUser(username, password);

            if (response)
            {
                clearValues();
                this.Hide();
                LoginView loginView = new LoginView();
                loginView.Show();
            }
            else
            {
                MessageBox.Show("USER REGISTRATION FAILED");
            }
        }

        private void clearValues()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void showLoginForm(object sender, EventArgs e)
        {

            LoginView loginView = new LoginView();
            loginView.Show();
            this.Hide();
        }
    }
}
