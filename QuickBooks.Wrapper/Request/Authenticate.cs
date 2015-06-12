using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace QuickBooks.Wrapper.Request
{
    [DataContract(Name = "authenticate")]
    [MessageContract(WrapperName = "authenticate", IsWrapped = true)]
    public class Authenticate
    {
        [DataMember(Name = "strUserName", IsRequired = true)]
        [MessageBodyMember(Name = "strUserName", Order = 1)]
        public string Username { get; set; }

        [DataMember(Name = "strPassword", IsRequired = true)]
        [MessageBodyMember(Name = "strPassword", Order = 2)]
        public string Password { get; set; }

        public Authenticate()
        {
        }

        public Authenticate(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public override string ToString()
        {
            var sb = new StringBuilder("authenticate");

            foreach (var p in this.GetType().GetProperties())
            {
                sb.Append(string.Format("; {0}: {1}", p.Name, p.GetValue(this, null)));
            }

            return sb.ToString();
        }
    }
}