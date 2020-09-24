using Marik.Core.Interfaces;
using Marik.Core.Models;
using Marik.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marik.Core.Repositories
{
    public class WebsiteContentRepository : IWebsiteContentRepository
    {
        private readonly ApplicationDbContext _ctx;

        public WebsiteContentRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public WebsiteContent GetWebsiteContent()
        {
            return _ctx.WebsiteContent.FirstOrDefault();
        }
    }
}