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
        public T Load<T>(T obj )
        {
            if (File.Exists(FICHIER_BIN_SAV))
            {
                Stream fichier = File.OpenRead(FICHIER_BIN_SAV);
                BinaryFormatter BinSerializer = new BinaryFormatter();
                T t = (T)BinSerializer.Deserialize(fichier);
                fichier.Close();
                return t;
                
            }
            return default(T);
            
        }

        public void Save<T>(T obj)
        {
            Stream fichier = File.Create(FICHIER_BIN_SAV);
            BinaryFormatter BinSerializer = new BinaryFormatter();
            BinSerializer.Serialize(fichier, obj);
            fichier.Close();
        }
    }
}
