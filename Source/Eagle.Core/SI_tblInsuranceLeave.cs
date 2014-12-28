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
    
    public partial class SI_tblInsuranceLeave
    {
        public SI_tblInsuranceLeave()
        {
            this.SI_tblConvalescence = new HashSet<SI_tblConvalescence>();
        }
    
        public int ID { get; set; }
        public int EmpID { get; set; }
        public System.DateTime FromDate { get; set; }
        public System.DateTime ToDate { get; set; }
        public int LSLeaveDayTypeID { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<bool> IsInsNotice { get; set; }
        public string SIMonth { get; set; }
        public Nullable<System.DateTime> BabyDOB { get; set; }
        public Nullable<bool> IsBenefits { get; set; }
        public Nullable<decimal> AvgSalary { get; set; }
        public Nullable<decimal> Percent { get; set; }
        public Nullable<decimal> BenifitSalary { get; set; }
        public Nullable<System.DateTime> BabyDOD { get; set; }
        public Nullable<int> Stage { get; set; }
        public Nullable<bool> IsConvalescence { get; set; }
        public string ConditionEffect { get; set; }
    
        public virtual ICollection<SI_tblConvalescence> SI_tblConvalescence { get; set; }
        public virtual Timesheet_tbLeaveDayType Timesheet_tbLeaveDayType { get; set; }
    }
}