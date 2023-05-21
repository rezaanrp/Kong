using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Renovation
{
  public  class csRenovationN
    {
        
        public DAL.Renovation.DataSet_RenovationN.mRenovationFloorDataTable mRenovationFloor(int? xRenovation_)
        {
            DAL.Renovation.DataSet_RenovationNTableAdapters.mRenovationFloorTableAdapter adp =
               new DAL.Renovation.DataSet_RenovationNTableAdapters.mRenovationFloorTableAdapter();
            return adp.GetData(xRenovation_);
        }
        public string UdRenovationFloor(DAL.Renovation.DataSet_RenovationN.mRenovationFloorDataTable dt)
        {
            try
            {
                DAL.Renovation.DataSet_RenovationNTableAdapters.mRenovationFloorTableAdapter adp =
                   new DAL.Renovation.DataSet_RenovationNTableAdapters.mRenovationFloorTableAdapter();
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
