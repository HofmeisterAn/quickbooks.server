using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.Xsl;
using QB.Wrapper.Entity;
using QB.Wrapper.Properties;

namespace QB.Wrapper.Core
{
    public static class XmlSerializer<T> where T : QBBaseEntity, new()
    {
        private static readonly XslCompiledTransform XslCompiledTransform = new XslCompiledTransform();

        private static XmlWriterSettings IndentedSettings
        {
            get
            {
                return new XmlWriterSettings
                {
                    NewLineChars = Environment.NewLine,
                    Indent = true,
                    IndentChars = "\t",
                    Encoding = new ASCIIEncoding()
                };
            }
        }
        
        private static XmlSerializerNamespaces Namespaces
        {
            get
            {
                var xmlSerializerNamespaces = new XmlSerializerNamespaces();
                xmlSerializerNamespaces.Add(string.Empty, string.Empty);

                return xmlSerializerNamespaces;
            }    
        }

        static XmlSerializer()
        {
            using (var sr = new StringReader(Resource.QB))
            {
                using (var xr = XmlReader.Create(sr))
                {
                    XslCompiledTransform.Load(xr);
                }
            }
        }

        public static string Serialize(T source)
        {
            return Serialize(source, Namespaces, IndentedSettings);
        }

        public static T[] Deserialize(string source)
        {
            if (string.IsNullOrEmpty(source))
            {
                throw new ArgumentNullException("source", "Source to deserialize cannot be null.");
            }

            var type = new T();

            var xmlSerializer = new XmlSerializer(typeof(T));
            
            var result = XDocument.Parse(source).Descendants(type.TypeName);

            try
            {
                return result.Select(ds => (T) xmlSerializer.Deserialize(ds.CreateReader())).ToArray();
            }
            catch (Exception)
            {
                return new T[0];
            }            
        }

        private static string Serialize(T source, XmlSerializerNamespaces namespaces, XmlWriterSettings settings)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source", "Object to serialize cannot be null.");
            }

            using (var ms = new MemoryStream())
            {
                var xw = XmlWriter.Create(ms, settings);

                var xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(xw, source, namespaces);

                ms.Position = 0;

                var xr = XDocument.Load(ms).CreateReader();

                ms.Position = 0;
                ms.SetLength(0);
                
                xw = XmlWriter.Create(ms, settings);

                if (source.IsRequest)
                {
                    xr.ReadToDescendant(source.TypeName);
                    xr.Read();
                }

                var argsList = new XsltArgumentList();
                argsList.AddParam(source.RequestRq, string.Empty, source.Method);
                argsList.AddParam(source.RequestId, string.Empty, source.Ticket);

                XslCompiledTransform.Transform(xr, argsList, xw);

                return Encoding.ASCII.GetString(ms.ToArray());
            }
        }
    }
}