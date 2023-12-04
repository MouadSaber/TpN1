using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1
{
    internal class programme
    {
        static void Main(string[] args)
        {
            // la réservation mémoire des trois objets et l'appel du constructeur pour les initialiser :
            Livre livre1 = new Livre("c");
            Livre livre2 = new Livre("a");
            Livre livre3 = new Livre("b");

            // la collection des objets dans un tableau pour simplifier le trie de ces derniers :
           string Livres[] = {livre1.titre , livre2.titre , livre3.titre};

            // l'appel de méthode sort de la classe Array sur notre tableau de livres :
            Array.Sort(Livres);

            // l'affichage de livre triés selon l'ordre alphabétique :
            foreach (Livre livre in Livres)
            {
                Console.WriteLine(Livres);
            }
        }
    }
}
