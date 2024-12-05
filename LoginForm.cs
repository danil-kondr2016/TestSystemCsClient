using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSystemClient
{
    public enum LoginFormResult
    {
        Login, Register, ResetPassword
    };

    public partial class LoginForm : Form
    {
        public LoginFormResult Result { get; set; }
        public string ServerAddress { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public LoginForm()
        {
            ServerAddress = "";
            UserName = "";
            Password = "";
            Result = LoginFormResult.Login;

            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ServerAddress = tbServerAddress.Text;
            UserName = tbUserName.Text;
            Password = tbPassword.Text;
            Result = LoginFormResult.Login;
            DialogResult = DialogResult.OK;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Result = LoginFormResult.Register;
            DialogResult = DialogResult.OK;
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            Program.ErrorUnimplemented();
            Result = LoginFormResult.ResetPassword;
            DialogResult = DialogResult.Cancel;
        }
    }
}
