using Marik.Core;
using Marik.Core.Models;
using Marik.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;
using System.Xml.Linq;

namespace Marik.Controllers
{
    [HandleError]
    [SessionState(SessionStateBehavior.Disabled)]
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #region Sitemap

        public class SitemapNode
        {
            public SitemapFrequency? Frequency { get; set; }
            public DateTime? LastModified { get; set; }
            public double? Priority { get; set; }
            public string Url { get; set; }
        }

        public enum SitemapFrequency
        {
            Never,
            Yearly,
            Monthly,
            Weekly,
            Daily,
            Hourly,
            Always
        }

        public IReadOnlyCollection<SitemapNode> GetSitemapNodes(UrlHelper urlHelper)
        {
            List<SitemapNode> nodes = new List<SitemapNode>();

            nodes.Add(
                new SitemapNode()
                {
                    Url = "http://www.bymarik.com",
                    Priority = 1,
                    Frequency = SitemapFrequency.Daily
                });
            nodes.Add(
               new SitemapNode()
               {
                   Url = "http://www.bymarik.com/products",
                   Priority = .8,
                   Frequency = SitemapFrequency.Daily
               });
            nodes.Add(
               new SitemapNode()
               {
                   Url = "http://www.bymarik.com/about",
                   Priority = .5,
                   Frequency = SitemapFrequency.Monthly
               });
            nodes.Add(
               new SitemapNode()
               {
                   Url = "http://www.bymarik.com/blogs",
                   Priority = .5,
                   Frequency = SitemapFrequency.Daily
               });
            nodes.Add(
              new SitemapNode()
              {
                  Url = "http://www.bymarik.com/contact",
                  Priority = .5,
                  Frequency = SitemapFrequency.Monthly
              });
            nodes.Add(
               new SitemapNode()
               {
                   Url = "http://www.bymarik.com/services/businessdevelopment",
                   Priority = .5,
                   Frequency = SitemapFrequency.Daily
               });
            nodes.Add(
               new SitemapNode()
               {
                   Url = "http://www.bymarik.com/services/marketing",
                   Priority = .5,
                   Frequency = SitemapFrequency.Daily
               });
            nodes.Add(
               new SitemapNode()
               {
                   Url = "http://www.bymarik.com/services/webdesign",
                   Priority = .5,
                   Frequency = SitemapFrequency.Daily
               });
            nodes.Add(
               new SitemapNode()
               {
                   Url = "http://www.bymarik.com/services/spss",
                   Priority = .5,
                   Frequency = SitemapFrequency.Daily
               });
            nodes.Add(
               new SitemapNode()
               {
                   Url = "http://www.bymarik.com/services/graphicdesign",
                   Priority = .5,
                   Frequency = SitemapFrequency.Daily
               });
            var products = _unitOfWork.Product.GetActiveProducts().Select(l => new
            {
                ID = l.Id,
                name = Helpers.UrlCleaner.CleanUrl(null, l.Name)
            }).ToList();
            foreach (var item in products)
            {
                nodes.Add(
                   new SitemapNode()
                   {
                       Url = "http://www.bymarik.com/products/" + item.ID + "/" + item.name,
                       Frequency = SitemapFrequency.Weekly,
                       Priority = .8
                   });
            }

            var blogs = _unitOfWork.Blog.GetActiveBlogs().Select(l => new
            {
                ID = l.Id,
                caption = Helpers.UrlCleaner.CleanUrl(null, l.Caption)
            }).ToList();
            foreach (var item in blogs)
            {
                nodes.Add(
                   new SitemapNode()
                   {
                       Url = "http://www.bymarik.com/blogs/" + item.ID + "/" + item.caption,
                       Frequency = SitemapFrequency.Weekly,
                       Priority = .5
                   });
            }

            return nodes;
        }

        public string GetSitemapDocument(IEnumerable<SitemapNode> sitemapNodes)
        {
            XNamespace xmlns = "http://www.sitemaps.org/schemas/sitemap/0.9";
            XElement root = new XElement(xmlns + "urlset");

            foreach (SitemapNode sitemapNode in sitemapNodes)
            {
                XElement urlElement = new XElement(
                    xmlns + "url",
                    new XElement(xmlns + "loc", Uri.EscapeUriString(sitemapNode.Url)),
                    sitemapNode.LastModified == null ? null : new XElement(
                        xmlns + "lastmod",
                        sitemapNode.LastModified.Value.ToLocalTime().ToString("yyyy-MM-ddTHH:mm:sszzz")),
                    sitemapNode.Frequency == null ? null : new XElement(
                        xmlns + "changefreq",
                        sitemapNode.Frequency.Value.ToString().ToLowerInvariant()),
                    sitemapNode.Priority == null ? null : new XElement(
                        xmlns + "priority",
                        sitemapNode.Priority.Value.ToString("F1", CultureInfo.InvariantCulture)));
                root.Add(urlElement);
            }

            XDocument document = new XDocument(root);
            return document.ToString();
        }

