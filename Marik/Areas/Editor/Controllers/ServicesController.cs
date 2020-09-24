using Marik.Core;
using Marik.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marik.Areas.Editor.Controllers
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
            };

            ViewBag.TopImage = websiteContent.ServiceContentManagementMainImagePath + "/" + websiteContent.ServiceContentManagementMainImageName;
            ViewBag.Headline = websiteContent.ServiceContentManagementTitle;
            ViewBag.SubHeadline = websiteContent.ServiceContentManagementSubtitle;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveContentManagementContent(ServiceViewModel model)
        {
            var abContent = _unitOfWork.WebsiteContent.GetWebsiteContent();
            var HomepagePath = "/DynamicContent/Services/ContentManagement";

            abContent.ServiceContentManagementFirstSectionFirstParagraph = model.ServiceContentManagementFirstSectionFirstParagraph;
            if (model.ServiceContentManagementFirstSectionImageFile != null)
            {
                abContent.ServiceContentManagementFirstSectionImageName = model.ServiceContentManagementFirstSectionImageFile.FileName;
                abContent.ServiceContentManagementFirstSectionImagePath = HomepagePath;
                model.ServiceContentManagementFirstSectionImageFile.SaveAs(Path.Combine(Server.MapPath(HomepagePath), model.ServiceContentManagementFirstSectionImageFile.FileName));
            }
            abContent.ServiceContentManagementFirstSectionSecondParagraph = model.ServiceContentManagementFirstSectionSecondParagraph;
            if (model.ServiceContentManagementMainImageFile != null)
            {
                abContent.ServiceContentManagementMainImageName = model.ServiceContentManagementMainImageFile.FileName;
                abContent.ServiceContentManagementMainImagePath = HomepagePath;
                model.ServiceContentManagementMainImageFile.SaveAs(Path.Combine(Server.MapPath(HomepagePath), model.ServiceContentManagementMainImageFile.FileName));
            }
            abContent.ServiceContentManagementFirstSectionTitle = model.ServiceContentManagementFirstSectionTitle;
            abContent.ServiceContentManagementSubtitle = model.ServiceContentManagementSubtitle;
            abContent.ServiceContentManagementTitle = model.ServiceContentManagementTitle;

            _unitOfWork.Complete();

            return RedirectToAction("BusinessDevelopment");
        }

        public ActionResult Marketing()
        {
            var websiteContent = _unitOfWork.WebsiteContent.GetWebsiteContent();
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
            };

            ViewBag.TopImage = websiteContent.ServiceMarketingMainImagePath + "/" + websiteContent.ServiceMarketingMainImageName;
            ViewBag.Headline = websiteContent.ServiceMarketingTitle;
            ViewBag.SubHeadline = websiteContent.ServiceMarketingSubtitle;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveMarketingContent(ServiceViewModel model)
        {
            var abContent = _unitOfWork.WebsiteContent.GetWebsiteContent();
            var HomepagePath = "/DynamicContent/Services/Marketing";

            abContent.ServiceMarketingFirstSectionFirstParagraph = model.ServiceMarketingFirstSectionFirstParagraph;
            if (model.ServiceMarketingFirstSectionImageFile != null)
            {
                abContent.ServiceMarketingFirstSectionImageName = model.ServiceMarketingFirstSectionImageFile.FileName;
                abContent.ServiceMarketingFirstSectionImagePath = HomepagePath;
                model.ServiceMarketingFirstSectionImageFile.SaveAs(Path.Combine(Server.MapPath(HomepagePath), model.ServiceMarketingFirstSectionImageFile.FileName));
            }
            abContent.ServiceMarketingFirstSectionSecondParagraph = model.ServiceMarketingFirstSectionSecondParagraph;
            if (model.ServiceMarketingMainImageFile != null)
            {
                abContent.ServiceMarketingMainImageName = model.ServiceMarketingMainImageFile.FileName;
                abContent.ServiceMarketingMainImagePath = HomepagePath;
                model.ServiceMarketingMainImageFile.SaveAs(Path.Combine(Server.MapPath(HomepagePath), model.ServiceMarketingMainImageFile.FileName));
            }
            abContent.ServiceMarketingFirstSectionTitle = model.ServiceMarketingFirstSectionTitle;
            abContent.ServiceMarketingSubtitle = model.ServiceMarketingSubtitle;
            abContent.ServiceMarketingTitle = model.ServiceMarketingTitle;

            _unitOfWork.Complete();

            return RedirectToAction("Marketing");
        }

        public ActionResult WebDesign()
        {
            var websiteContent = _unitOfWork.WebsiteContent.GetWebsiteContent();
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
            };

            ViewBag.TopImage = websiteContent.ServiceWebDesignMainImagePath + "/" + websiteContent.ServiceWebDesignMainImageName;
            ViewBag.Headline = websiteContent.ServiceWebDesignTitle;
            ViewBag.SubHeadline = websiteContent.ServiceWebDesignSubtitle;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveWebDesignContent(ServiceViewModel model)
        {
            var abContent = _unitOfWork.WebsiteContent.GetWebsiteContent();
            var HomepagePath = "/DynamicContent/Services/WebDesign";

            abContent.ServiceWebDesignFirstSectionFirstParagraph = model.ServiceWebDesignFirstSectionFirstParagraph;
            if (model.ServiceWebDesignFirstSectionImageFile != null)
            {
                abContent.ServiceWebDesignFirstSectionImageName = model.ServiceWebDesignFirstSectionImageFile.FileName;
                abContent.ServiceWebDesignFirstSectionImagePath = HomepagePath;
                model.ServiceWebDesignFirstSectionImageFile.SaveAs(Path.Combine(Server.MapPath(HomepagePath), model.ServiceWebDesignFirstSectionImageFile.FileName));
            }
            abContent.ServiceWebDesignFirstSectionSecondParagraph = model.ServiceWebDesignFirstSectionSecondParagraph;
            if (model.ServiceWebDesignMainImageFile != null)
            {
                abContent.ServiceWebDesignMainImageName = model.ServiceWebDesignMainImageFile.FileName;
                abContent.ServiceWebDesignMainImagePath = HomepagePath;
                model.ServiceWebDesignMainImageFile.SaveAs(Path.Combine(Server.MapPath(HomepagePath), model.ServiceWebDesignMainImageFile.FileName));
            }
            abContent.ServiceWebDesignFirstSectionTitle = model.ServiceWebDesignFirstSectionTitle;
            abContent.ServiceWebDesignSubtitle = model.ServiceWebDesignSubtitle;
            abContent.ServiceWebDesignTitle = model.ServiceWebDesignTitle;

            _unitOfWork.Complete();

            return RedirectToAction("WebDesign");
        }

        public ActionResult SPSS()
        {
            var websiteContent = _unitOfWork.WebsiteContent.GetWebsiteContent();
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
            };

            ViewBag.TopImage = websiteContent.ServiceSPSSMainImagePath + "/" + websiteContent.ServiceSPSSMainImageName;
            ViewBag.Headline = websiteContent.ServiceSPSSTitle;
            ViewBag.SubHeadline = websiteContent.ServiceSPSSSubtitle;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveSPSSContent(ServiceViewModel model)
        {
            var abContent = _unitOfWork.WebsiteContent.GetWebsiteContent();
            var HomepagePath = "/DynamicContent/Services/SPSS";

            abContent.ServiceSPSSFirstSectionFirstParagraph = model.ServiceSPSSFirstSectionFirstParagraph;
            if (model.ServiceSPSSFirstSectionImageFile != null)
            {
                abContent.ServiceSPSSFirstSectionImageName = model.ServiceSPSSFirstSectionImageFile.FileName;
                abContent.ServiceSPSSFirstSectionImagePath = HomepagePath;
                model.ServiceSPSSFirstSectionImageFile.SaveAs(Path.Combine(Server.MapPath(HomepagePath), model.ServiceSPSSFirstSectionImageFile.FileName));
            }
            abContent.ServiceSPSSFirstSectionSecondParagraph = model.ServiceSPSSFirstSectionSecondParagraph;
            if (model.ServiceSPSSMainImageFile != null)
            {
                abContent.ServiceSPSSMainImageName = model.ServiceSPSSMainImageFile.FileName;
                abContent.ServiceSPSSMainImagePath = HomepagePath;
                model.ServiceSPSSMainImageFile.SaveAs(Path.Combine(Server.MapPath(HomepagePath), model.ServiceSPSSMainImageFile.FileName));
            }
            abContent.ServiceSPSSFirstSectionTitle = model.ServiceSPSSFirstSectionTitle;
            abContent.ServiceSPSSSubtitle = model.ServiceSPSSSubtitle;
            abContent.ServiceSPSSTitle = model.ServiceSPSSTitle;

            _unitOfWork.Complete();

            return RedirectToAction("SPSS");
        }

        public ActionResult GraphicDesign()
        {
            var websiteContent = _unitOfWork.WebsiteContent.GetWebsiteContent();
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
            };

            ViewBag.TopImage = websiteContent.ServiceGraphicDesignMainImagePath + "/" + websiteContent.ServiceGraphicDesignMainImageName;
            ViewBag.Headline = websiteContent.ServiceGraphicDesignTitle;
            ViewBag.SubHeadline = websiteContent.ServiceGraphicDesignSubtitle;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveGraphicDesignContent(ServiceViewModel model)
        {
            var abContent = _unitOfWork.WebsiteContent.GetWebsiteContent();
            var HomepagePath = "/DynamicContent/Services/GraphicDesign";

            abContent.ServiceGraphicDesignFirstSectionFirstParagraph = model.ServiceGraphicDesignFirstSectionFirstParagraph;
            if (model.ServiceGraphicDesignFirstSectionImageFile != null)
            {
                abContent.ServiceGraphicDesignFirstSectionImageName = model.ServiceGraphicDesignFirstSectionImageFile.FileName;
                abContent.ServiceGraphicDesignFirstSectionImagePath = HomepagePath;
                model.ServiceGraphicDesignFirstSectionImageFile.SaveAs(Path.Combine(Server.MapPath(HomepagePath), model.ServiceGraphicDesignFirstSectionImageFile.FileName));
            }
            abContent.ServiceGraphicDesignFirstSectionSecondParagraph = model.ServiceGraphicDesignFirstSectionSecondParagraph;
            if (model.ServiceGraphicDesignMainImageFile != null)
            {
                abContent.ServiceGraphicDesignMainImageName = model.ServiceGraphicDesignMainImageFile.FileName;
                abContent.ServiceGraphicDesignMainImagePath = HomepagePath;
                model.ServiceGraphicDesignMainImageFile.SaveAs(Path.Combine(Server.MapPath(HomepagePath), model.ServiceGraphicDesignMainImageFile.FileName));
            }
            abContent.ServiceGraphicDesignFirstSectionTitle = model.ServiceGraphicDesignFirstSectionTitle;
            abContent.ServiceGraphicDesignSubtitle = model.ServiceGraphicDesignSubtitle;
            abContent.ServiceGraphicDesignTitle = model.ServiceGraphicDesignTitle;

            _unitOfWork.Complete();

            return RedirectToAction("GraphicDesign");
        }
    }
}