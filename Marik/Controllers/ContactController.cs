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
    [HandleError]
    public class ContactController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ContactController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Contact
        public ActionResult Index()
        {
            var gs = _unitOfWork.GlobalSettings.GetGlobalValues();
            var websiteContent = _unitOfWork.WebsiteContent.GetWebsiteContent();

            var model = new ContactViewModel()
            {
                WebsiteEmailAddress = gs.EmailAddress,
                FacebookLink = gs.FacebookLink,
                GooglePlusLink = gs.GooglePlusLink,
                InstagramLink = gs.InstagramLink,
                LinkedinLink = gs.LinkedinLink,
                PinterestLink = gs.PinterestLink,
                TwitterLink = gs.TwitterLink,
                YoutubeLink = gs.YoutubeLink,
                ContactFirstSectionFirstParagraph = websiteContent.ContactFirstSectionFirstParagraph,
                ContactFirstSectionSignature = websiteContent.ContactFirstSectionSignature,
                ContactFirstSectionTitle = websiteContent.ContactFirstSectionTitle,
                ContactMainImageName = websiteContent.ContactMainImageName,
                ContactMainImagePath = websiteContent.ContactMainImagePath,
                ContactSubtitle = websiteContent.ContactSubtitle,
                ContactTitle = websiteContent.ContactTitle
            };

            ViewBag.TopImage = websiteContent.ContactMainImagePath + "/" + websiteContent.ContactMainImageName;
            ViewBag.Headline = websiteContent.ContactTitle;
            ViewBag.SubHeadline = websiteContent.ContactSubtitle;

            return View(model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult SubmitForm(ContactViewModel model)
        {
            var lead = new Lead()
            {
                BusinessName = model.BusinessName,
                EmailAddress = model.EmailAddress,
                FirstName = model.FirstName,
                LastName = model.LastName,
                LeadSource = "Contact form",
                Location = model.Location,
                Note = model.Note,
                PhoneNumber = model.PhoneNumber,
                Website = model.Website,
                Date = DateTime.Now
            };

            _unitOfWork.Lead.AddNewLead(lead);
            _unitOfWork.Complete();

            string imgHtml = "<img src='/Content/img/thank-you.jpg' alt='Thank you!' class='w-100 thank-you-img' />";

            return Content(imgHtml, "text/html");
        }
    }
}