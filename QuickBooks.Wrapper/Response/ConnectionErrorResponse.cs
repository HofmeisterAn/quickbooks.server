using System.Runtime.Serialization;
using System.ServiceModel;

namespace QuickBooks.Wrapper.Response
{
    [DataContract(Name = "connectionErrorResponse")]
    [MessageContract(WrapperName = "connectionErrorResponse", IsWrapped = true)]
    public class ConnectionErrorResponse 
    {
        [DataMember(Name = "connectionErrorResult", IsRequired = true)]
        [MessageBodyMember(Name = "connectionErrorResult", Order = 1)]
        public string ConnectionErrorResult { get; set; }

        public ConnectionErrorResponse()
        {
            this.ConnectionErrorResult = "done";
        }

        public ConnectionErrorResponse(string connectionErrorResult)
        {
            this.ConnectionErrorResult = connectionErrorResult;
        }
    }
}