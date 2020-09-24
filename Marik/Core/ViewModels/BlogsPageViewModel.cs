using PagedList;
using System.Web;
using System.Web.Mvc;

namespace Marik.Core.ViewModels
{
    public class BlogsPageViewModel
    {
        public IPagedList<BlogListViewModel> BlogList { get; set; }

        [AllowHtml]
        public string BlogsTitle { get; set; }
        [AllowHtml]
        public string BlogsSubtitle { get; set; }
        public HttpPostedFileBase BlogsMainImageFile { get; set; }
        public string BlogsMainImageName { get; set; }
        public string BlogsMainImagePath { get; set; }
    }
}