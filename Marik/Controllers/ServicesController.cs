using Marik.Core;
using Marik.Core.Models;
using Marik.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marik.Controllers
{
    public class ServicesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ServicesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        public ActionResult BusinessDevelopment()
        {
            var websiteContent = _unitOfWork.WebsiteContent.GetWebsiteContent();
            var gs = _unitOfWork.GlobalSettings.GetGlobalValues();

            var model = new ServiceViewModel()
            {
                ServiceContentManagementFirstSectionFirstParagraph = websiteContent.ServiceContentManagementFirstSectionFirstParagraph,
                ServiceContentManagementFirstSectionImageName = websiteContent.ServiceContentManagementFirstSectionImageName,
                ServiceContentManagementFirstSectionImagePath = websiteContent.ServiceContentManagementFirstSectionImagePath,
                ServiceContentManagementFirstSectionSecondParagraph = websiteContent.ServiceContentManagementFirstSectionSecondParagraph,
                ServiceContentManagementMainImageName = websiteContent.ServiceContentManagementMainImageName,
                ServiceContentManagementMainImagePath = websiteContent.ServiceContentManagementMainImagePath,
                ServiceContentManagementFirstSectionTitle = websiteContent.ServiceContentManagementFirstSectionTitle,
                ServiceContentManagementSubtitle = websiteContent.ServiceContentManagementSubtitle,
                ServiceContentManagementTitle = websiteContent.ServiceContentManagementTitle,
                ContactFormDetails = new ContactViewModel()
                {
                    WebsiteEmailAddress = gs.EmailAddress,
                    FacebookLink = gs.FacebookLink,
                    GooglePlusLink = gs.GooglePlusLink,
                    InstagramLink = gs.InstagramLink,
                    LinkedinLink = gs.LinkedinLink,
                    PinterestLink = gs.PinterestLink,
                    TwitterLink = gs.TwitterLink,
                    YoutubeLink = gs.YoutubeLink
                }
            };

            ViewBag.TopImage = websiteContent.ServiceContentManagementMainImagePath + "/" + websiteContent.ServiceContentManagementMainImageName;
            ViewBag.Headline = websiteContent.ServiceContentManagementTitle;
            ViewBag.SubHeadline = websiteContent.ServiceContentManagementSubtitle;
            
            return View(model);
        }

        public ActionResult Marketing()
        {
            var websiteContent = _unitOfWork.WebsiteContent.GetWebsiteContent();
            var gs = _unitOfWork.GlobalSettings.GetGlobalValues();
            var model = new ServiceViewModel()
            {
                ServiceMarketingFirstSectionFirstParagraph = websiteContent.ServiceMarketingFirstSectionFirstParagraph,
                ServiceMarketingFirstSectionImageName = websiteContent.ServiceMarketingFirstSectionImageName,
                ServiceMarketingFirstSectionImagePath = websiteContent.ServiceMarketingFirstSectionImagePath,
                ServiceMarketingFirstSectionSecondParagraph = websiteContent.ServiceMarketingFirstSectionSecondParagraph,
                ServiceMarketingMainImageName = websiteContent.ServiceMarketingMainImageName,
                ServiceMarketingMainImagePath = websiteContent.ServiceMarketingMainImagePath,
                ServiceMarketingFirstSectionTitle = websiteContent.ServiceMarketingFirstSectionTitle,
                ServiceMarketingSubtitle = websiteContent.ServiceMarketingSubtitle,
                ServiceMarketingTitle = websiteContent.ServiceMarketingTitle,
                ContactFormDetails = new ContactViewModel()
                {
                    WebsiteEmailAddress = gs.EmailAddress,
                    FacebookLink = gs.FacebookLink,
                    GooglePlusLink = gs.GooglePlusLink,
                    InstagramLink = gs.InstagramLink,
                    LinkedinLink = gs.LinkedinLink,
                    PinterestLink = gs.PinterestLink,
                    TwitterLink = gs.TwitterLink,
                    YoutubeLink = gs.YoutubeLink
                }
            };

            ViewBag.TopImage = websiteContent.ServiceMarketingMainImagePath + "/" + websiteContent.ServiceMarketingMainImageName;
            ViewBag.Headline = websiteContent.ServiceMarketingTitle;
            ViewBag.SubHeadline = websiteContent.ServiceMarketingSubtitle;

            return View(model);
        }

        public ActionResult WebDesign()
        {
            var websiteContent = _unitOfWork.WebsiteContent.GetWebsiteContent();
            var gs = _unitOfWork.GlobalSettings.GetGlobalValues();
            var model = new ServiceViewModel()
            {
                ServiceWebDesignFirstSectionFirstParagraph = websiteContent.ServiceWebDesignFirstSectionFirstParagraph,
                ServiceWebDesignFirstSectionImageName = websiteContent.ServiceWebDesignFirstSectionImageName,
                ServiceWebDesignFirstSectionImagePath = websiteContent.ServiceWebDesignFirstSectionImagePath,
                ServiceWebDesignFirstSectionSecondParagraph = websiteContent.ServiceWebDesignFirstSectionSecondParagraph,
                ServiceWebDesignMainImageName = websiteContent.ServiceWebDesignMainImageName,
                ServiceWebDesignMainImagePath = websiteContent.ServiceWebDesignMainImagePath,
                ServiceWebDesignFirstSectionTitle = websiteContent.ServiceWebDesignFirstSectionTitle,
                ServiceWebDesignSubtitle = websiteContent.ServiceWebDesignSubtitle,
                ServiceWebDesignTitle = websiteContent.ServiceWebDesignTitle,
                ContactFormDetails = new ContactViewModel()
                {
                    WebsiteEmailAddress = gs.EmailAddress,
                    FacebookLink = gs.FacebookLink,
                    GooglePlusLink = gs.GooglePlusLink,
                    InstagramLink = gs.InstagramLink,
                    LinkedinLink = gs.LinkedinLink,
                    PinterestLink = gs.PinterestLink,
                    TwitterLink = gs.TwitterLink,
                    YoutubeLink = gs.YoutubeLink
                }
            };

            ViewBag.TopImage = websiteContent.ServiceWebDesignMainImagePath + "/" + websiteContent.ServiceWebDesignMainImageName;
            ViewBag.Headline = websiteContent.ServiceWebDesignTitle;
            ViewBag.SubHeadline = websiteContent.ServiceWebDesignSubtitle;

            return View(model);
        }

        public ActionResult SPSS()
        {
            var websiteContent = _unitOfWork.WebsiteContent.GetWebsiteContent();
            var gs = _unitOfWork.GlobalSettings.GetGlobalValues();
            var model = new ServiceViewModel()
            {
                ServiceSPSSFirstSectionFirstParagraph = websiteContent.ServiceSPSSFirstSectionFirstParagraph,
                ServiceSPSSFirstSectionImageName = websiteContent.ServiceSPSSFirstSectionImageName,
                ServiceSPSSFirstSectionImagePath = websiteContent.ServiceSPSSFirstSectionImagePath,
                ServiceSPSSFirstSectionSecondParagraph = websiteContent.ServiceSPSSFirstSectionSecondParagraph,
                ServiceSPSSMainImageName = websiteContent.ServiceSPSSMainImageName,
                ServiceSPSSMainImagePath = websiteContent.ServiceSPSSMainImagePath,
                ServiceSPSSFirstSectionTitle = websiteContent.ServiceSPSSFirstSectionTitle,
                ServiceSPSSSubtitle = websiteContent.ServiceSPSSSubtitle,
                ServiceSPSSTitle = websiteContent.ServiceSPSSTitle,
                ContactFormDetails = new ContactViewModel()
                {
                    WebsiteEmailAddress = gs.EmailAddress,
                    FacebookLink = gs.FacebookLink,
                    GooglePlusLink = gs.GooglePlusLink,
                    InstagramLink = gs.InstagramLink,
                    LinkedinLink = gs.LinkedinLink,
                    PinterestLink = gs.PinterestLink,
                    TwitterLink = gs.TwitterLink,
                    YoutubeLink = gs.YoutubeLink
                }
            };

            ViewBag.TopImage = websiteContent.ServiceSPSSMainImagePath + "/" + websiteContent.ServiceSPSSMainImageName;
            ViewBag.Headline = websiteContent.ServiceSPSSTitle;
            ViewBag.SubHeadline = websiteContent.ServiceSPSSSubtitle;

            return View(model);
        }

        public ActionResult GraphicDesign()
        {
            var websiteContent = _unitOfWork.WebsiteContent.GetWebsiteContent();
            var gs = _unitOfWork.GlobalSettings.GetGlobalValues();
            var model = new ServiceViewModel()
            {
                ServiceGraphicDesignFirstSectionFirstParagraph = websiteContent.ServiceGraphicDesignFirstSectionFirstParagraph,
                ServiceGraphicDesignFirstSectionImageName = websiteContent.ServiceGraphicDesignFirstSectionImageName,
                ServiceGraphicDesignFirstSectionImagePath = websiteContent.ServiceGraphicDesignFirstSectionImagePath,
                ServiceGraphicDesignFirstSectionSecondParagraph = websiteContent.ServiceGraphicDesignFirstSectionSecondParagraph,
                ServiceGraphicDesignMainImageName = websiteContent.ServiceGraphicDesignMainImageName,
                ServiceGraphicDesignMainImagePath = websiteContent.ServiceGraphicDesignMainImagePath,
                ServiceGraphicDesignFirstSectionTitle = websiteContent.ServiceGraphicDesignFirstSectionTitle,
                ServiceGraphicDesignSubtitle = websiteContent.ServiceGraphicDesignSubtitle,
                ServiceGraphicDesignTitle = websiteContent.ServiceGraphicDesignTitle,
                ContactFormDetails = new ContactViewModel()
                {
                    WebsiteEmailAddress = gs.EmailAddress,
                    FacebookLink = gs.FacebookLink,
                    GooglePlusLink = gs.GooglePlusLink,
                    InstagramLink = gs.InstagramLink,
                    LinkedinLink = gs.LinkedinLink,
                    PinterestLink = gs.PinterestLink,
                    TwitterLink = gs.TwitterLink,
                    YoutubeLink = gs.YoutubeLink
                }
            };

            ViewBag.TopImage = websiteContent.ServiceGraphicDesignMainImagePath + "/" + websiteContent.ServiceGraphicDesignMainImageName;
            ViewBag.Headline = websiteContent.ServiceGraphicDesignTitle;
            ViewBag.SubHeadline = websiteContent.ServiceGraphicDesignSubtitle;

            return View(model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult SubmitForm(ServiceViewModel model)
        {
            var lead = new Lead()
            {
                BusinessName = model.ContactFormDetails.BusinessName,
                EmailAddress = model.ContactFormDetails.EmailAddress,
                FirstName = model.ContactFormDetails.FirstName,
                LastName = model.ContactFormDetails.LastName,
                LeadSource = model.ContactFormDetails.LeadSource,
                Location = model.ContactFormDetails.Location,
                Note = model.ContactFormDetails.Note,
                PhoneNumber = model.ContactFormDetails.PhoneNumber,
                Website = model.ContactFormDetails.Website,
                Date = DateTime.Now
            };

            _unitOfWork.Lead.AddNewLead(lead);
            _unitOfWork.Complete();

            string imgHtml = "<img src='/Content/img/thank-you.jpg' alt='Thank you!' class='w-100 thank-you-img' />";

            return Content(imgHtml, "text/html");
        }
    }
}