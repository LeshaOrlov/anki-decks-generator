using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AnkiDecksGeneratorWindowsForms
{
    class SerializerToXML
    {
        
        XmlSerializer formatter;

        public SerializerToXML()
        {
           formatter = new XmlSerializer(typeof(List<Card>));
        }

        public void Serialize(List<Card> list, string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, list);
            }
        }

        public List<Card> DeSerialize(string path)
        {
            List<Card> list = new List<Card>();
            if (!File.Exists(path))
            {
                return list;
            };
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                list = (List<Card>)formatter.Deserialize(fs);
            }
            return list;
        }
    }
}
