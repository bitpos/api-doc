using System;

namespace BitPOS.Models
{
    public class Order
    {
        public string currency { get; set; }

        public Int32 amount { get; set; }

        public String reference { get; set; }

        public String description { get; set; }

        public String successURL { get; set; }

        public String failureURL { get; set; }
    }
}
