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
            
            //GG : Bien        
            bool continu = true;
            Console.WriteLine("Choisissez votre mode de sauvegarde : binaire, xml, json");
            
            Jeu2DesDLL.Jeu2Des jeu = new Jeu2DesDLL.Jeu2Des(Console.ReadLine());
            jeu.Classement.Load();
           
            while (continu) {
                Console.Clear();
                Console.WriteLine("Entrez votre nom pour pouvoir lancer les dés");
                string nom = Console.ReadLine();
                Joueur joueur = new Joueur(nom);
                
                jeu.JouerPartie(joueur);
                Console.WriteLine("Voulez-vous voir le classement ? Y / N");
                if (Console.ReadLine() == "Y")
                {
                    Console.Clear();
                    Console.WriteLine(jeu.VoirClassement());
                }
                Console.WriteLine("Voulez vous continuez? Y / N");
                if (Console.ReadLine() != "Y")
                {
                    continu = false;
                }
            }
            jeu.Classement.Save();
            Console.ReadKey();
        }
    }
}
