using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Jeu2DesDLL
{
    public class ClassementXML : Classement
    {
        private const string FICHIER_XML_SAV = "xmlsave.xml";
        public ClassementXML() { }
        public override void Load()
        {
            if(File.Exists(FICHIER_XML_SAV))
            {
                Stream fichier = File.OpenRead(FICHIER_XML_SAV);
                XmlSerializer serializer = new XmlSerializer(typeof(ClassementXML));
                Classement c = (Classement)serializer.Deserialize(fichier);
                _Entrees = c.Entrees;
                fichier.Close();
            }
            
        }

        public override void Save()
        {
            Stream fichier = File.Create(FICHIER_XML_SAV);
            XmlSerializer serializer = new XmlSerializer(GetType());
            serializer.Serialize(fichier, this);
            fichier.Close();
        }
    }
}
