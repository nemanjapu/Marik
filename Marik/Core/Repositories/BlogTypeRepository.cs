using Marik.Core.Interfaces;
using Marik.Core.Models;
using Marik.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marik.Core.Repositories
{
    public class BlogTypeRepository : IBlogTypeRepository
    {
        private readonly ApplicationDbContext _ctx;

        public BlogTypeRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public void AddBlogType(BlogType type)
        {
            _ctx.BlogTypes.Add(type);
        }

        public BlogType GetBlogType(int id)
        {
            return _ctx.BlogTypes.Find(id);
        }

        public IQueryable<BlogType> GetBlogTypes()
        {
            return _ctx.BlogTypes;
        }

        public bool RemoveBlogType(int id)
        {
            if (_ctx.Blogs.Any(l => l.BlogTypeId == id))
            {
                return false;
            }

            _ctx.BlogTypes.Remove(GetBlogType(id));
            return true;
        }
    }
}