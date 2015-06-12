using System.Runtime.Serialization;
using System.ServiceModel;

namespace QuickBooks.Wrapper.Response
{
    [DataContract(Name = "serverVersionResponse")]
    [MessageContract(WrapperName = "serverVersionResponse", IsWrapped = true)]
    public class ServerVersionResponse
    {
        [DataMember(Name = "serverVersionResult", IsRequired = true)]
        [MessageBodyMember(Name = "serverVersionResult", Order = 1)]
        public string ServerVersionResult { get; set; }

        public ServerVersionResponse()
        {
            this.ServerVersionResult = "1.0.0";
        }
    }
}