using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WorkBD
{
    class SerializerToXML
    {
        
        XmlSerializer formatter;

        public SerializerToXML()
        {
           formatter = new XmlSerializer(typeof(Card));
        }

        public void Serialize(List<Card> list, string path)
        {
            
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                foreach (Card card in list)
                {
                    formatter.Serialize(fs, card);
                }

            }
        }

        public List<Card> DeSerialize(string path)
        {
            List<Card> list = new List<Card>();

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
               
                    Card newCard = (Card)formatter.Deserialize(fs);
            }
            return list;
        }
    }
}
