using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AceAdmin.Web.Controllers
{
    public class TablesController : Controller
    {
        // GET: Tables
        public ActionResult Table()
        {
            return View();
        }

        public ActionResult JQGrid()
        {
            return View();
        }
    }
}