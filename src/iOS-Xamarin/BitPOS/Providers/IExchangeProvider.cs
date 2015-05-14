using System;

namespace BitPOS.Providers
{
	public interface IExchangeProvider
	{
		Decimal GetRate(Decimal amount, String currencyCode);
	}
}