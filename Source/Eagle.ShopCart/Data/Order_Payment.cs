//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eagle.ShopCart.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order_Payment
    {
        public System.Guid Order_No { get; set; }
        public int Payment_Method_Id { get; set; }
        public string Payment_Code { get; set; }
        public string Payment_Name { get; set; }
        public string Payment_Number { get; set; }
        public string Payment_Expire { get; set; }
        public Nullable<bool> Payment_Status { get; set; }
    }
}