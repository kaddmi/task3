using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class SortBySalary : IComparer<Empoyee>
    {
        public int Compare(Empoyee e1, Empoyee e2)
        {
            if (e1.Salary < e2.Salary)
                return -1;
            else if (e1.Salary > e2.Salary)
                return 1;
            else
                return 0;
        }
    }
}
