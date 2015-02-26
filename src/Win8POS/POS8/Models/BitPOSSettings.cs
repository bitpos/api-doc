using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS8.Models
{
    public class BitPOSSettings : ISettings
    {
        public String ForwardingAddress { get; set; }

        public String APIUser { get; set; }

        public String APIPassword { get; set; }
    }
}
