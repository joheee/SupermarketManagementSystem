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
    public partial class HomeAdmin : Form
    {
        public HomeAdmin()
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
            if (e.ColumnIndex == ProductGridView.Columns["update"].Index)
            {
                int id_product = Convert.ToInt32(ProductGridView.Rows[e.RowIndex].Cells["id_product"].Value);
                this.Hide();
                UpdateProduct updateProduct = new UpdateProduct(id_product);
                updateProduct.Show();
            }

            if (e.ColumnIndex == ProductGridView.Columns["delete"].Index)
            {
                int id_product = Convert.ToInt32(ProductGridView.Rows[e.RowIndex].Cells["id_product"].Value);
                string deleteProductQuery = $"delete from product where id_product = '{id_product}'";
                DatabaseConnector.ExecuteQuery(deleteProductQuery);
                initProductData();
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertProduct insertProductPage = new InsertProduct();  
            insertProductPage.Show();   
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
