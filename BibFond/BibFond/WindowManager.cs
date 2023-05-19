using System.Windows;

namespace BibFond
{
    internal class WindowManager
    {
        public static void ChangeWindow(string nameWindow, Window currentWindow)
        {
            switch (nameWindow)
            {
                case "MainWindow":
                    MainWindow mainWindow = new MainWindow();
                    currentWindow.Hide();
                    mainWindow.ShowDialog();
                    currentWindow.Close();
                    break;
                case "RegistrationWindow":
                    RegistrationWindow registrationWindow = new RegistrationWindow();
                    currentWindow.Hide();
                    registrationWindow.ShowDialog();
                    currentWindow.Close();
                    break;
                case "AuthorizationWindow":
                    AuthorizationWindow authorizationWindow = new AuthorizationWindow();
                    currentWindow.Hide();
                    authorizationWindow.ShowDialog();
                    currentWindow.Close();
                    break;
                case "AdminWindow":
                    AdminWindow adminWindow = new AdminWindow();
                    currentWindow.Hide();
                    adminWindow.ShowDialog();
                    currentWindow.Close();
                    break;
                case "MyBookWindow":
                    MyBookWindow myBookWindow = new MyBookWindow();
                    currentWindow.Hide();
                    myBookWindow.ShowDialog();
                    currentWindow.Close();
                    break;
            }
        }
    }
}
