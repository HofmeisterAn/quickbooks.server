using System;
using System.Xml.Serialization;

namespace QB.Wrapper.Entity
{
    [Serializable]
    [XmlType(TypeName = TYPE_NAME)]
    public class CustomerRet : QBBaseEntity
    {
        private const string TYPE_NAME = "CustomerRet";

        private const string METHOD = "CustomerQueryRs";

        [XmlElement(Order = 1)]
        public string ListID { get; set; }

        [XmlElement(Order = 2)]
        public DateTime TimeCreated { get; set; }

        [XmlElement(Order = 3)]
        public DateTime TimeModified { get; set; }

        [XmlElement(Order = 4)]
        public string EditSequence { get; set; }

        [XmlElement(Order = 5)]
        public string Name { get; set; }

        [XmlElement(Order = 6)]
        public string FullName { get; set; }

        public CustomerRet() : base(TYPE_NAME, METHOD)
        {
        }
    }
}