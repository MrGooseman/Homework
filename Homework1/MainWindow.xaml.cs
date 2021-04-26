
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
using System.Windows.Shapes;

namespace Homework1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(string _login)
        {
            InitializeComponent();
            LoginLabel.Content = _login;
        }
        private void CreateSaleButton_Click(object sender, RoutedEventArgs e)
        {
            //FrameTable.NavigationService.Navigate(new Uri("pack://application:,,,/Pages/CreateSalePage.xaml"));
            CreateSaleWindow window = new CreateSaleWindow();
            if(window.ShowDialog()==true)
            {
                MessageBox.Show("New sale created");
            }
        }

        private void SaleButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
