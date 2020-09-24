using Marik.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marik.Areas.Admin.ViewModels
{
    public class BlogFormViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Caption { get; set; }
        [Required]
        [AllowHtml]
        public string Text { get; set; }
        public string Tags { get; set; }
        public DateTime DatePublished { get; set; }
        public ApplicationUser User { get; set; }
        public int UserId { get; set; }
        public HttpPostedFileBase File { get; set; }
        public string imageName { get; set; }
        public bool isActive { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }

        public int BlogTypeId { get; set; }
        public IEnumerable<BlogType> BlogTypes { get; set; }
    }
}