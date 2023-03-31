namespace SupermarketManagementSystem
{
    partial class Transaction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TransactionGridView = new System.Windows.Forms.DataGridView();
            this.goToProductPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TransactionGridView
            // 
            this.TransactionGridView.AllowUserToAddRows = false;
            this.TransactionGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TransactionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionGridView.Location = new System.Drawing.Point(12, 12);
            this.TransactionGridView.Name = "TransactionGridView";
            this.TransactionGridView.Size = new System.Drawing.Size(776, 311);
            this.TransactionGridView.TabIndex = 0;
            // 
            // goToProductPage
            // 
            this.goToProductPage.Location = new System.Drawing.Point(12, 329);
            this.goToProductPage.Name = "goToProductPage";
            this.goToProductPage.Size = new System.Drawing.Size(163, 23);
            this.goToProductPage.TabIndex = 1;
            this.goToProductPage.Text = "back to product page";
            this.goToProductPage.UseVisualStyleBackColor = true;
            this.goToProductPage.Click += new System.EventHandler(this.goToProductPage_Click);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 362);
            this.Controls.Add(this.goToProductPage);
            this.Controls.Add(this.TransactionGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Transaction";
            this.Text = "Transaction";
            ((System.ComponentModel.ISupportInitialize)(this.TransactionGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TransactionGridView;
        private System.Windows.Forms.Button goToProductPage;
    }
}