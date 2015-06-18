using System;

namespace QB.Wrapper.Entity
{
    [Serializable]
    public class Address
    {
        public string Addr1 { get; set; }

        public string Addr2 { get; set; }

        public string Addr3 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }
    }
}