using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Marik.Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subtitle { get; set; }
        public string Text { get; set; }
        public DateTime DatePublished { get; set; }
        public virtual ICollection<ProductImages> Images { get; set; }
        public bool isActive { get; set; }
        public decimal Price { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string DocumentName { get; set; }
        public string DocumentPath { get; set; }
        public int NumberOfDownloads { get; set; }
    }
}