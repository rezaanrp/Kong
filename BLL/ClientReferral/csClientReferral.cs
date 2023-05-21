using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BLL.ClientReferral
{
    public class csClientReferral
    {
        //SlStatementSaleIncomeSurveyReport

        public DataTable SlClientReferralSurveyReport(string DateFrom, string DateTo)
        {
            string con = new DAL.csConnection().GetConeectionPaya;
            using (SqlConnection sqlcon = new SqlConnection(con))
            {
                using (SqlCommand cmd = new SqlCommand("SlClientReferralSurveyReport", sqlcon))
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
        public DataTable SlStatementSaleIncomeSurveyReport(string DateFrom, string DateTo)
        {
            string con = new DAL.csConnection().GetConeectionPaya;
            using (SqlConnection sqlcon = new SqlConnection(con))
            {
                using (SqlCommand cmd = new SqlCommand("SlStatementSaleIncomeSurveyReport", sqlcon))
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
        public DataTable SlStatementRentalIncomeSurveyReport(string DateFrom, string DateTo)
        {
            string con = new DAL.csConnection().GetConeectionPaya;
            using (SqlConnection sqlcon = new SqlConnection(con))
            {
                using (SqlCommand cmd = new SqlCommand("SlStatementRentalIncomeSurveyReport", sqlcon))
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

        public DAL.ClientReferral.DataSet_ClientReferral.SlClientReferral_ReferDataTable SlClientReferral_Refer(string DateFrom,
                                                                                                        string DateTo,
                                                                                                            bool SearchDate,
                                                                                                            string xClientReferral,
                                                                                                            bool SearchxClientReferral,
                                                                                                            string xTel,
                                                                                                            bool SearchxTel,
                                                                                                            string xRequestedGoods,
                                                                                                            bool SearchxRequestedGoods,
                                                                                                            int xGenResultOfReferral_,
                                                                                                            bool SearchxGenResultOfReferral_,
                                                                                                            int xGenReferTo_)
        {
            DAL.ClientReferral.DataSet_ClientReferralTableAdapters.SlClientReferral_ReferTableAdapter adp =
               new DAL.ClientReferral.DataSet_ClientReferralTableAdapters.SlClientReferral_ReferTableAdapter();
            return adp.GetData(DateFrom, DateTo, SearchDate,
                                                            xClientReferral,
                                                            SearchxClientReferral,
                                                            xTel,
                                                            SearchxTel,
                                                            xRequestedGoods,
                                                            SearchxRequestedGoods,
                                                            xGenResultOfReferral_,
                                                            SearchxGenResultOfReferral_,
                                                            xGenReferTo_);
        }
        public string UdClientReferral_Refer(DAL.ClientReferral.DataSet_ClientReferral.SlClientReferral_ReferDataTable dt)
        {
            try
            {
                DAL.ClientReferral.DataSet_ClientReferralTableAdapters.SlClientReferral_ReferTableAdapter adp =
                   new DAL.ClientReferral.DataSet_ClientReferralTableAdapters.SlClientReferral_ReferTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }



        public DAL.ClientReferral.DataSet_ClientReferral.mClientReferralSurveyDataTable mClientReferralSurvey(int xClientReferralSurvey_, int xGenSurveyForWho_)
        {
            DAL.ClientReferral.DataSet_ClientReferralTableAdapters.mClientReferralSurveyTableAdapter adp =
               new DAL.ClientReferral.DataSet_ClientReferralTableAdapters.mClientReferralSurveyTableAdapter();
            return adp.GetData(xClientReferralSurvey_, xGenSurveyForWho_);
        }
        public string UdClientReferralSurvey(DAL.ClientReferral.DataSet_ClientReferral.mClientReferralSurveyDataTable dt)
        {
            try
            {
                DAL.ClientReferral.DataSet_ClientReferralTableAdapters.mClientReferralSurveyTableAdapter adp =
                   new DAL.ClientReferral.DataSet_ClientReferralTableAdapters.mClientReferralSurveyTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
        public DAL.ClientReferral.DataSet_ClientReferral.SlClientReferral_ForWellComeSMSDataTable SlClientReferral_ForWellComeSMS()
        {
            DAL.ClientReferral.DataSet_ClientReferralTableAdapters.SlClientReferral_ForWellComeSMSTableAdapter adp =
               new DAL.ClientReferral.DataSet_ClientReferralTableAdapters.SlClientReferral_ForWellComeSMSTableAdapter();
            return adp.GetData();
        }
        public string UdClientReferral_ForWellComeSMS(DAL.ClientReferral.DataSet_ClientReferral.SlClientReferral_ForWellComeSMSDataTable dt)
        {
            try
            {
                DAL.ClientReferral.DataSet_ClientReferralTableAdapters.SlClientReferral_ForWellComeSMSTableAdapter adp =
                   new DAL.ClientReferral.DataSet_ClientReferralTableAdapters.SlClientReferral_ForWellComeSMSTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        public DAL.ClientReferral.DataSet_ClientReferral.SlClientReferral_MoonReportDataTable SlClientReferral_MoonReport(string Year)
        {
            DAL.ClientReferral.DataSet_ClientReferralTableAdapters.SlClientReferral_MoonReportTableAdapter adp =
               new DAL.ClientReferral.DataSet_ClientReferralTableAdapters.SlClientReferral_MoonReportTableAdapter();
            return adp.GetData(Year);
        }
        public DAL.ClientReferral.DataSet_ClientReferral.mClientReferral_TelDataTable mClientReferral_Tel(string xTel)
        {
            DAL.ClientReferral.DataSet_ClientReferralTableAdapters.mClientReferral_TelTableAdapter adp =
               new DAL.ClientReferral.DataSet_ClientReferralTableAdapters.mClientReferral_TelTableAdapter();
            return adp.GetData(xTel);
        }
        public DAL.ClientReferral.DataSet_ClientReferral.SlClientReferralDataTable SlClientReferral(string DateFrom,
                                                                                                        string DateTo,
                                                                                                            bool SearchDate,
                                                                                                            string xClientReferral,
                                                                                                            bool SearchxClientReferral,
                                                                                                            string xTel,
                                                                                                            bool SearchxTel,
                                                                                                            string xRequestedGoods,
                                                                                                            bool SearchxRequestedGoods,
                                                                                                            int xGenResultOfReferral_,
                                                                                                            bool SearchxGenResultOfReferral_


            )
        {
            DAL.ClientReferral.DataSet_ClientReferralTableAdapters.SlClientReferralTableAdapter adp =
               new DAL.ClientReferral.DataSet_ClientReferralTableAdapters.SlClientReferralTableAdapter();
                        return adp.GetData(DateFrom, DateTo, SearchDate,
                                                            xClientReferral,
                                                            SearchxClientReferral,
                                                            xTel,
                                                            SearchxTel,
                                                            xRequestedGoods,
                                                            SearchxRequestedGoods,
                                                            xGenResultOfReferral_,
                                                            SearchxGenResultOfReferral_);
        }
        public string UdClientReferral(DAL.ClientReferral.DataSet_ClientReferral.SlClientReferralDataTable dt)
        {
            try
            {
                DAL.ClientReferral.DataSet_ClientReferralTableAdapters.SlClientReferralTableAdapter adp =
                   new DAL.ClientReferral.DataSet_ClientReferralTableAdapters.SlClientReferralTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }


        public DAL.ClientReferral.DataSet_ClientReferral.mClientReferralFollowUpDataTable mClientReferralFollowUp(int xClientReferral_)
        {
            DAL.ClientReferral.DataSet_ClientReferralTableAdapters.mClientReferralFollowUpTableAdapter adp =
               new DAL.ClientReferral.DataSet_ClientReferralTableAdapters.mClientReferralFollowUpTableAdapter();
            return adp.GetData(xClientReferral_);
        }
        public string UdClientReferralFollowUp(DAL.ClientReferral.DataSet_ClientReferral.mClientReferralFollowUpDataTable dt)
        {
            try
            {
                DAL.ClientReferral.DataSet_ClientReferralTableAdapters.mClientReferralFollowUpTableAdapter adp =
                   new DAL.ClientReferral.DataSet_ClientReferralTableAdapters.mClientReferralFollowUpTableAdapter();
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
