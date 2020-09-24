using Marik.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marik.Areas.Admin.ViewModels
{
    public class DashboardViewModel
    {
        public int NumberOfProduts { get; set; }
        public int NumberOfBlogs { get; set; }
        public int NumberOfNewsletterSubscribers { get; set; }
        public int NumberOfContacts { get; set; }
        public Product MostDownloadedProduct { get; set; }
        public List<Lead> LatestContacts { get; set; }
        public List<Product> LatestProducts { get; set; }
    }
}