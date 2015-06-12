using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace QuickBooks.Wrapper.Request
{
    [DataContract(Name = "sendRequestXML")]
    [MessageContract(WrapperName = "sendRequestXML", IsWrapped = true)]
    public class RequestXML
    {
        [DataMember(Name = "ticket", IsRequired = true)]
        [MessageBodyMember(Name = "ticket", Order = 1)]
        public string Ticket { get; set; }

        [DataMember(Name = "strHCPResponse", IsRequired = true)]
        [MessageBodyMember(Name = "strHCPResponse", Order = 2)]
        public string HCPResponse { get; set; }

        [DataMember(Name = "strCompanyFileName", IsRequired = true)]
        [MessageBodyMember(Name = "strCompanyFileName", Order = 3)]
        public string CompanyFile { get; set; }

        [DataMember(Name = "qbXMLCountry", IsRequired = true)]
        [MessageBodyMember(Name = "qbXMLCountry", Order = 4)]
        public int XMLCountry { get; set; }

        [DataMember(Name = "qbXMLMajorVers", IsRequired = true)]
        [MessageBodyMember(Name = "qbXMLMajorVers", Order = 5)]
        public int XMLMajorVersion { get; set; }

        [DataMember(Name = "qbXMLMinorVers", IsRequired = true)]
        [MessageBodyMember(Name = "qbXMLMinorVers", Order = 6)]
        public int XMLMinorVersion { get; set; }

        public RequestXML()
        {
        }

        public RequestXML(string ticket, string hcpResponse, string companyFile, int xmlCountry, int xmlMajorVersion,
            int xmlMinorVersion)
        {
            this.Ticket = ticket;
            this.HCPResponse = hcpResponse;
            this.CompanyFile = companyFile;
            this.XMLCountry = xmlCountry;
            this.XMLMajorVersion = xmlMajorVersion;
            this.XMLMinorVersion = xmlMinorVersion;
        }

        public override string ToString()
        {
            var sb = new StringBuilder("sendRequestXML");

            foreach (var p in this.GetType().GetProperties())
            {
                sb.Append(string.Format("; {0}: {1}", p.Name, p.GetValue(this, null)));
            }

            return sb.ToString();
        }
    }
}