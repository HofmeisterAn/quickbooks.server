using System.Runtime.Serialization;
using System.ServiceModel;

namespace QB.Wrapper.Soap.Request
{
    [DataContract(Name = Name)]
    [MessageContract(WrapperName = Name, IsWrapped = true)]
    public class CloseConnection
    {
        private const string Name = "closeConnection";

        [DataMember(Name = "ticket", IsRequired = true)]
        [MessageBodyMember(Name = "ticket", Order = 1)]
        public string Ticekt { get; set; }
    }
}