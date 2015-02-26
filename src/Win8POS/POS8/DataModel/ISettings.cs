using System;
namespace POS8.DataModel
{
    public interface ISettings
    {
        string APIPassword { get; set; }
        string APIUser { get; set; }
        string ForwardingAddress { get; set; }
    }
}
