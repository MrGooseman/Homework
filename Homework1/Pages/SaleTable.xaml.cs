using Homework1.DataBase;
using Homework1.ViewModels;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Homework1.Pages
{
    public partial class SaleTable : Page
    {
        public SaleTable()
        {
            InitializeComponent();
            using (var context = new Model1())
            {
                context.Sale_Item.Load();
                context.Item.Load();
                context.Client.Load();
                DBDataGrid.ItemsSource =(from s in context.Sale_Item.Local
                                          join c in context.Client.Local on s.ID equals c.ID
                                          join i in context.Item.Local on s.ID equals i.ID
                                          select new
                                          {
                                              s.ID,
                                              c.FirstName,
                                              c.LastName,
                                              c.SurName,
                                              i.Name,
                                              i.Price
                                          });

            }
        }

        private void IDSort_Selected(object sender, RoutedEventArgs e)
        {
            using (var context = new Model1())
            {
                context.Sale_Item.Load();
                context.Item.Load();
                context.Client.Load();
                DBDataGrid.ItemsSource = (from s in context.Sale_Item.Local
                                          join c in context.Client.Local on s.ID equals c.ID
                                          join i in context.Item.Local on s.ID equals i.ID
                                          orderby s.ID
                                          select new
                                          {
                                              s.ID,
                                              c.FirstName,
                                              c.LastName,
                                              c.SurName,
                                              i.Name,
                                              i.Price
                                          });

            }
        }

        private void ItemNameSort_Selected(object sender, RoutedEventArgs e)
        {
            using (var context = new Model1())
            {
                context.Sale_Item.Load();
                context.Item.Load();
                context.Client.Load();
                DBDataGrid.ItemsSource = (from s in context.Sale_Item.Local
                                          join c in context.Client.Local on s.ID equals c.ID
                                          join i in context.Item.Local on s.ID equals i.ID
                                          orderby i.Name
                                          select new
                                          {
                                              s.ID,
                                              c.FirstName,
                                              c.LastName,
                                              c.SurName,
                                              i.Name,
                                              i.Price
                                          });

            }
        }
    }
}
