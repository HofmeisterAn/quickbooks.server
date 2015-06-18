# QuickBooks Server
This small sample provides a Windows Communication Foundation (WCF) SOAP server to communicate with the QuickBooks Web Connector proxy.

## Usage
Simple derived you're custom WCF service from `QuickBooks` and override the required operations. The `XmlSerializer<T>` serialize your objects into valid `QBXML` and also back.

## Exampel
View my example in [QB.Customers](QB.Customers).
