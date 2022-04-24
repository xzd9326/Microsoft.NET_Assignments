using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementRepository
{
    public class GenericRepository : IRepository<Data>
    {
        List<Data> lstData = new List<Data>();
        public void Add(Data item)
        {
            lstData.Add(item);
        }

        public IEnumerable<Data> GetAll()
        {
            return lstData;
        }

        public Data GetById(int id)
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

        public void Remove(Data item)
        {
            Data d = GetById(item.Id);
            if (d != null)
            {
                lstData.Remove(d);
            }
        }

        public void Save()
        {
            Console.WriteLine("Save Database");
            foreach (Data item in lstData)
            {
                Console.WriteLine($"Data id {item.Id} saved successfully.");
            }
        }
    }
}
