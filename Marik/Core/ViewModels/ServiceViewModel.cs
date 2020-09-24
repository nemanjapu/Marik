using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marik.Core.ViewModels
{
    public class ServiceViewModel
    {
        /*CONTENT MANAGEMENT*/
        [AllowHtml]
        public string ServiceContentManagementTitle { get; set; }
        [AllowHtml]
        public string ServiceContentManagementSubtitle { get; set; }

        public HttpPostedFileBase ServiceContentManagementMainImageFile { get; set; }
        public string ServiceContentManagementMainImageName { get; set; }
        public string ServiceContentManagementMainImagePath { get; set; }

        [AllowHtml]
        public string ServiceContentManagementFirstSectionTitle { get; set; }
        [AllowHtml]
        public string ServiceContentManagementFirstSectionFirstParagraph { get; set; }
        [AllowHtml]
        public string ServiceContentManagementFirstSectionSecondParagraph { get; set; }
        public HttpPostedFileBase ServiceContentManagementFirstSectionImageFile { get; set; }
        public string ServiceContentManagementFirstSectionImageName { get; set; }
        public string ServiceContentManagementFirstSectionImagePath { get; set; }

        /*WEB DESIGN*/
        [AllowHtml]
        public string ServiceWebDesignTitle { get; set; }
        [AllowHtml]
        public string ServiceWebDesignSubtitle { get; set; }

        public HttpPostedFileBase ServiceWebDesignMainImageFile { get; set; }
        public string ServiceWebDesignMainImageName { get; set; }
        public string ServiceWebDesignMainImagePath { get; set; }

        [AllowHtml]
        public string ServiceWebDesignFirstSectionTitle { get; set; }
        [AllowHtml]
        public string ServiceWebDesignFirstSectionFirstParagraph { get; set; }
        [AllowHtml]
        public string ServiceWebDesignFirstSectionSecondParagraph { get; set; }
        public HttpPostedFileBase ServiceWebDesignFirstSectionImageFile { get; set; }
        public string ServiceWebDesignFirstSectionImageName { get; set; }
        public string ServiceWebDesignFirstSectionImagePath { get; set; }

        /*SPSS*/
        [AllowHtml]
        public string ServiceSPSSTitle { get; set; }
        [AllowHtml]
        public string ServiceSPSSSubtitle { get; set; }

        public HttpPostedFileBase ServiceSPSSMainImageFile { get; set; }
        public string ServiceSPSSMainImageName { get; set; }
        public string ServiceSPSSMainImagePath { get; set; }

        [AllowHtml]
        public string ServiceSPSSFirstSectionTitle { get; set; }
        [AllowHtml]
        public string ServiceSPSSFirstSectionFirstParagraph { get; set; }
        [AllowHtml]
        public string ServiceSPSSFirstSectionSecondParagraph { get; set; }
        public HttpPostedFileBase ServiceSPSSFirstSectionImageFile { get; set; }
        public string ServiceSPSSFirstSectionImageName { get; set; }
        public string ServiceSPSSFirstSectionImagePath { get; set; }

        /*MARKETING*/
        [AllowHtml]
        public string ServiceMarketingTitle { get; set; }
        [AllowHtml]
        public string ServiceMarketingSubtitle { get; set; }

        public HttpPostedFileBase ServiceMarketingMainImageFile { get; set; }
        public string ServiceMarketingMainImageName { get; set; }
        public string ServiceMarketingMainImagePath { get; set; }

        [AllowHtml]
        public string ServiceMarketingFirstSectionTitle { get; set; }
        [AllowHtml]
        public string ServiceMarketingFirstSectionFirstParagraph { get; set; }
        [AllowHtml]
        public string ServiceMarketingFirstSectionSecondParagraph { get; set; }
        public HttpPostedFileBase ServiceMarketingFirstSectionImageFile { get; set; }
        public string ServiceMarketingFirstSectionImageName { get; set; }
        public string ServiceMarketingFirstSectionImagePath { get; set; }

        /*GRAPHIC DESIGN*/
        [AllowHtml]
        public string ServiceGraphicDesignTitle { get; set; }
        [AllowHtml]
        public string ServiceGraphicDesignSubtitle { get; set; }

        public HttpPostedFileBase ServiceGraphicDesignMainImageFile { get; set; }
        public string ServiceGraphicDesignMainImageName { get; set; }
        public string ServiceGraphicDesignMainImagePath { get; set; }

        [AllowHtml]
        public string ServiceGraphicDesignFirstSectionTitle { get; set; }
        [AllowHtml]
        public string ServiceGraphicDesignFirstSectionFirstParagraph { get; set; }
        [AllowHtml]
        public string ServiceGraphicDesignFirstSectionSecondParagraph { get; set; }
        public HttpPostedFileBase ServiceGraphicDesignFirstSectionImageFile { get; set; }
        public string ServiceGraphicDesignFirstSectionImageName { get; set; }
        public string ServiceGraphicDesignFirstSectionImagePath { get; set; }

        public ContactViewModel ContactFormDetails { get; set; }
    }
}