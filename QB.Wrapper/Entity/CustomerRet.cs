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

        public CustomerRet() : base(TYPE_NAME, METHOD)
        {
        }
    }
}