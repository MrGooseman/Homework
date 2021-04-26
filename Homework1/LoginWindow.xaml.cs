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
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTextBox.Text != "" && (PassBox.Password != "" || PassTextBox.Text != ""))
            {
                if (LoginTextBox.Text == "login1" && (PassBox.Password == "tuptup" || PassTextBox.Text == "tuptup"))
                {
                    MainWindow window = new MainWindow(LoginTextBox.Text);
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
    }
}
