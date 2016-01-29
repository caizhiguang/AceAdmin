using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AceAdmin.Web.Controllers
{
    public class MorePagesController : Controller
    {
        // GET: MorePage
        public ActionResult ProfilePage()
        {
            return View("Profile");
        }

        public ActionResult Inbox()
        {
            return View();
        }

        public ActionResult Pricing()
        {
            return View();
        }
        public ActionResult Invoice()
        {
            return View();
        }

        public ActionResult Timeline()
        {
            return View();
        }

        public ActionResult EmailTemplates()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}