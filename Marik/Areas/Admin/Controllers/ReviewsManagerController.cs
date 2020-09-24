using Marik.Areas.Admin.ViewModels;
using Marik.Core;
using Marik.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marik.Areas.Admin.Controllers
{
    [Authorize]
    public class ReviewsManagerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReviewsManagerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Admin/ReviewsManager
        public ActionResult Index()
        {
            var model = _unitOfWork.ClientReviews.GetActiveReviews().ToList();

            return View(model);
        }

        public ActionResult InactiveReviews()
        {
            var model = _unitOfWork.ClientReviews.GetInactiveReviews().ToList();

            return View(model);
        }

        public ActionResult NewReview()
        {
            var model = new AddClientReviewViewModel();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveNewReview(AddClientReviewViewModel model)
        {
            var reviewDb = new ClientReview()
            {
                ClientName = model.ClientName,
                isActive = model.isActive,
                Text = model.Text
            };

            _unitOfWork.ClientReviews.AddReview(reviewDb);
            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }

        public ActionResult EditReview(int id)
        {
            var reviewDb = _unitOfWork.ClientReviews.GetReviewById(id);

            var model = new AddClientReviewViewModel()
            {
                Id = reviewDb.Id,
                Text = reviewDb.Text,
                isActive = reviewDb.isActive,
                ClientName = reviewDb.ClientName
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveEditedReview(AddClientReviewViewModel model)
        {
            var reviewDb = _unitOfWork.ClientReviews.GetReviewById(model.Id);

            reviewDb.ClientName = model.ClientName;
            reviewDb.isActive = model.isActive;
            reviewDb.Text = model.Text;

            _unitOfWork.Complete();

            return RedirectToAction("Index"); ;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteReview(int id)
        {
            _unitOfWork.ClientReviews.RemoveReview(id);
            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }
    }
}