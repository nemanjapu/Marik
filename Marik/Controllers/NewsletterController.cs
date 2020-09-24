using MailChimp.Net;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;
using Marik.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marik.Controllers
{
    public class NewsletterController : Controller
    {
        public ActionResult NewsletterForm()
        {
            var model = new NewsletterViewModel();

            return PartialView("_NewsletterFormPartial", model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async System.Threading.Tasks.Task<ActionResult> NewsletterSignUp(NewsletterViewModel model)
        {
            IMailChimpManager mailChimpManager = new MailChimpManager("7c9f307bfe083c6152698211349bf9a8-us20");
            var listId = "a0df8aa760";

            var member = new Member { EmailAddress = model.Email, StatusIfNew = Status.Subscribed };
            member.MergeFields.Add("FNAME", model.FirstName);
            member.MergeFields.Add("LNAME", model.LastName);
            await mailChimpManager.Members.AddOrUpdateAsync(listId, member);

            return Content("<h4 class='m-0'>Thank you for your subscription!</h4>", "text/html");
        }
    }
}