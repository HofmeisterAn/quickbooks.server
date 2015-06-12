using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace QuickBooks.Wrapper.Request
{
    [DataContract(Name = "clientVersion")]
    [MessageContract(WrapperName = "clientVersion", IsWrapped = true)]
    public class ClientVersion
    {
        [DataMember(Name = "strVersion", IsRequired = true)]
        [MessageBodyMember(Name = "strVersion", Order = 1)]
        public string Version { get; set; }

        public ClientVersion()
        {
        }

        public ClientVersion(string version)
        {
            this.Version = version;
        }

        public override string ToString()
        {
            var sb = new StringBuilder("clientVersion");

            foreach (var p in this.GetType().GetProperties())
            {
                sb.Append(string.Format("; {0}: {1}", p.Name, p.GetValue(this, null)));
            }

            return sb.ToString();
        }
    }
}