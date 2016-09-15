using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu2DesDLL
{
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

        public Jeu2Des(string typeSerialization)
        {
            string s = typeSerialization.ToUpper();

            FactoryClassement factory = FactoryClassement.getFactoryClassementInstance();
            _Classement = factory.getClassement(s);           
            _D1 = new De();
            _D2 = new De();
        }

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

        public string VoirClassement()
        {
            return Classement.TopN(); //GG : bien
        }
    }
}
