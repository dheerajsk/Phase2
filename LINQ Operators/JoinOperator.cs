using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LINQ_Operators
{
    class JoinOperator
    {
        public static void Do()
        {
            var employees = EmployeeCollection.Get();
            var departments = DepartmentCollection.Get();

            var resultOfJoin = employees.Join(
                departments,
                employee => employee.DepartmentID,
                department => department.ID,
                (employee, department) => new { employee.ID, employee.DepartmentID, employee.Department, department.Name }
                );

            //select e.ID, e.DepartmentID, e.Department, d.Name 
                //from Employee e inner join Department d on e.DepartmentID=d.ID

            foreach (var item in resultOfJoin)
            {
                Console.WriteLine("\n ID: " + item.ID + ", Dept ID: " + item.DepartmentID + ", Department: " + item.Department + ", Dept.Name: " + item.Name);
            }
        }

    }
}
