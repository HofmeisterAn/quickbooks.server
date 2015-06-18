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
                    NewLineHandling = NewLineHandling.Entitize,
                    Indent = true,
                    IndentChars = "\t",
                    Encoding = new UTF8Encoding(false, false)
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

            var xml = string.Empty;

            using (var sw1 = new UTF8StringWriter())
            {
                var xw1 = XmlWriter.Create(sw1);

                var xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(xw1, source, namespaces);

                xml = sw1.ToString();
            }

            using (var sr = new StringReader(xml))
            {
                using (var xr = XmlReader.Create(sr))
                {
                    using (var sw2 = new UTF8StringWriter())
                    {
                        if (source.IsRequest)
                        {
                            xr.ReadToDescendant(source.TypeName);
                            xr.Read();                            
                        }

                        var xw2 = XmlWriter.Create(sw2, settings);

                        var argsList = new XsltArgumentList();
                        argsList.AddParam(source.RequestRq, string.Empty, source.Method);
                        argsList.AddParam(source.RequestId, string.Empty, source.Ticket);
                        
                        XslCompiledTransform.Transform(xr, argsList, xw2);

                        return sw2.ToString();
                    }    
                }
            }
        }
    }
}