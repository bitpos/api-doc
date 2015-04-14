using System;

namespace BitPOS.Models
{
	public class Order : IOrder
	{
		public Decimal FiatAmount { get; set; }
		public Int64 Satoshis { get; set; }
		public String Reference { get; set; }
		public String Address { get; set; }
		public DateTime Created { get; set;}

		public Order ()
		{
		}
	}
}