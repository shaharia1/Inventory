using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Interface
{
    public interface IBaseRepo<T> where T :class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Insert(T obj);
        void Update(T obj);
        void Delete(int id);
        void Save();
    }
}
