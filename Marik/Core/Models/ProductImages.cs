using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marik.Core.Models
{
    public class ProductImages
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Extension { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int SortOrder { get; set; }
        public string FileNameNoExt { get; set; }
        public string FilePath { get; set; }
        public int NumberOfDownloads { get; set; }
    }
}