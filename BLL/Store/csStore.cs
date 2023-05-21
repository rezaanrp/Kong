using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Store
{
  public  class csStore
    {
        public DAL.Store.DataSet_Store.SlStoreBillTaxDataTable SlStoreBillTax(int id)
        {
            DAL.Store.DataSet_StoreTableAdapters.SlStoreBillTaxTableAdapter adp =
               new DAL.Store.DataSet_StoreTableAdapters.SlStoreBillTaxTableAdapter();
            return adp.GetData(id);
        }
        public DAL.Store.DataSet_Store.SlStoreBillDataTable SlStoreBill(int x_)
        {
            DAL.Store.DataSet_StoreTableAdapters.SlStoreBillTableAdapter adp =
               new DAL.Store.DataSet_StoreTableAdapters.SlStoreBillTableAdapter();
            return adp.GetData(x_);
        }
        public DAL.Store.DataSet_Store.mStore_By_x_DataTable mStore_By_x_(int x_)
        {
            DAL.Store.DataSet_StoreTableAdapters.mStore_By_x_TableAdapter adp =
               new DAL.Store.DataSet_StoreTableAdapters.mStore_By_x_TableAdapter();
            return adp.GetData(x_);
        }
        public string UdStore_By_x_(DAL.Store.DataSet_Store.mStore_By_x_DataTable dt)
        {
            try
            {
                DAL.Store.DataSet_StoreTableAdapters.mStore_By_x_TableAdapter adp =
                   new DAL.Store.DataSet_StoreTableAdapters.mStore_By_x_TableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
        public DAL.Store.DataSet_Store.mStoreDataTable mStore(string DateFrom, string DateTo)
        {
            DAL.Store.DataSet_StoreTableAdapters.mStoreTableAdapter adp =
               new DAL.Store.DataSet_StoreTableAdapters.mStoreTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }
        public string UdStore(DAL.Store.DataSet_Store.mStoreDataTable dt)
        {
            try
            {
                DAL.Store.DataSet_StoreTableAdapters.mStoreTableAdapter adp =
                   new DAL.Store.DataSet_StoreTableAdapters.mStoreTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        public DAL.Store.DataSet_Store.mStoreDetialsDataTable mStoreDetials(int xStore_)
        {
            DAL.Store.DataSet_StoreTableAdapters.mStoreDetialsTableAdapter adp =
               new DAL.Store.DataSet_StoreTableAdapters.mStoreDetialsTableAdapter();
            return adp.GetData(xStore_);
        }
        public string UdStoreDetials(DAL.Store.DataSet_Store.mStoreDetialsDataTable dt)
        {
            try
            {
                DAL.Store.DataSet_StoreTableAdapters.mStoreDetialsTableAdapter adp =
                   new DAL.Store.DataSet_StoreTableAdapters.mStoreDetialsTableAdapter();
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
