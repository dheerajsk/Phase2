using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Operators
{
    class Printer
    {
        public static void Print(IEnumerable<Employee> employees)
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine("Employee - ID: " + employee.ID + " , Name: " + employee.Name + " , Dept: " + employee.Department);
            }
        }
    }
}
