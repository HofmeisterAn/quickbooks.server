using System.Runtime.Serialization;
using System.ServiceModel;

namespace QuickBooks.Wrapper.Response
{
    [DataContract(Name = "receiveResponseXMLResponse")]
    [MessageContract(WrapperName = "receiveResponseXMLResponse", IsWrapped = true)]
    public class ReceiveXMLResponse
    {
        [DataMember(Name = "receiveResponseXMLResult", IsRequired = true)]
        [MessageBodyMember(Name = "receiveResponseXMLResult", Order = 1)]
        public int ReceiveXMLResult { get; set; }

        public ReceiveXMLResponse()
        {
            this.ReceiveXMLResult = 0;
        }

        public ReceiveXMLResponse(int receiveXMLResult)
        {
            this.ReceiveXMLResult = receiveXMLResult;
        }
    }
}