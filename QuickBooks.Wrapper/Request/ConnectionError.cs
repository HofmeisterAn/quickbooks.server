using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace QuickBooks.Wrapper.Request
{
    [DataContract(Name = "connectionError")]
    [MessageContract(WrapperName = "connectionError", IsWrapped = true)]
    public class ConnectionError
    {
        // 0x80040400 - QuickBooks found an error when parsing the provided XML text stream. 
        public const string QB_ERROR_WHEN_PARSING = "0x80040400";
        
        // 0x80040401 - Could not access QuickBooks.
        public const string QB_COULDNT_ACCESS_QB = "0x80040401";

        // 0x80040402 - Unexpected error. Check the qbsdklog.txt file
        public const string QB_UNEXPECTED_ERROR = "0x80040402";

        [DataMember(Name = "ticket", IsRequired = true)]
        [MessageBodyMember(Name = "ticket", Order = 1)]
        public string Ticket { get; set; }

        [DataMember(Name = "hresult", IsRequired = true)]
        [MessageBodyMember(Name = "hresult", Order = 2)]
        public string HResult { get; set; }

        [DataMember(Name = "message", IsRequired = true)]
        [MessageBodyMember(Name = "message", Order = 3)]
        public string Message { get; set; }

        
        public ConnectionError()
        {
        }

        public ConnectionError(string ticket, string hResult, string message)
        {
            this.Ticket = ticket;
            this.HResult = hResult;
            this.Message = message;
        }

        public override string ToString()
        {
            var sb = new StringBuilder("connectionError");

            foreach (var p in this.GetType().GetProperties())
            {
                sb.Append(string.Format("; {0}: {1}", p.Name, p.GetValue(this, null)));
            }

            return sb.ToString();
        }
    }
}