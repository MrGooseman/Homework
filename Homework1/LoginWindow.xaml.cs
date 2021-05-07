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

namespace Homework1 
{ 
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            LoginTextBox.Focus();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            PassTextBox.Text = PassBox.Password;
            if (LoginTextBox.Text != "" && (PassBox.Password != "" || PassTextBox.Text != ""))
            {
                if ((LoginTextBox.Text == "123" && PassBox.Password == "123") || LoginPasswordCheck(LoginTextBox.Text, PassTextBox.Text))
                {
                    MainWindow window = new MainWindow();
                    window.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Incorrect login or password", "LogIn error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Fill in all the fields!", "LogIn error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
        }

        private bool LoginPasswordCheck(string _login, string _password)
        {
            using (var context = new DataBase.Model1())
            {

                if (context.Users.FirstOrDefault(u => u.Login == _login && u.Password == _password) != null)
                {
                    CurrentUserData data = new CurrentUserData();
                    data.ID = context.Users.FirstOrDefault(p => p.Login == _login).ID;
                    data.FirstName = context.Users.FirstOrDefault(p => p.Login == _login).FirstName;
                    data.LastName = context.Users.FirstOrDefault(p => p.Login == _login).LastName;
                    data.SurName = context.Users.FirstOrDefault(p => p.Login == _login).SurName;
                    data.Login = context.Users.FirstOrDefault(p => p.Login == _login).Login;
                    return true;
                }
            }
            return false;
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            PassTextBox.Text = PassBox.Password;
            PassTextBox.Visibility = Visibility.Visible;
            PassBox.Visibility = Visibility.Hidden;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            PassBox.Password = PassTextBox.Text;
            PassTextBox.Visibility = Visibility.Hidden;
            PassBox.Visibility = Visibility.Visible;
        }

        private void LoginTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) LoginButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
        }
    }
}


