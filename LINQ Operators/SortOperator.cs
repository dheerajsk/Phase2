using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LINQ_Operators
{
    class SortOperator
    {
        public static void Do()
        {
            IEnumerable<Employee> employees = EmployeeCollection.Get();

            Console.WriteLine("Employees before an sort");
            Printer.Print(employees);
            var sortedEmployeesByName = employees.OrderBy(e => e.Name);
            Console.WriteLine("Employees sorted by name");
            Printer.Print(sortedEmployeesByName);

            var sortedEmployeesByDept = employees.OrderBy(e => e.Department).ThenBy(e=> e.Name);
            Console.WriteLine("Employees sorted by dept");
            Printer.Print(sortedEmployeesByDept);

            var employeesSortedInDescById = employees.OrderByDescending(e => e.ID);
            Console.WriteLine("\nEmployees in desc order by ID");
            Printer.Print(employeesSortedInDescById);

        }

    }
}
