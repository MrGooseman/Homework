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
    public class DBModel
    {
        public int SaleID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string SurName { get; set; }

         public List<ItemModel> Items { get; set; }


        public DBModel SetName(Client client)
        {
            this.FirstName = client.FirstName;
            this.LastName = client.LastName;
            this.SurName = client.SurName;

            return this;
        }
        public DBModel SetSaleID(Sale sale)
        {
            this.SaleID = sale.ID;
            return this;

        }
        public DBModel SetItem(IEnumerable<Item> items)
        {
            foreach (var item in items)
            {
                Items.Add(new ItemModel
                {
                      id = item.ID,
                      Name = item.Name,
                      Price = item.Price, 
                      Value = 1
                });
            }
           

            return this;
        }

        public static DBModel FromDB(Client client, Sale sale, IEnumerable<Item> item)
        {
            return new DBModel().SetItem(item).SetName(client).SetSaleID(sale);
        }
    }
}
