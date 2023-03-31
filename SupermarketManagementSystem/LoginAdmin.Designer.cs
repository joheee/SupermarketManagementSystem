namespace SupermarketManagementSystem
{
    partial class LoginAdmin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.goToLoginPage = new System.Windows.Forms.Button();
            this.LoginHeader = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.LoginErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LoginErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "email:";
            // 
            // goToLoginPage
            // 
            this.goToLoginPage.Location = new System.Drawing.Point(12, 124);
            this.goToLoginPage.Name = "goToLoginPage";
            this.goToLoginPage.Size = new System.Drawing.Size(268, 23);
            this.goToLoginPage.TabIndex = 12;
            this.goToLoginPage.Text = "back to user login";
            this.goToLoginPage.UseVisualStyleBackColor = true;
            this.goToLoginPage.Click += new System.EventHandler(this.goToLoginPage_Click);
            // 
            // LoginHeader
            // 
            this.LoginHeader.AutoSize = true;
            this.LoginHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LoginHeader.Location = new System.Drawing.Point(66, 9);
            this.LoginHeader.Name = "LoginHeader";
            this.LoginHeader.Size = new System.Drawing.Size(163, 31);
            this.LoginHeader.TabIndex = 11;
            this.LoginHeader.Text = "Admin Login";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(12, 95);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(268, 23);
            this.loginButton.TabIndex = 10;
            this.loginButton.Text = "login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(90, 69);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(190, 20);
            this.password.TabIndex = 9;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(90, 43);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(190, 20);
            this.email.TabIndex = 8;
            // 
            // LoginErrorProvider
            // 
            this.LoginErrorProvider.ContainerControl = this;
            // 
            // LoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 157);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goToLoginPage);
            this.Controls.Add(this.LoginHeader);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginAdmin";
            this.Text = "LoginAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.LoginErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goToLoginPage;
        private System.Windows.Forms.Label LoginHeader;
        private System.Windows.Forms.Button loginButton;
        protected System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.ErrorProvider LoginErrorProvider;
    }
}