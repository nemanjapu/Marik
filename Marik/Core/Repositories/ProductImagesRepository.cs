using Marik.Core.Interfaces;
using Marik.DAL;
using Marik.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marik.Core.Repositories
{
    public class ProductImagesRepository: IProductImagesRepository
    {
        private readonly ApplicationDbContext _ctx;

        public ProductImagesRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public bool DeleteProductImage(int id)
        {
            ProductImages ProductImages = _ctx.ProductImages.Find(id);
            if (_ctx.ProductImages.Where(pimg => pimg.ProductId == ProductImages.ProductId).ToList().Count() > 1)
            {
                string fullPath = System.Web.Hosting.HostingEnvironment.MapPath("~/" + ProductImages.FilePath + "/" + ProductImages.FileName);
                if (System.IO.File.Exists(fullPath))
                {
                    System.IO.File.Delete(fullPath);
                }

                _ctx.ProductImages.Remove(ProductImages);

                return true;
            }
            return false;
        }

        public ProductImages GetProductImageByProductId(int productId)
        {
            return _ctx.ProductImages.Where(pimg => pimg.ProductId == productId).OrderBy(pimg => pimg.SortOrder).ThenBy(pimg => pimg.Id).FirstOrDefault();
        }

        public IQueryable<ProductImages> GetProductImages()
        {
            return _ctx.ProductImages;
        }

        public void SetImagesOrder(IEnumerable<ProductImages> images)
        {
            foreach (var img in images)
            {
                var DbImage = _ctx.ProductImages.Find(img.Id);
                DbImage.SortOrder = img.SortOrder;
            }
        }
    }
}