using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empoyee> employees = new List<Empoyee>(3);
            employees.Add(new Empoyee() { FullName = "Pischik A.", Salary = 300});
            employees.Add(new Empoyee() { FullName = "Ivanova J.", Salary = 200});
            employees.Add(new Empoyee() { FullName = "Komolova K.", Salary = 500 });
            employees.Sort(new SortByName());
            for (int i = 0; i < employees.Count; i++)
            {
                Empoyee emp = employees[i];
                Console.WriteLine("Full name: {0}; Salary: {1}", emp.FullName, emp.Salary);
            }
            employees.Sort(new SortBySalary());
            for (int i = 0; i < employees.Count; i++)
            {
                Empoyee emp = employees[i];
                Console.WriteLine("Full name: {0}; Salary: {1}", emp.FullName, emp.Salary);
            }
            Console.Read();
        }
    }
}
