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
    
    public partial class timesheet_sprptTimeKeepingReport_detail_Result
    {
        public Nullable<int> Seq { get; set; }
        public string EmployeeName { get; set; }
        public int LSCompanyID { get; set; }
        public string CompanyName { get; set; }
        public Nullable<int> LSPositionID { get; set; }
        public string PositionName { get; set; }
        public System.DateTime DateID { get; set; }
        public string DateInfo { get; set; }
        public int LSShiftID { get; set; }
        public string Shiftname { get; set; }
        public Nullable<System.DateTime> TimeInShift { get; set; }
        public string TimeInInfo { get; set; }
        public Nullable<System.DateTime> TimeOutShift { get; set; }
        public string TimeOutInfo { get; set; }
        public Nullable<System.DateTime> TimeInLate { get; set; }
        public string TimeInLateInfo { get; set; }
        public Nullable<System.DateTime> TimeOutEarly { get; set; }
        public string TimeOutEarlyInfo { get; set; }
    }
}
