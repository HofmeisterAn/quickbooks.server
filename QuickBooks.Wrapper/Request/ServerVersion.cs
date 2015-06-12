using System.Runtime.Serialization;
using System.ServiceModel;

namespace QuickBooks.Wrapper.Request
{
    [DataContract(Name = "serverVersion")]
    [MessageContract(WrapperName = "serverVersion", IsWrapped = true)]
    public class ServerVersion
    {
    }
}