using System.Runtime.Serialization;
using System.ServiceModel;

namespace QB.Wrapper.Soap.Response
{
    [DataContract(Name = Name)]
    [MessageContract(WrapperName = Name, IsWrapped = true)]
    public class ReceiveXMLResponse
    {
        private const string Name = "receiveResponseXMLResponse";

        private const string Result = "receiveResponseXMLResult";

        [DataMember(Name = Result, IsRequired = true)]
        [MessageBodyMember(Name = Result, Order = 1)]
        public int ReceiveXMLResult { get; set; }
    }
}