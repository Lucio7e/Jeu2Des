using Jeu2DesDLL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Jeu2DesDLL
{
    [Serializable]
    public class ClassementJson : Classement
    {
       private const string FICHIER_JSON_SAV = "jsonsave.json";
        
        public ClassementJson(){}
        public override void Load()
        {
            if (File.Exists(FICHIER_JSON_SAV))
            {
                Stream fichier = File.OpenRead(FICHIER_JSON_SAV);
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ClassementJson));
                Classement c = (Classement)serializer.ReadObject(fichier);
                _Entrees = c.Entrees;
                fichier.Close();
            }
          
        }

        public override void Save()
        {
            Stream fichier = File.Create(FICHIER_JSON_SAV);
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(GetType());
            serializer.WriteObject(fichier, this);
            fichier.Close();

            
        }
    }
}
