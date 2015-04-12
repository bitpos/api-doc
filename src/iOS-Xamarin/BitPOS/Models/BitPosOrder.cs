using System;

namespace BitPOS.Models
{
	public class Order : IOrder
	{
		public Decimal Amount { get; set; }
		public String Reference { get; set; }
		public String Address { get; set; }
		public DateTime Created { get; set;}

		public Order ()
		{
		}

		public override string ToString ()
		{
			return string.Format ("{0} {1} {2}", Reference, Amount, Address);
		}
	}
}