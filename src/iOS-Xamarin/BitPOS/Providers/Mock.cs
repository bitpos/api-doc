using System;

namespace BitPOS.Providers
{
	public class Mock : Providers.IExchangeProvider
	{
		public Mock ()
		{
		}

		public Decimal GetRate(Decimal amount, String currencyCode)
		{
			return 300.1M;
		}
	}
}