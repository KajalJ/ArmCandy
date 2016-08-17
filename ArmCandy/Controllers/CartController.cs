using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArmCandy.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            ArmCandy.Models.CartModel Shoppingcart = new ArmCandy.Models.CartModel();


            return View(Shoppingcart);
        }

        public ActionResult Checkout()
        {
            ArmCandy.Models.CartModel Shoppingcart = new ArmCandy.Models.CartModel();


            return View(Shoppingcart);
        }
    }
}