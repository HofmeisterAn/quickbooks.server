using System.Runtime.Serialization;
using System.ServiceModel;

namespace QuickBooks.Wrapper.Response
{
    [DataContract(Name = "clientVersionResponse")]
    [MessageContract(WrapperName = "clientVersionResponse", IsWrapped = true)]
    public class ClientVersionResponse
    {
        [DataMember(Name = "clientVersionResult", IsRequired = true)]
        [MessageBodyMember(Name = "clientVersionResult", Order = 1)]
        public string ClientVersionResult { get; set; }

        public ClientVersionResponse()
        {
            this.ClientVersionResult = "O:2.0";
        }
    }
}