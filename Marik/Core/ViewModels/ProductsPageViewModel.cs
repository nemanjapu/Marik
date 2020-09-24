using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marik.Core.ViewModels
{
    public class ProductsPageViewModel
    {
        public IPagedList<ProductListViewModel> ProductList { get; set; }

        [AllowHtml]
        public string ProductsTitle { get; set; }
        [AllowHtml]
        public string ProductsSubtitle { get; set; }
        public HttpPostedFileBase ProductsMainImageFile { get; set; }
        public string ProductsMainImageName { get; set; }
        public string ProductsMainImagePath { get; set; }
    }
}