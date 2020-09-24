using Marik.Core;
using Marik.Core.ViewModels;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Marik.Helpers;

namespace Marik.Controllers
{
    [HandleError]
    public class BlogsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public BlogsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActionResult Index(int? page)
        {
            int pageSize = 6;
            int pageNumber = (page ?? 1);

            var websiteContent = _unitOfWork.WebsiteContent.GetWebsiteContent();

            var model = new BlogsPageViewModel()
            {
                BlogList = _unitOfWork.Blog.GetActiveBlogs().Select(b => new BlogListViewModel()
                {
                    Id = b.Id,
                    Caption = b.Caption,
                    BlogType = b.BlogType.Name,
                    Image = b.ImagePath + "/" + b.ImageName,
                    Date = b.Date,
                    Text = StripHTML.StripHtml(b.Text)
                }).OrderBy(b => b.Date).ThenBy(b => b.Id).ToPagedList(pageNumber, pageSize),
                BlogsMainImageName = websiteContent.BlogsMainImageName,
                BlogsMainImagePath = websiteContent.BlogsMainImagePath,
                BlogsSubtitle = websiteContent.BlogsSubtitle,
                BlogsTitle = websiteContent.BlogsTitle
            };

            ViewBag.TopImage = websiteContent.BlogsMainImagePath + "/" + websiteContent.BlogsMainImageName;
            ViewBag.Headline = websiteContent.BlogsTitle;
            ViewBag.SubHeadline = websiteContent.BlogsSubtitle;

            return View(model);
        }

        [Route("blogs/{id}/{Name}")]
        public ActionResult Blog(int id)
        {
            var blog = _unitOfWork.Blog.GetBlogById(id);

            var model = new BlogDetailsViewModel()
            {
                BlogType = blog.BlogType.Name,
                Caption = blog.Caption,
                Date = blog.Date,
                Id = blog.Id,
                Image = blog.ImagePath + "/" + blog.ImageName,
                MetaDescription = blog.MetaDescription,
                MetaKeywords = blog.MetaKeywords,
                Tags = blog.Tags,
                Text = blog.Text
            };

            ViewBag.TopImage = "/" + model.Image;
            ViewBag.Headline = model.BlogType;

            return View(model);
        }
    }
}