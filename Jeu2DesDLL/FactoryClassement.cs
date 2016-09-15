using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu2DesDLL
{
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
        #region "Methodes héritées et substituées"
        #endregion
        #region "Methodes à implementer pour les interfaces"
        #endregion

    }
}
