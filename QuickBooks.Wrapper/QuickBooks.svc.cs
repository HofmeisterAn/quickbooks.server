using System.ServiceModel;
using QuickBooks.Wrapper.Request;
using QuickBooks.Wrapper.Response;

namespace QuickBooks.Wrapper
{
    [ServiceBehavior(Namespace = QuickBooks.URL)]
    public class QuickBooks : IQuickBooks
    {
        public const string URL = "http://developer.intuit.com/";

        public ServerVersionResponse serverVersion(ServerVersion serverVersionSoapIn)
        {
            return new ServerVersionResponse();
        }

        public ClientVersionResponse clientVersion(ClientVersion clientVersionSoapIn)
        {
            return new ClientVersionResponse();
        }

        public AuthenticateResponse authenticate(Authenticate authenticateSoapIn)
        {
            System.Diagnostics.Debug.WriteLine(authenticateSoapIn);

            var authenticateResponse = new AuthenticateResponse();
            authenticateResponse.AuthenticateResult.Add(System.Guid.NewGuid().ToString());
            authenticateResponse.AuthenticateResult.Add(string.Empty);

            return authenticateResponse;
        }

        public CloseConnectionResponse closeConnection(CloseConnection closeConnectionSoapIn)
        {
            System.Diagnostics.Debug.WriteLine(closeConnectionSoapIn);

            return new CloseConnectionResponse();
        }

        public LastErrorResponse getLastError(LastError lastError)
        {
            System.Diagnostics.Debug.WriteLine(lastError);

            return new LastErrorResponse();
        }

        public ConnectionErrorResponse connectionError(ConnectionError connectionError)
        {
            System.Diagnostics.Debug.WriteLine(connectionError);

            return new ConnectionErrorResponse();
        }

        public ReceiveXMLResponse receiveResponseXML(ReceiveXML receiveXml)
        {
            System.Diagnostics.Debug.WriteLine(receiveXml);

            return new ReceiveXMLResponse();
        }

        public RequestXMLResponse sendRequestXML(RequestXML requestXml)
        {
            System.Diagnostics.Debug.WriteLine(requestXml);

            return new RequestXMLResponse();
        }
    }
}
