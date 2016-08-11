using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArmCandy.Models;

namespace ArmCandy.Tests
{
    [TestClass]
    public class CartTests
    {
        [TestMethod]
        public void ConstructorTest()
        {
            CartModel c = new CartModel();
            Assert.IsNotNull(c);
        }

        [TestMethod]
        public void CartPropertiesTest()
        {
            CartModel c = new CartModel();
            c.Email = "joe@codingtemple.com";
            Assert.AreEqual("joe@codingtemple.com", c.Email);

            c.PhoneNumber = "222-222-2222";
            Assert.AreEqual("222-222-2222", c.PhoneNumber);

            c.ShippingAddress1 = "Street Address";
            Assert.AreEqual("Street Address", c.ShippingAddress1);
        }

        [TestMethod]
        public void CategoryTest()
        {
            CategoryModel c = new CategoryModel();
            c.Products = new ProductModel[] 
            {
                new ProductModel { ProductType = "clutch" },
                new ProductModel { ProductType = "hotdog" }
            };
           
            Assert.AreEqual("clutch", c.Products[0].ProductType);
        }

        [TestMethod]
        public void ProductTest()
        {
            ProductModel p = new ProductModel();
            p.ProductName = "bracelet01";
            Assert.AreEqual("bracelet01", p.ProductName);
        }
    }
}
