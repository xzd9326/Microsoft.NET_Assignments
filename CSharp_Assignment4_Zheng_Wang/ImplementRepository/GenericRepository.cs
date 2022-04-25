using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementRepository
{
    public class GenericRepository<T>: IRepository<T> where T : Entity
    {
        List<T> lstData = new List<T>();
        public void Add(T item)
        {
            lstData.Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            return lstData;
        }

        public T GetById(int id)
        {
            for (int i = 0; i < lstData.Count; i++)
            {
                if (lstData[i].Id == id)
                {
                    return lstData[i];
                }
            }
            return null;
        }

        public void Remove(T item)
        {
            T d = GetById(item.Id);
            if (d != null)
            {
                lstData.Remove(d);
            }
        }

        public void Save()
        {
            Console.WriteLine("Save Database");
            foreach (T item in lstData)
            {
                Console.WriteLine($"Data id {item.Id} saved successfully.");
            }
        }
    }
}
