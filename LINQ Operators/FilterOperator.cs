using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LINQ_Operators
{
    class FilterOperator
    {
        public static void Do()
        {
            var employees = EmployeeCollection.Get();

            var allEmployeesWithFinanceDept = employees.Where(e => e.Department == "Finance").ToList();

            var isAllEmployeeFromFinanceDept = allEmployeesWithFinanceDept.All(e => e.Department == "Finance");
            Console.WriteLine(isAllEmployeeFromFinanceDept);

            var allEmployeesWithFinanceandITDept = employees.Where(e => e.Department == "Finance" || e.Department=="IT");

            isAllEmployeeFromFinanceDept = allEmployeesWithFinanceandITDept.All(e => e.Department == "Finance");
            Console.WriteLine(isAllEmployeeFromFinanceDept);

            var isAnyEmployeeIsHR = allEmployeesWithFinanceandITDept.Any(e => e.Department == "HR");
            Console.WriteLine(isAnyEmployeeIsHR);
            isAnyEmployeeIsHR = employees.Any(e => e.Department == "HR");
            Console.WriteLine(isAnyEmployeeIsHR);

        }
    }
}
