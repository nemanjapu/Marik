using Marik.Core.Interfaces;
using Marik.DAL;
using Marik.Core.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Marik.Core.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _ctx;

        public ProductRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public void AddProduct(Product product)
        {
            _ctx.Products.Add(product);
        }

        public IEnumerable<Product> GetActiveProducts()
        {
            return _ctx.Products.Where(p => p.isActive).OrderByDescending(p => p.DatePublished).AsEnumerable();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _ctx.Products.OrderByDescending(p => p.DatePublished).AsEnumerable();
        }

        public IEnumerable<Product> GetInactiveProducts()
        {
            return _ctx.Products.Where(p => !p.isActive).OrderByDescending(p => p.DatePublished).AsEnumerable();
        }

        public Product GetProductById(int id)
        {
            return _ctx.Products.Find(id);
        }

        public void RemoveProduct(int id)
        {
            string imagesFolder = _ctx.ProductImages.Where(b => b.ProductId == id).FirstOrDefault().FilePath;
            _ctx.ProductImages.RemoveRange(_ctx.ProductImages.Where(b => b.ProductId == id));

            var product = _ctx.Products.Find(id);
            string mappedPath = HttpContext.Current.Server.MapPath(@"~/" + imagesFolder);

            Directory.Delete(mappedPath, true);

            _ctx.Products.Remove(product);
        }
    }
}