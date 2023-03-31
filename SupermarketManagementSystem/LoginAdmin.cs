using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagementSystem
{
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string emailText = email.Text;
            string passwordText = password.Text;
            if (string.IsNullOrEmpty(emailText))
            {
                LoginErrorProvider.SetError(email, "username must be filled!");
                return;
            }
            if (string.IsNullOrEmpty(passwordText))
            {
                LoginErrorProvider.SetError(password, "password must be filled!");
                return;
            }
            LoginErrorProvider.SetError(email, "");
            LoginErrorProvider.SetError(password, "");
            string query = $"select * from admin where email like '{emailText}' and password like '{passwordText}'";
            MySqlDataReader read = DatabaseConnector.ExecuteQuery(query);
            if (!read.Read())
            {
                LoginErrorProvider.SetError(password, "invalid email or password!");
                return;
            }
            while (read.Read())
            {
                LoggedUser.SetLoggedUser(read.GetString(1), read.GetString(2), read.GetString(3), true);
                break;
            }
            this.Hide();
            HomeAdmin homePage = new HomeAdmin();
            homePage.Show();
        }

        private void goToLoginPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginPage = new Login();
            loginPage.Show();
        }


    }
}
