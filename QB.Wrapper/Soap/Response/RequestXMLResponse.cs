using System.Runtime.Serialization;
using System.ServiceModel;

namespace QB.Wrapper.Soap.Response
{
    [DataContract(Name = Name)]
    [MessageContract(WrapperName = Name, IsWrapped = true)]
    public class RequestXMLResponse
    {
        private const string Name = "sendRequestXMLResponse";

        private const string Result = "sendRequestXMLResult";

        [DataMember(Name = Result, IsRequired = true)]
        [MessageBodyMember(Name = Result, Order = 1)]
        public string RequestXMLResult { get; set; }
    }
}