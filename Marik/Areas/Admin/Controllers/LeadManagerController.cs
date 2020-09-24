using Marik.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marik.Areas.Admin.Controllers
{
    [Authorize]
    public class LeadManagerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public LeadManagerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Admin/LeadManager
        public ActionResult Index()
        {
            var model = _unitOfWork.Lead.GetAllLeads();

            return View(model);
        }

        public ActionResult DeleteLead(int id)
        {
            _unitOfWork.Lead.DeleteLead(id);
            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }

        public ActionResult ViewLead(int id)
        {
            var model = _unitOfWork.Lead.GetLeadById(id);

            return View(model);
        }
    }
}