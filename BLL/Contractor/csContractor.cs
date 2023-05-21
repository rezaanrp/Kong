using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Contractor
{
    public class csContractor
    {
        public DAL.Contractor.DataSet_Contractor.mContractorsEvaluationDataTable mContractorsEvaluation(int xContractors_)
        {
            DAL.Contractor.DataSet_ContractorTableAdapters.mContractorsEvaluationTableAdapter adp =
               new DAL.Contractor.DataSet_ContractorTableAdapters.mContractorsEvaluationTableAdapter();
            return adp.GetData(xContractors_);
        }
        public string UdContractorsEvaluation(DAL.Contractor.DataSet_Contractor.mContractorsEvaluationDataTable dt)
        {
            try
            {
                DAL.Contractor.DataSet_ContractorTableAdapters.mContractorsEvaluationTableAdapter adp =
                   new DAL.Contractor.DataSet_ContractorTableAdapters.mContractorsEvaluationTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
        public DAL.Contractor.DataSet_Contractor.SlContractorsDataTable SlContractor(string Src)
        {
            DAL.Contractor.DataSet_ContractorTableAdapters.SlContractorsTableAdapter adp =
               new DAL.Contractor.DataSet_ContractorTableAdapters.SlContractorsTableAdapter();
            return adp.GetData(Src);
        }
        public DAL.Contractor.DataSet_Contractor.mContractorDataTable mContractor(string Src, int xGenJob_)
        {

            DAL.Contractor.DataSet_ContractorTableAdapters.mContractorTableAdapter adp =
               new DAL.Contractor.DataSet_ContractorTableAdapters.mContractorTableAdapter();
            if (Src.Replace(" ", "") == "")
                return adp.GetData(null, xGenJob_);
            else if (Src == "*")
                return adp.GetData("", xGenJob_);
            else
                return adp.GetData(Src, xGenJob_);

        }
        public string UdContractor(DAL.Contractor.DataSet_Contractor.mContractorDataTable dt)
        {
            try
            {
                DAL.Contractor.DataSet_ContractorTableAdapters.mContractorTableAdapter adp =
                   new DAL.Contractor.DataSet_ContractorTableAdapters.mContractorTableAdapter();
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
