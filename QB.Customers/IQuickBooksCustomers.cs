using System.ServiceModel;
using QB.Wrapper;

namespace QB.Customers
{
    [ServiceContract(Namespace = QuickBooks.URL, Name = "QuickBooksCustomers")]
    public interface IQuickBooksCustomers
    {
        [OperationContract(Action = QuickBooks.URL + "doNothing")]
        void DoNothing();
    }
}
