using System;
using Newtonsoft.Json;

namespace BitPOS.Models
{
	public class OrderResponse
	{
		[JsonProperty(PropertyName="id")]
		public Int64 Id { get; set; }

		public String successUrl { get; set; }

		public String bitcoinAddress { get; set; }

		public String reference { get; set; }

		public String transactionSpeed { get; set; }

		public OrderResponse ()
		{
		}
	}
}