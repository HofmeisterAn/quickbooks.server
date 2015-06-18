using System.Xml.Serialization;

namespace QB.Wrapper.Entity
{
    public class QBBaseEntity
    {
        private readonly bool isRequest;

        private readonly string typeName;

        private readonly string method;

        protected string requestIdValue;
        
        [XmlIgnore]
        public string RequestRq
        {
            get { return "RequestRq"; }
        }

        [XmlIgnore]
        public string RequestId
        {
            get { return "RequestId"; }
        }

        [XmlIgnore]
        public string TypeName
        {
            get { return this.typeName; }
        }

        [XmlIgnore]
        public string Method
        {
            get { return this.method; }
        }

        [XmlIgnore]
        public bool IsRequest
        {
            get { return this.isRequest; }
        }

        [XmlIgnore]
        public string Ticket
        {
            get { return this.requestIdValue; }
            set { this.requestIdValue = value; }
        }

        protected QBBaseEntity(string typeName, string method)
        {
            this.isRequest = false;

            this.typeName = typeName;
            this.method = method;
            this.requestIdValue = string.Empty;
        }

        protected QBBaseEntity(string typeName, string method, bool isRequest)
        {
            this.isRequest = isRequest;
            
            this.typeName = typeName;
            this.method = method;
            this.requestIdValue = string.Empty;
        }
    }
}