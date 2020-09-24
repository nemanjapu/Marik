using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marik.Core.Models
{
    public class ClientReview
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string ClientName { get; set; }
        public bool isActive { get; set; }
    }
}