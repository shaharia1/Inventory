using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Models;

namespace Inventory.Interface
{
    public interface IProductRepo : IBaseRepo<Product>, IDisposable
    {
        Product SaveProduct(Product product);
        void UpdateProduct(Product product);
        IEnumerable<Product> GetProducts();
        Product FindById(int id);
        void DeleteProduct(int id);
    }
}
