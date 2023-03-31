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
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
            initTransactionData();
        }
        void initTransactionData()
        {
            string transactionQuery = $"select p.name, p.description, t.ammount, t.date from transaction t join product p on t.id_product = p.id_product where t.id_user = {LoggedUser.id}";
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = DatabaseConnector.ExercuteAdapater(transactionQuery);
            adapter.Fill(dt);
            TransactionGridView.DataSource = dt;
        }

        private void goToProductPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();  
        }
    }
}
