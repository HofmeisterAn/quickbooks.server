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

            System.Diagnostics.Debug.WriteLine(result.ElementAt(0).ListID);
            System.Diagnostics.Debug.WriteLine(result.ElementAt(1).ListID);

            return new ReceiveXMLResponse
            {
                ReceiveXMLResult = 100
            };
        }

        public override RequestXMLResponse SendRequestXML(RequestXML requestXml)
        {
            var customerRq = new CustomerRq();
            customerRq.MaxReturned = 10;
            customerRq.Ticket = requestXml.Ticket;

            return new RequestXMLResponse
            {
                RequestXMLResult = XmlSerializer<CustomerRq>.Serialize(customerRq)
            };
        }

        public void DoNothing()
        {
        }
    }
}
