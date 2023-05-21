using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.GoodsAndSupplierInfo
{
 public   class csGoodsAndSupplierInfo
    {
        public DAL.GoodsAndSupplierInfo.DataSet_GoodsAndSupplierInfo.mGoodsAndSupplierInfoDataTable mGoodsAndSupplierInfo(int xCompany_)
        {
            DAL.GoodsAndSupplierInfo.DataSet_GoodsAndSupplierInfoTableAdapters.mGoodsAndSupplierInfoTableAdapter adp =
               new DAL.GoodsAndSupplierInfo.DataSet_GoodsAndSupplierInfoTableAdapters.mGoodsAndSupplierInfoTableAdapter();
            return adp.GetData(xCompany_);
        }
        public string UdGoodsAndSupplierInfo(DAL.GoodsAndSupplierInfo.DataSet_GoodsAndSupplierInfo.mGoodsAndSupplierInfoDataTable dt)
        {
            try
            {
                DAL.GoodsAndSupplierInfo.DataSet_GoodsAndSupplierInfoTableAdapters.mGoodsAndSupplierInfoTableAdapter adp =
                   new DAL.GoodsAndSupplierInfo.DataSet_GoodsAndSupplierInfoTableAdapters.mGoodsAndSupplierInfoTableAdapter();
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
