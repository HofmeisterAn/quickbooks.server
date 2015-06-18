using System.Runtime.Serialization;
using System.ServiceModel;

namespace QB.Wrapper.Soap.Request
{
    [DataContract(Name = Name)]
    [MessageContract(WrapperName = Name, IsWrapped = true)]
    public class ReceiveXML
    {
        private const string Name = "receiveResponseXML";

        [DataMember(Name = "ticket", IsRequired = true)]
        [MessageBodyMember(Name = "ticket", Order = 1)]
        public string Ticket { get; set; }

        [DataMember(Name = "response", IsRequired = true)]
        [MessageBodyMember(Name = "response", Order = 2)]
        public string Response { get; set; }

        [DataMember(Name = "hresult", IsRequired = true)]
        [MessageBodyMember(Name = "hresult", Order = 3)]
        public string HResult { get; set; }

        [DataMember(Name = "message", IsRequired = true)]
        [MessageBodyMember(Name = "message", Order = 4)]
        public string Message { get; set; }
    }
}