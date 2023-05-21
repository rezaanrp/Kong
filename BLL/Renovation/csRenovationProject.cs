using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Renovation
{
  public  class csRenovationProject
    {

        public DAL.Renovation.DataSet_RenovationProject.mRenovationProjectDataTable mRenovationProject(int? xRenovation_)
        {
            DAL.Renovation.DataSet_RenovationProjectTableAdapters.mRenovationProjectTableAdapter adp =
               new DAL.Renovation.DataSet_RenovationProjectTableAdapters.mRenovationProjectTableAdapter();
            return adp.GetData(xRenovation_);
        }
        public string UdRenovationProject(DAL.Renovation.DataSet_RenovationProject.mRenovationProjectDataTable dt)
        {
            try
            {
                DAL.Renovation.DataSet_RenovationProjectTableAdapters.mRenovationProjectTableAdapter adp =
                   new DAL.Renovation.DataSet_RenovationProjectTableAdapters.mRenovationProjectTableAdapter();
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
