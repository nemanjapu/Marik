using Marik.Core;
using Marik.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Marik.Areas.Admin.Controllers.APIControllers
{
    public class ProductImagesController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductImagesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public IHttpActionResult SetImagesOrder(IEnumerable<ProductImages> images)
        {
            _unitOfWork.ProductImage.SetImagesOrder(images);
            _unitOfWork.Complete();

            return Ok();
        }

        [HttpPost]
        public IHttpActionResult DeleteProductImage(int id)
        {
            if (!_unitOfWork.ProductImage.DeleteProductImage(id))
            {
                return BadRequest();
            }
            _unitOfWork.Complete();

            return Ok();
        }
    }
}
