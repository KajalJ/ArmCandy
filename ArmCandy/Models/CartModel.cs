using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArmCandy.Models
{
    public class CartModel
    {
        public string Email;
        public string PhoneNumber;

        public string ShippingAddress1 { get; set; }
        public string ShippingAddress2 { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingState { get; set; }
    }
}