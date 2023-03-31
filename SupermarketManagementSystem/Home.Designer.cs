namespace SupermarketManagementSystem
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.buy = new System.Windows.Forms.DataGridViewButtonColumn();
            this.transactionButton = new System.Windows.Forms.Button();
            this.ErrorMessageProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.logoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorMessageProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductGridView
            // 
            this.ProductGridView.AllowUserToAddRows = false;
            this.ProductGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buy});
            this.ProductGridView.Location = new System.Drawing.Point(12, 12);
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.Size = new System.Drawing.Size(776, 311);
            this.ProductGridView.TabIndex = 0;
            this.ProductGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGridView_CellContentClick);
            // 
            // buy
            // 
            this.buy.HeaderText = "buy";
            this.buy.Name = "buy";
            this.buy.Text = "buy";
            this.buy.UseColumnTextForButtonValue = true;
            // 
            // transactionButton
            // 
            this.transactionButton.Location = new System.Drawing.Point(12, 329);
            this.transactionButton.Name = "transactionButton";
            this.transactionButton.Size = new System.Drawing.Size(102, 23);
            this.transactionButton.TabIndex = 1;
            this.transactionButton.Text = "transaction log";
            this.transactionButton.UseVisualStyleBackColor = true;
            this.transactionButton.Click += new System.EventHandler(this.transactionButton_Click);
            // 
            // ErrorMessageProvider
            // 
            this.ErrorMessageProvider.ContainerControl = this;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(120, 329);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 362);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.transactionButton);
            this.Controls.Add(this.ProductGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorMessageProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductGridView;
        private System.Windows.Forms.DataGridViewButtonColumn buy;
        private System.Windows.Forms.Button transactionButton;
        private System.Windows.Forms.ErrorProvider ErrorMessageProvider;
        private System.Windows.Forms.Button logoutButton;
    }
}