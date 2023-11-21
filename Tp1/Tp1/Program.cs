using System;
using System.Collections.Generic;

namespace Tp1
{
    class Livre: IComparable <Livre>
    {
        public string titre;
        public Livre(string t)
        { 
            titre = t;
        }
        public int comparer(Livre autre) 
        {
            return string.Compare(titre, autre.titre);
        }

        public int CompareTo(Livre? other)
        {
            throw new NotImplementedException();
        }
    }
}
