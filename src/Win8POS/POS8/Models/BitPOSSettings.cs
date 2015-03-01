using System;

namespace POS8.Models
{
    public class BitPOSSettings : ISettings
    {
        public String ForwardingAddress { get; set; }

        public String APIUser { get; set; }

        public String APIPassword { get; set; }

        public Boolean TestNet
        {
            get;
            set;
        }
    }
}
