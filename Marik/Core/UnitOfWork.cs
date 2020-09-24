using Marik.Core.Interfaces;
using Marik.Core.Repositories;
using Marik.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marik.Core
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _ctx;

        public IBlogRepository Blog { get; private set; }
        public IProductRepository Product { get; private set; }
        public IProductImagesRepository ProductImage { get; private set; }
        public IGlobalSettingsRepository GlobalSettings { get; private set; }
        public IBlogTypeRepository BlogTypes { get; private set; }
        public IClientReviewsRepository ClientReviews { get; private set; }
        public ILeadRepository Lead { get; private set; }
        public IWebsiteContentRepository WebsiteContent { get; private set; }

        public UnitOfWork(ApplicationDbContext ctx)
        {
            _ctx = ctx;
            Blog = new BlogRepository(_ctx);
            Product = new ProductRepository(_ctx);
            ProductImage = new ProductImagesRepository(_ctx);
            GlobalSettings = new GlobalValuesRepository(_ctx);
            BlogTypes = new BlogTypeRepository(_ctx);
            ClientReviews = new ClientReviewsRepository(_ctx);
            Lead = new LeadRepository(_ctx);
            WebsiteContent = new WebsiteContentRepository(_ctx);
        }

        public void Complete()
        {
            _ctx.SaveChanges();
        }
    }
}