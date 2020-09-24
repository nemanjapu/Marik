using Marik.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marik.Areas.Admin.ViewModels
{
    public class AddProductViewModel
    {
        [Required]
        [Display(Name = "Product name:")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Product subtitle:")]
        public string Subtitle { get; set; }
        [Required]
        [AllowHtml]
        public string Text { get; set; }
        public virtual ICollection<ProductImages> Images { get; set; }
        public bool isActive { get; set; }
        [DataType(DataType.Currency)]
        [Required]
        public decimal Price { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        [Required]
        [DataType(DataType.Upload)]
        public HttpPostedFileBase document { get; set; }
        public string DocumentName { get; set; }
    }
}