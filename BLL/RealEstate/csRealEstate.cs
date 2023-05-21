using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BLL.RealEstate
{
    public class csRealEstate
    {
        public DAL.RealEstate.DataSet_StatementRentalIncome.SlStatementRentalIncomeSmsBeforeEndContractDataTable 
            SlStatementRentalIncomeSmsBeforeEndContract(int maxRemiandDay)
        {
            DAL.RealEstate.DataSet_StatementRentalIncomeTableAdapters.SlStatementRentalIncomeSmsBeforeEndContractTableAdapter adp =
               new DAL.RealEstate.DataSet_StatementRentalIncomeTableAdapters.SlStatementRentalIncomeSmsBeforeEndContractTableAdapter();
            return adp.GetData(maxRemiandDay);
        }
        public string UdStatementRentalIncomeSmsBeforeEndContract(DAL.RealEstate.DataSet_StatementRentalIncome.SlStatementRentalIncomeSmsBeforeEndContractDataTable dt)
        {
            try
            {
                DAL.RealEstate.DataSet_StatementRentalIncomeTableAdapters.SlStatementRentalIncomeSmsBeforeEndContractTableAdapter adp =
                   new DAL.RealEstate.DataSet_StatementRentalIncomeTableAdapters.SlStatementRentalIncomeSmsBeforeEndContractTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
        public DAL.RealEstate.DataSet_StatementRefer.mStatementReferFollowUpDataTable mStatementReferFollowUp(int xStatementRefer_)
        {
            DAL.RealEstate.DataSet_StatementReferTableAdapters.mStatementReferFollowUpTableAdapter adp =
               new DAL.RealEstate.DataSet_StatementReferTableAdapters.mStatementReferFollowUpTableAdapter();
            return adp.GetData(xStatementRefer_);
        }
        public string UdStatementReferFollowUp(DAL.RealEstate.DataSet_StatementRefer.mStatementReferFollowUpDataTable dt)
        {
            try
            {
                DAL.RealEstate.DataSet_StatementReferTableAdapters.mStatementReferFollowUpTableAdapter adp =
                   new DAL.RealEstate.DataSet_StatementReferTableAdapters.mStatementReferFollowUpTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
        public DAL.RealEstate.DataSet_StatementRefer.mStatementReferDataTable mStatementRefer(int xConsultant_, string DateFrom,string DateTo,int xGenFollowUpFinalResult_)
        {
            DAL.RealEstate.DataSet_StatementReferTableAdapters.mStatementReferTableAdapter adp =
               new DAL.RealEstate.DataSet_StatementReferTableAdapters.mStatementReferTableAdapter();
            return adp.GetData(xConsultant_, xGenFollowUpFinalResult_, DateFrom,DateTo);
        }
        public string UdStatementRefer(DAL.RealEstate.DataSet_StatementRefer.mStatementReferDataTable dt)
        {
            try
            {
                DAL.RealEstate.DataSet_StatementReferTableAdapters.mStatementReferTableAdapter adp =
                   new DAL.RealEstate.DataSet_StatementReferTableAdapters.mStatementReferTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        public DataTable SlStatementSaleIncomeContractConsultant_Report(string DateFrom, string DateTo)
        {
            string con = new DAL.csConnection().GetConeectionPaya;
            using (SqlConnection sqlcon = new SqlConnection(con))
            {
                using (SqlCommand cmd = new SqlCommand("SlStatementSaleIncomeContractConsultant_Report", sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@datefrom", DateFrom));
                    cmd.Parameters.Add(new SqlParameter("@dateto", DateTo));
                    cmd.CommandTimeout = 200;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public DataTable SlStatementRentalIncomeContractConsultant_Report(string DateFrom, string DateTo)
        {
            string con = new DAL.csConnection().GetConeectionPaya;
            using (SqlConnection sqlcon = new SqlConnection(con))
            {
                using (SqlCommand cmd = new SqlCommand("SlStatementRentalIncomeContractConsultant_Report", sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@datefrom", DateFrom));
                    cmd.Parameters.Add(new SqlParameter("@dateto", DateTo));
                    cmd.CommandTimeout = 200;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public DataTable SlMainCountTanzimerByDateDetails(string DateFrom, string DateTo)
        {
            string con = new DAL.csConnection().GetConeectionPaya;
            using (SqlConnection sqlcon = new SqlConnection(con))
            {
                using (SqlCommand cmd = new SqlCommand("SlMainCountTanzimerByDateDetails", sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@datefrom", DateFrom));
                    cmd.Parameters.Add(new SqlParameter("@dateto", DateTo));
                    cmd.CommandTimeout = 200;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        //xStatementSaleIncome_
        public DataTable
             SlHiraDemandManagerReport(string DateFrom, string DateTo)
        {
            string con = new DAL.csConnection().GetConeectionPaya;
            using (SqlConnection sqlcon = new SqlConnection(con))
            {
                using (SqlCommand cmd = new SqlCommand("SlHiraDemandManagerReport", sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@datefrom", DateFrom));
                    cmd.Parameters.Add(new SqlParameter("@dateto", DateTo));
                    cmd.CommandTimeout = 200;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        public DataTable 
            SlHiraManagerReport(string DateFrom, string DateTo)
        {
            string con = new DAL.csConnection().GetConeectionPaya;
            using (SqlConnection sqlcon = new SqlConnection(con))
            {
                using (SqlCommand cmd = new SqlCommand("SlHiraManagerReport", sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@datefrom", DateFrom));
                    cmd.Parameters.Add(new SqlParameter("@dateto", DateTo));
                    cmd.CommandTimeout = 200;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public DAL.RealEstate.DataSet_StatementSaleIncome.mStatementSaleIncomeSurveyDataTable mStatementSaleIncomeSurvey(int xStatementSaleIncomeSurvey_, int xGenSurveyForWho_)
        {
            DAL.RealEstate.DataSet_StatementSaleIncomeTableAdapters.mStatementSaleIncomeSurveyTableAdapter adp =
               new DAL.RealEstate.DataSet_StatementSaleIncomeTableAdapters.mStatementSaleIncomeSurveyTableAdapter();
            return adp.GetData(xStatementSaleIncomeSurvey_,xGenSurveyForWho_);
        }
        public string UdStatementSaleIncomeSurvey(DAL.RealEstate.DataSet_StatementSaleIncome.mStatementSaleIncomeSurveyDataTable dt)
        {
            try
            {
                DAL.RealEstate.DataSet_StatementSaleIncomeTableAdapters.mStatementSaleIncomeSurveyTableAdapter adp =
                   new DAL.RealEstate.DataSet_StatementSaleIncomeTableAdapters.mStatementSaleIncomeSurveyTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
        public DAL.RealEstate.DataSet_StatementRentalIncome.mStatementRentalIncomeSurveyDataTable mStatementRentalIncomeSurvey(int xStatementRentalIncome_, int xGenSurveyForWho_)
        {
            DAL.RealEstate.DataSet_StatementRentalIncomeTableAdapters.mStatementRentalIncomeSurveyTableAdapter adp =
               new DAL.RealEstate.DataSet_StatementRentalIncomeTableAdapters.mStatementRentalIncomeSurveyTableAdapter();
            return adp.GetData(xStatementRentalIncome_,xGenSurveyForWho_);
        }
        public string UdStatementRentalIncomeSurvey(DAL.RealEstate.DataSet_StatementRentalIncome.mStatementRentalIncomeSurveyDataTable dt)
        {
            try
            {
                DAL.RealEstate.DataSet_StatementRentalIncomeTableAdapters.mStatementRentalIncomeSurveyTableAdapter adp =
                   new DAL.RealEstate.DataSet_StatementRentalIncomeTableAdapters.mStatementRentalIncomeSurveyTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        public DAL.RealEstate.DataSet_User.SlUserFromHiraDataTable SlUserFromHira()
        {
            DAL.RealEstate.DataSet_UserTableAdapters.SlUserFromHiraTableAdapter adp =
               new DAL.RealEstate.DataSet_UserTableAdapters.SlUserFromHiraTableAdapter();
            return adp.GetData();
        }

        //   SlRealEstate_NumberFileByUser
        public DAL.RealEstate.DataSet_Total.SlRealEstate_NumberFileByUserDataTable SlRealEstate_NumberFileByUser(string DateFrom, string DateTo)
        {
            DAL.RealEstate.DataSet_TotalTableAdapters.SlRealEstate_NumberFileByUserTableAdapter adp =
               new DAL.RealEstate.DataSet_TotalTableAdapters.SlRealEstate_NumberFileByUserTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }
        public DAL.RealEstate.DataSet_Total.SlRealEstate_NumberFileByTypeAndMoonDataTable SlRealEstate_NumberFileByTypeAndMoon(string DateFrom, string DateTo)
        {
            DAL.RealEstate.DataSet_TotalTableAdapters.SlRealEstate_NumberFileByTypeAndMoonTableAdapter adp =
               new DAL.RealEstate.DataSet_TotalTableAdapters.SlRealEstate_NumberFileByTypeAndMoonTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }
        public DAL.RealEstate.DataSet_Total.SlRealEstate_RentSaleCountHiraAndMisDataTable SlRealEstate_RentSaleCountHiraAndMis(string DateFrom, string DateTo)
        {
            DAL.RealEstate.DataSet_TotalTableAdapters.SlRealEstate_RentSaleCountHiraAndMisTableAdapter adp =
               new DAL.RealEstate.DataSet_TotalTableAdapters.SlRealEstate_RentSaleCountHiraAndMisTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }
        public DAL.RealEstate.DataSet_Main.SlMainCountTanzimerDataTable SlMainCountTanzimer(string DateFrom, string DateTo)
        {
            DAL.RealEstate.DataSet_MainTableAdapters.SlMainCountTanzimerTableAdapter adp =
               new DAL.RealEstate.DataSet_MainTableAdapters.SlMainCountTanzimerTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }

        public DAL.RealEstate.DataSet_Demand.SlDemandCountTanzimerDataTable SlDemandCountTanzimer(string DateFrom, string DateTo)
        {
            DAL.RealEstate.DataSet_DemandTableAdapters.SlDemandCountTanzimerTableAdapter adp =
               new DAL.RealEstate.DataSet_DemandTableAdapters.SlDemandCountTanzimerTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }
        public DAL.RealEstate.DataSet_StatementRentalIncome.SlStatementRentalIncomeDataTable SlStatementRentalIncome(string DateFrom, string DateTo,
                     string xBuildingAddress ,
		 bool SearchxBuildingAddress ,

         string xContractConsultant ,
         bool SearchxContractConsultant ,

         string xContractNumber ,
		 bool SearchxContractNumber ,

         string xContractManager ,
         bool SearchxContractManager ,

         string xLessorTel ,
         bool SearchxLessorTel ,

         string xTenantTel ,
         bool SearchxTenantTel ,

         string xTenantName ,
         bool SearchxTenantName ,

         string xLessorName ,
         bool SearchxLessorName ,bool SearchDate 
            )
        {
            DAL.RealEstate.DataSet_StatementRentalIncomeTableAdapters.SlStatementRentalIncomeTableAdapter adp =
               new DAL.RealEstate.DataSet_StatementRentalIncomeTableAdapters.SlStatementRentalIncomeTableAdapter();
            return adp.GetData(DateFrom, DateTo,
                                      xBuildingAddress,
          SearchxBuildingAddress,

          xContractConsultant,
          SearchxContractConsultant,

          xContractNumber,
          SearchxContractNumber,

          xContractManager,
          SearchxContractManager,

          xLessorTel,
          SearchxLessorTel,

          xTenantTel,
          SearchxTenantTel,

          xTenantName,
          SearchxTenantName,

          xLessorName,
          SearchxLessorName, SearchDate
                );
        }
        public string UdStatementRentalIncome(DAL.RealEstate.DataSet_StatementRentalIncome.SlStatementRentalIncomeDataTable dt)
        {
            try
            {
                DAL.RealEstate.DataSet_StatementRentalIncomeTableAdapters.SlStatementRentalIncomeTableAdapter adp =
                   new DAL.RealEstate.DataSet_StatementRentalIncomeTableAdapters.SlStatementRentalIncomeTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        public DAL.RealEstate.DataSet_StatementSaleIncome.SlStatementSaleIncomeDataTable mStatementSaleIncome(string DateFrom, string DateTo,
                     string xBuildingAddress,
         bool SearchxBuildingAddress,

         string xContractConsultant,
         bool SearchxContractConsultant,

         string xContractNumber,
         bool SearchxContractNumber,

         string xContractManager,
         bool SearchxContractManager,

         string xSellerTel,
         bool SearchxSellerTel,

         string xBuyerTel,
         bool SearchxBuyerTel,

         string xBuyerName,
         bool SearchxBuyerName,

         string xSellerName,
         bool SearchxSellerName, bool SearchDate)
        {
            DAL.RealEstate.DataSet_StatementSaleIncomeTableAdapters.SlStatementSaleIncomeTableAdapter adp =
               new DAL.RealEstate.DataSet_StatementSaleIncomeTableAdapters.SlStatementSaleIncomeTableAdapter();
            return adp.GetData(DateFrom, DateTo,
                                      xBuildingAddress,
          SearchxBuildingAddress,

          xContractConsultant,
          SearchxContractConsultant,

          xContractNumber,
          SearchxContractNumber,

          xContractManager,
          SearchxContractManager,

          xSellerTel,
          SearchxSellerTel,

          xBuyerTel,
          SearchxBuyerTel,

          xBuyerName,
          SearchxBuyerName,

          xSellerName,
          SearchxSellerName, SearchDate);
        }
        public string UdStatementSaleIncome(DAL.RealEstate.DataSet_StatementSaleIncome.SlStatementSaleIncomeDataTable dt)
        {
            try
            {
                DAL.RealEstate.DataSet_StatementSaleIncomeTableAdapters.SlStatementSaleIncomeTableAdapter adp =
                   new DAL.RealEstate.DataSet_StatementSaleIncomeTableAdapters.SlStatementSaleIncomeTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
    }
}
