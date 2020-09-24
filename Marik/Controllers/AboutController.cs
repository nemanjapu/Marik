using Marik.Core;
using Marik.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marik.Controllers
{
    [HandleError]
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

            ViewBag.TopImage = websiteContent.AboutMainImagePath + "/" + websiteContent.AboutMainImageName;
            ViewBag.Headline = websiteContent.AboutTitle;
            ViewBag.SubHeadline = websiteContent.AboutSubtitle;

            return View(model);
        }
    }
}