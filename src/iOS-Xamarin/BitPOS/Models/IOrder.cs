using System;

namespace BitPOS
{
	public interface IOrder
	{
		Decimal FiatAmount { get; set; }
		Int64 Satoshis { get; set; }
		String Reference { get; set; }
		String Address { get; set; }
		DateTime Created { get; set;}
	}
}