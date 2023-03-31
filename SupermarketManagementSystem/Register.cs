using MySql.Data.MySqlClient;
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

namespace SupermarketManagementSystem
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string usernameText = username.Text;
            string emailText = email.Text;
            string passwordText = password.Text;
            string confirmPasswordText = confirmPassword.Text;
            Boolean agreeBool = RegisterTerms.Checked;
            if (string.IsNullOrEmpty(usernameText))
            {
                registerErrorProvider.SetError(username, "username must be filled!");
                return;
            }
            if (string.IsNullOrEmpty(emailText))
            {
                registerErrorProvider.SetError(email, "email must be filled!");
                return;
            }
            if (string.IsNullOrEmpty(passwordText))
            {
                registerErrorProvider.SetError(password, "password must be filled!");
                return;
            }
            if (string.IsNullOrEmpty(confirmPasswordText))
            {
                registerErrorProvider.SetError(confirmPassword, "confirm password must be filled!");
                return;
            }
            if (string.Compare(passwordText, confirmPasswordText) != 0)
            {
                registerErrorProvider.SetError(confirmPassword, "password and confirm password must be the same!");
                return;
            }
            if(!agreeBool)
            {
                registerErrorProvider.SetError(RegisterTerms, "you need to check this field!");
                return;
            }
            registerErrorProvider.SetError(username, "");
            registerErrorProvider.SetError(email, "");
            registerErrorProvider.SetError(password, "");
            registerErrorProvider.SetError(confirmPassword, "");
            string newUserQuery = $"INSERT INTO `user` (`id_user`, `email`, `name`, `password`) VALUES (NULL, '{emailText}', '{usernameText}', '{passwordText}')";
            DatabaseConnector.ExecuteQuery(newUserQuery);
            LoggedUser.SetLoggedUser(emailText, usernameText, passwordText, false);

            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void goToLoginPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginPage = new Login();
            loginPage.Show();
        }


    }
}
