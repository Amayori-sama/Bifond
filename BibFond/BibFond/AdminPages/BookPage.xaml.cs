using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace BibFond.AdminPages
{
    public partial class BookPage : Page
    {
        private int DlgMode;
        public Base.books SelectedBook;
        public ObservableCollection<Base.books> Books;

        public BookPage()
        {
            InitializeComponent();
            DataContext = this;
            DlgLoad(false, "");
            AuthorComboBox.ItemsSource = SourceCore.Base.author.ToList();
            PubComboBox.ItemsSource = SourceCore.Base.publishhouse.ToList();
            UpdateGrid(null);
        }

        private void UpdateGrid(Base.books Book)
        {
            if ((Book == null) && (PageGrid.ItemsSource != null))
            {
                Book = (Base.books)PageGrid.SelectedItem;
            }
            Books = new ObservableCollection<Base.books>(SourceCore.Base.books);

            PageGrid.ItemsSource = Books;
            PageGrid.ItemsSource = SourceCore.Base.books.ToList();
            PageGrid.SelectedItem = Book;
            AuthorComboBox.Text = SourceCore.Base.author.ToString();
            PubComboBox.Text = SourceCore.Base.publishhouse.ToString();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> Columns = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                Columns.Add(PageGrid.Columns[i].Header.ToString());
            }
            FilterComboBox.ItemsSource = Columns;
            FilterComboBox.SelectedIndex = 0;

            foreach (DataGridColumn Column in PageGrid.Columns)
            {
                Column.CanUserSort = false;
            }
        }

        private void DlgLoad(bool b, string DlgModeContent)
        {
            if (b == true)
            {
                ColumnChange.Width = new GridLength(300);
                PageGrid.IsHitTestVisible = false;
                RecordLabel.Content = DlgModeContent + " запись";
                AddCommit.Content = DlgModeContent;
                RecordAdd.IsEnabled = false;
                RecordCopy.IsEnabled = false;
                RecordEdit.IsEnabled = false;
                RecordDellete.IsEnabled = false;
            }
            else
            {
                ColumnChange.Width = new GridLength(0);
                PageGrid.IsHitTestVisible = true;
                RecordAdd.IsEnabled = true;
                RecordCopy.IsEnabled = true;
                RecordEdit.IsEnabled = true;
                RecordDellete.IsEnabled = true;
                DlgMode = -1;
            }
        }

        private void FillTextBox()
        {
            RecordTextBookName.Text = SelectedBook.name;
            AuthorComboBox.Text = SelectedBook.author.fio.ToString();
            PubComboBox.Text = SelectedBook.publishhouse.pubName.ToString();
            RecordTextGenres.Text = SelectedBook.genres;
        }

        private void RecordAdd_Click(object sender, RoutedEventArgs e)
        {
            DlgLoad(true, "Добавить");
            DataContext = null;
            DlgMode = 0;
        }

        private void RecordkCopy_Click(object sender, RoutedEventArgs e)
        {
            if (PageGrid.SelectedItem != null)
            {
                DlgLoad(true, "Копировать");
                SelectedBook = (Base.books)PageGrid.SelectedItem;
                FillTextBox();
                DlgMode = 0;
            }
            else
            {
                MessageBox.Show("Не выбрано ни одной строки!", "Сообщение", MessageBoxButton.OK);
            }
        }

        private void RecordEdit_Click(object sender, RoutedEventArgs e)
        {
            if (PageGrid.SelectedItem != null)
            {
                DlgLoad(true, "Изменить");
                SelectedBook = (Base.books)PageGrid.SelectedItem;
                FillTextBox();
            }
            else
            {
                MessageBox.Show("Не выбрано ни одной строки!", "Сообщение", MessageBoxButton.OK);
            }
        }

        private void RecordDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Удалить запись?", "Внимание", MessageBoxButton.OKCancel, MessageBoxImage.Warning) == MessageBoxResult.OK)
            {

                try
                {
                    // Ссылка на удаляемую книгу
                    Base.books DeletingAccessory = (Base.books)PageGrid.SelectedItem;
                    // Определение ссылки, на которую должен перейти указатель после удаления
                    if (PageGrid.SelectedIndex < PageGrid.Items.Count - 1)
                    {
                        PageGrid.SelectedIndex++;
                    }
                    else
                    {
                        if (PageGrid.SelectedIndex > 0)
                        {
                            PageGrid.SelectedIndex--;
                        }
                    }
                    Base.books SelectingAccessory = (Base.books)PageGrid.SelectedItem;
                    SourceCore.Base.books.Remove(DeletingAccessory);
                    SourceCore.Base.SaveChanges();
                    UpdateGrid(SelectingAccessory);
                }
                catch
                {

                    MessageBox.Show("Невозможно удалить запись, так как она используется в других справочниках базы данных.",
                    "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.None);
                }
            }
        }

        private void FilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textbox = sender as TextBox;
            switch (FilterComboBox.SelectedIndex)
            {
                case 0:
                    PageGrid.ItemsSource = SourceCore.Base.books.Where(q => q.name.Contains(textbox.Text)).ToList();
                    break;
                case 1:
                    PageGrid.ItemsSource = SourceCore.Base.books.Where(q => q.author.fio.ToString().Contains(textbox.Text)).ToList();
                    break;
                case 2:
                    PageGrid.ItemsSource = SourceCore.Base.books.Where(q => q.publishhouse.pubName.ToString().Contains(textbox.Text)).ToList();
                    break;
                case 3:
                    PageGrid.ItemsSource = SourceCore.Base.books.Where(q => q.genres.ToString().Contains(textbox.Text)).ToList();
                    break;
            }
        }

        private void AddCommit_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrEmpty(RecordTextBookName.Text))
                errors.AppendLine("Укажите название книги");

            if (((Base.author)AuthorComboBox.SelectedItem == null) || (AuthorComboBox.Text == " ..."))
                errors.AppendLine("Укажите автора");

            if (((Base.publishhouse)PubComboBox.SelectedItem == null) || (PubComboBox.Text == " ..."))
                errors.AppendLine("Укажите издательство");

            if (string.IsNullOrEmpty(RecordTextGenres.Text))
                errors.AppendLine("Укажите жанр(-ы)");

            if (string.IsNullOrEmpty(RecordTextImage.Text))
                errors.AppendLine("Укажите название картинки");

            string[] buf = RecordTextImage.Text.Split('.');
            if (buf[buf.Length - 1] != "jpg")
                errors.AppendLine("Укажите название картинки");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (DlgMode == 0)
            {
                try
                {
                    var NewBase = new Base.books();
                    NewBase.name = RecordTextBookName.Text.Trim();
                    NewBase.author = (Base.author)AuthorComboBox.SelectedItem;
                    NewBase.publishhouse = (Base.publishhouse)PubComboBox.SelectedItem;
                    NewBase.genres = RecordTextGenres.Text.Trim();
                    NewBase.image = ActionsWithPictures.ConvertImageToBinary(RecordTextImage.Text);
                    SourceCore.Base.books.Add(NewBase);
                    SelectedBook = NewBase;
                }
                catch (Exception)
                {
                    MessageBox.Show("Введены некоректные данные");
                }
            }
            else
            {
                try
                {
                    var EditBase = new Base.books();
                    EditBase = SourceCore.Base.books.First(p => p.id == SelectedBook.id);
                    EditBase.name = RecordTextBookName.Text.Trim();
                    EditBase.author = (Base.author)AuthorComboBox.SelectedItem;
                    EditBase.publishhouse = (Base.publishhouse)PubComboBox.SelectedItem;
                    EditBase.genres = RecordTextGenres.Text.Trim();
                    EditBase.image = ActionsWithPictures.ConvertImageToBinary(RecordTextImage.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Введены некоректные данные");
                }
            }

            try
            {
                SourceCore.Base.SaveChanges();
                UpdateGrid(SelectedBook);
                DlgLoad(false, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void AddRollback_Click(object sender, RoutedEventArgs e)
        {
            UpdateGrid(SelectedBook);
            DlgLoad(false, "");
        }

        private void SelectFileButton_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                RecordTextImage.Text = openFileDialog.FileName;
            }
        }
    }
}