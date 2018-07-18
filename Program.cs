using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>(3);
            employees.Add(new Employee() { FullName = "Pischik A.", Salary = 400} );
            employees.Add(new Employee() { FullName = "Ivanova J.", Salary = 200} );
            employees.Add(new Employee() { FullName = "Komolova K.", Salary = 500} ); 
            employees.Sort();
            foreach(Employee emp in employees)
                Console.WriteLine("Full name: {0}; Salary: {1}", emp.FullName, emp.Salary);
            Console.Read();
        }
    }
}
