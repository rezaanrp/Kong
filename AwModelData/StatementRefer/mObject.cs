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
    
    public partial class mObject
    {
        public mObject()
        {
            this.mAuthentications = new HashSet<mAuthentication>();
        }
    
        public int x_ { get; set; }
        public string xObjectname { get; set; }
        public string xObjectFarsiName { get; set; }
        public Nullable<int> xRegistringGroup_ { get; set; }
        public Nullable<int> xType_ { get; set; }
        public Nullable<int> xGroup_ { get; set; }
    
        public virtual ICollection<mAuthentication> mAuthentications { get; set; }
        public virtual mObjectGroup mObjectGroup { get; set; }
        public virtual mObjectType mObjectType { get; set; }
    }
}
