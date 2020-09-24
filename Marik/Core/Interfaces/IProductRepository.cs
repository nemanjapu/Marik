using Marik.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marik.Core.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetActiveProducts();
        IEnumerable<Product> GetInactiveProducts();
        Product GetProductById(int id);
        void AddProduct(Product product);
        void RemoveProduct(int id);
    }
}
