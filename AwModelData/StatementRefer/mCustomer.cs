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
    
    public partial class mCustomer
    {
        public mCustomer()
        {
            this.mStores = new HashSet<mStore>();
        }
    
        public int x_ { get; set; }
        public Nullable<int> xGenCUSTOMERTYPE_ { get; set; }
        public string xName { get; set; }
        public string xLastName { get; set; }
        public string xBusinessNumber { get; set; }
        public string xRegistrationNumber { get; set; }
        public string xNationalCode { get; set; }
        public string xFatherName { get; set; }
        public Nullable<int> xChildNo { get; set; }
        public string xBirthDay { get; set; }
        public string xMobile { get; set; }
        public string xPhone { get; set; }
        public string xEmploy { get; set; }
        public string xAddress { get; set; }
        public string xZipCode { get; set; }
        public string xDate { get; set; }
        public Nullable<int> xSupplier_ { get; set; }
    
        public virtual ICollection<mStore> mStores { get; set; }
    }
}