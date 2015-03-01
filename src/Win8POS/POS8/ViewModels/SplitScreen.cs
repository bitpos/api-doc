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

        public ObservableCollection<ViewModels.Order> Orders { get; set; }

        public Repositories.BitPOS Repo
        {
            get
            {
                return new Repositories.BitPOS(App.Settings.APIUser, App.Settings.APIPassword);
            }
        }

        public SplitScreen()
        {
            this.Orders = new ObservableCollection<ViewModels.Order>();
        }

        public async void GetOrders()
        {
            this.Orders.Add(new ViewModels.Order() { Amount = 15.95M, Confirmations = 2, Created = DateTime.Now, Reference = "12" });
            this.Orders.Add(new ViewModels.Order() { Amount = 10.00M, Confirmations = 5, Created = DateTime.Now, Reference = "12" });
        }
    }
}
