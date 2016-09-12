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
        public Jeu2Des(Joueur joueur, Classement classement, De D1, De D2)
        {
            _Joueur = joueur;
            _Classement = classement;
            _D1 = D1;
            _D2 = D2;
        }

        public void JouerPartie()
        {
           
            for (int i = 0; i < 10; i++)
            {
                _Joueur.Jouer(_D1, _D2);
            }
            _Classement.AjouterEntree(_Joueur);
            Console.WriteLine(VoirClassement()); 
        }

        public string VoirClassement()
        {
            return _Classement.TopN();
        }
    }
}
