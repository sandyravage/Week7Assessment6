using Assessment6Week7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assessment6Week7.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RSVPConfirmation(ApplicationUser model)
        {
            return View(model);
        }

        public ActionResult RSVPNotAttending(ApplicationUser model)
        {
            return View(model);
        }
    }
}