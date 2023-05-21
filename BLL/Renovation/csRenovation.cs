using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Renovation
{
  public  class csRenovation
    {
        public DAL.Renovation.DataSet_Renovation.mRenovationUnit_Byx_DataTable mRenovationUnit_Byx_(int x_)
        {
            DAL.Renovation.DataSet_RenovationTableAdapters.mRenovationUnit_Byx_TableAdapter adp =
               new DAL.Renovation.DataSet_RenovationTableAdapters.mRenovationUnit_Byx_TableAdapter();
            return adp.GetData(x_);
        }
        public string UdRenovationUnit_Byx_(DAL.Renovation.DataSet_Renovation.mRenovationUnit_Byx_DataTable dt)
        {
            try
            {
                DAL.Renovation.DataSet_RenovationTableAdapters.mRenovationUnit_Byx_TableAdapter adp =
                   new DAL.Renovation.DataSet_RenovationTableAdapters.mRenovationUnit_Byx_TableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
        public DAL.Renovation.DataSet_Renovation.mRenovationUnitDataTable mRenovationUnit(int? xRenovation_)
        {
            DAL.Renovation.DataSet_RenovationTableAdapters.mRenovationUnitTableAdapter adp =
               new DAL.Renovation.DataSet_RenovationTableAdapters.mRenovationUnitTableAdapter();
            return adp.GetData(xRenovation_);
        }
        public string UdxRenovationUnit_(DAL.Renovation.DataSet_Renovation.mRenovationUnitDataTable dt)
        {
            try
            {
                DAL.Renovation.DataSet_RenovationTableAdapters.mRenovationUnitTableAdapter adp =
                   new DAL.Renovation.DataSet_RenovationTableAdapters.mRenovationUnitTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
        public string UdRenovationByx_(DAL.Renovation.DataSet_Renovation.mRenovation_Byx_DataTable dt)
        {
            try
            {
                DAL.Renovation.DataSet_RenovationTableAdapters.mRenovation_Byx_TableAdapter adp =
                   new DAL.Renovation.DataSet_RenovationTableAdapters.mRenovation_Byx_TableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
        public DAL.Renovation.DataSet_Renovation.SlRenovation_Byx_DataTable SlRenovationByx_(int x_)
        {
            DAL.Renovation.DataSet_RenovationTableAdapters.SlRenovation_Byx_TableAdapter adp =
               new DAL.Renovation.DataSet_RenovationTableAdapters.SlRenovation_Byx_TableAdapter();
            return adp.GetData(x_);
        }
        public DAL.Renovation.DataSet_Renovation.mRenovation_Byx_DataTable mRenovationByx_(int x_)
        {
            DAL.Renovation.DataSet_RenovationTableAdapters.mRenovation_Byx_TableAdapter adp =
               new DAL.Renovation.DataSet_RenovationTableAdapters.mRenovation_Byx_TableAdapter();
            return adp.GetData(x_);
        }

        //public string InRenovationAll(string xDate ,
        //              int xCustomer_  ,
        //              int xGenUsageType_  ,
        //              int xBuldingStatus_ ,
        //                int xArea ,
        //              int xZone , 
        //              string xAddress ,
        //              int xGenPosition_ ,
        //              int xlength ,
        //              int xWidth ,
        //              int xGenContractType_ , 
        //              bool xProductionLicense ,
        //              string xProductionLicenseComment ,
        //              int xFloorsNumber ,
        //              int xBuildingUnitsNumberRequest ,
        //              int xParkingNumber ,
        //              int xStorageNumber ,
        //              int xSupplier_ )
        //{
        //    DAL.Renovation.DataSet_RenovationTableAdapters.QueriesTableAdapter adp =
        //       new DAL.Renovation.DataSet_RenovationTableAdapters.QueriesTableAdapter();
        //    adp.InRenovationAll(
        //        xDate,
        //              xCustomer_,
        //              xGenUsageType_,
        //              xBuldingStatus_,
        //              xArea,
        //              xZone,
        //              xAddress,
        //              xGenPosition_,
        //              xlength,
        //              xWidth,
        //              xGenContractType_,
        //              xProductionLicense,
        //              xProductionLicenseComment,
        //              xFloorsNumber,
        //              xBuildingUnitsNumberRequest,
        //              xParkingNumber,
        //              xStorageNumber,
        //              xSupplier_
        //        );
        //    return "";
        //}



        public string InRenovation(string xDate,
                      int? xCustomer_,
                      int? xGenUsageType_,
                      int? xBuldingStatus_,
                      int? xArea,
                      string xZone,
                      string xAddress,
                      int? xGenPosition_,
                      int? xlength,
                      int? xWidth,
                      int? xGenContractType_, bool xLicenseRenovation, string xLicenseRenovationComment,
                      bool xProductionLicense,
                      string xProductionLicenseComment,
                      int? xFloorsNumber,
                      int? xBuildingUnitsNumberRequest,
                      int? xParkingNumber,
                      int? xStorageNumber,
                      string xComment,
                      int? xSupplier_)
        {
            DAL.Renovation.DataSet_RenovationTableAdapters.QueriesTableAdapter adp =
               new DAL.Renovation.DataSet_RenovationTableAdapters.QueriesTableAdapter();
            adp.InRenovation( xDate,
                       xCustomer_,
                       xGenUsageType_,
                       xBuldingStatus_,
                         xArea,
                       xZone,
                       xAddress,
                       xGenPosition_,
                       xlength,
                       xWidth,
                       xGenContractType_, xLicenseRenovation, xLicenseRenovationComment,
                       xProductionLicense,
                       xProductionLicenseComment,
                       xFloorsNumber,
                       xBuildingUnitsNumberRequest,
                       xParkingNumber,
                       xStorageNumber,xComment,
                       xSupplier_);
            return "";
        }
        public DAL.Renovation.DataSet_Renovation.mRenovationDataTable mRenovation(int xCustomer_)
        {
            DAL.Renovation.DataSet_RenovationTableAdapters.mRenovationTableAdapter adp =
               new DAL.Renovation.DataSet_RenovationTableAdapters.mRenovationTableAdapter();
            return adp.GetData(xCustomer_);
        }
        public string UdRenovation(DAL.Renovation.DataSet_Renovation.mRenovationDataTable dt)
        {
            try
            {
                DAL.Renovation.DataSet_RenovationTableAdapters.mRenovationTableAdapter adp =
                   new DAL.Renovation.DataSet_RenovationTableAdapters.mRenovationTableAdapter();
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
