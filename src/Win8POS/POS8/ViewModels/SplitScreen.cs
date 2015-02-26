using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS8.ViewModels
{
    public class SplitScreen
    {
        public String Title { get; set; }

        public Double Rate { get; set; }

        public String CurrencyCode { get; set; }

        public ObservableCollection<Models.Order> Orders { get; set; }


        public SplitScreen()
        {
            this.Orders = new ObservableCollection<Models.Order>();
        }

        public async void GetOrders()
        {

        }

        public static async Task<Models.Order> GetItemsAsync()
        {
            return new Models.Order() { Amount = 15.95M, Confirmations = 2, Created = DateTime.Now, Reference = "12" };
        }
    }
}
