using Marik.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marik.Core.Interfaces
{
    public interface IBlogRepository
    {
        IEnumerable<Blog> GetAllBlogs();
        IEnumerable<Blog> GetActiveBlogs();
        IEnumerable<Blog> GetInactiveBlogs();
        Blog GetBlogById(int id);
        void AddBlog(Blog blog);
        void RemoveBlog(int id);
    }
}
