using System.Runtime.Serialization;
using System.ServiceModel;

namespace QB.Wrapper.Soap.Response
{
    [DataContract(Name = Name)]
    [MessageContract(WrapperName = Name, IsWrapped = true)]
    public class ServerVersionResponse
    {
        private const string Name = "serverVersionResponse";

        private const string Result = "serverVersionResult";

        [DataMember(Name = Result, IsRequired = true)]
        [MessageBodyMember(Name = Result, Order = 1)]
        public string ServerVersionResult { get; set; }

        public ServerVersionResponse()
        {
            this.ServerVersionResult = "1.0.0";
        }
    }
}