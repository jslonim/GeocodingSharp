using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace GeocodingSharp.Service.Helpers
{
    static class XMLHelper
    {
        /// <summary>
        /// Converts any JSON to XML
        /// </summary>
        public static string SerializeToXML<T>(T dto)
        {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(T));
            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                    ns.Add("", "");
                    xsSubmit.Serialize(writer, dto, ns);
                    return sww.ToString();
                }
            }
        }
    }
}
