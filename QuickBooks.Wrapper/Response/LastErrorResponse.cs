using System.Runtime.Serialization;
using System.ServiceModel;

namespace QuickBooks.Wrapper.Response
{
    [DataContract(Name = "lastErrorResponse")]
    [MessageContract(WrapperName = "lastErrorResponse", IsWrapped = true)]
    public class LastErrorResponse
    {
        [DataMember(Name = "lastErrorResult", IsRequired = true)]
        [MessageBodyMember(Name = "lastErrorResult", Order = 1)]
        public string LastErrorResult { get; set; }

        public LastErrorResponse()
        {
            this.LastErrorResult = string.Empty;
        }

        public LastErrorResponse(string lastErrorResult)
        {
            this.LastErrorResult = lastErrorResult;
        }
    }
}