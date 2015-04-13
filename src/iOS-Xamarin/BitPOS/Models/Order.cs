using System;

namespace BitPOS.Models
{
	public class Order //: IOrder
	{
//		public Decimal Amount { get; set; }
//		public String Reference { get; set; }
//		public String Address { get; set; }
//		public DateTime Created { get; set;}

		public string currency { get; set; }
		public Int32 amount { get; set; }
		public String reference { get; set; }
		public String description { get; set; }
		public String successURL { get; set; }
		public String failureURL { get; set; }

		public Order()
		{
		}

		public override string ToString ()
		{
			return string.Format ("{0} {1} {2}", Reference, Amount, Address);
		}
	}
}