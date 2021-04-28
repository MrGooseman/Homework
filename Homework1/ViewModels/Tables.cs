using Homework1.DataBase;
using System.Collections.Generic;
using System.Linq;

namespace Homework1.ViewModels
{
    public class ItemModel
    {

        public int id { get; set; }

        public string Name { get; set; }
        public int Value { get; set; }

        public decimal Price { get; set; }


    }
    public class FinalTable
    {
        public int SaleID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string SurName { get; set; }

        public string ItemName { get; set; }

        public int Value { get; set; }

        public decimal Price { get; set; }

        //public List<ItemModel> Items { get; set; }

        public FinalTable SetSaleID(Sale sale)
        {
            SaleID = sale.ID;
            return this;
        }
        public FinalTable SetClientData(Client client)
        {
            FirstName = client.FirstName;
            LastName = client.LastName;
            SurName = client.SurName;
            return this;
        }
        public FinalTable SetItemData(IEnumerable<Item> items)
        {
            foreach (var item in items)
            {
                
            }
            return this;
        }
        public FinalTable Final() 
        {

            return this;
        }
        //public static FinalTable FromDB(IEnumerable<Sale> sale, Item item)
        //{
        //    return new FinalTable().SetItemData(item).SetSaleID(sale);
        //}

        public static FinalTable FromDB(Client client, Sale sale, IEnumerable<Item> item)
        {
            return new FinalTable().SetClientData(client).SetItemData(item).SetSaleID(sale);
        }
        public static FinalTable FromDB1(IEnumerable<Client> client, IEnumerable<Sale> sale, IEnumerable<Item> items)
        {
            
            return new FinalTable();
        }
    }
}