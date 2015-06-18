using System.Runtime.Serialization;
using System.ServiceModel;

namespace QB.Wrapper.Soap.Request
{
    [DataContract(Name = Name)]
    [MessageContract(WrapperName = Name, IsWrapped = true)]
    public class RequestXML
    {
        private const string Name = "sendRequestXML";

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
        public string XMLCountry { get; set; }

        [DataMember(Name = "qbXMLMajorVers", IsRequired = true)]
        [MessageBodyMember(Name = "qbXMLMajorVers", Order = 5)]
        public int XMLMajorVersion { get; set; }

        [DataMember(Name = "qbXMLMinorVers", IsRequired = true)]
        [MessageBodyMember(Name = "qbXMLMinorVers", Order = 6)]
        public int XMLMinorVersion { get; set; }
    }
}