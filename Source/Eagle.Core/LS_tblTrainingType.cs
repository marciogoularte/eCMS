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
    
    public partial class LS_tblTrainingType
    {
        public LS_tblTrainingType()
        {
            this.REC_tblQualification = new HashSet<REC_tblQualification>();
            this.TR_tblPlan = new HashSet<TR_tblPlan>();
            this.TR_tblTrainingRequest = new HashSet<TR_tblTrainingRequest>();
        }
    
        public int LSTrainingTypeID { get; set; }
        public string LSTrainingTypeCode { get; set; }
        public string Name { get; set; }
        public string VNName { get; set; }
        public Nullable<short> Rank { get; set; }
        public string Note { get; set; }
        public Nullable<bool> Used { get; set; }
    
        public virtual ICollection<REC_tblQualification> REC_tblQualification { get; set; }
        public virtual ICollection<TR_tblPlan> TR_tblPlan { get; set; }
        public virtual ICollection<TR_tblTrainingRequest> TR_tblTrainingRequest { get; set; }
    }
}
