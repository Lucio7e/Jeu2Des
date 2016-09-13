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

            set //GG : attention, set ici permet de modifier le score du joueur en dehors de la classe --> private
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
            
            int total = d1.Lancer() + d2.Lancer();
            if (total == 7)
            {
                Score += 10;
            }
            Console.WriteLine("Les dés sont jetés D1 : "+d1.Valeur+", D2 : "+d2.Valeur+" Total :"+total );
        }

        #endregion
        #region "Methodes héritées et substituées"
        public override string ToString()
        {
            return "Nom : " + Nom + " Score : " + Score;
        }
        #endregion
        #region "Methodes à implementer pour les interfaces"
        #endregion

    }
}
