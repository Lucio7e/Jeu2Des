using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu2DesDLL
{
    /// <summary>
    /// Classe qui permet de créer une partie de jeu de Dés
    /// </summary>
    public class Jeu2Des
    {
        private Joueur _Joueur;
        private Classement _Classement;
        private De _D1;
        private De _D2;

        public Classement Classement
        {
            get
            {
                return _Classement;
            }
        }
        /// <summary>
        /// Constructeur qui créer une partie, et auquel on spécifie le type de Serialization que l'on va utiliser
        /// Par défaut si aucune sérialization n'est spécifié, c'est Json qui sera utilisé (voir FactoryClassement)
        /// </summary>
        /// <param name="typeSerialization"></param>
        public Jeu2Des(string typeSerialization)
        {
            string s = typeSerialization.ToUpper();

            FactoryClassement factory = FactoryClassement.getFactoryClassementInstance();
            _Classement = factory.getClassement(s);           
            _D1 = new De();
            _D2 = new De();
        }
        /// <summary>
        /// Methode permettant à un joueur de jouer son tour pendant partie
        /// </summary>
        /// <param name="joueur"></param>
        public void JouerPartie(Joueur joueur)
        {
            //GG : bien
             _Joueur = joueur;
            for (int i = 0; i < 10; i++)
            {
                _Joueur.Jouer(_D1, _D2);
            }
            Classement.AjouterEntree(_Joueur);
            
        }

        /// <summary>
        /// Methode qui permettra d'afficher le classement 
        /// </summary>
        /// <returns></returns>
        public string VoirClassement()
        {
            return Classement.TopN(); //GG : bien
        }
    }
}
