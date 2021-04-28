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
    public class DataGridDBViewModel
    {
        public ObservableCollection<FinalTable> db { get; set; }
        public FinalTable SelectedModel { get; set; }

        public DataGridDBViewModel()
        {
            db = new ObservableCollection<FinalTable>();

            using (var context = new Model1())
            {
                
            }
        }
    }
}
