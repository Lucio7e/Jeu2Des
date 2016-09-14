using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu2DesDLL
{
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
        //GG : Si tu passes Joueur au constructeur d'Entree, tu rends la classe Joueur dépendante de la classe Joueur
        //GG : je préfère 2 paramètres : nom et score
        public Entree(string nom, int score)
        {
            this.Nom = nom;
            this.Score = score;
        }
        #endregion
        #region "Methodes"
        #endregion
        #region "Methodes héritées et substituées"
        public override string ToString()
        {
            return "Nom: "+Nom+" Score: "+Score;
        }
        #endregion
        #region "Methodes à implementer pour les interfaces"
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
