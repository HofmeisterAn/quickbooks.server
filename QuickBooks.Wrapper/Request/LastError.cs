using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace QuickBooks.Wrapper.Request
{
    [DataContract(Name = "getLastError")]
    [MessageContract(WrapperName = "getLastError", IsWrapped = true)]
    public class LastError
    {
        [DataMember(Name = "ticket", IsRequired = true)]
        [MessageBodyMember(Name = "ticket", Order = 1)]
        public string Ticket { get; set; }

        public LastError()
        {
        }

        public LastError(string ticket)
        {
            this.Ticket = ticket;
        }

        public override string ToString()
        {
            var sb = new StringBuilder("lastError");

            foreach (var p in this.GetType().GetProperties())
            {
                sb.Append(string.Format("; {0}: {1}", p.Name, p.GetValue(this, null)));
            }

            return sb.ToString();
        }
    }
}