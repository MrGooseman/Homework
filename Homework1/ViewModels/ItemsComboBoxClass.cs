using Homework1.DataBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.ViewModels
{
    class ItemsComboBoxClass
    {
        public ItemsComboBoxClass()
        {
            using (var context = new Model1())
            {
                context.Item.Load();
                Items = new ObservableCollection<Item>(context.Item.Local.ToList());
            }
        }
        public ObservableCollection<Item> Items { get; set; }
        public Item SelectedItem { get; set; }
    }
}
