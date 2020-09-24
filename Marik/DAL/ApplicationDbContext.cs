using Marik.Core.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Marik.DAL
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Blog> Blogs { set; get; }
        public DbSet<BlogType> BlogTypes { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<ProductImages> ProductImages { set; get; }
        public DbSet<GlobalValues> GlobalValues { set; get; }
        public DbSet<ClientReview> ClientReviews { set; get; }
        public DbSet<Lead> Leads { set; get; }
        public DbSet<WebsiteContent> WebsiteContent { set; get; }
    }
}