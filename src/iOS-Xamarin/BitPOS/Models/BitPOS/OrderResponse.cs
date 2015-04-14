using System;
using Newtonsoft.Json;

namespace BitPOS.Models.BitPOS
{
	public class OrderResponse
	{
		[JsonProperty(PropertyName="id")]
		public Int64 Id { get; set; }

		public String successUrl { get; set; }

		public String bitcoinAddress { get; set; }

		public String reference { get; set; }

		public String transactionSpeed { get; set; }

		public String description { get; set; }

		public String encodedOrderId { get; set; }

		public Int64 satoshis { get; set; }

		public String bitcoinUri { get; set; }

		public OrderResponse ()
		{
		}
	}
}