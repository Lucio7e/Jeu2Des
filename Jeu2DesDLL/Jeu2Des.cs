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
        public Jeu2Des()
        {
           
            _Classement = new Classement();
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
            _Classement.AjouterEntree(_Joueur);
            
        }

        public string VoirClassement()
        {
            return _Classement.TopN(); //GG : bien
        }
    }
}
