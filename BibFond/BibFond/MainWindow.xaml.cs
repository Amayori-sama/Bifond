using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace BibFond
{
    public partial class MainWindow : Window
    {
        public static Base.users user = null;
        public Base.books SelectedBook;
        
        public MainWindow()
        {
            InitializeComponent();
            if (user != null)
            {
                ShowUserStackPanel();
            }
            booksList.ItemsSource = SourceCore.Base.books.ToList();
        }

        private void booksList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (booksList.SelectedItem != null)
            {
                SelectedBook = (Base.books)booksList.SelectedItem;
                RecordTextBookName.Content = SelectedBook.name;
                AuthorComboBox.Content = SelectedBook.author.fio.ToString();
                PubComboBox.Content = SelectedBook.publishhouse.pubName.ToString();
                RecordTextGenres.Content = SelectedBook.genres;
            }
            else
            {
                MessageBox.Show("Не выбрано ни одной книги!", "Сообщение", MessageBoxButton.OK);
            }
        }
        private void ShowUserStackPanel()
        {
            UserStackPanel.Visibility = Visibility.Visible;
            NameUser.Text = user.name;
            if (user.admin)
            {
                AdminPanelButton.Visibility = Visibility.Visible;
            }
        }

        private void AddCommit_Click(object sender, RoutedEventArgs e)
        {
            SelectedBook = (Base.books)booksList.SelectedItem;
            Base.myBooklist mylist = new Base.myBooklist
            {
                bookId = this.SelectedBook.id,
                userId = MainWindow.user.id,
            };
            // Добавление его в базу данных
            SourceCore.Base.myBooklist.Add(mylist);
            // Сохранение изменений
            try
            {
                SourceCore.Base.SaveChanges();
                MessageBox.Show("Книга успешно добавлена в ваш список!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void AddRollback_Click(object sender, RoutedEventArgs e)
        {
            RecordTextBookName.Content = null;
            AuthorComboBox.Content = null;
            PubComboBox.Content = null;
            RecordTextGenres.Content = null;
        }

        private void AdminPanel_Click(object sender, RoutedEventArgs e)
        {
            WindowManager.ChangeWindow("AdminWindow", this);
        }

        private void myBooksList_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowManager.ChangeWindow("MyBookWindow", this);
        }
    }
}