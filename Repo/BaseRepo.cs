using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Inventory.Interface;
using Inventory.Models;

namespace Inventory.Repo
{
    public class BaseRepo<T>:IBaseRepo<T> where T:class
    {
        private DbSet<T> table;
        private ProductDbContext _context;

        public BaseRepo(ProductDbContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            try
            {
                return table.ToList();
            }
            catch (Exception )
            {
                throw;
            }
        }

        public T GetById(int id)
        {
            try
            {
                return table.Find(id);
            }
            catch (Exception )
            {
                throw;
            }
        }

        public T Insert(T obj)
        {
            try
            {
                table.Add(obj);
                Save();
                return obj;
            }
            catch (Exception )
            {
                throw;
            }
        }

        public void Update(T obj)
        {
            try
            {
                table.Attach(obj);
                _context.Entry(obj).State = EntityState.Modified;
                Save();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                T existing = table.Find(id);
                table.Remove(existing);
                Save();
            }
            catch (Exception )
            {
                throw;
            }
        }

        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception )
            {
                throw;
            }
        }
    }
}