namespace TestSystemClient
{
    partial class RegisterForm
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
            btnCancel = new Button();
            btnRegister = new Button();
            tbRepeatPassword = new TextBox();
            label4 = new Label();
            tbEmail = new TextBox();
            label5 = new Label();
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
            label3.Location = new Point(12, 99);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Пароль";
            // 
            // tbServerAddress
            // 
            tbServerAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbServerAddress.Location = new Point(137, 9);
            tbServerAddress.Name = "tbServerAddress";
            tbServerAddress.Size = new Size(209, 23);
            tbServerAddress.TabIndex = 3;
            tbServerAddress.Text = "http://localhost:8080";
            // 
            // tbUserName
            // 
            tbUserName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbUserName.Location = new Point(137, 38);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(209, 23);
            tbUserName.TabIndex = 4;
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbPassword.Location = new Point(137, 96);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(209, 23);
            tbPassword.TabIndex = 6;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCancel.Location = new Point(12, 197);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(334, 23);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRegister.Location = new Point(12, 168);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(334, 23);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Зарегистрироваться";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // tbRepeatPassword
            // 
            tbRepeatPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbRepeatPassword.Location = new Point(137, 125);
            tbRepeatPassword.Name = "tbRepeatPassword";
            tbRepeatPassword.Size = new Size(209, 23);
            tbRepeatPassword.TabIndex = 7;
            tbRepeatPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 128);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 9;
            label4.Text = "Повторите пароль";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(137, 67);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(209, 23);
            tbEmail.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 70);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 11;
            label5.Text = "E-mail";
            // 
            // RegisterForm
            // 
            AcceptButton = btnRegister;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(358, 232);
            Controls.Add(tbEmail);
            Controls.Add(label5);
            Controls.Add(tbRepeatPassword);
            Controls.Add(label4);
            Controls.Add(btnRegister);
            Controls.Add(btnCancel);
            Controls.Add(tbPassword);
            Controls.Add(tbUserName);
            Controls.Add(tbServerAddress);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Arrow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegisterForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Зарегистрироваться";
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
        private Button btnCancel;
        private Button btnRegister;
        private TextBox tbRepeatPassword;
        private Label label4;
        private TextBox tbEmail;
        private Label label5;
    }
}