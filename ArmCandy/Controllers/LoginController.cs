using ArmCandy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebMatrix.WebData;

namespace ArmCandy.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            LoginModel model = new LoginModel();
            return View();
        }
        //POST: Login
        [HttpPost]
        public ActionResult Index(LoginModel model, string returnUrl = "/")
        {
            if (ModelState.IsValid)
            {
                if (WebSecurity.Login(model.Email, model.Password, true))
                {
                    //User is logged in
                    FormsAuthentication.SetAuthCookie(model.Email, true);
                    return Redirect(returnUrl);
                }
                else
                {
                    ModelState.AddModelError("Email", "Username and/or Password are incorrect");
                }
            }
            return View(model);
        }

        public ActionResult Logout()
        {
            if (User.Identity.IsAuthenticated)
            {
                FormsAuthentication.SignOut();
            }
            return RedirectToAction("Index", "Home");
        }
    }
}