using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Inventory.Interface;
using Inventory.Models;

namespace Inventory.Repo
{
    public class ProductRepo: BaseRepo<Product>,IProductRepo
    {
        //private readonly IBaseRepo<Product> _baseRepo;
        //private readonly ProductDbContext _dbContext;

        //private ProductRepo(IBaseRepo<Product> baseRepo, ProductDbContext dbContext)
        //{
        //    _baseRepo = baseRepo;
        //    _dbContext = dbContext;
        //}
        public ProductRepo(ProductDbContext dbContext) : base(dbContext)
        {

        }

        public Product SaveProduct(Product product)
        {
            try
            {
                var data = Insert(product);
                return data;
                
            }
            catch (Exception )
            {
                throw;
            }
        }

        public void UpdateProduct(Product product)
        {
            try
            {
                Update(product);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Product> GetProducts()
        {
            try
            {
                return GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Product FindById(int id)
        {
            try
            {
                return GetById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteProduct(int id)
        {
            try
            {
                Delete(id);
                //_baseRepo.Delete(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Dispose()
        {
            //_dbContext.Dispose();
        }
    }
}