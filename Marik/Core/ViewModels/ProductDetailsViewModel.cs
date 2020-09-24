using Marik.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marik.Core.ViewModels
{
    public class ProductDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subtitle { get; set; }
        public string Text { get; set; }
        public IEnumerable<ProductImages> Images { get; set; }
        public decimal Price { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string DocumentName { get; set; }
        public string DocumentPath { get; set; }
    }
}