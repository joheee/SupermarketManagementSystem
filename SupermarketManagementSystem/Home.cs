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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            initProductData();
        }
        void initProductData()
        {
            string productQuery = "select id_product,name,description,stock from product";
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = DatabaseConnector.ExercuteAdapater(productQuery);
            adapter.Fill(dt);
            ProductGridView.DataSource = dt;
        }

        private void ProductGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ProductGridView.Columns["buy"].Index)
            {
                int id_product = Convert.ToInt32(ProductGridView.Rows[e.RowIndex].Cells["id_product"].Value);

                // cari product
                string findProductQuery = $"select * from product where id_product = '{id_product}'";
                MySqlDataReader findProduct = DatabaseConnector.ExecuteQuery(findProductQuery);
                while(findProduct.Read())
                {
                    // stock product lebih gede dari 0
                    if(findProduct.GetInt32(4) > 0)
                    {
                        ErrorMessageProvider.SetError(transactionButton, "");

                        // cari transaction
                        string findTransactionQuery = $"select * from transaction where id_product = '{id_product}' and id_user = '{LoggedUser.id}'";
                        MySqlDataReader findTransaction = DatabaseConnector.ExecuteQuery(findTransactionQuery);
                        while(findTransaction.Read())
                        {
                            // kalo ketemu di update
                            string updateTransactionQuery = $"update transaction set ammount  = ammount + 1 where id_product = '{id_product}' and id_user = '{LoggedUser.id}'";
                            DatabaseConnector.ExecuteQuery(updateTransactionQuery);

                            // update stock product
                            string reduceProductStockUpdateQuery = $"update product set stock = stock - 1 where id_product = '{id_product}'";
                            DatabaseConnector.ExecuteQuery(reduceProductStockUpdateQuery);
                            initProductData();
                            return;
                        }
                        // kalo gaada buat baru transaction dengan ammount = 1
                        string insertTransactionQuery = $"INSERT INTO `transaction` (`id_product`, `id_user`, `ammount`, `date`) VALUES ('{id_product}', '{LoggedUser.id}', '1', current_timestamp())";
                        DatabaseConnector.ExecuteQuery(insertTransactionQuery);

                        // update stock product
                        string reduceProductStockInsertQuery = $"update product set stock = stock - 1 where id_product = '{id_product}'";
                        DatabaseConnector.ExecuteQuery(reduceProductStockInsertQuery);
                        initProductData();
                        return;
                    } else
                    {
                        ErrorMessageProvider.SetError(transactionButton, "product is run out of stock!");
                    }
                }
            }
        }

        private void transactionButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transaction transactionPage = new Transaction();
            transactionPage.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginPage = new Login();
            LoggedUser.ResetUser();
            loginPage.Show();
        }
    }
}
