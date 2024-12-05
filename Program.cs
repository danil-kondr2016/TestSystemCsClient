namespace TestSystemClient
{
    internal static class Program
    { 
        public static void ErrorUnimplemented()
        {
            TaskDialogPage page = new TaskDialogPage();
            page.Caption = "Ошибка";
            page.Icon = TaskDialogIcon.Error;
            page.Buttons = new TaskDialogButtonCollection { TaskDialogButton.OK };
            page.Heading = "На данный момент возможность не поддерживается.";

            TaskDialog.ShowDialog(page);
        }

        public static void ErrorLogin()
        {
            TaskDialogPage page = new TaskDialogPage();
            page.Caption = "Ошибка";
            page.Icon = TaskDialogIcon.Error;
            page.Buttons = new TaskDialogButtonCollection { TaskDialogButton.OK };
            page.Heading = "Произошла ошибка при входе в систему.";
            page.Text = "Пожалуйста, проверьте логин или пароль.";

            TaskDialog.ShowDialog(page);
        }

        static DialogResult RunRegister(Client client)
        {
            RegisterForm registerForm = new RegisterForm();
            DialogResult result;
            if ((result = registerForm.ShowDialog()) != DialogResult.OK)
                return result;

            if (client.Register(registerForm.UserName, registerForm.Email, registerForm.Password))
            {
                MessageBox.Show("Регистрация прошла успешно.", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return DialogResult.OK;
            }
            else
            {
                MessageBox.Show("При регистрации произошла ошибка.", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DialogResult.Abort;
            }
        }

        static DialogResult RunLogin(Client client)
        {
            LoginForm loginForm = new LoginForm();
            DialogResult result;

            if ((result = loginForm.ShowDialog()) != DialogResult.OK)
                return result;
            switch (loginForm.Result)
            {
                case LoginFormResult.Login:
                    client.ServerAddress = loginForm.ServerAddress;
                    bool loginResult = client.Login(loginForm.UserName, loginForm.Password);
                    if (!loginResult)
                    {
                        ErrorLogin();
                        return DialogResult.Abort;
                    }
                    else
                    {
                        MessageBox.Show("Вход произведён успешно.", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case LoginFormResult.Register:
                    return RunRegister(client);
                case LoginFormResult.ResetPassword:
                    break;
            }

            return DialogResult.OK;
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Client client = new Client();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            SelectRoleForm selectRoleForm = new SelectRoleForm(); 
            if (selectRoleForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            if (selectRoleForm.SelectedRole == UserRole.Organizator)
            {
                DialogResult result;
                while ((result = RunLogin(client)) == DialogResult.OK) ;

                if (result == DialogResult.Abort)
                    return;
                if (result == DialogResult.Continue)
                    return; // TODO the form 
            }
        }
    }
}