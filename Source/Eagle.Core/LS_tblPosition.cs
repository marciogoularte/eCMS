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
    
    public partial class LS_tblPosition
    {
        public LS_tblPosition()
        {
            this.PR_tblAddSalaryByPosition = new HashSet<PR_tblAddSalaryByPosition>();
            this.REC_tblDemand = new HashSet<REC_tblDemand>();
            this.REC_tblPlan = new HashSet<REC_tblPlan>();
            this.REC_tblWorkingExpectation = new HashSet<REC_tblWorkingExpectation>();
            this.REC_tblWorkingExpectation1 = new HashSet<REC_tblWorkingExpectation>();
            this.REC_tblWorkingExpectation2 = new HashSet<REC_tblWorkingExpectation>();
        }
    
        public int LSPositionID { get; set; }
        public string LSPositionCode { get; set; }
        public string Name { get; set; }
        public string VNName { get; set; }
        public Nullable<int> Rank { get; set; }
        public bool Used { get; set; }
        public string Note { get; set; }
    
        public virtual ICollection<PR_tblAddSalaryByPosition> PR_tblAddSalaryByPosition { get; set; }
        public virtual ICollection<REC_tblDemand> REC_tblDemand { get; set; }
        public virtual ICollection<REC_tblPlan> REC_tblPlan { get; set; }
        public virtual ICollection<REC_tblWorkingExpectation> REC_tblWorkingExpectation { get; set; }
        public virtual ICollection<REC_tblWorkingExpectation> REC_tblWorkingExpectation1 { get; set; }
        public virtual ICollection<REC_tblWorkingExpectation> REC_tblWorkingExpectation2 { get; set; }
    }
}