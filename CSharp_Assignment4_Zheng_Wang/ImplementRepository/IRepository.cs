using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementRepository
{
    public interface IRepository<T> where T: class
    {
        void Add(T item);
        void Remove(T item);
        void Save();
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
