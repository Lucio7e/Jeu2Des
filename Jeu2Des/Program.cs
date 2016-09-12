using Jeu2DesDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu2Des
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continu = true;
            Classement c = new Classement();
            De D1 = new De();
            De D2 = new De();
            while (continu) {
                Console.Clear();
                Console.WriteLine("Entrez votre nom pour pouvoir lancer les dés");
                string nom = Console.ReadLine();
                Joueur joueur = new Joueur(nom);
                Jeu2DesDLL.Jeu2Des jeu = new Jeu2DesDLL.Jeu2Des(joueur, c, D1, D2);
                jeu.JouerPartie();
                Console.WriteLine("Voulez vous continuez? Y / N");
                if (Console.ReadLine() != "Y")
                {
                    continu = false;
                }
            }
             
            Console.ReadKey();
        }
    }
}
