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
    
    public partial class mMarketerInformation
    {
        public mMarketerInformation()
        {
            this.mMarketerInformationFollowUps = new HashSet<mMarketerInformationFollowUp>();
        }
    
        public int x_ { get; set; }
        public string xDate { get; set; }
        public string xAddress { get; set; }
        public Nullable<int> xGenUsage_ { get; set; }
        public string xArea { get; set; }
        public Nullable<int> xFloorNumber { get; set; }
        public Nullable<int> xUnitNumber { get; set; }
        public Nullable<int> xConstractionState_ { get; set; }
        public string xBuildingLicenseDate { get; set; }
        public string xBuildingOwner { get; set; }
        public string xBuildingOwnerTel { get; set; }
        public string xContractor { get; set; }
        public string xContractorTel { get; set; }
        public string xSiteManeger { get; set; }
        public string xSiteManegerTel { get; set; }
        public string xGuardName { get; set; }
        public string xGuardTel { get; set; }
        public string xInterViewer { get; set; }
        public string xInterViewerJob { get; set; }
        public string xInterViewerTel { get; set; }
        public Nullable<bool> xDesignService { get; set; }
        public Nullable<int> xBulidingTypeService_ { get; set; }
        public Nullable<bool> xKitchen { get; set; }
        public Nullable<bool> xWallCoverings { get; set; }
        public Nullable<bool> xFloorCoverings { get; set; }
        public Nullable<bool> xFacilities { get; set; }
        public Nullable<bool> xWoodenProducts { get; set; }
        public Nullable<bool> xStoneAndBricks { get; set; }
        public Nullable<bool> xDecorationInside { get; set; }
        public Nullable<bool> xConcrete { get; set; }
        public string xOtherService { get; set; }
        public string xComment { get; set; }
        public string xIntroductionFor { get; set; }
        public string xIntroductionCode { get; set; }
        public Nullable<int> xSupplier_ { get; set; }
        public string xRegisterDate { get; set; }
    
        public virtual ICollection<mMarketerInformationFollowUp> mMarketerInformationFollowUps { get; set; }
    }
}
