using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marik.Core.ViewModels
{
    public class BlogListViewModel
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public string BlogType { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
    }
}