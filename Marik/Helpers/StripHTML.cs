using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Marik.Helpers
{
    public class StripHTML
    {
        public static string StripHtml(string blogText)
        {
            string noHTML = Regex.Replace(blogText, @"<[^>]+>|&nbsp;", " ").Trim();
            string noHTMLNormalised = Regex.Replace(noHTML, @"\s{2,}", " ");

            if (noHTMLNormalised.Length > 300)
            {
                return noHTMLNormalised.Substring(0, 300);
            }

            return noHTMLNormalised;
        }
    }
}