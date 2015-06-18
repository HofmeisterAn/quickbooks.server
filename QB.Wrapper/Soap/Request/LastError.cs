using System.Runtime.Serialization;
using System.ServiceModel;

namespace QB.Wrapper.Soap.Request
{
    [DataContract(Name = Name)]
    [MessageContract(WrapperName = Name, IsWrapped = true)]
    public class LastError
    {
        private const string Name = "getLastError";

        [DataMember(Name = "ticket", IsRequired = true)]
        [MessageBodyMember(Name = "ticket", Order = 1)]
        public string Ticket { get; set; }
    }
}