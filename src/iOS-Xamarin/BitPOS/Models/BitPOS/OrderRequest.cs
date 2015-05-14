using System;

namespace BitPOS.Models.BitPOS
{
	//Bitpos order
	public class OrderRequest
	{
		public String currency { get; set; }

		//[JsonProperty(PropertyName="amount")]
		public Int32 amount { get; set; }
		public String reference { get; set; }
		public String description { get; set; }
		public String successURL { get; set; }
		public String failureURL { get; set; }

		public OrderRequest()
		{
		}

		public override string ToString ()
		{
			return string.Format ("{0} {1}", reference, amount );
		}
	}
}