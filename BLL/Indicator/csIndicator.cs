using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Indicator
{
    public class csIndicator
    {
        public DAL.Indicator.DataSet_Indicator.mIndicatorFiling_ByIdDataTable mIndicatorFiling_ById(int id)
        {
            DAL.Indicator.DataSet_IndicatorTableAdapters.mIndicatorFiling_ByIdTableAdapter adp =
               new DAL.Indicator.DataSet_IndicatorTableAdapters.mIndicatorFiling_ByIdTableAdapter();
            return adp.GetData(id);
        }
        public string UdIndicatorFiling_ById(DAL.Indicator.DataSet_Indicator.mIndicatorFiling_ByIdDataTable dt)
        {
            try
            {
                DAL.Indicator.DataSet_IndicatorTableAdapters.mIndicatorFiling_ByIdTableAdapter adp =
                      new DAL.Indicator.DataSet_IndicatorTableAdapters.mIndicatorFiling_ByIdTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public DAL.Indicator.DataSet_Indicator.mIndicatorFilingDataTable mIndicatorFiling(string DateFrom, string DateTo)
        {
            DAL.Indicator.DataSet_IndicatorTableAdapters.mIndicatorFilingTableAdapter adp =
               new DAL.Indicator.DataSet_IndicatorTableAdapters.mIndicatorFilingTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }

        public string UdIndicatorFiling(DAL.Indicator.DataSet_Indicator.mIndicatorFilingDataTable dt)
        {
            try
            {
                DAL.Indicator.DataSet_IndicatorTableAdapters.mIndicatorFilingTableAdapter adp =
                      new DAL.Indicator.DataSet_IndicatorTableAdapters.mIndicatorFilingTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public DAL.Indicator.DataSet_Indicator.mIndicatorApplicantsDataTable mIndicatorApplicants(string DateFrom, string DateTo)
        {
            DAL.Indicator.DataSet_IndicatorTableAdapters.mIndicatorApplicantsTableAdapter adp =
               new DAL.Indicator.DataSet_IndicatorTableAdapters.mIndicatorApplicantsTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }
        public string UdIndicatorApplicants(DAL.Indicator.DataSet_Indicator.mIndicatorApplicantsDataTable dt)
        {
            try
            {
                DAL.Indicator.DataSet_IndicatorTableAdapters.mIndicatorApplicantsTableAdapter adp =
                      new DAL.Indicator.DataSet_IndicatorTableAdapters.mIndicatorApplicantsTableAdapter();
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
