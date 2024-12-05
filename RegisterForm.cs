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
    public partial class RegisterForm : Form
    {
        public string ServerAddress { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }  
        public string Password { get; set; }

        public RegisterForm()
        {
            ServerAddress = "";
            UserName = "";
            Email = "";
            Password = "";

            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text.CompareTo(tbRepeatPassword.Text) == 0)
            {
                ServerAddress = tbServerAddress.Text;
                UserName = tbUserName.Text;
                Email = tbEmail.Text;
                Password = tbPassword.Text;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Пароли не совпадают", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
