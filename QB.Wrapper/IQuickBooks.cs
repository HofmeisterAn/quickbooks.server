using System.ServiceModel;
using QB.Wrapper.Soap.Request;
using QB.Wrapper.Soap.Response;

namespace QB.Wrapper
{
    [ServiceContract(Namespace = QuickBooks.URL, Name = "QuickBooks")]
    public interface IQuickBooks
    {
        [OperationContract(Action = QuickBooks.URL + "serverVersion")]
        ServerVersionResponse ServerVersion(ServerVersion serverVersionSoapIn);

        [OperationContract(Action = QuickBooks.URL + "clientVersion")]
        ClientVersionResponse ClientVersion(ClientVersion clientVersionSoapIn);

        [OperationContract(Action = QuickBooks.URL + "authenticate")]
        AuthenticateResponse Authenticate(Authenticate authenticateSoapIn);

        [OperationContract(Action = QuickBooks.URL + "closeConnection")]
        CloseConnectionResponse CloseConnection(CloseConnection closeConnectionSoapIn);

        [OperationContract(Action = QuickBooks.URL + "getLastError")]
        LastErrorResponse GetLastError(LastError lastError);

        [OperationContract(Action = QuickBooks.URL + "connectionError")]
        ConnectionErrorResponse GetConnectionError(ConnectionError connectionError);

        [OperationContract(Action = QuickBooks.URL + "sendRequestXML")]
        RequestXMLResponse SendRequestXML(RequestXML requestXml);

        [OperationContract(Action = QuickBooks.URL + "receiveResponseXML")]
        ReceiveXMLResponse ReceiveResponseXML(ReceiveXML receiveXml);
    }
}
