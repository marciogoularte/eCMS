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
    
    public partial class SYS_tblFunctionPermission
    {
        public int PermissionID { get; set; }
        public int GroupID { get; set; }
        public int ModuleID { get; set; }
        public Nullable<int> FunctionID { get; set; }
        public Nullable<int> MasterDataID { get; set; }
        public Nullable<bool> FView { get; set; }
        public Nullable<bool> FEdit { get; set; }
        public Nullable<bool> FDelete { get; set; }
        public Nullable<bool> FExport { get; set; }
    
        public virtual LS_tblMasterData LS_tblMasterData { get; set; }
        public virtual SYS_tblFunctionList SYS_tblFunctionList { get; set; }
        public virtual SYS_tblGroup SYS_tblGroup { get; set; }
    }
}