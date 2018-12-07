using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Week7Assessment6.Models;

namespace Week7Assessment6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Welcome!";
            return View();
        }

        public ActionResult BAD()
        {
            ViewBag.Title = "Bring a Dish";

            return View();
        }

        public ActionResult RSVP()
        {
            ViewBag.Title = "RSVP";

            return View();
        }

       
        public ActionResult RSVPConfirmation(Guest guest)
        {
            ViewBag.Title = "RSVP Confirmation";

            return View(guest);
        }

     
        public ActionResult BADConfirmation(Dish dish)
        {
            ViewBag.Title = "Bring a Dish Confirmation";

            return View(dish);
        }

        
        public ActionResult RSVPNotAttending(Guest guest)
        {
            ViewBag.Title = "RSVPNotAttending";

            return View(guest);
        }
    }
}