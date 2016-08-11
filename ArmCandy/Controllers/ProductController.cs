using ArmCandy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArmCandy.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index(int? ID)
        {
            ArmCandy.Models.ProductModel product = new ArmCandy.Models.ProductModel();
            using (ArmCandyEntities entities = new ArmCandyEntities())
            {
                var databaseRecord = entities.Products.First(x => x.ID == ID);
                product.ImageFileName = entities.ProductImages.FirstOrDefault(x => x.ProductID == ID).ImageFileName;
                product.ProductId = databaseRecord.ID;
                product.ProductName = databaseRecord.ProductName;
                product.ProductDescription = databaseRecord.ProductDescription;
                //product.ProductPrice = databaseRecord.ProductPrice;
            }
            

            return View(product);
        }


        [HttpPost]
        public ActionResult Index(ProductModel p)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}