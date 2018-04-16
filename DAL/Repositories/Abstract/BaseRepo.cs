using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public abstract class BaseRepo<T> where T : class
    {
        protected MyDbContext _context { get; set; }
        public T Get(Func<T,bool> func)
        {
            return _context.Set<T>().FirstOrDefault(func);
        }

        public IEnumerable<T> GetBy(Func<T, bool> func)
        {
            return _context.Set<T>().Where(func);
        }

        public void Add(T model)
        {

        }

        public void Modify(T model) { 
}

        public void Delete(T model)
        {

        }
    }
}
