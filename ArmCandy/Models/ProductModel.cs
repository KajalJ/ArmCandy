using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArmCandy.Models
{
    public class ProductModel
    {
        public decimal? ProductPrice { get; set; }
        public string ProductType { get; set; }
        public string ProductDescription { get; set; }
        public string ProductName{ get; set; }
        public int? Inventory { get; set; }
        public int? ProductId { get; set; }
        public string ImageFileName { get; set; }
        public string ATL { get; set; }


    }
}