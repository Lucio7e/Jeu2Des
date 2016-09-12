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
            De de = new De();
            de.Lancer();
            Console.WriteLine(de.Valeur);
            Console.ReadKey();
        }
    }
}
