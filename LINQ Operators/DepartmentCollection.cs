using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Operators
{
    class DepartmentCollection
    {
        public static IEnumerable<Department> Get()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { ID = 1, Name = "Finance" });
            list.Add(new Department { ID = 2, Name = "HR" });
            list.Add(new Department { ID = 3, Name = "IT" });

            return list;
        }
    }
}
