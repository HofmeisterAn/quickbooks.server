using System.Runtime.Serialization;
using System.ServiceModel;

namespace QB.Wrapper.Soap.Response
{
    [DataContract(Name = Name)]
    [MessageContract(WrapperName = Name, IsWrapped = true)]
    public class ConnectionErrorResponse 
    {
        private const string Name = "connectionErrorResponse";

        private const string Result = "connectionErrorResult";

        [DataMember(Name = Result, IsRequired = true)]
        [MessageBodyMember(Name = Result, Order = 1)]
        public string ConnectionErrorResult { get; set; }
    }
}