using System;
using Newtonsoft;

namespace BitPOS.Providers
{
	public class BlockChainInfo : IBalanceProvider, IExchangeProvider
	{
		public BlockChainInfo ()
		{
		}

		public Decimal GetBalance(String address, Int32 confirmations = 1)
		{
			return 0.0M;
		}

		public Decimal GetRate(Decimal amount, String currencyCode)
		{
			//https://blockchain.info/ticker
			return 300.0M;
		}
	}
}