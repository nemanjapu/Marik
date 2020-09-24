using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace Marik.Helpers
{
    public static class UrlCleaner
    {
        public static string CleanUrl(this UrlHelper helper, string title)
        {
            string cleanTitle = title.ToLower().Replace(" ", "-");
            //Removes invalid character like .,-_ etc
            cleanTitle = Regex.Replace(cleanTitle, @"[^a-zA-Z0-9\/_|+ -]", "");
            return cleanTitle;
        }
    }
}