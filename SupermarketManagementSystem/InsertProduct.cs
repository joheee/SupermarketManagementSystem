using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SupermarketManagementSystem
{
    public partial class InsertProduct : Form
    {
        public InsertProduct()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
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
            if(int.Parse(stockText) < 1)
            {
                ErrorMessageProvider.SetError(productStock, "product stock must be more than 0!");
                return;
            }
            string insertProductQuery = $"INSERT INTO `product` (`id_product`, `id_admin`, `name`, `description`, `stock`) VALUES (NULL, '{LoggedUser.id}', '{nameText}', '{descText}', '{stockText}')";
            DatabaseConnector.ExecuteQuery(insertProductQuery);
            this.Hide();
            HomeAdmin homeAdminPage = new HomeAdmin();
            homeAdminPage.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeAdmin homeAdminPage = new HomeAdmin();
            homeAdminPage.Show();  
        }
    }
}
