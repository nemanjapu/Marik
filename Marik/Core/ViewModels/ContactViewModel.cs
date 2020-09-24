using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Marik.Core.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Location { get; set; }
        public string BusinessName { get; set; }
        public string Website { get; set; }
        public string Note { get; set; }

        public string LeadSource { get; set; }

        public string WebsiteEmailAddress { get; set; }
        public string FacebookLink { get; set; }
        public string InstagramLink { get; set; }
        public string TwitterLink { get; set; }
        public string PinterestLink { get; set; }
        public string GooglePlusLink { get; set; }
        public string LinkedinLink { get; set; }
        public string YoutubeLink { get; set; }

        public string ContactTitle { get; set; }
        public string ContactSubtitle { get; set; }
        public string ContactMainImageName { get; set; }
        public string ContactMainImagePath { get; set; }
        public string ContactFirstSectionTitle { get; set; }
        public string ContactFirstSectionFirstParagraph { get; set; }
        public string ContactFirstSectionSignature { get; set; }
    }
}