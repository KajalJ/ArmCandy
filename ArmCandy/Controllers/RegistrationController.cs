using ArmCandy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;

namespace ArmCandy.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            RegistrationModel model = new RegistrationModel();
            return View();
        }

        //POST: Registration
        [HttpPost]
        public ActionResult Index(RegistrationModel model)
        {
            if (ModelState.IsValid)
            {
                if (WebSecurity.UserExists(model.Email))
                {
                    ModelState.AddModelError("Email", "This Username is already registered");
                }
                else
                {
                    WebSecurity.CreateUserAndAccount(model.Email, model.Password);
                    return RedirectToAction("index", "Home");
                }

            }
            return View(model);
        }
    }
    
}