﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ParkerEntities1 : DbContext
    {
        public ParkerEntities1()
            : base("name=ParkerEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<mAuthentication> mAuthentications { get; set; }
        public DbSet<mClientReferral> mClientReferrals { get; set; }
        public DbSet<mClientReferralFollowUp> mClientReferralFollowUps { get; set; }
        public DbSet<mClientReferralSurvey> mClientReferralSurveys { get; set; }
        public DbSet<mCompany> mCompanies { get; set; }
        public DbSet<mContractor> mContractors { get; set; }
        public DbSet<mContractorsEvaluation> mContractorsEvaluations { get; set; }
        public DbSet<mCustomer> mCustomers { get; set; }
        public DbSet<mCustomerCheckedList> mCustomerCheckedLists { get; set; }
        public DbSet<mCustomerQuestion> mCustomerQuestions { get; set; }
        public DbSet<mGenGroup> mGenGroups { get; set; }
        public DbSet<mGood> mGoods { get; set; }
        public DbSet<mGoodsAndSupplierInfo> mGoodsAndSupplierInfoes { get; set; }
        public DbSet<mGroup> mGroups { get; set; }
        public DbSet<mMarketerInformation> mMarketerInformations { get; set; }
        public DbSet<mMarketerInformationFollowUp> mMarketerInformationFollowUps { get; set; }
        public DbSet<mMessage> mMessages { get; set; }
        public DbSet<mObject> mObjects { get; set; }
        public DbSet<mObjectGroup> mObjectGroups { get; set; }
        public DbSet<mObjectTree> mObjectTrees { get; set; }
        public DbSet<mObjectType> mObjectTypes { get; set; }
        public DbSet<mPersonInfo> mPersonInfoes { get; set; }
        public DbSet<mPoem> mPoems { get; set; }
        public DbSet<mQuestion> mQuestions { get; set; }
        public DbSet<mQuestionItem> mQuestionItems { get; set; }
        public DbSet<mRebuilding> mRebuildings { get; set; }
        public DbSet<mRenovation> mRenovations { get; set; }
        public DbSet<mRenovationFloor> mRenovationFloors { get; set; }
        public DbSet<mRenovationProject> mRenovationProjects { get; set; }
        public DbSet<mRenovationProjectAnswer> mRenovationProjectAnswers { get; set; }
        public DbSet<mRenovationUnit> mRenovationUnits { get; set; }
        public DbSet<mShift> mShifts { get; set; }
        public DbSet<mSMSContext> mSMSContexts { get; set; }
        public DbSet<mSMSLog> mSMSLogs { get; set; }
        public DbSet<mState> mStates { get; set; }
        public DbSet<mStatementRefer> mStatementRefers { get; set; }
        public DbSet<mStatementReferFollowUp> mStatementReferFollowUps { get; set; }
        public DbSet<mStatementRentalIncome> mStatementRentalIncomes { get; set; }
        public DbSet<mStatementRentalIncomeSurvey> mStatementRentalIncomeSurveys { get; set; }
        public DbSet<mStatementSaleIncome> mStatementSaleIncomes { get; set; }
        public DbSet<mStatementSaleIncomeSurvey> mStatementSaleIncomeSurveys { get; set; }
        public DbSet<mStatu> mStatus { get; set; }
        public DbSet<mStore> mStores { get; set; }
        public DbSet<mStoreDetial> mStoreDetials { get; set; }
        public DbSet<mUser> mUsers { get; set; }
        public DbSet<mUserevent> mUserevents { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}