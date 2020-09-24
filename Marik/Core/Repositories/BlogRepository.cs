using Marik.Core.Interfaces;
using Marik.DAL;
using Marik.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.IO;

namespace Marik.Core.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly ApplicationDbContext _ctx;

        public BlogRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Blog> GetAllBlogs()
        {
            return _ctx.Blogs.OrderByDescending(b => b.Date).AsEnumerable();
        }

        public IEnumerable<Blog> GetActiveBlogs()
        {
            return _ctx.Blogs.Include(b => b.BlogType).Where(b => b.isActive == true && b.isDeleted == false).OrderByDescending(b => b.Date).AsEnumerable();
        }

        public IEnumerable<Blog> GetInactiveBlogs()
        {
            return _ctx.Blogs.Where(b => b.isActive == false && b.isDeleted == false).OrderByDescending(b => b.Date).AsEnumerable();
        }

        public Blog GetBlogById(int id)
        {
            return _ctx.Blogs.Include(b => b.BlogType).Where(b => b.Id == id).FirstOrDefault();
        }

        public void AddBlog(Blog blog)
        {
            _ctx.Blogs.Add(blog);
        }

        public void RemoveBlog(int id)
        {
            string imagesFolder = _ctx.Blogs.Where(b => b.Id == id).FirstOrDefault().ImagePath;

            var blog = _ctx.Blogs.Find(id);
            string mappedPath = HttpContext.Current.Server.MapPath(@"~/" + imagesFolder);

            Directory.Delete(mappedPath, true);

            _ctx.Blogs.Remove(blog);
        }
    }
}