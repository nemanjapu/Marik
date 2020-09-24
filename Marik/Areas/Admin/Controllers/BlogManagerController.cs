using Marik.Areas.Admin.ViewModels;
using Marik.Core;
using Marik.DAL;
using Marik.Core.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marik.Areas.Admin.Controllers
{
    [Authorize]
    public class BlogManagerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public BlogManagerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActionResult Index()
        {
            var blogs = _unitOfWork.Blog.GetActiveBlogs();

            return View(blogs);
        }

        [HttpPost]
        public string UploadImage(HttpPostedFileBase file)
        {
            var imgPath = "";
            string folderDate = DateTime.Now.ToString("yyyyMMddHHmmss");
            Directory.CreateDirectory(Server.MapPath("~/DynamicContent/BlogImages/Blog" + folderDate));
            var path = "~/DynamicContent/BlogImages/Blog" + folderDate;
            var pathToSave = "DynamicContent/BlogImages/Blog" + folderDate;

            if (file != null)
            {
                imgPath = Path.Combine(Server.MapPath(path), file.FileName);
                file.SaveAs(imgPath);
            }

            return @"/" + pathToSave + file.FileName;
        }

        public ActionResult NewBlog()
        {
            var viewModel = new BlogFormViewModel
            {
                Id = new int(),
                imageName = "/Areas/Admin/Content/images/upload-icon.png",
                BlogTypes = _unitOfWork.BlogTypes.GetBlogTypes()
            };

            return View("NewBlog", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveNewBlog(BlogFormViewModel blog)
        {
            if (blog.File != null && blog.File.ContentLength > 0)
            {
                string userId = User.Identity.GetUserId();

                string folderDate = DateTime.Now.ToString("yyyyMMddHHmmss");
                Directory.CreateDirectory(Server.MapPath("~/DynamicContent/BlogImages/Blog" + folderDate));
                var path = "~/DynamicContent/BlogImages/Blog" + folderDate;
                var pathToSave = "DynamicContent/BlogImages/Blog" + folderDate;

                var blogDB = new Blog
                {
                    Caption = blog.Caption,
                    Text = blog.Text,
                    isActive = blog.isActive,
                    MetaDescription = blog.MetaDescription,
                    MetaKeywords = blog.MetaDescription,
                    Date = DateTime.Now,
                    UserId = userId,
                    ImageName = blog.File.FileName,
                    ImagePath = pathToSave,
                    Tags = blog.Tags,
                    BlogTypeId = blog.BlogTypeId
                };
                _unitOfWork.Blog.AddBlog(blogDB);
                blog.File.SaveAs(Path.Combine(Server.MapPath(path), blog.File.FileName));
            }

            _unitOfWork.Complete();

            return RedirectToAction("Index", "BlogManager", new { area = "Admin" });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveEditedBlog(BlogFormViewModel blog)
        {
            var blogDB = _unitOfWork.Blog.GetBlogById(blog.Id);
            
            var pathToSave = blogDB.ImagePath;
            var path = "~/" + pathToSave;

            blogDB.Caption = blog.Caption;
            blogDB.Text = blog.Text;
            blogDB.isActive = blog.isActive;
            blogDB.MetaKeywords = blog.MetaKeywords;
            blogDB.MetaDescription = blog.MetaDescription;
            blogDB.Tags = blog.Tags;
            blogDB.BlogTypeId = blog.BlogTypeId;
            if (blog.File != null)
            {
                blogDB.ImageName = blog.File.FileName;
                blogDB.ImagePath = pathToSave;
                blog.File.SaveAs(Path.Combine(Server.MapPath(path), blog.File.FileName));
            }

            _unitOfWork.Complete();

            return RedirectToAction("Index", "BlogManager", new { area = "Admin" });
        }

        public ActionResult EditBlog(int id)
        {
            var blog = _unitOfWork.Blog.GetBlogById(id);

            var model = new BlogFormViewModel
            {
                Caption = blog.Caption,
                Text = blog.Text,
                BlogTypeId = blog.BlogTypeId,
                Tags = blog.Tags,
                MetaDescription = blog.MetaDescription,
                MetaKeywords = blog.MetaKeywords,
                isActive = blog.isActive,
                imageName = blog.ImagePath + "/" + blog.ImageName,
                BlogTypes = _unitOfWork.BlogTypes.GetBlogTypes()
            };

            return View("EditBlog", model);
        }

        public ActionResult InactiveBlogs()
        {
            var blogs = _unitOfWork.Blog.GetInactiveBlogs();

            return View(blogs);
        }


        public ActionResult ToggleActive(int id)
        {
            Blog blog = _unitOfWork.Blog.GetBlogById(id);

            string action = "";

            if (blog.isActive == true)
            {
                blog.isActive = false;
                action = "Index";
            }
            else
            {
                blog.isActive = true;
                action = "InactiveBlogs";
            }

            _unitOfWork.Complete();

            return RedirectToAction(action, "BlogManager");
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult DeleteBlog(int id)
        {
            _unitOfWork.Blog.RemoveBlog(id);
            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }
    }
}