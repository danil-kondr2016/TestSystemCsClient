namespace TestSystemClient
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbServerAddress = new TextBox();
            tbUserName = new TextBox();
            tbPassword = new TextBox();
            btnLogin = new Button();
            btnResetPassword = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Адрес сервера";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 70);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Пароль";
            // 
            // tbServerAddress
            // 
            tbServerAddress.Location = new Point(105, 9);
            tbServerAddress.Name = "tbServerAddress";
            tbServerAddress.Size = new Size(209, 23);
            tbServerAddress.TabIndex = 3;
            tbServerAddress.Text = "http://localhost:8080";
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(105, 38);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(209, 23);
            tbUserName.TabIndex = 4;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(105, 67);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(209, 23);
            tbPassword.TabIndex = 5;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(12, 104);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(302, 23);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += this.btnLogin_Click;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Location = new Point(12, 162);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(302, 23);
            btnResetPassword.TabIndex = 7;
            btnResetPassword.Text = "Забыл пароль";
            btnResetPassword.UseVisualStyleBackColor = true;
            btnResetPassword.Click += this.btnResetPassword_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(12, 133);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(302, 23);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Зарегистрироваться";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += this.btnRegister_Click;
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 198);
            Controls.Add(btnRegister);
            Controls.Add(btnResetPassword);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbUserName);
            Controls.Add(tbServerAddress);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Войти";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbServerAddress;
        private TextBox tbUserName;
        private TextBox tbPassword;
        private Button btnLogin;
        private Button btnResetPassword;
        private Button btnRegister;
    }
}