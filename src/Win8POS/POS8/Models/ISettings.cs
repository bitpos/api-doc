using System;

namespace POS8.Models
{
    public interface ISettings
    {
        String APIPassword { get; set; }
        String APIUser { get; set; }
        String ForwardingAddress { get; set; }
        Boolean TestNet { get; set; }
    }
}
