﻿using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class AccountController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (model.UserName == "Cash" && model.Password == "1234")
            {
                return RedirectToAction("Index", "Account");
            }

            return View();
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}