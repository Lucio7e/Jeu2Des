using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Jeu2DesDLL
{
   [Serializable]
    public class PersisterBinaire : IPersistable
    {
        private const string FICHIER_BIN_SAV = "binsave.txt";
        public void Load(Classement classement)
        {
            if (File.Exists(FICHIER_BIN_SAV))
            {
                Stream fichier = File.OpenRead(FICHIER_BIN_SAV);
                BinaryFormatter BinSerializer = new BinaryFormatter();
                Classement c = (Classement)BinSerializer.Deserialize(fichier);
                classement.Entrees = c.Entrees;
                fichier.Close();
            }
            
        }

        public void Save(Classement classement)
        {
            Stream fichier = File.Create(FICHIER_BIN_SAV);
            BinaryFormatter BinSerializer = new BinaryFormatter();
            BinSerializer.Serialize(fichier, classement);
            fichier.Close();
        }
    }
}
