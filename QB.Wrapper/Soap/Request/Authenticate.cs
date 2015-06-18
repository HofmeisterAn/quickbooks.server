using System.Runtime.Serialization;
using System.ServiceModel;

namespace QB.Wrapper.Soap.Request
{
    [DataContract(Name = Name)]
    [MessageContract(WrapperName = Name, IsWrapped = true)]
    public class Authenticate
    {
        private const string Name = "authenticate";

        [DataMember(Name = "strUserName", IsRequired = true)]
        [MessageBodyMember(Name = "strUserName", Order = 1)]
        public string Username { get; set; }

        [DataMember(Name = "strPassword", IsRequired = true)]
        [MessageBodyMember(Name = "strPassword", Order = 2)]
        public string Password { get; set; }
    }
}