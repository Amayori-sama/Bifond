using System.Linq;
using System.Windows;

namespace BibFond
{
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void AuthorizationRollBack_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти из программы?", "Внимание", MessageBoxButton.OKCancel, MessageBoxImage.Warning) == MessageBoxResult.OK)
            {
                Close();
            }
        }

        private void AuthorizationCommit_Click(object sender, RoutedEventArgs e)
        {
            Base.users User = SourceCore.Base.users.SingleOrDefault(U => U.login == LoginText.Text && U.password == PasswordText.Text);
            if (User != null)
            {
                MainWindow.user = User;
                WindowManager.ChangeWindow("MainWindow", this);
            }
            else
            {
                MessageBox.Show("Неверно указан логин и/или пароль!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            };
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow window = new RegistrationWindow();
            Close();
            window.ShowDialog();
        }
    }
}