using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace QuickBooks.Wrapper.Request
{
    [DataContract(Name = "closeConnection")]
    [MessageContract(WrapperName = "closeConnection", IsWrapped = true)]
    public class CloseConnection
    {
        [DataMember(Name = "ticket", IsRequired = true)]
        [MessageBodyMember(Name = "ticket", Order = 1)]
        public string Ticekt { get; set; }

        public CloseConnection()
        {
        }

        public CloseConnection(string ticket)
        {
            this.Ticekt = ticket;
        }

        public override string ToString()
        {
            var sb = new StringBuilder("closeConnection");

            foreach (var p in this.GetType().GetProperties())
            {
                sb.Append(string.Format("; {0}: {1}", p.Name, p.GetValue(this, null)));
            }

            return sb.ToString();
        }
    }
}