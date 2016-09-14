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
    
    public class PersisterJson : IPersistable
    {
       private const string FICHIER_JSON_SAV = "jsonsave.json";
        
       
        public  void Load(Classement classement)
        {
            if (File.Exists(FICHIER_JSON_SAV))
            {
                Stream fichier = File.OpenRead(FICHIER_JSON_SAV);
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Classement));
                Classement c = (Classement)serializer.ReadObject(fichier);
                classement.Entrees = c.Entrees;
                fichier.Close();
            }
          
        }

        public void Save(Classement classement)
        {
            Stream fichier = File.Create(FICHIER_JSON_SAV);
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(classement.GetType());
            serializer.WriteObject(fichier,classement);
            fichier.Close();

            
        }
    }
}
