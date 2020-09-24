using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marik.Core.ViewModels
{
    public class HomePageViewModel
    {
        public IEnumerable<ReviewsViewModel> Reviews { get; set; }

        [AllowHtml]
        public string HomepageTitle { get; set; }
        [AllowHtml]
        public string HomepageSubtitle { get; set; }

        public HttpPostedFileBase HomepageMainImageFile { get; set; }
        public string HomepageMainImageName { get; set; }
        public string HomepageMainImagePath { get; set; }

        [AllowHtml]
        public string HomepageFirstSectionTitle { get; set; }
        [AllowHtml]
        public string HomepageFirstSectionFirstParagraph { get; set; }
        [AllowHtml]
        public string HomepageFirstSectionSecondParagraph { get; set; }
        public HttpPostedFileBase HomepageFirstSectionImageFile { get; set; }
        public string HomepageFirstSectionImageName { get; set; }
        public string HomepageFirstSectionImagePath { get; set; }

        [AllowHtml]
        public string HomepageServicesTitle { get; set; }
        public HttpPostedFileBase HomepageService1ImageFile { get; set; }
        public string HomepageService1ImageName { get; set; }
        public string HomepageService1ImagePath { get; set; }
        public HttpPostedFileBase HomepageService2ImageFile { get; set; }
        public string HomepageService2ImageName { get; set; }
        public string HomepageService2ImagePath { get; set; }
        public HttpPostedFileBase HomepageService3ImageFile { get; set; }
        public string HomepageService3ImageName { get; set; }
        public string HomepageService3ImagePath { get; set; }
        public HttpPostedFileBase HomepageService4ImageFile { get; set; }
        public string HomepageService4ImageName { get; set; }
        public string HomepageService4ImagePath { get; set; }
        public HttpPostedFileBase HomepageService5ImageFile { get; set; }
        public string HomepageService5ImageName { get; set; }
        public string HomepageService5ImagePath { get; set; }

        [AllowHtml]
        public string HomepageReviewsText { get; set; }

        [AllowHtml]
        public string HomepageSecondSectionTitle { get; set; }
        [AllowHtml]
        public string HomepageSecondSectionFirstParagraph { get; set; }
        [AllowHtml]
        public string HomepageSecondSectionSecondParagraph { get; set; }
        public HttpPostedFileBase HomepageSecondSectionImageFile { get; set; }
        public string HomepageSecondSectionImageName { get; set; }
        public string HomepageSecondSectionImagePath { get; set; }
    }
}