        public ActionResult SitemapXml()
        {
            var sitemapNodes = GetSitemapNodes(this.Url);
            string xml = GetSitemapDocument(sitemapNodes);
            return this.Content(xml, "xml", Encoding.UTF8);
        }

        #endregion

        //[OutputCache(Location = System.Web.UI.OutputCacheLocation.Server, Duration = 86400, VaryByParam = "id")]
        //public ActionResult Index()
        //{
        //    var model = new Lead();

        //    return View(model);
        //}

        [ValidateAntiForgeryToken]
        [HttpPost]
        public string SubmitEmail(Lead model)
        {
            model.LeadSource = "Splash Page";
            model.Date = DateTime.Now;
            _unitOfWork.Lead.AddNewLead(model);
            _unitOfWork.Complete();

            string HostMail = "postmaster@struix.co";
            string HostPassword = "StruiXTeaM12#$";
            string subject = "New subscription on bymarik.com";
            string body = "Email Address: " + model.EmailAddress;
            SmtpClient client = new SmtpClient
            {
                Host = "mail.struix.co",
                Port = 8889,
                EnableSsl = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new System.Net.NetworkCredential(HostMail, HostPassword),
                Timeout = 10000
            };

            MailMessage mm = new MailMessage(HostMail, "vahida@bymarik.com", subject, body);
            //MailMessage mm = new MailMessage(HostMail, "nemanja.pu@gmail.com", subject, body);
            mm.IsBodyHtml = true;
            client.Send(mm);

            string message = "Thank You! We will get back to you as soon as posible.";

            return message;
        }

        public ActionResult Index()
        {
            var hpContent = _unitOfWork.WebsiteContent.GetWebsiteContent();
            var model = new HomePageViewModel()
            {
                Reviews = _unitOfWork.ClientReviews.GetActiveReviews().Select(r => new ReviewsViewModel()
                {
                    ClientName = r.ClientName,
                    Text = r.Text
                }),
                HomepageFirstSectionFirstParagraph = hpContent.HomepageFirstSectionFirstParagraph,
                HomepageFirstSectionImageName = hpContent.HomepageFirstSectionImageName,
                HomepageFirstSectionImagePath = hpContent.HomepageFirstSectionImagePath,
                HomepageFirstSectionSecondParagraph = hpContent.HomepageFirstSectionSecondParagraph,
                HomepageFirstSectionTitle = hpContent.HomepageFirstSectionTitle,
                HomepageMainImageName = hpContent.HomepageMainImageName,
                HomepageMainImagePath = hpContent.HomepageMainImagePath,
                HomepageReviewsText = hpContent.HomepageReviewsText,
                HomepageSecondSectionFirstParagraph = hpContent.HomepageSecondSectionFirstParagraph,
                HomepageSecondSectionImageName = hpContent.HomepageSecondSectionImageName,
                HomepageSecondSectionImagePath = hpContent.HomepageSecondSectionImagePath,
                HomepageSecondSectionSecondParagraph = hpContent.HomepageSecondSectionSecondParagraph,
                HomepageSecondSectionTitle = hpContent.HomepageSecondSectionTitle,
                HomepageService1ImageName = hpContent.HomepageService1ImageName,
                HomepageService1ImagePath = hpContent.HomepageService1ImagePath,
                HomepageService2ImageName = hpContent.HomepageService2ImageName,
                HomepageService2ImagePath = hpContent.HomepageService2ImagePath,
                HomepageService3ImageName = hpContent.HomepageService3ImageName,
                HomepageService3ImagePath = hpContent.HomepageService3ImagePath,
                HomepageService4ImageName = hpContent.HomepageService4ImageName,
                HomepageService4ImagePath = hpContent.HomepageService4ImagePath,
                HomepageService5ImageName = hpContent.HomepageService5ImageName,
                HomepageService5ImagePath = hpContent.HomepageService5ImagePath,
                HomepageServicesTitle = hpContent.HomepageServicesTitle,
                HomepageSubtitle = hpContent.HomepageSubtitle,
                HomepageTitle = hpContent.HomepageTitle
            };

            ViewBag.TopImage = hpContent.HomepageMainImagePath + "/" + hpContent.HomepageMainImageName;
            ViewBag.Headline = hpContent.HomepageTitle;
            ViewBag.SubHeadline = hpContent.HomepageSubtitle;

            return View(model);
        }
    }
}