//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AwModelData.StatementRefer
{
    using System;
    using System.Collections.Generic;
    
    public partial class mClientReferralFollowUp
    {
        public int x_ { get; set; }
        public string xDate { get; set; }
        public string xTime { get; set; }
        public Nullable<int> xGenFollowUp_ { get; set; }
        public string xAction { get; set; }
        public string xConstructionStage { get; set; }
        public string xMasterFollowUp { get; set; }
        public Nullable<int> xSupplier_ { get; set; }
        public Nullable<int> xClientReferral_ { get; set; }
    
        public virtual mClientReferral mClientReferral { get; set; }
    }
}
