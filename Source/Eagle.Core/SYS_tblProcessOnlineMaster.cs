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
    
    public partial class SYS_tblProcessOnlineMaster
    {
        public SYS_tblProcessOnlineMaster()
        {
            this.SYS_tblOnlineProcessEmp = new HashSet<SYS_tblOnlineProcessEmp>();
        }
    
        public int OnlineProcessID { get; set; }
        public int DMQuiTrinhID { get; set; }
        public string StatusLevel1A { get; set; }
        public string StatusLevel1U { get; set; }
        public string StatusLevel2A { get; set; }
        public string StatusLevel2U { get; set; }
        public string StatusLevel3A { get; set; }
        public string StatusLevel3U { get; set; }
        public string StatusLevel4A { get; set; }
        public string StatusLevel4U { get; set; }
        public string StatusLevel5A { get; set; }
        public string StatusLevel5U { get; set; }
        public string Description { get; set; }
    
        public virtual LS_tblOnlineProcess LS_tblOnlineProcess { get; set; }
        public virtual ICollection<SYS_tblOnlineProcessEmp> SYS_tblOnlineProcessEmp { get; set; }
    }
}