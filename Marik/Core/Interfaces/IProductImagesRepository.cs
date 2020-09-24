using Marik.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marik.Core.Interfaces
{
    public interface IProductImagesRepository
    {
        bool DeleteProductImage(int id);
        ProductImages GetProductImageByProductId(int ProductId);
        IQueryable<ProductImages> GetProductImages();
        void SetImagesOrder(IEnumerable<ProductImages> images);
    }
}
