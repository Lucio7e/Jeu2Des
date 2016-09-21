using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Jeu2DesDLL
{
    public class PersisterXML : IPersistable
    {
        private const string FICHIER_XML_SAV = "xmlsave.xml";
        
        public T Load<T>(T obj)
        {
            if (File.Exists(FICHIER_XML_SAV))
            {
                Stream fichier = File.OpenRead(FICHIER_XML_SAV);
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                fichier.Close();
                return (T)serializer.Deserialize(fichier);
                
            }
            return default(T);
        }

        public void Save<T>(T obj)
        {
            
            Stream fichier = File.Create(FICHIER_XML_SAV);
            XmlSerializer serializer = new XmlSerializer(obj.GetType());
            serializer.Serialize(fichier, obj);
            fichier.Close();
        }
    }
}
