using Marik.Core;
using Marik.Core.ViewModels;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marik.Controllers
{
    [HandleError]
    public class ProductsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Products
        public ActionResult Index(int? page)
        {
            int pageSize = 9;
            int pageNumber = (page ?? 1);

            var websiteContent = _unitOfWork.WebsiteContent.GetWebsiteContent();

            var model = new ProductsPageViewModel()
            {
                ProductList = _unitOfWork.Product.GetActiveProducts().Select(pl => new ProductListViewModel
                {
                    Id = pl.Id,
                    Name = pl.Name,
                    FeaturedImage = _unitOfWork.ProductImage.GetProductImageByProductId(pl.Id).FilePath + "/" + _unitOfWork.ProductImage.GetProductImageByProductId(pl.Id).FileName
                }).ToPagedList(pageNumber, pageSize),
                ProductsTitle = websiteContent.ProductsTitle,
                ProductsSubtitle = websiteContent.ProductsSubtitle,
                ProductsMainImageName = websiteContent.ProductsMainImageName,
                ProductsMainImagePath = websiteContent.ProductsMainImagePath
            };

            ViewBag.TopImage = websiteContent.ProductsMainImagePath + "/" + websiteContent.ProductsMainImageName;
            ViewBag.Headline = websiteContent.ProductsTitle;
            ViewBag.SubHeadline = websiteContent.ProductsSubtitle;

            return View(model);
        }

        [Route("products/{Id}/{Name}")]
        public ActionResult Product(int id)
        {
            var productDb = _unitOfWork.Product.GetProductById(id);

            var model = new ProductDetailsViewModel()
            {
                Name = productDb.Name,
                Subtitle = productDb.Subtitle,
                DocumentName = productDb.DocumentName,
                DocumentPath = productDb.DocumentPath,
                Id = productDb.Id,
                Images = productDb.Images,
                Price = productDb.Price,
                MetaDescription = productDb.MetaDescription,
                MetaKeywords = productDb.MetaKeywords,
                Text = productDb.Text
            };

            ViewBag.TopImage = "/Content/img/main-banner.jpg";
            ViewBag.Headline = model.Name;
            //ViewBag.SubHeadline = "let's get personal";

            return View(model);
        }

        //public ActionResult DownloadPDF(string path, string fileName)
        public ActionResult DownloadPDF(int productId)
        {

            var product = _unitOfWork.Product.GetProductById(productId);

            product.NumberOfDownloads = product.NumberOfDownloads + 1;
            _unitOfWork.Complete();

            var filePath = Server.MapPath("~/" + product.DocumentPath + "/" + product.DocumentName);
            return File(filePath, "application/pdf", product.DocumentName);
        }
    }
}