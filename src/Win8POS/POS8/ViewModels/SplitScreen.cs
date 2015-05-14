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

        /// <summary>
        /// Holds the order value.  Buttons will add or subtract to this property
        /// </summary>
        public Double OrderValue { get; set; }

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
            this.OrderValue = 0.0F;
        }

        public async void GetOrders()
        {
            this.Orders.Add(new ViewModels.Order() { FiatAmount = 15.95M, CryptoAmount=0.12M, Confirmations = 2, Created = DateTime.Now, Reference = "12" });
            this.Orders.Add(new ViewModels.Order() { FiatAmount = 10.00M, CryptoAmount=0.09M, Confirmations = 5, Created = DateTime.Now, Reference = "12", Status="Paid", Paid=true });
        }
    }
}
