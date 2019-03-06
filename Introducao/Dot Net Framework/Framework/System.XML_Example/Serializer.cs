using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace System.XML_Example
{
    public class Serializer
    {
        public T Deserialize<T>(XElement element)
        {
            using (var memoryStream = new MemoryStream(Encoding.ASCII.GetBytes(element.ToString())))
            {
                var xmlSerializador = new XmlSerializer(typeof(T));
                return (T)xmlSerializador.Deserialize(memoryStream);
            }
        }

        public XElement Serialize<T>(object o)
        {
            using (var memoryStream = new MemoryStream())
            {
                using (TextWriter streamWriter = new StreamWriter(memoryStream))
                {
                    var xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(streamWriter, o);
                    return XElement.Parse(Encoding.ASCII.GetString(memoryStream.ToArray()));
                }
            }
        }
    }
}
