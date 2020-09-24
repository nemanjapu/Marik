using Marik.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marik.Core.Interfaces
{
    public interface IBlogTypeRepository
    {
        void AddBlogType(BlogType type);
        BlogType GetBlogType(int id);
        IQueryable<BlogType> GetBlogTypes();
        bool RemoveBlogType(int id);
    }
}
