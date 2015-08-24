using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace list_manager_website.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult LogIn()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult LogOff()
        {
            return View();
        }
    }
}