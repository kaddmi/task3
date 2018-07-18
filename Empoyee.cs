using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Employee  : IComparable<Employee>
    {
        public string FullName { set; get; }
        public int Salary { set; get; }

        public int CompareTo(Employee e1)
        {
            if (this.Salary < e1.Salary)
                   return -1;
            else if (this.Salary > e1.Salary)
                   return 1;
            else
                   return 0;
        }
    }
}
