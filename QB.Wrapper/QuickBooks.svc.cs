using System;
using System.ServiceModel;
using QB.Wrapper.Soap.Request;
using QB.Wrapper.Soap.Response;

namespace QB.Wrapper
{
    [ServiceBehavior(Namespace = URL)]
    public class QuickBooks : IQuickBooks
    {
        private const string COMPANY_FILE = @"C:\Users\hofmeister\Desktop\QuickBooks\BodyToning.QBW";

        public const string URL = "http://developer.intuit.com/";

        public virtual ServerVersionResponse ServerVersion(ServerVersion serverVersionSoapIn)
        {
            return new ServerVersionResponse();
        }

        public virtual ClientVersionResponse ClientVersion(ClientVersion clientVersionSoapIn)
        {
            return new ClientVersionResponse();
        }

        public virtual AuthenticateResponse Authenticate(Authenticate authenticateSoapIn)
        {
            var authenticateResponse = new AuthenticateResponse();
            authenticateResponse.AuthenticateResult.Add(Guid.NewGuid().ToString());
            authenticateResponse.AuthenticateResult.Add(COMPANY_FILE);

            return authenticateResponse;
        }

        public virtual CloseConnectionResponse CloseConnection(CloseConnection closeConnectionSoapIn)
        {
            return new CloseConnectionResponse();
        }

        public virtual LastErrorResponse GetLastError(LastError lastError)
        {
            return new LastErrorResponse();
        }

        public virtual ConnectionErrorResponse GetConnectionError(ConnectionError connectionError)
        {
            return new ConnectionErrorResponse();
        }

        public virtual ReceiveXMLResponse ReceiveResponseXML(ReceiveXML receiveXml)
        {
            return new ReceiveXMLResponse()
            {
                ReceiveXMLResult = 100
            };
        }

        public virtual RequestXMLResponse SendRequestXML(RequestXML requestXml)
        {
            return new RequestXMLResponse
            {
                RequestXMLResult = string.Empty
            };
        }
    }
}
