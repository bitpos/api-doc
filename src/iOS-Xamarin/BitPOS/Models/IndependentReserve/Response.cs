using System;

namespace BitPOS.Models.IndependentReserve
{
	public class Response
	{
		public Decimal CurrentLowestOfferPrice { get; set; }

		public Decimal CurrentHighestBidPrice { get; set; }

		public Response()
		{
		}
	}
}