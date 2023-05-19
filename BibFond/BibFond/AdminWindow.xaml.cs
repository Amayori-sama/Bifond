using System.Windows;
using System.Windows.Controls;

namespace BibFond
{
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void BookButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new AdminPages.BookPage());
        }

        private void PubButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new AdminPages.PubPage());
        }

        private void AuthorsButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new AdminPages.AuthorsPage());
        }
        private void ClientButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new AdminPages.UsersPage());
        }

        private void BackHomeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowManager.ChangeWindow("MainWindow", this);
        }
    }
}