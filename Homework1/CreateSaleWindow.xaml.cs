using Homework1.DataBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
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
    public partial class CreateSaleWindow : Window
    {
        public CreateSaleWindow()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            if (ClientSurNameText.Text!=""&&ClientFirstNameText.Text!=""&&ClientLastNameText.Text!=""&&ComboBoxViewModel.SelectedItem!=null&&ValueText.Text!="")
            {
                SaleCreator();
                DialogResult = true;
                Close();
            }
            else
            {
                MessageBox.Show("Fill all the fields");
            }
        }

        public void SaleCreator()
        {
            using (var cont = new Model1())
            {
                int client_status = 0;
                foreach (var client in cont.Client)
                {
                    if (client.FirstName == ClientFirstNameText.Text && client.LastName == ClientLastNameText.Text && client.SurName == ClientSurNameText.Text) client_status = 1;
                }
                if (client_status == 0)
                {
                    cont.Client.Add(new Client() { FirstName=ClientFirstNameText.Text, LastName=ClientLastNameText.Text, SurName=ClientSurNameText.Text});
                    MessageBox.Show("New client");
                }
                int sale_ID = 0;
                foreach (var sale in cont.Sale_Item)
                {
                    if (sale.Sale_ID > sale_ID) sale_ID = sale.Sale_ID;
                }
                MessageBox.Show(sale_ID.ToString(), "Sale_ID");
                for (int i = 0; i < Convert.ToInt32(ValueText.Text); i++)
                {
                    cont.Sale_Item.Add(new Sale_Item() { Sale_ID = sale_ID, Item=ComboBoxViewModel.SelectedItem });
                }
                cont.SaveChanges();
            }
        }

        private void ValueText_TextInput(object sender, TextCompositionEventArgs e)
        {
            if (e.Text == "0" || e.Text == "1" || e.Text == "2" || e.Text == "3" || e.Text == "4" || e.Text == "5" || e.Text == "6" || e.Text == "7" || e.Text == "8" || e.Text == "9")
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void ValueText_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.D0 || e.Key == Key.D1 || e.Key == Key.D2 || e.Key == Key.D3 || e.Key == Key.D4 || e.Key == Key.D5 || e.Key == Key.D6 || e.Key == Key.D7 || e.Key == Key.D8 || e.Key == Key.D9)
            {
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
