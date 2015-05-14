using System;
using System.Net;

namespace BitPOS
{
	public class IndependentReserve : Providers.IExchangeProvider
	{
		#region IExchangeProvider implementation

		public decimal GetRate (decimal amount, string currencyCode)
		{
			WebClient client = new WebClient();
			String json = client.DownloadString("https://api.independentreserve.com/Public/GetMarketSummary?primaryCurrencyCode=xbt&secondaryCurrencyCode=AUD");
			Models.IndependentReserve.Response irResponse = JsonConvert.DeserializeObject<Models.IndependentReserve.Response>(json);

			return irResponse.CurrentHighestBidPrice; //Sell
			//this.Ask = irResponse.CurrentLowestOfferPrice; //Buy
		}

		#endregion

		public IndependentReserve ()
		{
		}
	}
}