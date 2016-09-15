using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu2DesDLL
{
    /// <summary>
    /// Classe permettant l'instanciation d'un classement en fonction de la sérialization choisie
    /// Mise en place du design pattern Factory
    /// </summary>
    public class FactoryClassement
    {
        #region "Propriétés et accesseurs"

        private static FactoryClassement instance = new FactoryClassement();
        public static FactoryClassement getFactoryClassementInstance() { return instance; }
        #endregion
        #region "Constructeurs"

        private FactoryClassement() { }

        #endregion
        #region "Methodes"
        /// <summary>
        /// Methode qui va instancier un classement et le renvoyer en fonction du type de serialization que l'on souhaite
        /// </summary>
        /// <param name="typeSerialization"></param>
        /// <returns></returns>
        public Classement getClassement(String typeSerialization)
        {
            if (typeSerialization.ToUpper().Equals("BINAIRE"))
            {
                return new ClassementBinaire();
            }
            if (typeSerialization.ToUpper().Equals("XML"))
            {
                return new ClassementXML();
            }
            else
            {
                return new ClassementJson();
            }
        }
        #endregion
    
    }
}
