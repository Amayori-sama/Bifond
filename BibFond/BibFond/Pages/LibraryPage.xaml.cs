using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BibFond.Base;

namespace BibFond.Pages
{
    /// <summary>
    /// Interaction logic for LibraryPage.xaml
    /// </summary>
    public partial class LibraryPage : Page
    {
        public LibraryPage()
        {
            InitializeComponent();
            DataContext = this;
            booksList.ItemsSource = SourceCore.Base.Book.ToList();
        }
        private void booksList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Book p = (Book)booksList.SelectedItem;
        } 
        private void LibraryPage_Loaded(object sender, RoutedEventArgs e)
        {
/*            // Первоначальная настройка фильтра данных для быстрого поиска,
            // при этом из фильтрации нужно исключить столбец "Управление"
            // Создание собствнного списка заголовков столбцов
            List<String> Columns = new List<string>();
            // Перебор и добавление в новый список только необходимых заголовков
            // Исключен столбец 4
            for (int i = 0; i < 6; i++)
            {
                Columns.Add(LibraryPageDataGrid.Columns[i].Header.ToString());
            }
            LibraryFilterComboBox.ItemsSource = Columns;
            LibraryFilterComboBox.SelectedIndex = 0;
            // Запрет на управление сортировкой щелчком по заголовку столбца
            foreach (DataGridColumn Column in LibraryPageDataGrid.Columns)
            {
                Column.CanUserSort = false;
            }*/
        }
        private void LibraryFilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
/*            var textbox = sender as TextBox;
            switch (LibraryFilterComboBox.SelectedIndex)
            {
                case 0:
                    LibraryPageDataGrid.ItemsSource = SourceCore.Base.Book.Where(q => q.ID.ToString().Contains(textbox.Text)).ToList();
                    break;
                case 1:
                    LibraryPageDataGrid.ItemsSource = SourceCore.Base.Book.Where(q => q.NAME.ToString().Contains(textbox.Text)).ToList();
                    break;
                case 2:
                    LibraryPageDataGrid.ItemsSource = SourceCore.Base.Book.Where(q => q.genre_ID.ToString().Contains(textbox.Text)).ToList();
                    break;
                case 3:
                    LibraryPageDataGrid.ItemsSource = SourceCore.Base.Book.Where(q => q.date_PRINTING.ToString().Contains(textbox.Text)).ToList();
                    break;
                case 4:
                    LibraryPageDataGrid.ItemsSource = SourceCore.Base.Book.Where(q => q.date_PUBLICATION.ToString().Contains(textbox.Text)).ToList();
                    break;
                case 5:
                    LibraryPageDataGrid.ItemsSource = SourceCore.Base.Book.Where(q => q.duration_READING.ToString().Contains(textbox.Text)).ToList();
                    break;
                case 6:
                    LibraryPageDataGrid.ItemsSource = SourceCore.Base.Book.Where(q => q.debt_PRICE.ToString().Contains(textbox.Text)).ToList();
                    break;
                case 7:
                    LibraryPageDataGrid.ItemsSource = SourceCore.Base.Book.Where(q => q.author.ToString().Contains(textbox.Text)).ToList();
                    break;
                case 8:
                    LibraryPageDataGrid.ItemsSource = SourceCore.Base.Book.Where(q => q.publishhouse.ToString().Contains(textbox.Text)).ToList();
                    break;
                case 9:
                    {
                        List<Base.Book> vs = new List<Base.Book>();
                        foreach (Base.Book c in SourceCore.Base.Book)
                        {
                            if (c.date_PUBLICATION.Value.ToShortDateString().Contains(textbox.Text))
                            {
                                vs.Add(c);
                            }
                        }
                        LibraryPageDataGrid.ItemsSource = vs;
                    }
                    break;
            }*/
        }

        private void AddBook_Click(object sender, MouseEventArgs e)
        {
            InfoBookWindow isn = new InfoBookWindow();
            isn.InfoBook.Content = "Добавление новой книги";
            isn.OkButton.Content = "Добавить книгу";
            isn.AddBookMyButton.Content = "Отменить";
            isn.DeleteBookMyButton.Visibility = Visibility.Hidden;
            isn.Show();            
        }
    }
}
