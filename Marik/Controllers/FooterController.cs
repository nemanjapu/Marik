using Marik.Core;
using Marik.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marik.Controllers
{
    public class FooterController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public FooterController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActionResult Index()
        {
            var gs = _unitOfWork.GlobalSettings.GetGlobalValues();

            var model = new FooterViewModel()
            {
                EmailAddress = gs.EmailAddress,
                FacebookLink = gs.FacebookLink,
                GooglePlusLink = gs.GooglePlusLink,
                InstagramLink = gs.InstagramLink,
                LinkedinLink = gs.LinkedinLink,
                PinterestLink = gs.PinterestLink,
                TwitterLink = gs.TwitterLink,
                YoutubeLink = gs.YoutubeLink
            };

            return PartialView("_FooterPartial", model);
        }
    }
}