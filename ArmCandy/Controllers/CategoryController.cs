using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArmCandy.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index(string id = "bracelet")
        {
            Models.CategoryModel model = new Models.CategoryModel();
            using (ArmCandyEntities entities = new ArmCandyEntities())
            {
                var products = entities.Products.Where(x => x.ProductType == id);
                model.Products = products.Select(x => new Models.ProductModel
                {
                    ProductName = x.ProductName,
                    ProductType = x.ProductType,
                    ProductDescription = x.ProductDescription,
                    ProductId = x.ID,
                    ProductPrice = x.ProductPrice,
                    ImageFileName = x.ProductImage.ImageFileName


                }).ToArray();
            }

            return View(model);
            //above is th connetion to my database
        }
    }
}