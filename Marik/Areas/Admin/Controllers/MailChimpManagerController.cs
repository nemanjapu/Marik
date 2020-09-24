using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using MailChimp.Net;
using MailChimp.Net.Core;

namespace Marik.Areas.Admin.Controllers
{
    [Authorize]
    public class MailChimpManagerController : Controller
    {
        private static MailChimpManager mcManager = new MailChimpManager("7c9f307bfe083c6152698211349bf9a8-us20");

        public async Task<ActionResult> Index()
        {
            try
            {
                var model = await mcManager.Members.GetAllAsync("a0df8aa760").ConfigureAwait(false);

                return View(model);
            }
            catch(MailChimpException mce)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadGateway, mce.Message);
            }
            catch(Exception ex)
            {
                return new HttpStatusCodeResult(HttpStatusCode.ServiceUnavailable, ex.Message);
            }
        }
    }
}