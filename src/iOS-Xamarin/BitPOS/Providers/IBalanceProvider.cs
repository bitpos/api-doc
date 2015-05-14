using System;

namespace BitPOS.Providers
{
	public interface IBalanceProvider
	{
		Decimal GetBalance(String address, Int32 confirmations = 1);
	}
}