using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Company
{
  public  class csCompany
    {
        public DAL.Company.DataSet_Company.mCompany_Byx_DataTable mCompany_Byx_(int x_)
        {
            DAL.Company.DataSet_CompanyTableAdapters.mCompany_Byx_TableAdapter adp =
               new DAL.Company.DataSet_CompanyTableAdapters.mCompany_Byx_TableAdapter();
            return adp.GetData(x_);
        }
        public string UdCompany_Byx_(DAL.Company.DataSet_Company.mCompany_Byx_DataTable dt)
        {
            try
            {
                DAL.Company.DataSet_CompanyTableAdapters.mCompany_Byx_TableAdapter adp =
                      new DAL.Company.DataSet_CompanyTableAdapters.mCompany_Byx_TableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
        public DAL.Company.DataSet_Company.mCompany_ActiveListDataTable mCompany_ActiveList(string SRC)
        {
            DAL.Company.DataSet_CompanyTableAdapters.mCompany_ActiveListTableAdapter adp =
                new DAL.Company.DataSet_CompanyTableAdapters.mCompany_ActiveListTableAdapter();
            return adp.GetData(SRC);
        }
        public DAL.Company.DataSet_Company.mCompany_CustomerDataTable mCompany_Customer(string SRC)
        {
            DAL.Company.DataSet_CompanyTableAdapters.mCompany_CustomerTableAdapter adp =
                new DAL.Company.DataSet_CompanyTableAdapters.mCompany_CustomerTableAdapter();
            return adp.GetData(SRC);
        }
        public DAL.Company.DataSet_Company.mCompanyDataTable mCompany(string SRC)
        {
            DAL.Company.DataSet_CompanyTableAdapters.mCompanyTableAdapter adp =
                new DAL.Company.DataSet_CompanyTableAdapters.mCompanyTableAdapter();
            return adp.GetData(SRC);
        }
        public string UdCompany(DAL.Company.DataSet_Company.mCompanyDataTable dt)
        {
            try
            {
                DAL.Company.DataSet_CompanyTableAdapters.mCompanyTableAdapter adp =
                    new DAL.Company.DataSet_CompanyTableAdapters.mCompanyTableAdapter();
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
