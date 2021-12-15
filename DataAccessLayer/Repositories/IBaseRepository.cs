using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public interface IBaseRepository<T> where T: BaseEntity
    {
        public IEnumerable<T> GetAll();
        public T Get(int id);

        public void Add(T entity);

        public void Update(T entity);

        public bool Exists(int id);

        public void Delete(int id);
    }
}
