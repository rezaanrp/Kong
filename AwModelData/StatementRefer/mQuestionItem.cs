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
    
    public partial class mQuestionItem
    {
        public int x_ { get; set; }
        public string xQuestionItem { get; set; }
        public Nullable<int> xQuestion_ { get; set; }
    
        public virtual mQuestion mQuestion { get; set; }
    }
}