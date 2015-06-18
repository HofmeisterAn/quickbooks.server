using System;
using System.Xml.Serialization;

namespace QB.Wrapper.Entity
{
    [Serializable]
    [XmlType(TypeName = TYPE_NAME, AnonymousType = true)]
    public class CustomerRq : QBBaseEntity
    {
        private const string TYPE_NAME = "CustomerRq";

        private const string METHOD = "CustomerQueryRq";

        [XmlElement(Order = 1)]
        public string FullName { get; set; }

        [XmlElement(Order = 2)]
        public int MaxReturned { get; set; }

        public CustomerRq() : base(TYPE_NAME, METHOD, true)
        {
        }
    }
}