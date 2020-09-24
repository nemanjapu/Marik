using Marik.Core;
using Marik.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marik.Areas.Editor.Controllers
{
    [Authorize]
    public class AboutController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public AboutController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActionResult Index()
        {
            var websiteContent = _unitOfWork.WebsiteContent.GetWebsiteContent();

            var model = new AboutViewModel()
            {
                AboutFirstSectionFirstParagraph = websiteContent.AboutFirstSectionFirstParagraph,
                AboutFirstSectionImageName = websiteContent.AboutFirstSectionImageName,
                AboutFirstSectionImagePath = websiteContent.AboutFirstSectionImagePath,
                AboutFirstSectionSecondParagraph = websiteContent.AboutFirstSectionSecondParagraph,
                AboutFollowAlongMainImageName = websiteContent.AboutFollowAlongMainImageName,
                AboutFollowAlongMainImagePath = websiteContent.AboutFollowAlongMainImagePath,
                AboutMainImageName = websiteContent.AboutMainImageName,
                AboutMainImagePath = websiteContent.AboutMainImagePath,
                AboutFirstSectionTitle = websiteContent.AboutFirstSectionTitle,
                AboutMyFavoritesMainImageName = websiteContent.AboutMyFavoritesMainImageName,
                AboutMyFavoritesMainImagePath = websiteContent.AboutMyFavoritesMainImagePath,
                AboutMyFavoritesOneOneSubtitle = websiteContent.AboutMyFavoritesOneOneSubtitle,
                AboutMyFavoritesOneOneTitle = websiteContent.AboutMyFavoritesOneOneTitle,
                AboutMyFavoritesOneTwoSubtitle = websiteContent.AboutMyFavoritesOneTwoSubtitle,
                AboutMyFavoritesOneTwoTitle = websiteContent.AboutMyFavoritesOneTwoTitle,
                AboutMyFavoritesSubtitle = websiteContent.AboutMyFavoritesSubtitle,
                AboutMyFavoritesThreeOneSubtitle = websiteContent.AboutMyFavoritesThreeOneSubtitle,
                AboutMyFavoritesThreeOneTitle = websiteContent.AboutMyFavoritesThreeOneTitle,
                AboutMyFavoritesThreeTwoSubtitle = websiteContent.AboutMyFavoritesThreeTwoSubtitle,
                AboutMyFavoritesThreeTwoTitle = websiteContent.AboutMyFavoritesThreeTwoTitle,
                AboutMyFavoritesTitle = websiteContent.AboutMyFavoritesTitle,
                AboutMyFavoritesTwoOneSubtitle = websiteContent.AboutMyFavoritesTwoOneSubtitle,
                AboutMyFavoritesTwoOneTitle = websiteContent.AboutMyFavoritesTwoOneTitle,
                AboutMyFavoritesTwoTwoSubtitle = websiteContent.AboutMyFavoritesTwoTwoSubtitle,
                AboutMyFavoritesTwoTwoTitle = websiteContent.AboutMyFavoritesTwoTwoTitle,
                AboutMyStoryContent = websiteContent.AboutMyStoryContent,
                AboutMyStoryMainImageName = websiteContent.AboutMyStoryMainImageName,
                AboutMyStoryMainImagePath = websiteContent.AboutMyStoryMainImagePath,
                AboutMyStorySubtitle = websiteContent.AboutMyStorySubtitle,
                AboutMyStoryTitle = websiteContent.AboutMyStoryTitle,
                AboutSubtitle = websiteContent.AboutSubtitle,
                AboutTitle = websiteContent.AboutTitle,
                AboutTheFunStuffTitle = websiteContent.AboutTheFunStuffTitle
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveAboutContent(AboutViewModel model)
        {
            var abContent = _unitOfWork.WebsiteContent.GetWebsiteContent();
            var HomepagePath = "/DynamicContent/AboutContent";

            abContent.AboutFirstSectionFirstParagraph = model.AboutFirstSectionFirstParagraph;
            if (model.AboutFirstSectionImageFile != null)
            {
                abContent.AboutFirstSectionImageName = model.AboutFirstSectionImageFile.FileName;
                abContent.AboutFirstSectionImagePath = HomepagePath;
                model.AboutFirstSectionImageFile.SaveAs(Path.Combine(Server.MapPath(HomepagePath), model.AboutFirstSectionImageFile.FileName));
            }
            abContent.AboutFirstSectionSecondParagraph = model.AboutFirstSectionSecondParagraph;
            if (model.AboutFollowAlongMainImageFile != null)
            {
                abContent.AboutFollowAlongMainImageName = model.AboutFollowAlongMainImageFile.FileName;
                abContent.AboutFollowAlongMainImagePath = HomepagePath;
                model.AboutFollowAlongMainImageFile.SaveAs(Path.Combine(Server.MapPath(HomepagePath), model.AboutFollowAlongMainImageFile.FileName));
            }
            if (model.AboutMainImageFile != null)
            {
                abContent.AboutMainImageName = model.AboutMainImageFile.FileName;
                abContent.AboutMainImagePath = HomepagePath;
                model.AboutMainImageFile.SaveAs(Path.Combine(Server.MapPath(HomepagePath), model.AboutMainImageFile.FileName));
            }
            abContent.AboutFirstSectionTitle = model.AboutFirstSectionTitle;
            if (model.AboutMyFavoritesMainImageFile != null)
            {
                abContent.AboutMyFavoritesMainImageName = model.AboutMyFavoritesMainImageFile.FileName;
                abContent.AboutMyFavoritesMainImagePath = HomepagePath;
                model.AboutMyFavoritesMainImageFile.SaveAs(Path.Combine(Server.MapPath(HomepagePath), model.AboutMyFavoritesMainImageFile.FileName));
            }
            abContent.AboutMyFavoritesOneOneSubtitle = model.AboutMyFavoritesOneOneSubtitle;
            abContent.AboutMyFavoritesOneOneTitle = model.AboutMyFavoritesOneOneTitle;
            abContent.AboutMyFavoritesOneTwoSubtitle = model.AboutMyFavoritesOneTwoSubtitle;
            abContent.AboutMyFavoritesOneTwoTitle = model.AboutMyFavoritesOneTwoTitle;
            abContent.AboutMyFavoritesSubtitle = model.AboutMyFavoritesSubtitle;
            abContent.AboutMyFavoritesThreeOneSubtitle = model.AboutMyFavoritesThreeOneSubtitle;
            abContent.AboutMyFavoritesThreeOneTitle = model.AboutMyFavoritesThreeOneTitle;
            abContent.AboutMyFavoritesThreeTwoSubtitle = model.AboutMyFavoritesThreeTwoSubtitle;
            abContent.AboutMyFavoritesThreeTwoTitle = model.AboutMyFavoritesThreeTwoTitle;
            abContent.AboutMyFavoritesTitle = model.AboutMyFavoritesTitle;
            abContent.AboutMyFavoritesTwoOneSubtitle = model.AboutMyFavoritesTwoOneSubtitle;
            abContent.AboutMyFavoritesTwoOneTitle = model.AboutMyFavoritesTwoOneTitle;
            abContent.AboutMyFavoritesTwoTwoSubtitle = model.AboutMyFavoritesTwoTwoSubtitle;
            abContent.AboutMyFavoritesTwoTwoTitle = model.AboutMyFavoritesTwoTwoTitle;
            abContent.AboutMyStoryContent = model.AboutMyStoryContent;
            if (model.AboutMyStoryMainImageFile != null)
            {
                abContent.AboutMyStoryMainImageName = model.AboutMyStoryMainImageFile.FileName;
                abContent.AboutMyStoryMainImagePath = HomepagePath;
                model.AboutMyStoryMainImageFile.SaveAs(Path.Combine(Server.MapPath(HomepagePath), model.AboutMyStoryMainImageFile.FileName));
            }
            abContent.AboutMyStorySubtitle = model.AboutMyStorySubtitle;
            abContent.AboutMyStoryTitle = model.AboutMyStoryTitle;
            abContent.AboutSubtitle = model.AboutSubtitle;
            abContent.AboutTitle = model.AboutTitle;
            abContent.AboutTheFunStuffTitle = model.AboutTheFunStuffTitle;

            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }
    }
}