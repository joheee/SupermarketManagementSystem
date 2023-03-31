namespace SupermarketManagementSystem
{
    partial class Register
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
            this.goToLoginPage = new System.Windows.Forms.Button();
            this.RegisterHeader = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.RegisterTerms = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.registerErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.registerErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // goToLoginPage
            // 
            this.goToLoginPage.Location = new System.Drawing.Point(10, 200);
            this.goToLoginPage.Name = "goToLoginPage";
            this.goToLoginPage.Size = new System.Drawing.Size(268, 23);
            this.goToLoginPage.TabIndex = 9;
            this.goToLoginPage.Text = "already have an account? let\'s go login";
            this.goToLoginPage.UseVisualStyleBackColor = true;
            this.goToLoginPage.Click += new System.EventHandler(this.goToLoginPage_Click);
            // 
            // RegisterHeader
            // 
            this.RegisterHeader.AutoSize = true;
            this.RegisterHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.RegisterHeader.Location = new System.Drawing.Point(51, 9);
            this.RegisterHeader.Name = "RegisterHeader";
            this.RegisterHeader.Size = new System.Drawing.Size(181, 31);
            this.RegisterHeader.TabIndex = 8;
            this.RegisterHeader.Text = "User Register";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(10, 171);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(268, 23);
            this.registerButton.TabIndex = 7;
            this.registerButton.Text = "register";
            this.registerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(88, 95);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(190, 20);
            this.password.TabIndex = 6;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(88, 43);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(190, 20);
            this.username.TabIndex = 5;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(88, 69);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(190, 20);
            this.email.TabIndex = 10;
            // 
            // confirmPassword
            // 
            this.confirmPassword.Location = new System.Drawing.Point(88, 121);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.PasswordChar = '*';
            this.confirmPassword.Size = new System.Drawing.Size(190, 20);
            this.confirmPassword.TabIndex = 11;
            // 
            // RegisterTerms
            // 
            this.RegisterTerms.AutoSize = true;
            this.RegisterTerms.Location = new System.Drawing.Point(10, 148);
            this.RegisterTerms.Name = "RegisterTerms";
            this.RegisterTerms.Size = new System.Drawing.Size(167, 17);
            this.RegisterTerms.TabIndex = 12;
            this.RegisterTerms.Text = "I agree with terms and service";
            this.RegisterTerms.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(7, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(7, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(7, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "confirm:";
            // 
            // registerErrorProvider
            // 
            this.registerErrorProvider.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 236);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegisterTerms);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.email);
            this.Controls.Add(this.goToLoginPage);
            this.Controls.Add(this.RegisterHeader);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Register";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.registerErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goToLoginPage;
        private System.Windows.Forms.Label RegisterHeader;
        private System.Windows.Forms.Button registerButton;
        protected System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        protected System.Windows.Forms.TextBox email;
        protected System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.CheckBox RegisterTerms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider registerErrorProvider;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}