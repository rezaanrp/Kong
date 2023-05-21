using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Customer
{
    public class csCustomer
    {

        //public string InDelCustomerCheckedList(int xCustomer_, string xType_, int xGen_, bool checked_)
        //{
        //    try
        //    {
        //        DAL.Customer.DataSet_CustomerTableAdapters.QueriesTableAdapter adp =
        //       new DAL.Customer.DataSet_CustomerTableAdapters.QueriesTableAdapter();
        //        adp.InDelCustomerCheckedList(xCustomer_, xType_, xGen_, checked_);
        //        return "عملیات ذخیره سازی با موفقیت انجام شد";
        //    }
        //    catch (Exception e)
        //    {
        //        return e.Message;
        //    }
        //}
        //public DAL.Customer.DataSet_Customer.SlCustomerCheckedListDataTable SlCustomerCheckedList(int x_, string Type_)
        //{
        //    DAL.Customer.DataSet_CustomerTableAdapters.SlCustomerCheckedListTableAdapter adp =
        //       new DAL.Customer.DataSet_CustomerTableAdapters.SlCustomerCheckedListTableAdapter();
        //    return adp.GetData(Type_, x_);
        //}
        public DAL.Customer.DataSet_Customer.SlCustomerOpenProjectDataTable SlCustomerOpenProject()
        {
            DAL.Customer.DataSet_CustomerTableAdapters.SlCustomerOpenProjectTableAdapter adp =
               new DAL.Customer.DataSet_CustomerTableAdapters.SlCustomerOpenProjectTableAdapter();
            return adp.GetData();
        }
        public DAL.Customer.DataSet_Customer.mCustomerCheckedListDataTable mCustomerCheckedList(int x_, string Type_)
        {
            DAL.Customer.DataSet_CustomerTableAdapters.mCustomerCheckedListTableAdapter adp =
               new DAL.Customer.DataSet_CustomerTableAdapters.mCustomerCheckedListTableAdapter();
            return adp.GetData(x_, Type_);
        }
        public string UdCustomerCheckedList(DAL.Customer.DataSet_Customer.mCustomerCheckedListDataTable dt)
        {
            try
            {
                DAL.Customer.DataSet_CustomerTableAdapters.mCustomerCheckedListTableAdapter adp =
                      new DAL.Customer.DataSet_CustomerTableAdapters.mCustomerCheckedListTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public DAL.Customer.DataSet_Customer.mCustomer_Byx_DataTable mCustomer_Byx_(int x_)
        {
            DAL.Customer.DataSet_CustomerTableAdapters.mCustomer_Byx_TableAdapter adp =
               new DAL.Customer.DataSet_CustomerTableAdapters.mCustomer_Byx_TableAdapter();
            return adp.GetData(x_);
        }
        public string UdCustomer_Byx_(DAL.Customer.DataSet_Customer.mCustomer_Byx_DataTable dt)
        {
            try
            {
                DAL.Customer.DataSet_CustomerTableAdapters.mCustomer_Byx_TableAdapter adp =
                      new DAL.Customer.DataSet_CustomerTableAdapters.mCustomer_Byx_TableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }


        public DAL.Customer.DataSet_Customer.mCustomer_ComboBoxDataTable mCustomer_ComboBox( )
        {
            DAL.Customer.DataSet_CustomerTableAdapters.mCustomer_ComboBoxTableAdapter adp =
               new DAL.Customer.DataSet_CustomerTableAdapters.mCustomer_ComboBoxTableAdapter();
            return adp.GetData();
        }
        public DAL.Customer.DataSet_Customer.mCustomer_SrchDataTable mCustomer_Srch(string Srch)
        {
            DAL.Customer.DataSet_CustomerTableAdapters.mCustomer_SrchTableAdapter adp =
               new DAL.Customer.DataSet_CustomerTableAdapters.mCustomer_SrchTableAdapter();
            return adp.GetData(Srch);
        }


        public string UdCustomer_Srch(DAL.Customer.DataSet_Customer.mCustomer_SrchDataTable dt)
        {
            try
            {
                DAL.Customer.DataSet_CustomerTableAdapters.mCustomer_SrchTableAdapter adp =
                      new DAL.Customer.DataSet_CustomerTableAdapters.mCustomer_SrchTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public DAL.Customer.DataSet_Customer.mCustomerDataTable mCustomer()
        {
            DAL.Customer.DataSet_CustomerTableAdapters.mCustomerTableAdapter adp =
               new DAL.Customer.DataSet_CustomerTableAdapters.mCustomerTableAdapter();
            return adp.GetData();
        }
        public string UdCustomer(DAL.Customer.DataSet_Customer.mCustomerDataTable dt)
        {
            try
            {
                DAL.Customer.DataSet_CustomerTableAdapters.mCustomerTableAdapter adp =
                      new DAL.Customer.DataSet_CustomerTableAdapters.mCustomerTableAdapter();
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
