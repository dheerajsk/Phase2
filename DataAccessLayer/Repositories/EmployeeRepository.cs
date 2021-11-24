using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class EmployeeRepository
    {
        private readonly AppDBContext _context;

        public EmployeeRepository(AppDBContext context)
        {
            _context = context;
        }


        public IEnumerable<Employee> GetAll()
        {
            return _context.Employee.ToList();
        }

        public Employee Get(int id)
        {
            return _context.Employee.FirstOrDefault(e => e.ID == id);
        }

        public void Add(Employee employee)
        {
            _context.Add(employee);
            _context.SaveChanges();
        }

        public void Update(Employee employee)
        {
            _context.Update(employee);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Remove(Get(id));
            _context.SaveChanges();
        }


        public bool EmployeeExists(int id)
        {
            return _context.Employee.Any(e => e.ID == id);
        }


    }
}
