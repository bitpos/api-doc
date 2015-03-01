using System;

namespace POS8.ViewModels
{
    public class Order
    {
        public String Reference { get; set; }

        public Decimal Amount { get; set; }

        public DateTime Created { get; set; }

        public Int32? Confirmations { get; set; }

        public Boolean? Paid { get; set; } 
    }
}
