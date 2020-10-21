using MailChimp.Net;
using Marik.Areas.Admin.ViewModels;
using Marik.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marik.Areas.Admin.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        //private static MailChimpManager mcManager = new MailChimpManager("7c9f307bfe083c6152698211349bf9a8-us20");

        public DashboardController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Admin/Dashboard
        public async System.Threading.Tasks.Task<ActionResult> Index()
        {
            //var newsletterSubscribers =  await mcManager.Members.GetTotalItems("a0df8aa760", null).ConfigureAwait(false);
            var model = new DashboardViewModel()
            {
                LatestContacts = _unitOfWork.Lead.GetAllLeads().Take(10).ToList(),
                LatestProducts = _unitOfWork.Product.GetActiveProducts().Take(10).ToList(),
                MostDownloadedProduct = _unitOfWork.Product.GetAllProducts().OrderByDescending(p => p.NumberOfDownloads).FirstOrDefault(),
                NumberOfBlogs = _unitOfWork.Blog.GetActiveBlogs().Count(),
                NumberOfContacts = _unitOfWork.Lead.GetAllLeads().Count(),
                NumberOfProduts = _unitOfWork.Product.GetActiveProducts().Count()
                //NumberOfNewsletterSubscribers = newsletterSubscribers
            };

            return View(model);
        }
    }
}