using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementSystem
{
    internal class LoggedUser
    {
        public static int id;
        public static string email;
        public static string username;
        public static string password;
        public static Boolean isAdmin;

        public static void ResetUser()
        {
            id = -24;
            email = null;
            username = null;
            password = null;
            isAdmin = false;
        }

        public static void SetLoggedUser(string emailField, string usernameField, string passwordField, Boolean isAdminField)
        {
            string query = $"select * from user where name like '{usernameField}' and email like '{emailField}' and password like '{passwordField}'";
            MySqlDataReader user =  DatabaseConnector.ExecuteQuery(query);
            while(user.Read())
            {
                id = user.GetInt32(0);
                email = user.GetString(1);
                username = user.GetString(2);
                password = user.GetString(3);
                isAdmin = isAdminField;
            }
        }
    }
}
