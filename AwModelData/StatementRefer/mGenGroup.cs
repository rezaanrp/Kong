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
    
    public partial class mGenGroup
    {
        public mGenGroup()
        {
            this.mContractorsEvaluations = new HashSet<mContractorsEvaluation>();
            this.mPersonInfoes = new HashSet<mPersonInfo>();
            this.mPersonInfoes1 = new HashSet<mPersonInfo>();
            this.mPersonInfoes2 = new HashSet<mPersonInfo>();
            this.mQuestions = new HashSet<mQuestion>();
            this.mQuestions1 = new HashSet<mQuestion>();
            this.mRenovationProjects = new HashSet<mRenovationProject>();
            this.mRenovationProjectAnswers = new HashSet<mRenovationProjectAnswer>();
        }
    
        public int x_ { get; set; }
        public string xType { get; set; }
        public string xName { get; set; }
        public Nullable<double> xValue { get; set; }
        public string xComment { get; set; }
    
        public virtual ICollection<mContractorsEvaluation> mContractorsEvaluations { get; set; }
        public virtual ICollection<mPersonInfo> mPersonInfoes { get; set; }
        public virtual ICollection<mPersonInfo> mPersonInfoes1 { get; set; }
        public virtual ICollection<mPersonInfo> mPersonInfoes2 { get; set; }
        public virtual ICollection<mQuestion> mQuestions { get; set; }
        public virtual ICollection<mQuestion> mQuestions1 { get; set; }
        public virtual ICollection<mRenovationProject> mRenovationProjects { get; set; }
        public virtual ICollection<mRenovationProjectAnswer> mRenovationProjectAnswers { get; set; }
    }
}
