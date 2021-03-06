//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArmCandy
{
    using System;
    using System.Collections.Generic;
    
    public partial class CART
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CART()
        {
            this.Products = new HashSet<Product>();
        }
    
        public int OrderId { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public Nullable<int> PhoneNumber { get; set; }
        public string ShippingAddress1 { get; set; }
        public string ShippingAddress2 { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingState { get; set; }
        public string ShippingZipCode { get; set; }
        public string BillingAddress1 { get; set; }
        public string BillingAddress2 { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingZipCode { get; set; }
        public string BillinggState { get; set; }
        public string CreditCardNumber { get; set; }
        public Nullable<System.DateTime> CreditCardExpiration { get; set; }
        public int CVV { get; set; }
        public Nullable<int> Items { get; set; }
        public decimal TOTAL { get; set; }
        public Nullable<decimal> ShippingCost { get; set; }
        public Nullable<decimal> TAX { get; set; }
        public int SubTotal { get; set; }
        public decimal GrandTotal { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
