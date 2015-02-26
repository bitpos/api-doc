using System;

namespace POS8.Models
{
    public class Order
    {
        public String Reference { get; set; }

        public Decimal Amount { get; set; }

        public DateTime Created { get; set; }

        public Int32? Confirmations { get; set; }
    }
}
