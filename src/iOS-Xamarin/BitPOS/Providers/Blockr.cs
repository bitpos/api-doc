using System;

namespace BitPOS.Providers
{
	public class Blockr : IBalanceProvider, IExchangeProvider
	{
		private Boolean testNet = false;

		public Blockr ()
		{
		}

		public Decimal GetBalance(String address, Int32 confirmations = 1)
		{
			//http://btc.blockr.io/api/v1/block/info/1
			throw new NotImplementedException ();
		}

		public Decimal GetRate(Decimal amount, String currencyCode)
		{
			//http://btc.blockr.io/api/v1/exchangerate/current
			throw new NotImplementedException ();
		}
	}
}