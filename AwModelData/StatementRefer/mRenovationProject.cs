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
    
    public partial class mRenovationProject
    {
        public mRenovationProject()
        {
            this.mRenovationFloors = new HashSet<mRenovationFloor>();
        }
    
        public int x_ { get; set; }
        public string xDate { get; set; }
        public Nullable<int> xCustomer_ { get; set; }
        public Nullable<int> xGenQUESTLEVL1_ { get; set; }
        public string xAddress { get; set; }
        public string xComment { get; set; }
        public Nullable<int> xSupplier_ { get; set; }
        public Nullable<int> xGenStatus_ { get; set; }
    
        public virtual mGenGroup mGenGroup { get; set; }
        public virtual ICollection<mRenovationFloor> mRenovationFloors { get; set; }
    }
}
