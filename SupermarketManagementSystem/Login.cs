using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SupermarketManagementSystem
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            string emailText = email.Text;
            string passwordText = password.Text;
            if(string.IsNullOrEmpty(emailText))
            {
                LoginErrorProvider.SetError(email, "username must be filled!");
                return;
            }
            if(string.IsNullOrEmpty(passwordText))
            {
                LoginErrorProvider.SetError(password, "password must be filled!");
                return;
            }
            LoginErrorProvider.SetError(email, "");
            LoginErrorProvider.SetError(password, "");
            string query = $"select * from user where email like '{emailText}' and password like '{passwordText}'";
            MySqlDataReader read = DatabaseConnector.ExecuteQuery(query);
            if(!read.Read())
            {
                LoginErrorProvider.SetError(password, "invalid email or password!");
                return;
            }
            LoggedUser.SetLoggedUser(read.GetString(1), read.GetString(2), read.GetString(3), false);
            Debug.WriteLine(LoggedUser.username);
            this.Hide();
            Home homePage = new Home();
            homePage.Show();
        }

        private void goToRegisterPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register registerPage = new Register();
            registerPage.Show();
        }

        private void goToLoginAdminPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginAdmin loginAdmin = new LoginAdmin();
            loginAdmin.Show();
        }
    }
}
