using Homework1.DataBase;
using Homework1.ViewModels;
using System;
using System.Collections.Generic;
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
    /// <summary>
    /// Логика взаимодействия для SaleTable.xaml
    /// </summary>
    public partial class SaleTable : Page
    {
        public SaleTable()
        {
            InitializeComponent();
            using (var context = new Model1())
            {
                context.Sale.Load();
                context.Client.Load();
                context.Item.Load();
                context.Sale_Items.Load();
                context.Client_Sales.Load();
                var sl = from s in context.Sale
                         join cl in context.Client_Sales on new { x1=s.ID } equals new { x1=cl.Sale_ID }
                         join c in context.Client on new { x1=cl.Client_ID } equals new { x1=c.ID }
                         join si in context.Sale_Items on new { x1=s.ID } equals new { x1=si.Sale_ID }
                         join i in context.Item on new { x1=si.Item_ID } equals new { x1=i.ID }
                         orderby new { i.ID }
                         select new { s.ID, c.FirstName, i.Name, i.Price };
                DBDataGrid.ItemsSource = sl.ToList();
            }

        }
    }
}
