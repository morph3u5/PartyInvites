using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index()
        {
            int h = DateTime.Now.Hour;
            ViewBag.Greetings = h < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }

         
        public ActionResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RsvpForm(GuestResponse guestResponse)
        {
            return View("Thanks",guestResponse);
        }
    }
}

