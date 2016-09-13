using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu2DesDLL
{
    public class De
    {

        #region "Propriétés et accesseurs"

        //GG : une alternative consiste nà décalrer une instance de Random static
        //GG : private static Random rand = new Random();
        private Random rand = new Random(DateTime.Now.Millisecond);
        private int _Valeur;

        public int Valeur
        {
            get
            {
                return _Valeur;
            }
                       
        }
        #endregion
        #region "Constructeurs"

        public De()
        {
            //La valeur par défaut du dé est 0 
            _Valeur = 0;
        }

        #endregion
        #region "Methodes"

        /// <summary>
        /// Methode permettant de lancer un dé, et stock la valeur du lancé dans l'attribut Valeur du dé
        /// </summary>
        public int Lancer()
        {
           //GG : la méthode Lancer pourait renvoyer la valeur comme résultat
           //GG : car en général le programme qui appelle la méthode Next() veut aussi récupérer la valeur
           //GG : Ici, il devra faire 2 actions : appeler Next() puis appeler Valeur pour récupérer le résultat du lancer
            _Valeur = rand.Next(1, 7);
            return _Valeur;
        }
        #endregion
        #region "Methodes héritées et substituées"
        #endregion
        #region "Methodes à implementer pour les interfaces"
        #endregion

    }
}
