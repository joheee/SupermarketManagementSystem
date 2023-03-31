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
    public partial class UpdateProduct : Form
    {
        private int curr_id_product;
        public UpdateProduct(int id_product)
        {
            this.curr_id_product = id_product;
            InitializeComponent();
            initProductData(id_product);
        }

        void initProductData(int id_product)
        {
            string getProductQuery = $"select * from product where id_product = '{id_product}'";
            MySqlDataReader getProduct = DatabaseConnector.ExecuteQuery(getProductQuery);
            while(getProduct.Read()) { 
                productName.Text = getProduct.GetString(2);
                productDesc.Text = getProduct.GetString(3);
                productStock.Text = getProduct.GetString(4);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeAdmin homeAdmin = new HomeAdmin();
            homeAdmin.Show();   
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string nameText = productName.Text;
            string descText = productDesc.Text;
            string stockText = productStock.Text;
            if (string.IsNullOrEmpty(nameText))
            {
                ErrorMessageProvider.SetError(productName, "product name must be filled!");
                return;
            }
            if (string.IsNullOrEmpty(descText))
            {
                ErrorMessageProvider.SetError(productDesc, "product description must be filled!");
                return;
            }

            if (string.IsNullOrEmpty(stockText) || !int.TryParse(stockText, out _))
            {
                ErrorMessageProvider.SetError(productStock, "product stock cannot be empty or must be numeric!");
                return;
            }
            if (int.Parse(stockText) < 1)
            {
                ErrorMessageProvider.SetError(productStock, "product stock must be more than 0!");
                return;
            }
            string updateProductQuery = $"update product set name = '{nameText}', description = '{descText}', stock = '{stockText}' where id_product = '{curr_id_product}'";
            DatabaseConnector.ExecuteQuery(updateProductQuery);
            this.Hide();
            HomeAdmin homeAdmin = new HomeAdmin();
            homeAdmin.Show();
        }
    }
}
