using System;
using Newtonsoft.Json;

namespace POS8.Models.BitPOS
{
    public class OrderResponse
    {
        [JsonProperty(PropertyName="id")]
        public String Id { get; set; }

        [JsonProperty(PropertyName = "satoshis")]
        public Int64 Satoshis { get; set; }

        [JsonProperty(PropertyName = "bitcoinAddress")]
        public String BitcoinAddress { get; set; }
    }
}
