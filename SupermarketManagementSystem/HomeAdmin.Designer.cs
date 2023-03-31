namespace SupermarketManagementSystem
{
    partial class HomeAdmin
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
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.insertButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductGridView
            // 
            this.ProductGridView.AllowUserToAddRows = false;
            this.ProductGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.update,
            this.delete});
            this.ProductGridView.Location = new System.Drawing.Point(12, 12);
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.Size = new System.Drawing.Size(776, 311);
            this.ProductGridView.TabIndex = 0;
            this.ProductGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGridView_CellContentClick);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(13, 330);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(113, 23);
            this.insertButton.TabIndex = 1;
            this.insertButton.Text = "insert product";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(132, 330);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // update
            // 
            this.update.DataPropertyName = "update";
            this.update.HeaderText = "update";
            this.update.Name = "update";
            this.update.Text = "update";
            this.update.UseColumnTextForButtonValue = true;
            // 
            // delete
            // 
            this.delete.DataPropertyName = "delete";
            this.delete.HeaderText = "delete";
            this.delete.Name = "delete";
            this.delete.Text = "delete";
            this.delete.UseColumnTextForButtonValue = true;
            // 
            // HomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 362);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.ProductGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HomeAdmin";
            this.Text = "HomeAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductGridView;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.DataGridViewButtonColumn update;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}