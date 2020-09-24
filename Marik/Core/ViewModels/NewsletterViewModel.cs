using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Marik.Core.ViewModels
{
    public class NewsletterViewModel
    {
        [Required(ErrorMessage = "Email is mandatory field.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "First name is mandatory field.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is mandatory field.")]
        public string LastName { get; set; }
    }
}