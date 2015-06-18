using System.Runtime.Serialization;
using System.ServiceModel;

namespace QB.Wrapper.Soap.Response
{
    [DataContract(Name = Name)]
    [MessageContract(WrapperName = Name, IsWrapped = true)]
    public class AuthenticateResponse
    {
        private const string Name = "authenticateResponse";

        private const string Result = "authenticateResult";

        [DataMember(Name = Result, IsRequired = true)]
        [MessageBodyMember(Name = Result, Order = 1)]
        public ArrayOfString AuthenticateResult { get; set; }

        public AuthenticateResponse()
        {
            this.AuthenticateResult = new ArrayOfString();
        }
    }
}