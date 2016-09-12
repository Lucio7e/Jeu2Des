using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu2DesDLL
{
    public class Joueur
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
        public Joueur (string nom)
        {
            Nom = nom;
            Score = 0;
        }
        #endregion
        #region "Methodes"

        public void Jouer(De d1, De d2)
        {
            d1.Lancer();
            d2.Lancer();
            if(d1.Valeur + d2.Valeur == 7)
            {
                Score += 10;
            }
        }

        #endregion
        #region "Methodes héritées et substituées"
        #endregion
        #region "Methodes à implementer pour les interfaces"
        #endregion

    }
}
