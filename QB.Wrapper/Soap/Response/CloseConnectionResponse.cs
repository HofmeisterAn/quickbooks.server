using System.Runtime.Serialization;
using System.ServiceModel;

namespace QB.Wrapper.Soap.Response
{
    [DataContract(Name = Name)]
    [MessageContract(WrapperName = Name, IsWrapped = true)]
    public class CloseConnectionResponse
    {
        private const string Name = "closeConnectionResponse";

        private const string Result = "closeConnectionResult";

        [DataMember(Name = Result, IsRequired = true)]
        [MessageBodyMember(Name = Result, Order = 1)]
        public string CloseConnectionResult { get; set; }
    }
}