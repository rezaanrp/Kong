using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Goods
{
   public class csGoods
    {
        public DAL.Goods.DataSet_Goods.mGoodsDataTable mGoods(string Src)
        {
            DAL.Goods.DataSet_GoodsTableAdapters.mGoodsTableAdapter adp =
               new DAL.Goods.DataSet_GoodsTableAdapters.mGoodsTableAdapter();
            return adp.GetData(Src);
        }
        public string UdGoods(DAL.Goods.DataSet_Goods.mGoodsDataTable dt)
        {
            try
            {
                DAL.Goods.DataSet_GoodsTableAdapters.mGoodsTableAdapter adp =
                   new DAL.Goods.DataSet_GoodsTableAdapters.mGoodsTableAdapter();
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
