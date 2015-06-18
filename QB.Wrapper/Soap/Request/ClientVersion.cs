using System.Runtime.Serialization;
using System.ServiceModel;

namespace QB.Wrapper.Soap.Request
{
    [DataContract(Name = Name)]
    [MessageContract(WrapperName = Name, IsWrapped = true)]
    public class ClientVersion
    {
        private const string Name = "clientVersion";

        [DataMember(Name = "strVersion", IsRequired = true)]
        [MessageBodyMember(Name = "strVersion", Order = 1)]
        public string Version { get; set; }
    }
}