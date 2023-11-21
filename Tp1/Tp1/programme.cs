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
            List<Livre> Biblioth = new list<Livre>();
            Livre livre1 = new Livre("c");
            Livre livre2 = new Livre("a");
            Livre livre3 = new Livre("b");

            Biblioth.Add(livre1);
            Biblioth.Add(livre2);
            Biblioth.Add(livre3);

            Biblioth.Sort();

            foreach (Livre livre in Biblioth)
            {
                Console.WriteLine(livre.titre);
            }
        }
    }
}
