using System.Linq;
using System.ServiceModel;
using QB.Wrapper;
using QB.Wrapper.Core;
using QB.Wrapper.Entity;
using QB.Wrapper.Soap.Request;
using QB.Wrapper.Soap.Response;

namespace QB.Customers
{
    [ServiceBehavior(Namespace = QuickBooks.URL)]
    public class QuickBooksCustomers : QuickBooks, IQuickBooksCustomers
    {
        public override ReceiveXMLResponse ReceiveResponseXML(ReceiveXML receiveXml)
        {
            var result = XmlSerializer<CustomerRet>.Deserialize(receiveXml.Response);

            System.Diagnostics.Debug.WriteLine(result.Length);
            System.Diagnostics.Debug.WriteLine(result.ElementAt(0).ListID, result.ElementAt(0).Name);
            System.Diagnostics.Debug.WriteLine(result.ElementAt(1).ListID, result.ElementAt(1).Name);

            return new ReceiveXMLResponse
            {
                ReceiveXMLResult = 100
            };
        }

        public override RequestXMLResponse SendRequestXML(RequestXML requestXml)
        {
            var customerRq = new CustomerRq();
            customerRq.MaxReturned = 4;
            customerRq.Ticket = requestXml.Ticket;

            var customer = Builder.Customer;
            
            return new RequestXMLResponse
            {
                //RequestXMLResult = XmlSerializer<Customer>.Serialize(customer)
                RequestXMLResult = XmlSerializer<CustomerRq>.Serialize(customerRq)
            };
        }

        public void DoNothing()
        {
        }
    }
}
