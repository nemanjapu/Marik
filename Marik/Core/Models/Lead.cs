using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marik.Core.Models
{
    public class Lead
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Location { get; set; }
        public string BusinessName { get; set; }
        public string Website { get; set; }
        public string Note { get; set; }
        public string LeadSource { get; set; }
        public DateTime Date { get; set; }
    }
}