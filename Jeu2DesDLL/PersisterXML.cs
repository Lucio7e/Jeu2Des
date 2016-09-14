using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Jeu2DesDLL
{
    public class PersisterXML : IPersistable
    {
        private const string FICHIER_XML_SAV = "xmlsave.xml";
        
        public void Load(Classement classement)
        {
            if (File.Exists(FICHIER_XML_SAV))
            {
                Stream fichier = File.OpenRead(FICHIER_XML_SAV);
                XmlSerializer serializer = new XmlSerializer(typeof(Classement));
                Classement c = (Classement)serializer.Deserialize(fichier);
                classement.Entrees = c.Entrees;
                fichier.Close();
            }
           
        }

        public void Save(Classement classement)
        {
            Stream fichier = File.Create(FICHIER_XML_SAV);
            XmlSerializer serializer = new XmlSerializer(classement.GetType());
            serializer.Serialize(fichier, classement);
            fichier.Close();
        }
    }
}
