using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Operators
{
    class EmployeeCollection
    {
        public static IEnumerable<Employee> Get()
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee { ID = 1, Department = "Finance", DepartmentID=1, Name = "Jon" });
            list.Add(new Employee { ID = 2, Department = "Finance", DepartmentID = 1, Name = "Dave" });
            list.Add(new Employee { ID = 3, Department = "IT", DepartmentID = 3, Name = "Sushil" });
            list.Add(new Employee { ID = 4, Department = "IT", DepartmentID = 3, Name = "Ram" });
            list.Add(new Employee { ID = 5, Department = "Finance", DepartmentID = 2, Name = "Sagar" });
            list.Add(new Employee { ID = 6, Department = "Finance", DepartmentID = 2, Name = "Palak" });

            return list;
        }
    }
}
