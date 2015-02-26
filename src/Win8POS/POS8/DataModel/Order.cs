using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS8.DataModel
{
    public class Order
    {
        public String Reference { get; set; }

        public Decimal Amount { get; set; }

        public DateTime Created { get; set; }

        public Int32? Confirmations { get; set; }
    }
}
