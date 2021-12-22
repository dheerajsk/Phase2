using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LINQ_Operators
{
    class AggregationOperator
    {
        public static void Do()
        {
            var employees = EmployeeCollection.Get();

            var countOfEmployees = employees.Count();
            Console.WriteLine("Count of all employees " + countOfEmployees);

            var maxIDOfEmployees = employees.Select(i => i.ID).Max();
            Console.WriteLine("Maximum ID of employee " + maxIDOfEmployees);

            var sumOFAllIDs = employees.Select(i => i.ID).Sum();
            Console.WriteLine("Sum of all IDs " + sumOFAllIDs);
        }
    }
}
