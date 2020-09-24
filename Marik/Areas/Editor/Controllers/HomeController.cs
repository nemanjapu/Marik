using Marik.Core;
using Marik.Core.Models;
using Marik.Core.ViewModels;
using System;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Web.Mvc;

namespace Marik.Areas.Editor.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActionResult Index()
        {
            var hpContent = _unitOfWork.WebsiteContent.GetWebsiteContent();
            var model = new HomePageViewModel()
            {
                Reviews = _unitOfWork.ClientReviews.GetActiveReviews().Select(r => new ReviewsViewModel()
                {
                    ClientName = r.ClientName,
                    Text = r.Text
                }),
                HomepageFirstSectionFirstParagraph = hpContent.HomepageFirstSectionFirstParagraph,
                HomepageFirstSectionImageName = hpContent.HomepageFirstSectionImageName,
                HomepageFirstSectionImagePath = hpContent.HomepageFirstSectionImagePath,
                HomepageFirstSectionSecondParagraph = hpContent.HomepageFirstSectionSecondParagraph,
                HomepageFirstSectionTitle = hpContent.HomepageFirstSectionTitle,
                HomepageMainImageName = hpContent.HomepageMainImageName,
                HomepageMainImagePath = hpContent.HomepageMainImagePath,
                HomepageReviewsText = hpContent.HomepageReviewsText,
                HomepageSecondSectionFirstParagraph = hpContent.HomepageSecondSectionFirstParagraph,
                HomepageSecondSectionImageName = hpContent.HomepageSecondSectionImageName,
                HomepageSecondSectionImagePath = hpContent.HomepageSecondSectionImagePath,
                HomepageSecondSectionSecondParagraph = hpContent.HomepageSecondSectionSecondParagraph,
                HomepageSecondSectionTitle = hpContent.HomepageSecondSectionTitle,
                HomepageService1ImageName = hpContent.HomepageService1ImageName,
                HomepageService1ImagePath = hpContent.HomepageService1ImagePath,
                HomepageService2ImageName = hpContent.HomepageService2ImageName,
                HomepageService2ImagePath = hpContent.HomepageService2ImagePath,
                HomepageService3ImageName = hpContent.HomepageService3ImageName,
                HomepageService3ImagePath = hpContent.HomepageService3ImagePath,
                HomepageService4ImageName = hpContent.HomepageService4ImageName,
                HomepageService4ImagePath = hpContent.HomepageService4ImagePath,
                HomepageService5ImageName = hpContent.HomepageService5ImageName,
                HomepageService5ImagePath = hpContent.HomepageService5ImagePath,
                HomepageServicesTitle = hpContent.HomepageServicesTitle,
                HomepageSubtitle = hpContent.HomepageSubtitle,
                HomepageTitle = hpContent.HomepageTitle
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveHomepageContent(HomePageViewModel model)
        {
            var hpContent = _unitOfWork.WebsiteContent.GetWebsiteContent();
            var HomepagePath = "/DynamicContent/HomepageContent";

            hpContent.HomepageFirstSectionFirstParagraph = model.HomepageFirstSectionFirstParagraph;
            if (model.HomepageFirstSectionImageFile != null)
            {
                hpContent.HomepageFirstSectionImageName = model.HomepageFirstSectionImageFile.FileName;
                hpContent.HomepageFirstSectionImagePath = HomepagePath;
                model.HomepageFirstSectionImageFile.SaveAs(Path.Combine(Server.MapPath(HomepagePath), model.HomepageFirstSectionImageFile.FileName));
            } 
            hpContent.HomepageFirstSectionSecondParagraph = model.HomepageFirstSectionSecondParagraph;
            hpContent.HomepageFirstSectionTitle = model.HomepageFirstSectionTitle;
            if (model.HomepageMainImageFile != null)
            {
                hpContent.HomepageMainImageName = model.HomepageMainImageFile.FileName;
                hpContent.HomepageMainImagePath = HomepagePath;
                model.HomepageMainImageFile.SaveAs(Path.Combine(Server.MapPath(HomepagePath), model.HomepageMainImageFile.FileName));
            }
            hpContent.HomepageReviewsText = model.HomepageReviewsText;
            hpContent.HomepageSecondSectionFirstParagraph = model.HomepageSecondSectionFirstParagraph;
            if (model.HomepageSecondSectionImageFile != null)
            {
                hpContent.HomepageSecondSectionImageName = model.HomepageSecondSectionImageFile.FileName;
                hpContent.HomepageSecondSectionImagePath = HomepagePath;
                model.HomepageSecondSectionImageFile.SaveAs(Path.Combine(Server.MapPath(HomepagePath), model.HomepageSecondSectionImageFile.FileName));
            }
            hpContent.HomepageSecondSectionSecondParagraph = model.HomepageSecondSectionSecondParagraph;
            hpContent.HomepageSecondSectionTitle = model.HomepageSecondSectionTitle;
            if (model.HomepageService1ImageFile != null)
            {
                hpContent.HomepageService1ImageName = model.HomepageService1ImageFile.FileName;
                hpContent.HomepageService1ImagePath = HomepagePath;
                model.HomepageService1ImageFile.SaveAs(Path.Combine(Server.MapPath(HomepagePath), model.HomepageService1ImageFile.FileName));
            }
            if (model.HomepageService2ImageFile != null)
            {
                hpContent.HomepageService2ImageName = model.HomepageService2ImageFile.FileName;
                hpContent.HomepageService2ImagePath = HomepagePath;
                model.HomepageService2ImageFile.SaveAs(Path.Combine(Server.MapPath(HomepagePath), model.HomepageService2ImageFile.FileName));
            }
            if (model.HomepageService3ImageFile != null)
            {
                hpContent.HomepageService3ImageName = model.HomepageService3ImageFile.FileName;
                hpContent.HomepageService3ImagePath = HomepagePath;
                model.HomepageService3ImageFile.SaveAs(Path.Combine(Server.MapPath(HomepagePath), model.HomepageService3ImageFile.FileName));
            }
            if (model.HomepageService4ImageFile != null)
            {
                hpContent.HomepageService4ImageName = model.HomepageService4ImageFile.FileName;
                hpContent.HomepageService4ImagePath = HomepagePath;
                model.HomepageService4ImageFile.SaveAs(Path.Combine(Server.MapPath(HomepagePath), model.HomepageService4ImageFile.FileName));
            }
            if (model.HomepageService5ImageFile != null)
            {
                hpContent.HomepageService5ImageName = model.HomepageService5ImageFile.FileName;
                hpContent.HomepageService5ImagePath = HomepagePath;
                model.HomepageService5ImageFile.SaveAs(Path.Combine(Server.MapPath(HomepagePath), model.HomepageService5ImageFile.FileName));
            }
            hpContent.HomepageServicesTitle = model.HomepageServicesTitle;
            hpContent.HomepageSubtitle = model.HomepageSubtitle;
            hpContent.HomepageTitle = model.HomepageTitle;

            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }
    }
}