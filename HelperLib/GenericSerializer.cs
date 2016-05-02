using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization;

namespace HelperLib
{
    public static class GenericSerializer<T>
    {
        public static string Serialize(T o)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            StringWriter stringWriter = new StringWriter();
            ser.Serialize(stringWriter,o);

            return stringWriter.ToString();
        }

        public static T DeSerialize(string xml)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            StringReader stringReader = new StringReader(xml);

            return (T)ser.Deserialize(stringReader);
        }

        public static string SerializeDC(T o)
        {
            DataContractSerializer dataContractSerializer = new DataContractSerializer(typeof(T));

            StringWriter stringWriter = new StringWriter();

            XmlWriter xmlWriter = XmlWriter.Create(stringWriter);
            dataContractSerializer.WriteObject(xmlWriter,o);
            xmlWriter.Close();

            return stringWriter.ToString();

        }

        public static T DeSerializeDC(string xml)
        {
            DataContractSerializer dataContractSerializer = new DataContractSerializer(typeof(T));

            StringReader stringReader = new StringReader(xml);

            XmlReader xmlReader = XmlReader.Create(stringReader);

            return (T)dataContractSerializer.ReadObject(xmlReader);
        }
    }
}
