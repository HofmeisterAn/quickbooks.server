using System.Collections.Generic;
using System.Runtime.Serialization;

namespace QB.Wrapper.Soap
{
    [CollectionDataContract(Name = "ArrayOfString", Namespace = QuickBooks.URL, ItemName = "string")]
    public class ArrayOfString : List<string>
    {
    }
}