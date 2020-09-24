using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marik.Core.ViewModels
{
    public class BlogDetailsViewModel
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public string Image { get; set; }
        public string Tags { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string BlogType { get; set; }
    }
}