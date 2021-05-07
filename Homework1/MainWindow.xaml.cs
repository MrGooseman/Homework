
using Homework1.DataBase;
using Homework1.Pages;
using System;
using System.Collections.Generic;
using System.Drawing;
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
using System.Windows.Shapes;

namespace Homework1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CurrentUserData data = new CurrentUserData();
            LoginLabel.Content = data.Login;
            SurNameLabel.Content = data.SurName;
            NameLabel.Content = data.FirstName;
            LastNameLabel.Content = data.LastName;
        }
        
        private void CreateSaleButton_Click(object sender, RoutedEventArgs e)
        {
            CreateSaleWindow window = new CreateSaleWindow();
            if(window.ShowDialog()==true)
            {
                MessageBox.Show("New sale created");
            }
        }

        private void SaleButton_Click(object sender, RoutedEventArgs e)
        {
            FrameTable.NavigationService.Navigate(new Uri(@"pack://application:,,,/Pages/SaleTable.xaml"));
        }
    }
}
