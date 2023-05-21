using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ManufacturersInformation
{
    public class csManufacturersInformation
    {
        public DAL.ManufacturersInformation.DataSet_ManufacturersInformation.mManufacturersInformationDataTable
            mManufacturersInformation(int x_)
        {
            DAL.ManufacturersInformation.DataSet_ManufacturersInformationTableAdapters.mManufacturersInformationTableAdapter adp =
               new DAL.ManufacturersInformation.DataSet_ManufacturersInformationTableAdapters.mManufacturersInformationTableAdapter();
            return adp.GetData(x_);
        }
        public string UdManufacturersInformation(DAL.ManufacturersInformation.DataSet_ManufacturersInformation.mManufacturersInformationDataTable dt)
        {
            try
            {
                DAL.ManufacturersInformation.DataSet_ManufacturersInformationTableAdapters.mManufacturersInformationTableAdapter adp =
                   new DAL.ManufacturersInformation.DataSet_ManufacturersInformationTableAdapters.mManufacturersInformationTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        public DAL.ManufacturersInformation.DataSet_ManufacturersInformation.mManufacturersInformationFinishProjectDataTable mManufacturersInformationFinishProject(int xManufacturersInformation_)
        {
            DAL.ManufacturersInformation.DataSet_ManufacturersInformationTableAdapters.mManufacturersInformationFinishProjectTableAdapter adp =
               new DAL.ManufacturersInformation.DataSet_ManufacturersInformationTableAdapters.mManufacturersInformationFinishProjectTableAdapter();
            return adp.GetData(xManufacturersInformation_);
        }
        public string UdManufacturersInformationFinishProject(DAL.ManufacturersInformation.DataSet_ManufacturersInformation.mManufacturersInformationFinishProjectDataTable dt)
        {
            try
            {
                DAL.ManufacturersInformation.DataSet_ManufacturersInformationTableAdapters.mManufacturersInformationFinishProjectTableAdapter adp =
                   new DAL.ManufacturersInformation.DataSet_ManufacturersInformationTableAdapters.mManufacturersInformationFinishProjectTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        public DAL.ManufacturersInformation.DataSet_ManufacturersInformation.mManufacturersInformationInProcessProjectDataTable mManufacturersInformationInProcessProject(int xManufacturersInformation_)
        {
            DAL.ManufacturersInformation.DataSet_ManufacturersInformationTableAdapters.mManufacturersInformationInProcessProjectTableAdapter adp =
               new DAL.ManufacturersInformation.DataSet_ManufacturersInformationTableAdapters.mManufacturersInformationInProcessProjectTableAdapter();
            return adp.GetData(xManufacturersInformation_);
        }
        public string UdManufacturersInformationInProcessProject(DAL.ManufacturersInformation.DataSet_ManufacturersInformation.mManufacturersInformationInProcessProjectDataTable dt)
        {
            try
            {
                DAL.ManufacturersInformation.DataSet_ManufacturersInformationTableAdapters.mManufacturersInformationInProcessProjectTableAdapter adp =
                   new DAL.ManufacturersInformation.DataSet_ManufacturersInformationTableAdapters.mManufacturersInformationInProcessProjectTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }






        public DAL.ManufacturersInformation.DataSet_ManufacturersInformation.mManufacturersInformationInProcessProjectNeedsDataTable
    mManufacturersInformationInProcessProjectNeeds(int x_)
        {
            DAL.ManufacturersInformation.DataSet_ManufacturersInformationTableAdapters.mManufacturersInformationInProcessProjectNeedsTableAdapter adp =
               new DAL.ManufacturersInformation.DataSet_ManufacturersInformationTableAdapters.mManufacturersInformationInProcessProjectNeedsTableAdapter();
            return adp.GetData(x_);
        }
        public string UdManufacturersInformationInProcessProjectNeeds(DAL.ManufacturersInformation.DataSet_ManufacturersInformation.mManufacturersInformationInProcessProjectNeedsDataTable dt)
        {
            try
            {
                DAL.ManufacturersInformation.DataSet_ManufacturersInformationTableAdapters.mManufacturersInformationInProcessProjectNeedsTableAdapter adp =
                   new DAL.ManufacturersInformation.DataSet_ManufacturersInformationTableAdapters.mManufacturersInformationInProcessProjectNeedsTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }


        public DAL.ManufacturersInformation.DataSet_ManufacturersInformation.mManufacturersInformationInProcessProjectNeedsResultDataTable
            mManufacturersInformationInProcessProjectNeedsResult(int x_)
        {
            DAL.ManufacturersInformation.DataSet_ManufacturersInformationTableAdapters.mManufacturersInformationInProcessProjectNeedsResultTableAdapter adp =
               new DAL.ManufacturersInformation.DataSet_ManufacturersInformationTableAdapters.mManufacturersInformationInProcessProjectNeedsResultTableAdapter();
            return adp.GetData(x_);
        }
        public string UdManufacturersInformationInProcessProjectNeedsResult(DAL.ManufacturersInformation.DataSet_ManufacturersInformation.mManufacturersInformationInProcessProjectNeedsResultDataTable dt)
        {
            try
            {
                DAL.ManufacturersInformation.DataSet_ManufacturersInformationTableAdapters.mManufacturersInformationInProcessProjectNeedsResultTableAdapter adp =
                   new DAL.ManufacturersInformation.DataSet_ManufacturersInformationTableAdapters.mManufacturersInformationInProcessProjectNeedsResultTableAdapter();
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
