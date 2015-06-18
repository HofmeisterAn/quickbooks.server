using System;
using System.Xml.Serialization;

namespace QB.Wrapper.Entity
{
    [Serializable]
    [XmlType(TypeName = TYPE_NAME)]
    public class Customer : QBBaseEntity
    {
        private const string TYPE_NAME = "CustomerAdd";

        private const string METHOD = "CustomerAddRq";

        [XmlElement(Order = 1)]
        public string Name { get; set; }

        [XmlElement(Order = 2)]
        public string CompanyName { get; set; }

        [XmlElement(Order = 3)]
        public string FirstName { get; set; }

        [XmlElement(Order = 4)]
        public string LastName { get; set; }

        [XmlElement(Order = 6)]
        public string Phone { get; set; }

        [XmlElement(Order = 7)]
        public string AltPhone { get; set; }

        [XmlElement(Order = 8)]
        public string Fax { get; set; }

        [XmlElement(Order = 9)]
        public string Email { get; set; }

        [XmlElement(Order = 10)]
        public string Contact { get; set; }

        [XmlElement(Order = 5)]
        public Address BillAddress { get; set; }

        public Customer() : base(TYPE_NAME, METHOD)
        {
        }
    }
}

