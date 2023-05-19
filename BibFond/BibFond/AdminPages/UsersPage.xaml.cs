using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace BibFond.AdminPages
{
    public partial class UsersPage : Page
    {
        public UsersPage()
        {
            InitializeComponent();
            DataContext = this;
            UpdateGrid(null);
            DlgLoad(false, "");
            RecordComboBoxIsAdmin.ItemsSource = new List<bool>() { true, false };
        }

        private int DlgMode = 0;
        public Base.users SelectedItem;
        public ObservableCollection<Base.users> Users;

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

        private void UpdateGrid(Base.users user)
        {
            if ((user == null) && (PageGrid.ItemsSource != null))
            {
                user = (Base.users)PageGrid.SelectedItem;
            }
            Users = new ObservableCollection<Base.users>(SourceCore.Base.users);
            PageGrid.ItemsSource = Users;
            PageGrid.SelectedItem = user;
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
            RecordTextLogin.Text = SelectedItem.login;
            RecordTextName.Text = SelectedItem.name;
            RecordComboBoxIsAdmin.SelectedItem = SelectedItem.admin;
            RecordTextPassword.Text = SelectedItem.password;
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
                SelectedItem = (Base.users)PageGrid.SelectedItem;
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
                SelectedItem = (Base.users)PageGrid.SelectedItem;
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
                    Base.users DeletingAccessory = (Base.users)PageGrid.SelectedItem;
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

                    if (DeletingAccessory.id == MainWindow.user.id)
                    {
                        MessageBox.Show("Нельзя удалить самого себя!");
                    }
                    else 
                    {
                        Base.users SelectingAccessory = (Base.users)PageGrid.SelectedItem;
                        SourceCore.Base.users.Remove(DeletingAccessory);
                        SourceCore.Base.SaveChanges();
                        UpdateGrid(SelectingAccessory);
                    }
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
                    PageGrid.ItemsSource = SourceCore.Base.users.Where(q => q.name.Contains(textbox.Text)).ToList();
                    break;
                case 1:
                    PageGrid.ItemsSource = SourceCore.Base.users.Where(q => q.login.ToString().Contains(textbox.Text)).ToList();
                    break;
                case 2:
                    PageGrid.ItemsSource = SourceCore.Base.users.Where(q => q.password.ToString().Contains(textbox.Text)).ToList();
                    break;
                case 3:
                    PageGrid.ItemsSource = SourceCore.Base.users.Where(q => q.admin.ToString().Contains(textbox.Text)).ToList();
                    break;
            }
        }

        private void AddCommit_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrEmpty(RecordTextName.Text))
                errors.AppendLine("Укажите имя пользователя");

            if (string.IsNullOrEmpty(RecordTextLogin.Text))
                errors.AppendLine("Укажите логин пользователя");

            if (RecordComboBoxIsAdmin.SelectedItem == null)
                errors.AppendLine("Укажите ограничения(администратор)");

            if (string.IsNullOrEmpty(RecordTextPassword.Text))
                errors.AppendLine("Укажите пароль пользователя");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (DlgMode == 0)
            {
                var NewBase = new Base.users();
                NewBase.name = RecordTextName.Text.Trim();
                NewBase.login = RecordTextLogin.Text.Trim();
                NewBase.admin = (bool)RecordComboBoxIsAdmin.SelectedItem;
                NewBase.password = RecordTextPassword.Text.Trim();
                SourceCore.Base.users.Add(NewBase);
                SelectedItem = NewBase;
            }
            else
            {
                var EditBase = new Base.users();
                EditBase = SourceCore.Base.users.First(p => p.id == SelectedItem.id);
                EditBase.name = RecordTextName.Text.Trim();
                EditBase.login = RecordTextLogin.Text.Trim();
                EditBase.admin = (bool)RecordComboBoxIsAdmin.SelectedItem;
                EditBase.password = RecordTextPassword.Text.Trim();
            }

            try
            {
                SourceCore.Base.SaveChanges();
                UpdateGrid(SelectedItem);
                DlgLoad(false, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void AddRollback_Click(object sender, RoutedEventArgs e)
        {
            UpdateGrid(SelectedItem);
            DlgLoad(false, "");
        }
    }
}