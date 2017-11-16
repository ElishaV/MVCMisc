using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMiscellaneous.Controllers
{
    public class SecretController : Controller
    {
        // GET: Secret
        public ContentResult Overt()
        {
            return Content("This is not a secret....");
        }

        [Authorize]
        public ContentResult Secret ()
        {
            return Content("This is a secret....");
        }
    }
}