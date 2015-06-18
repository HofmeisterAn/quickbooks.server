using QB.Wrapper.Entity;

namespace QB.Wrapper.Core
{
    public static class Builder
    {
        public static Customer Customer
        {
            get
            {
                return new Customer
                {
                    Name = "University of North Carolina (ÄÜÖß)",
                    CompanyName = "University of North Carolina",
                    FirstName = "Keith",
                    LastName = "Palmer",
                    Phone = "860-634-1602",
                    AltPhone = "860-429-0021",
                    Fax = "860-429-5183",
                    Email = "keith@consolibyte.com",
                    Contact = "Keith Palmer",

                    BillAddress = new Address
                    {
                        Addr1 = "University of North Carolina",
                        Addr2 = "University City Blvd",
                        Addr3 = "",
                        City = "Charlotte",
                        State = "NC",
                        PostalCode = "9201",
                        Country = "United States"
                    }
                };
            }
        }
    }
}