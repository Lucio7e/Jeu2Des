using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu2DesDLL
{
    /// <summary>
    /// Classe Entree, qui représente une entree du classement, qui implémente IComparable pour permettre le tri du classement
    /// </summary>
    [Serializable]
    public class Entree:IComparable //GG : Bien, indispensable pour trier 
    {

        #region "Propriétés et accesseurs"

        private string _Nom;
        private int _Score;

        public string Nom
        {
            get
            {
                return _Nom;
            }

            set
            {
                _Nom = value;
            }
        }

        public int Score
        {
            get
            {
                return _Score;
            }

            set
            {
                _Score = value;
            }
        }
        #endregion
        #region "Constructeurs"
        public Entree() { }
       
        /// <summary>
        /// Constructeur qui créer une entree à partir d'un nom et d'un score
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="score"></param>
        public Entree(string nom, int score)
        {
            this.Nom = nom;
            this.Score = score;
        }
        #endregion
   
        #region "Methodes héritées et substituées"
        /// <summary>
        /// Methode toString redefinie pour avoir l'entree sous forme Nom : Score :
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Nom: "+Nom+" Score: "+Score;
        }
        #endregion

        #region "Methodes à implementer pour les interfaces"
        /// <summary>
        /// Methode de l'interface redefinie pour permettre à une collection d'entrée d'être triée
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is Entree)
            {
                Entree other = (Entree)obj;
                return other.Score.CompareTo(this.Score);
            }
            return -1;
        }
        #endregion






    }
}
