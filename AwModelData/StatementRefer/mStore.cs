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
    
    public partial class mStore
    {
        public mStore()
        {
            this.mStoreDetials = new HashSet<mStoreDetial>();
        }
    
        public int x_ { get; set; }
        public string xDate { get; set; }
        public string xRegisterTime { get; set; }
        public Nullable<int> xCustomer_ { get; set; }
        public string xCustomerTitle { get; set; }
        public Nullable<int> xGenStatus_ { get; set; }
        public Nullable<int> xSellerUser_ { get; set; }
        public string xIntroduced { get; set; }
        public Nullable<int> xSupplier_ { get; set; }
        public string xComment { get; set; }
    
        public virtual mCustomer mCustomer { get; set; }
        public virtual ICollection<mStoreDetial> mStoreDetials { get; set; }
    }
}
