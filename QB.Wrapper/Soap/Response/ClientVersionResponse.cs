using System.Runtime.Serialization;
using System.ServiceModel;

namespace QB.Wrapper.Soap.Response
{
    [DataContract(Name = Name)]
    [MessageContract(WrapperName = Name, IsWrapped = true)]
    public class ClientVersionResponse
    {
        private const string Name = "clientVersionResponse";

        private const string Result = "clientVersionResult";

        [DataMember(Name = Result, IsRequired = true)]
        [MessageBodyMember(Name = Result, Order = 1)]
        public string ClientVersionResult { get; set; }

        public ClientVersionResponse()
        {
            this.ClientVersionResult = "O:2.0";
        }
    }
}