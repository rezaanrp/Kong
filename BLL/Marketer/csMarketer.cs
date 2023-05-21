using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Marketer
{
   public class csMarketer
    {
        public DAL.Marketer.DataSet_MarketerInformation.mMarketerInformation_By_x_DataTable mMarketerInformation_By_x_(int x_)
        {
            DAL.Marketer.DataSet_MarketerInformationTableAdapters.mMarketerInformation_By_x_TableAdapter adp =
               new DAL.Marketer.DataSet_MarketerInformationTableAdapters.mMarketerInformation_By_x_TableAdapter();
            return adp.GetData(x_);
        }
        public string UdMarketerInformation_By_x_(DAL.Marketer.DataSet_MarketerInformation.mMarketerInformation_By_x_DataTable dt)
        {
            try
            {
                DAL.Marketer.DataSet_MarketerInformationTableAdapters.mMarketerInformation_By_x_TableAdapter adp =
                   new DAL.Marketer.DataSet_MarketerInformationTableAdapters.mMarketerInformation_By_x_TableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        public DAL.Marketer.DataSet_MarketerInformation.mMarketerInformationFollowUpDataTable 
            mMarketerInformationFollowUp(int x_)
        {
            DAL.Marketer.DataSet_MarketerInformationTableAdapters.mMarketerInformationFollowUpTableAdapter adp =
               new DAL.Marketer.DataSet_MarketerInformationTableAdapters.mMarketerInformationFollowUpTableAdapter();
            return adp.GetData(x_);
        }
        public string UdMarketerInformationFollowUp(DAL.Marketer.DataSet_MarketerInformation.mMarketerInformationFollowUpDataTable dt)
        {
            try
            {
                DAL.Marketer.DataSet_MarketerInformationTableAdapters.mMarketerInformationFollowUpTableAdapter adp =
                   new DAL.Marketer.DataSet_MarketerInformationTableAdapters.mMarketerInformationFollowUpTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        public DAL.Marketer.DataSet_MarketerInformation.mMarketerInformationDataTable 
            mMarketerInformation(string DateFrom ,string DateTo,int xUser_)
        {
            DAL.Marketer.DataSet_MarketerInformationTableAdapters.mMarketerInformationTableAdapter adp =
               new DAL.Marketer.DataSet_MarketerInformationTableAdapters.mMarketerInformationTableAdapter();
            return adp.GetData(DateFrom,DateTo,xUser_);
        }
        public string UdMarketerInformation(DAL.Marketer.DataSet_MarketerInformation.mMarketerInformationDataTable dt)
        {
            try
            {
                DAL.Marketer.DataSet_MarketerInformationTableAdapters.mMarketerInformationTableAdapter adp =
                   new DAL.Marketer.DataSet_MarketerInformationTableAdapters.mMarketerInformationTableAdapter();
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
