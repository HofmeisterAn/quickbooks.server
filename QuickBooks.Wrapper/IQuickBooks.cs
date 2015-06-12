using System.ServiceModel;
using QuickBooks.Wrapper.Request;
using QuickBooks.Wrapper.Response;

namespace QuickBooks.Wrapper
{
    [ServiceContract(Namespace = QuickBooks.URL, Name = "QuickBooks")]
    public interface IQuickBooks
    {
        [OperationContract(Action = QuickBooks.URL + "serverVersion")]
        ServerVersionResponse serverVersion(ServerVersion serverVersionSoapIn);

        [OperationContract(Action = QuickBooks.URL + "clientVersion")]
        ClientVersionResponse clientVersion(ClientVersion clientVersionSoapIn);

        [OperationContract(Action = QuickBooks.URL + "authenticate")]
        AuthenticateResponse authenticate(Authenticate authenticateSoapIn);

        [OperationContract(Action = QuickBooks.URL + "closeConnection")]
        CloseConnectionResponse closeConnection(CloseConnection closeConnectionSoapIn);

        [OperationContract(Action = QuickBooks.URL + "getLastError")]
        LastErrorResponse getLastError(LastError lastError);

        [OperationContract(Action = QuickBooks.URL + "connectionError")]
        ConnectionErrorResponse connectionError(ConnectionError connectionError);

        [OperationContract(Action = QuickBooks.URL + "sendRequestXML")]
        RequestXMLResponse sendRequestXML(RequestXML requestXml);

        [OperationContract(Action = QuickBooks.URL + "receiveResponseXML")]
        ReceiveXMLResponse receiveResponseXML(ReceiveXML receiveXml);
       
        // Those method are not necessary
        //[OperationContract(Action = QuickBooks.URL + "getInteractiveURL")]
        //InteractiveURLResponse getInteractiveURL(InteractiveURL interactiveUrl);

        //[OperationContract(Action = QuickBooks.URL + "interactiveDone")]
        //InteractiveDoneResponse interactiveDone(InteractiveDone interactiveDone);

        //[OperationContract(Action = QuickBooks.URL + "interactiveRejected")]
        //InteractiveRejectedResponse interactiveRejected(InteractiveRejected interactiveRejected);
    }
}
