using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LINQ_Operators
{
    class PartitionOperator
    {
        public static void Do()
        {
            var employees = EmployeeCollection.Get();

            var first4Employees = employees.Take(4);

            //Printer.Print(first4Employees);

            var skip2andTake2Employees = employees.Skip(2).Take(2);
            //Printer.Print(skip2andTake2Employees);

            //var employeesWithIDlessthan4 = employees.TakeWhile(e => IsPartOFCompany(e.ID)==true);
            //Printer.Print(employeesWithIDlessthan4);

            var employeeWithFiance = employees.Where(e => e.Department == "Finance");
            Printer.Print(employeeWithFiance);
            Console.WriteLine("\n\n");
            employeeWithFiance = employees.TakeWhile(e => e.Department == "Finance");
            Printer.Print(employeeWithFiance);
        }

        //static bool IsPartOFCompany(int id)
        //{
        //    // businees logic
        //    return true, false;
        //}
    }
}
