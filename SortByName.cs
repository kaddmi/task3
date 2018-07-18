using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class SortByName : IComparer<Empoyee>
    {
        public int Compare(Empoyee e1, Empoyee e2)
        {
            if (String.Compare(e1.FullName, e2.FullName) < 0)
                return -1;
            else if (String.Compare(e1.FullName, e2.FullName) > 0)
                return 1;
            else
                return 0;
        }
    }
}
