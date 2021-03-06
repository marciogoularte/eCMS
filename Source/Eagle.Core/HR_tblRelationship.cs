//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eagle.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class HR_tblRelationship
    {
        public int RelationshipID { get; set; }
        public int EmpID { get; set; }
        public int LSRelationshipID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Gender { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public Nullable<int> YOB { get; set; }
        public string IDNo { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public bool IsDependant { get; set; }
        public Nullable<System.DateTime> FromDatePIT { get; set; }
        public Nullable<System.DateTime> ToDatePIT { get; set; }
        public string WokPlace { get; set; }
        public bool StillAlive { get; set; }
        public string Before75 { get; set; }
        public string After75 { get; set; }
        public string TaxNo { get; set; }
        public string Note { get; set; }
        public Nullable<int> Creater { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    
        public virtual HR_tblEmp HR_tblEmp { get; set; }
        public virtual LS_tblRelationship LS_tblRelationship { get; set; }
    }
}
