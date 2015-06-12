using System.Runtime.Serialization;
using System.ServiceModel;

namespace QuickBooks.Wrapper.Response
{
    [DataContract(Name = "closeConnectionResponse")]
    [MessageContract(WrapperName = "closeConnectionResponse", IsWrapped = true)]
    public class CloseConnectionResponse
    {
        [DataMember(Name = "closeConnectionResult", IsRequired = true)]
        [MessageBodyMember(Name = "closeConnectionResult", Order = 1)]
        public string CloseConnectionResult { get; set; }

        public CloseConnectionResponse()
        {
            this.CloseConnectionResult = string.Empty;
        }
    }
}