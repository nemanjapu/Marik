using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marik.Areas.Admin.ViewModels
{
    public class AddClientReviewViewModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string ClientName { get; set; }
        public bool isActive { get; set; }
    }
}