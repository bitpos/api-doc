using Newtonsoft.Json;
using System;

namespace POS8.Models.BitPOS
{
    /// <summary>
    /// BitPOS DTO
    /// </summary>
    public class Order
    {
        [JsonProperty(PropertyName = "currency")]
        public String Currency { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public Int32 Amount { get; set; }

        public String reference { get; set; }

        public String description { get; set; }

        public String successURL { get; set; }

        public String failureURL { get; set; }

        public Order(String currency, Int32 amount, String description, String reference)
        {
            if (amount > 0)
            {
                this.Currency = currency;
                this.Amount = amount;
                this.description = description;
                this.reference = reference;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Amount cannot be less than zero");
            }
        }
    }
}
