using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marik.Core.ViewModels
{
    public class ViewModelBase
    {
        public string EmailAddress { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string Address { get; set; }
        public string FacebookLink { get; set; }
        public string InstagramLink { get; set; }
        public string TwitterLink { get; set; }
        public string PinterestLink { get; set; }
        public string GooglePlusLink { get; set; }
        public string LinkedinLink { get; set; }
        public string YoutubeLink { get; set; }
    }
}