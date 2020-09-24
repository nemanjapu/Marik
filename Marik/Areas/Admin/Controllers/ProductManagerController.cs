using Marik.Areas.Admin.ViewModels;
using Marik.Core;
using Marik.Helpers;
using Marik.Core.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marik.Areas.Admin.Controllers
{
    [Authorize]
    public class ProductManagerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductManagerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActionResult Index()
        {
            var model = _unitOfWork.Product.GetActiveProducts();

            return View(model);
        }

        public ActionResult InactiveProducts()
        {
            var model = _unitOfWork.Product.GetInactiveProducts();

            return View(model);
        }

        public ActionResult NewProduct()
        {
            var model = new AddProductViewModel();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveNewProduct(AddProductViewModel model)
        {
            List<ProductImages> images = new List<ProductImages>();
            string folderDate = DateTime.Now.ToString("yyyyMMddHHmmss");
            Directory.CreateDirectory(Server.MapPath("~/DynamicContent/ProductImages/Product" + folderDate));
            var path = "~/DynamicContent/ProductImages/Product" + folderDate;
            var pathToSave = "DynamicContent/ProductImages/Product" + folderDate;
            var imgPath = "";
            for (int i = 0; i < Request.Files.Count; i++)
            {
                var file = Request.Files[i];

                if (file != null && file.ContentLength > 0 && HttpPostedFileBaseExtensions.IsImage(file))
                    {
                    var fileName = Path.GetFileName(file.FileName);
                    ProductImages fileDetail = new ProductImages()
                    {
                        FileName = fileName,
                        Extension = Path.GetExtension(fileName),
                        FileNameNoExt = Path.GetFileNameWithoutExtension(fileName),
                        FilePath = pathToSave
                    };
                    images.Add(fileDetail);

                    imgPath = Path.Combine(Server.MapPath(path), fileDetail.FileName);
                    file.SaveAs(imgPath);
                }
            }

            var PdfPathToSave = "";
            if (model.document != null && model.document.ContentLength > 0)
            {
                Directory.CreateDirectory(Server.MapPath("~/DynamicContent/ProductPDFs/Product" + folderDate));
                var PdfPath = Path.Combine(Server.MapPath("~/DynamicContent/ProductPDFs/Product" + folderDate), model.document.FileName);
                PdfPathToSave = "DynamicContent/ProductPDFs/Product" + folderDate;
                model.document.SaveAs(PdfPath);
            }

            var dbProduct = new Product
            {
                DatePublished = DateTime.Now,
                Images = images,
                isActive = model.isActive,
                Name = model.Name,
                Subtitle = model.Subtitle,
                Text = model.Text,
                Price = model.Price,
                MetaDescription = model.MetaDescription,
                MetaKeywords = model.MetaKeywords,
                DocumentPath = PdfPathToSave,
                DocumentName = model.document.FileName,
                NumberOfDownloads = 0
            };

            _unitOfWork.Product.AddProduct(dbProduct);
            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }

        public ActionResult DownloadPDF(string path, string fileName)
        {
            var filePath = Server.MapPath("~/" + path + "/" + fileName);
            return File(filePath, "application/pdf", fileName);
        }

        public ActionResult EditProduct(int id)
        {
            var p = _unitOfWork.Product.GetProductById(id);

            var model = new EditProductViewModel()
            {
                Id = p.Id,
                EditImagesList = _unitOfWork.ProductImage.GetProductImages().Where(pimg => pimg.ProductId == id).OrderBy(limg => limg.SortOrder).ThenBy(i => i.Id).ToList(),
                isActive = p.isActive,
                Name = p.Name,
                Subtitle = p.Subtitle,
                Text = p.Text,
                Price = p.Price,
                MetaDescription = p.MetaDescription,
                MetaKeywords = p.MetaKeywords,
                DocumentName = p.DocumentName
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveEditedProduct(EditProductViewModel model)
        {
            var proDB = _unitOfWork.Product.GetProductById(model.Id);

            List<ProductImages> images = new List<ProductImages>();
            var pathToSave = _unitOfWork.ProductImage.GetProductImageByProductId(model.Id).FilePath;
            var path = "~/" + pathToSave;
            var imgPath = "";
            for (int i = 0; i < Request.Files.Count; i++)
            {
                var file = Request.Files[i];
                
                if (file != null && file.ContentLength > 0 && HttpPostedFileBaseExtensions.IsImage(file))
                    {
                    var fileName = Path.GetFileName(file.FileName);
                    ProductImages fileDetail = new ProductImages()
                    {
                        FileName = fileName,
                        Extension = Path.GetExtension(fileName),
                        FileNameNoExt = Path.GetFileNameWithoutExtension(fileName),
                        FilePath = pathToSave
                    };
                    images.Add(fileDetail);

                    imgPath = Path.Combine(Server.MapPath(path), fileDetail.FileName);
                    file.SaveAs(imgPath);
                }
            }
            var newImages = proDB.Images.Concat(images).ToList();

            var PdfPathToSave = "";
            if (model.document != null && model.document.ContentLength > 0)
            {
                string folderDate = DateTime.Now.ToString("yyyyMMddHHmmss");
                Directory.CreateDirectory(Server.MapPath("~/DynamicContent/ProductPDFs/Product" + folderDate));
                var PdfPath = Path.Combine(Server.MapPath("~/DynamicContent/ProductPDFs/Product" + folderDate), model.document.FileName);
                PdfPathToSave = "DynamicContent/ProductPDFs/Product" + folderDate;
                model.document.SaveAs(PdfPath);

                proDB.DocumentPath = PdfPathToSave;
                proDB.DocumentName = model.document.FileName;
            }

            proDB.Images = newImages;
            proDB.isActive = model.isActive;
            proDB.Name = model.Name;
            proDB.Subtitle = model.Subtitle;
            proDB.Text = model.Text;
            proDB.Price = model.Price;
            proDB.MetaDescription = model.MetaDescription;
            proDB.MetaKeywords = model.MetaKeywords;

            _unitOfWork.Complete();

            return RedirectToAction("EditProduct", new { id = model.Id });
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult DeleteProduct(int id)
        {
            _unitOfWork.Product.RemoveProduct(id);
            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }
    }
}