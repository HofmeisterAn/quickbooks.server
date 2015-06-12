using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace QuickBooks.Wrapper.Request
{
    [DataContract(Name = "receiveResponseXML")]
    [MessageContract(WrapperName = "receiveResponseXML", IsWrapped = true)]
    public class ReceiveXML
    {
        [DataMember(Name = "ticket", IsRequired = true)]
        [MessageBodyMember(Name = "ticket", Order = 1)]
        public string Ticket { get; set; }

        [DataMember(Name = "response", IsRequired = true)]
        [MessageBodyMember(Name = "response", Order = 2)]
        public string Response { get; set; }

        [DataMember(Name = "hresult", IsRequired = true)]
        [MessageBodyMember(Name = "hresult", Order = 3)]
        public string HResult { get; set; }

        [DataMember(Name = "message", IsRequired = true)]
        [MessageBodyMember(Name = "message", Order = 4)]
        public string Message { get; set; }
        
        public ReceiveXML()
        {
        }

        public ReceiveXML(string ticket, string response, string hResult, string message)
        {
            this.Ticket = ticket;
            this.Response = response;
            this.HResult = hResult;
            this.Message = message;
        }

        public override string ToString()
        {
            var sb = new StringBuilder("receiveResponseXML");

            foreach (var p in this.GetType().GetProperties())
            {
                sb.Append(string.Format("; {0}: {1}", p.Name, p.GetValue(this, null)));
            }

            return sb.ToString();
        }
    }
}