using System.Runtime.Serialization;
using System.ServiceModel;

namespace QuickBooks.Wrapper.Response
{
    [DataContract(Name = "sendRequestXMLResponse")]
    [MessageContract(WrapperName = "sendRequestXMLResponse", IsWrapped = true)]
    public class RequestXMLResponse
    {
        [DataMember(Name = "sendRequestXMLResult", IsRequired = true)]
        [MessageBodyMember(Name = "sendRequestXMLResult", Order = 1)]
        public string RequestXMLResult { get; set; }

        public RequestXMLResponse()
        {
            this.RequestXMLResult = string.Empty;
        }

        public RequestXMLResponse(string requestXmlResult)
        {
            this.RequestXMLResult = requestXmlResult;
        }
    }
}