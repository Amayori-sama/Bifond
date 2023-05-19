using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace BibFond
{
    public partial class RegistrationWindow : Window
    {
        public string CaptchaValue { get; set; }
        public event EventHandler CaptchaRefreshed;

        public RegistrationWindow()
        {
            InitializeComponent();
            CreateCaptcha();
        }        
        //Captcha
        private void ResetCaptchaButton_Click(object sender, RoutedEventArgs e) => CreateCaptcha();
        private void CreateCaptcha()
        {
            string allowchar = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
            allowchar += "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,y,z";
            allowchar += "1,2,3,4,5,6,7,8,9,0";
            char[] a = { ',' };
            string[] ar = allowchar.Split(a);
            string pwd = string.Empty;
            Random r = new Random();

            for (int i = 0; i < 6; i++)
            {
                pwd += ar[r.Next(0, ar.Length)];
            }

            CaptchaText.Content = pwd;
            CaptchaValue = (string)CaptchaText.Content;
            CaptchaRefreshed?.Invoke(this, EventArgs.Empty);
        }

        private void PasswordButton_Click(object sender, RoutedEventArgs e)
        {
            // Переброска необходимой информации во временные буферы
            String Password = PasswordBox.Password;
            Visibility Visibility = PasswordBox.Visibility;
            double Width = PasswordBox.ActualWidth;
            // Изменение подписи на кнопке
            PasswordButton.Content = Visibility == Visibility.Visible ? "Скрыть" : "Показать";
            // Переброска информации из TextBox'а в PasswordBox
            PasswordBox.Password = PasswordTextBox.Text;
            PasswordBox.Visibility = PasswordTextBox.Visibility;
            PasswordBox.Width = PasswordTextBox.Width;
            // Возврат информации из временных буферов в TextBox
            PasswordTextBox.Text = Password;
            PasswordTextBox.Visibility = Visibility;
            PasswordTextBox.Width = Width;
            PasswordTextBox.TextAlignment = TextAlignment.Center;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow window = new AuthorizationWindow();
            Close();
            window.ShowDialog();
        }

        public static bool CheckUserExist(string login)
        {
            return SourceCore.Base.users.FirstOrDefault(cl => cl.login == login) == null;
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            if (CaptchaTextBox.Text == (string)CaptchaText.Content)
            {
                if (!CheckUserExist(LoginTextBox.Text))
                {
                    MessageBox.Show("Пользователь уже существует", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                // Создание и инициализация нового пользователя системы
                Base.users User = new Base.users
                {
                    name = NameTextBox.Text,
                    login = LoginTextBox.Text,
                    password = PasswordBox.Password != "" ? PasswordBox.Password : PasswordTextBox.Text,
                    admin = false,
                };

                // Добавление его в базу данных
                SourceCore.Base.users.Add(User);
                // Сохранение изменений
                SourceCore.Base.SaveChanges();
                new AuthorizationWindow().Show();
                Close();
            }
            else
            {
                MessageBox.Show("Неверно указана капча!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}