using System;

namespace BitPOS
{
	public interface IOrder
	{
		Decimal Amount { get; set; }
		String Reference { get; set; }
		String Address { get; set; }
		DateTime Created { get; set;}
	}
}