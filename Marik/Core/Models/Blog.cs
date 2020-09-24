using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marik.Core.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required]
        public string Caption { get; set; }
        [Required]
        [AllowHtml]
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public string ImageName { get; set; }
        public string ImagePath { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string UserId { get; set; }
        public string Tags { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public bool isActive { get; set; }
        public bool isDeleted { get; set; }

        public BlogType BlogType { get; set; }
        public int BlogTypeId { get; set; }
    }
}