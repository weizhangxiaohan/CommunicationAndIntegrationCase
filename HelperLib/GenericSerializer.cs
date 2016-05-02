using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace HelperLib
{
    public static class GenericSerializer<T>
    {
        public static string Serialize(T t)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            StringWriter stringWriter = new StringWriter();
            ser.Serialize(stringWriter,t);

            return stringWriter.ToString();
        }

        public static T DeSerialize(string xml)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            StringReader stringReader = new StringReader(xml);

            return (T)ser.Deserialize(stringReader);
        }
    }
}
