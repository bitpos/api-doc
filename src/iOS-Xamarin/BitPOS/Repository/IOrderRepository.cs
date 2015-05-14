using System;
using System.Collections.Generic;

namespace BitPOS.Repository
{
	public interface IOrderRepository
	{
		void AddOrder(IOrder order);
//		IList<IOrder> All ();
//		IOrder Select (String reference);
	}
}