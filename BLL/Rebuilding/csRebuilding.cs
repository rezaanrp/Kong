using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Rebuilding
{
    public class csRebuilding
    {
        public string UdRebuildingByx_(DAL.Rebuilding.DataSet_Rebuilding.mRebuilding_Byx_DataTable dt)
        {
            try
            {
                DAL.Rebuilding.DataSet_RebuildingTableAdapters.mRebuilding_Byx_TableAdapter adp =
                   new DAL.Rebuilding.DataSet_RebuildingTableAdapters.mRebuilding_Byx_TableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
        public DAL.Rebuilding.DataSet_Rebuilding.SlRebuilding_Byx_DataTable SlRebuildingByx_(int x_)
        {
            DAL.Rebuilding.DataSet_RebuildingTableAdapters.SlRebuilding_Byx_TableAdapter adp =
               new DAL.Rebuilding.DataSet_RebuildingTableAdapters.SlRebuilding_Byx_TableAdapter();
            return adp.GetData(x_);
        }
        public DAL.Rebuilding.DataSet_Rebuilding.mRebuilding_Byx_DataTable mRebuildingByx_(int x_)
        {
            DAL.Rebuilding.DataSet_RebuildingTableAdapters.mRebuilding_Byx_TableAdapter adp =
               new DAL.Rebuilding.DataSet_RebuildingTableAdapters.mRebuilding_Byx_TableAdapter();
            return adp.GetData(x_);
        }

        public string InRebuildingAll(string xDate,
                        int? xCustomer_,
                        int? xGenUsageType_,
                        int? xBuldingStatus_,
                        int? xArea,
                        string xZone,
                        string xAddress,
                        int? xGenPosition_,
                        int? xlength,
                        int? xWidth,
                        int? xGenContractType_,
                        bool xLicenseRebuilding,
                        string xLicenseRebuildingComment,
                        bool xProductionLicense,
                        string xProductionLicenseComment,
                        int? xBuildingUnitsNumber,
                        int? xFloorsNumber,
                        int? xBuildingUnitsNumberRequest,
                        int? xUnitID,
                        int? xUnitArea,
                        int? xAreaRebuilding,
                        string xBuildingYear,
                        int? xBedroomsNumber,
                        int? xBedroomsNumber_Ch,
                        int? xBathroomNumber,
                        int? xBathroomNumber_Ch,
                        int? xToiletNumber,
                        int? xToiletNumber_Ch,
                        int? xGenRoof_,
                        int? xGenRoof_Ch_,
                        int? xGenBuildingSkeleton_,
                        int? xGenBuildingSkeleton_Ch_,
                        int? xGenFoundation_,
                        int? xGenFoundation_Ch_,
                        int? xGenWall_,
                        int? xGenWall_Ch_,
                        int? xGenWaterPiping_,
                        int? xGenWaterPiping_Ch_,
                        int? xGenGasPiping_,
                        int? xGenGasPiping_Ch_,
                        int? xGenCoolingSystem_,
                        int? xGenCoolingSystem_Ch_,
                        int? xGenHeatingSystem_,
                        int? xGenHeatingSystem_Ch_,
                        int? xGenFlooring_,
                        int? xGenFlooring_Ch_,
                        int? xGenKitchenWall_,
                        int? xGenKitchenWall_Ch_,
                        int? xGenKitchenFloor_,
                        int? xGenKitchenFloor_Ch_,
                        int? xGenKitchenCupboards_,
                        int? xGenKitchenCupboards_Ch_,
                        int? xGenBathroomPiping_,
                        int? xGenBathroomPiping_Ch_,
                        bool xBathtub,
                        bool xBathtub_Ch,
                        bool xBathTile,
                        bool xBathTile_Ch,
                        int? xGenReasonsRebuilding_,
                        int? xSupplier_)
        {
            DAL.Rebuilding.DataSet_RebuildingTableAdapters.QueriesTableAdapter adp =
               new DAL.Rebuilding.DataSet_RebuildingTableAdapters.QueriesTableAdapter();
            adp.InRebuildingAll(xDate,
                        xCustomer_,
                        xGenUsageType_,
                        xBuldingStatus_,
                        xArea,
                        xZone,
                        xAddress,
                        xGenPosition_,
                        xlength,
                        xWidth,
                        xGenContractType_,
                        xLicenseRebuilding,
                        xLicenseRebuildingComment,
                        xProductionLicense,
                        xProductionLicenseComment,
                        xBuildingUnitsNumber,
                        xFloorsNumber,
                        xBuildingUnitsNumberRequest,
                        xUnitID,
                        xUnitArea,
                        xAreaRebuilding,
                        xBuildingYear,
                        xBedroomsNumber,
                        xBedroomsNumber_Ch,
                        xBathroomNumber,
                        xBathroomNumber_Ch,
                        xToiletNumber,
                        xToiletNumber_Ch,
                        xGenRoof_,
                        xGenRoof_Ch_,
                        xGenBuildingSkeleton_,
                        xGenBuildingSkeleton_Ch_,
                        xGenFoundation_,
                        xGenFoundation_Ch_,
                        xGenWall_,
                        xGenWall_Ch_,
                        xGenWaterPiping_,
                        xGenWaterPiping_Ch_,
                        xGenGasPiping_,
                        xGenGasPiping_Ch_,
                        xGenCoolingSystem_,
                        xGenCoolingSystem_Ch_,
                        xGenHeatingSystem_,
                        xGenHeatingSystem_Ch_,
                        xGenFlooring_,
                        xGenFlooring_Ch_,
                        xGenKitchenWall_,
                        xGenKitchenWall_Ch_,
                        xGenKitchenFloor_,
                        xGenKitchenFloor_Ch_,
                        xGenKitchenCupboards_,
                        xGenKitchenCupboards_Ch_,
                        xGenBathroomPiping_,
                        xGenBathroomPiping_Ch_,
                        xBathtub,
                        xBathtub_Ch,
                        xBathTile,
                        xBathTile_Ch,
                        xGenReasonsRebuilding_,
                        xSupplier_);
            return "";
        }



        public string InRebuilding(string xDate,
                        int? xCustomer_,
                        int? xGenUsageType_,
                        int? xBuldingStatus_,
                        int? xArea,
                        string xZone,
                        string xAddress,
                        int? xGenPosition_,
                        int? xlength,
                        int? xWidth,
                        int? xGenContractType_,
                        bool xLicenseRebuilding,
                        string xLicenseRebuildingComment,
                        bool xProductionLicense,
                        string xProductionLicenseComment,
                        int? xBuildingUnitsNumber,
                        int? xFloorsNumber,
                        int? xBuildingUnitsNumberRequest,
                        int? xUnitID,
                        int? xUnitArea,
                        int? xAreaRebuilding,
                        string xBuildingYear,
                        int? xBedroomsNumber,
                        int? xBathroomNumber,
                        int? xToiletNumber,
                        int? xGenRoof_,
                        int? xGenBuildingSkeleton_,
                        int? xGenFoundation_,
                        int? xGenWall_,
                        int? xGenWaterPiping_,
                        int? xGenGasPiping_,
                        int? xGenCoolingSystem_,
                        int? xGenHeatingSystem_,
                        int? xGenFlooring_,
                        int? xGenKitchenWall_,
                        int? xGenKitchenFloor_,
                        int? xGenKitchenCupboards_,
                        int? xGenBathroomPiping_,
                        bool xBathtub,
                        bool xBathTile,
                        int? xGenReasonsRebuilding_,
                        int? xSupplier_)
        {
            DAL.Rebuilding.DataSet_RebuildingTableAdapters.QueriesTableAdapter adp =
               new DAL.Rebuilding.DataSet_RebuildingTableAdapters.QueriesTableAdapter();
            adp.InRebuilding(xDate,
                        xCustomer_,
                        xGenUsageType_,
                        xBuldingStatus_,
                        xArea,
                        xZone,
                        xAddress,
                        xGenPosition_,
                        xlength,
                        xWidth,
                        xGenContractType_,
                        xLicenseRebuilding,
                        xLicenseRebuildingComment,
                        xProductionLicense,
                        xProductionLicenseComment,
                        xBuildingUnitsNumber,
                        xFloorsNumber,
                        xBuildingUnitsNumberRequest,
                        xUnitID,
                        xUnitArea,
                        xAreaRebuilding,
                        xBuildingYear,
                        xBedroomsNumber,
                        xBathroomNumber,
                        xToiletNumber,
                        xGenRoof_,
                        xGenBuildingSkeleton_,
                        xGenFoundation_,
                        xGenWall_,
                        xGenWaterPiping_,
                        xGenGasPiping_,
                        xGenCoolingSystem_,
                        xGenHeatingSystem_,
                        xGenFlooring_,
                        xGenKitchenWall_,
                        xGenKitchenFloor_,
                        xGenKitchenCupboards_,
                        xGenBathroomPiping_,
                        xBathtub,
                        xBathTile,
                        xGenReasonsRebuilding_,
                        xSupplier_);
            return "";
        }
        public DAL.Rebuilding.DataSet_Rebuilding.mRebuildingDataTable mRebuilding(int xCustomer_)
        {
            DAL.Rebuilding.DataSet_RebuildingTableAdapters.mRebuildingTableAdapter adp =
               new DAL.Rebuilding.DataSet_RebuildingTableAdapters.mRebuildingTableAdapter();
            return adp.GetData(xCustomer_);
        }
        public string UdRebuilding(DAL.Rebuilding.DataSet_Rebuilding.mRebuildingDataTable dt)
        {
            try
            {
                DAL.Rebuilding.DataSet_RebuildingTableAdapters.mRebuildingTableAdapter adp =
                   new DAL.Rebuilding.DataSet_RebuildingTableAdapters.mRebuildingTableAdapter();
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
