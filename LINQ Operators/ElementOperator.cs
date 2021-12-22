using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LINQ_Operators
{
    class ElementOperator
    {
        public static void Do()
        {
            var employees = EmployeeCollection.Get();

            var firstEmployee = employees.Where(i=> i.DepartmentID==1).First();

            Console.WriteLine(firstEmployee.Name);

            var lastEmployee = employees.Last();
            Console.WriteLine(lastEmployee.Name);
        }
    }
}
