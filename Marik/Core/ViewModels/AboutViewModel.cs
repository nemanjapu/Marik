using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marik.Core.ViewModels
{
    public class AboutViewModel
    {
        [AllowHtml]
        public string AboutTitle { get; set; }
        [AllowHtml]
        public string AboutSubtitle { get; set; }

        public HttpPostedFileBase AboutMainImageFile { get; set; }
        public string AboutMainImageName { get; set; }
        public string AboutMainImagePath { get; set; }

        [AllowHtml]
        public string AboutFirstSectionTitle { get; set; }
        [AllowHtml]
        public string AboutFirstSectionFirstParagraph { get; set; }
        [AllowHtml]
        public string AboutFirstSectionSecondParagraph { get; set; }
        public HttpPostedFileBase AboutFirstSectionImageFile { get; set; }
        public string AboutFirstSectionImageName { get; set; }
        public string AboutFirstSectionImagePath { get; set; }

        [AllowHtml]
        public string AboutMyStoryTitle { get; set; }
        [AllowHtml]
        public string AboutMyStorySubtitle { get; set; }
        [AllowHtml]
        public string AboutMyStoryContent { get; set; }
        public HttpPostedFileBase AboutMyStoryMainImageFile { get; set; }
        public string AboutMyStoryMainImageName { get; set; }
        public string AboutMyStoryMainImagePath { get; set; }

        [AllowHtml]
        public string AboutTheFunStuffTitle { get; set; }

        [AllowHtml]
        public string AboutMyFavoritesTitle { get; set; }
        [AllowHtml]
        public string AboutMyFavoritesSubtitle { get; set; }
        [AllowHtml]
        public string AboutMyFavoritesOneOneTitle { get; set; }
        [AllowHtml]
        public string AboutMyFavoritesOneOneSubtitle { get; set; }
        [AllowHtml]
        public string AboutMyFavoritesOneTwoTitle { get; set; }
        [AllowHtml]
        public string AboutMyFavoritesOneTwoSubtitle { get; set; }
        [AllowHtml]
        public string AboutMyFavoritesTwoOneTitle { get; set; }
        [AllowHtml]
        public string AboutMyFavoritesTwoOneSubtitle { get; set; }
        [AllowHtml]
        public string AboutMyFavoritesTwoTwoTitle { get; set; }
        [AllowHtml]
        public string AboutMyFavoritesTwoTwoSubtitle { get; set; }
        [AllowHtml]
        public string AboutMyFavoritesThreeOneTitle { get; set; }
        [AllowHtml]
        public string AboutMyFavoritesThreeOneSubtitle { get; set; }
        [AllowHtml]
        public string AboutMyFavoritesThreeTwoTitle { get; set; }
        [AllowHtml]
        public string AboutMyFavoritesThreeTwoSubtitle { get; set; }
        public HttpPostedFileBase AboutMyFavoritesMainImageFile { get; set; }
        public string AboutMyFavoritesMainImageName { get; set; }
        public string AboutMyFavoritesMainImagePath { get; set; }

        public HttpPostedFileBase AboutFollowAlongMainImageFile { get; set; }
        public string AboutFollowAlongMainImageName { get; set; }
        public string AboutFollowAlongMainImagePath { get; set; }
    }
}