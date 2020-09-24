using System.Web.Http;
using Unity;
using Unity.WebApi;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Web.Mvc;
using Unity.Injection;
using Unity.Lifetime;
using Microsoft.Owin.Security;
using System.Web;
using Marik.Controllers;
using Marik.DAL;
using Marik.Core.Models;
using Marik.Core;
using Marik.Core.Interfaces;
using Marik.Core.Repositories;

namespace Marik
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<AccountController>(new InjectionConstructor());
            container.RegisterType<DbContext, ApplicationDbContext>(new HierarchicalLifetimeManager());
            container.RegisterType<UserManager<ApplicationUser>>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>(new HierarchicalLifetimeManager());
            container.RegisterType<IAuthenticationManager>(new InjectionFactory(o => System.Web.HttpContext.Current.GetOwinContext().Authentication));

            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<IBlogRepository, BlogRepository>();
            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IProductImagesRepository, ProductImagesRepository>();
            container.RegisterType<IGlobalSettingsRepository, GlobalValuesRepository>();
            container.RegisterType<IBlogTypeRepository, BlogTypeRepository>();
            container.RegisterType<IClientReviewsRepository, ClientReviewsRepository>();
            container.RegisterType<ILeadRepository, LeadRepository>();
            container.RegisterType<IWebsiteContentRepository, WebsiteContentRepository>();

            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}