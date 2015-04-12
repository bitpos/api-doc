using System;

namespace BitPOS
{
	internal class Settings
	{
		internal static Providers.IExchangeProvider GetExchangeProvider()
		{
			return new Providers.Mock ();
		}
	}
}