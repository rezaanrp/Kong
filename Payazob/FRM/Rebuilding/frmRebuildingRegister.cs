using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MIS.FRM.Rebuilding
{
    public partial class frmRebuildingRegister : Form
    {
        public frmRebuildingRegister(int xCustomer_, int x_, CS.csEnum.RebuildingUser TypeUser)
        {
            TypeUser_ = TypeUser;

            InitializeComponent();
            Cust = xCustomer_;
            x = x_;
            CmbGiveValue();
            if (x_ > 0)
            {
                SetValueForm(x_);
            }
            if (TypeUser_ == CS.csEnum.RebuildingUser.Master)
            {
                GenDatatableForCorrespondence();

                ((Control)this.tabPage2).Enabled = false;
                ((Control)this.tabPage1).Enabled = false;
                panel_Pub.Enabled = false;
                tbc_01.SelectedTab = tabPage3;
            }
            else
            {
                ((Control)this.tabPage3).Enabled = false;
                ((Control)this.tabPage4).Enabled = false;
            }
        }
        CS.csEnum.RebuildingUser TypeUser_;
        DAL.Rebuilding.DataSet_Rebuilding.mRebuilding_Byx_DataTable dt_R;
        DAL.Rebuilding.DataSet_Rebuilding.SlRebuilding_Byx_DataTable dt_RR;
        DAL.Rebuilding.DataSet_Rebuilding.mRebuilding_Byx_DataTable dt_SS;
        void GenDatatableForCorrespondence()
        {
            dt_RR = new BLL.Rebuilding.csRebuilding().SlRebuildingByx_(x);
            dt_SS = new BLL.Rebuilding.csRebuilding().mRebuildingByx_(x);
            DataTable MyTable = new DataTable();

            MyTable.Columns.Add("Item1", typeof(string));
            MyTable.Columns.Add("CustomerComments", typeof(string));
            MyTable.Columns.Add("correspondence", typeof(bool));
            MyTable.Columns.Add("CustomerRequest", typeof(string));
            MyTable.Columns.Add("Accept", typeof(bool));
            MyTable.Columns.Add("MasterComments", typeof(string));

            MyTable.Rows.Add("تعداد اتاق خواب ", dt_RR[0]["xBedroomsNumber"].ToString(), false, dt_RR[0]["xBedroomsNumber_Ch"].ToString(), false, "");
            MyTable.Rows.Add("تعداد حمام ", dt_RR[0]["xBathroomNumber"].ToString(), false, dt_RR[0]["xBathroomNumber_Ch"].ToString(), false, "");
            MyTable.Rows.Add("تعداد دستشویی ", dt_RR[0]["xToiletNumber"].ToString(), false, dt_RR[0]["xToiletNumber_Ch"].ToString(), false, "");
            MyTable.Rows.Add("سقف", dt_RR[0]["xGenRoof_"].ToString(), false, dt_RR[0]["xGenRoof_Ch_"].ToString(), false, "");
            MyTable.Rows.Add("اسکلت ساختمان ", dt_RR[0]["xGenBuildingSkeleton_"].ToString(), false, dt_RR[0]["xGenBuildingSkeleton_Ch_"].ToString(), false, "");
            MyTable.Rows.Add("فنداسیون ", dt_RR[0]["xGenFoundation_"].ToString(), false, dt_RR[0]["xGenFoundation_Ch_"].ToString(), false, "");
            MyTable.Rows.Add("دیوار", dt_RR[0]["xGenWall_"].ToString(), false, dt_RR[0]["xGenWall_Ch_"].ToString(), false, "");
            MyTable.Rows.Add("لوله کشی آب", dt_RR[0]["xGenWaterPiping_"].ToString(), false, dt_RR[0]["xGenWaterPiping_Ch_"].ToString(), false, "");
            MyTable.Rows.Add("لوله کشی گاز", dt_RR[0]["xGenGasPiping_"].ToString(), false, dt_RR[0]["xGenGasPiping_Ch_"].ToString(), false, "");
            MyTable.Rows.Add("سیستم سرمایش ", dt_RR[0]["xGenCoolingSystem_"].ToString(), false, dt_RR[0]["xGenCoolingSystem_Ch_"].ToString(), false, "");
            MyTable.Rows.Add("سیستم گرمایش ", dt_RR[0]["xGenHeatingSystem_"].ToString(), false, dt_RR[0]["xGenHeatingSystem_Ch_"].ToString(), false, "");
            MyTable.Rows.Add("کف", dt_RR[0]["xGenFlooring_"].ToString(), false, dt_RR[0]["xGenFlooring_Ch_"].ToString(), false, "");
            MyTable.Rows.Add("دیوار آشپزخانه", dt_RR[0]["xGenKitchenWall_"].ToString(), false, dt_RR[0]["xGenKitchenWall_Ch_"].ToString(), false, "");
            MyTable.Rows.Add("کف آشپرخانه", dt_RR[0]["xGenKitchenFloor_"].ToString(), false, dt_RR[0]["xGenKitchenFloor_Ch_"].ToString(), false, "");
            MyTable.Rows.Add("کابینت آشپزخانه", dt_RR[0]["xGenKitchenCupboards_"].ToString(), false, dt_RR[0]["xGenKitchenCupboards_Ch_"].ToString(), false, "");
            MyTable.Rows.Add("لوله کشی حمام", dt_RR[0]["xGenBathroomPiping_"].ToString(), false, dt_RR[0]["xGenBathroomPiping_Ch_"].ToString(), false, "");
            MyTable.Rows.Add("وان حمام", dt_RR[0]["xBathtub"].ToString(), false, dt_RR[0]["xBathtub_Ch"].ToString(), false, "");
            MyTable.Rows.Add("کاشی حمام", dt_RR[0]["xBathTile"].ToString(), false, dt_RR[0]["xBathTile_Ch"].ToString(), false, "");

            dataGridView_CHK.DataSource = MyTable;

            dataGridView_CHK.Columns["Item1"].HeaderText = "مورد";
            dataGridView_CHK.Columns["CustomerComments"].HeaderText = "اظهارات مشتری";
            dataGridView_CHK.Columns["correspondence"].HeaderText = "مطابقت";
            dataGridView_CHK.Columns["CustomerRequest"].HeaderText = "درخواست مشتری";
            dataGridView_CHK.Columns["Accept"].HeaderText = "تایید کارشناس";
            dataGridView_CHK.Columns["MasterComments"].HeaderText = "نظر کارشناس";

            dataGridView_CHK.Columns["Item1"].ReadOnly = true;
            dataGridView_CHK.Columns["CustomerComments"].ReadOnly = true;
            dataGridView_CHK.Columns["correspondence"].HeaderText = "مطابقت";
            dataGridView_CHK.Columns["CustomerRequest"].ReadOnly = true;
            dataGridView_CHK.Columns["Accept"].HeaderText = "تایید کارشناس";
            dataGridView_CHK.Columns["MasterComments"].HeaderText = "نظر کارشناس";

            dataGridView_CHK.Columns["Item1"].DefaultCellStyle.BackColor = Color.AliceBlue;
            dataGridView_CHK.Columns["CustomerComments"].ReadOnly = true;
            dataGridView_CHK.Columns["correspondence"].DefaultCellStyle.BackColor = Color.Honeydew;
            dataGridView_CHK.Columns["CustomerRequest"].ReadOnly = true;
            dataGridView_CHK.Columns["Accept"].DefaultCellStyle.BackColor = Color.Honeydew;
            dataGridView_CHK.Columns["MasterComments"].DefaultCellStyle.BackColor = Color.Honeydew;

            ShowDataCorrespondence();

        }
        void ShowDataCorrespondence()
        {
            dataGridView_CHK["correspondence", 0].Value = dt_SS[0]["xBedroomsNumber_Crr"];
            dataGridView_CHK["Accept", 0].Value = dt_SS[0]["xBedroomsNumber_CkM"];
            dataGridView_CHK["MasterComments", 0].Value = dt_SS[0]["xBedroomsNumber_Remark"];

            dataGridView_CHK["correspondence", 1].Value = dt_SS[0]["xBathroomNumber_Crr"];
            dataGridView_CHK["Accept", 1].Value = dt_SS[0]["xBathroomNumber_CkM"];
            dataGridView_CHK["MasterComments", 1].Value = dt_SS[0]["xBathroomNumber_Remark"];

            dataGridView_CHK["correspondence", 2].Value = dt_SS[0]["xToiletNumber_Crr"];
            dataGridView_CHK["Accept", 2].Value = dt_SS[0]["xToiletNumber_CkM"];
            dataGridView_CHK["MasterComments", 2].Value = dt_SS[0]["xToiletNumber_Remark"];

            dataGridView_CHK["correspondence", 3].Value = dt_SS[0]["xGenRoof_Crr"];
            dataGridView_CHK["Accept", 3].Value = dt_SS[0]["xGenRoof_CkM"];
            dataGridView_CHK["MasterComments", 3].Value = dt_SS[0]["xGenRoof_Remark"];

            dataGridView_CHK["correspondence", 4].Value = dt_SS[0]["xGenBuildingSkeleton_Crr"];
            dataGridView_CHK["Accept", 4].Value = dt_SS[0]["xGenBuildingSkeleton_CkM"];
            dataGridView_CHK["MasterComments", 4].Value = dt_SS[0]["xGenBuildingSkeleton_Remark"];

            dataGridView_CHK["correspondence", 5].Value = dt_SS[0]["xGenFoundation_Crr"];
            dataGridView_CHK["Accept", 5].Value = dt_SS[0]["xGenFoundation_CkM"];
            dataGridView_CHK["MasterComments", 5].Value = dt_SS[0]["xGenFoundation_Remark"];

            dataGridView_CHK["correspondence", 6].Value = dt_SS[0]["xGenWall_Crr"];
            dataGridView_CHK["Accept", 6].Value = dt_SS[0]["xGenWall_CkM"];
            dataGridView_CHK["MasterComments", 6].Value = dt_SS[0]["xGenWall_Remark"];

            dataGridView_CHK["correspondence", 7].Value = dt_SS[0]["xGenWaterPiping_Crr"];
            dataGridView_CHK["Accept", 7].Value = dt_SS[0]["xGenWaterPiping_CkM"];
            dataGridView_CHK["MasterComments", 7].Value = dt_SS[0]["xGenWaterPiping_Remark"];

            dataGridView_CHK["correspondence", 8].Value = dt_SS[0]["xGenGasPiping_Crr"];
            dataGridView_CHK["Accept", 8].Value = dt_SS[0]["xGenGasPiping_CkM"];
            dataGridView_CHK["MasterComments", 8].Value = dt_SS[0]["xGenGasPiping_Remark"];

            dataGridView_CHK["correspondence", 9].Value = dt_SS[0]["xGenCoolingSystem_Crr"];
            dataGridView_CHK["Accept", 9].Value = dt_SS[0]["xGenCoolingSystem_CkM"];
            dataGridView_CHK["MasterComments", 9].Value = dt_SS[0]["xGenCoolingSystem_Remark"];

            dataGridView_CHK["correspondence", 10].Value = dt_SS[0]["xGenHeatingSystem_Crr"];
            dataGridView_CHK["Accept", 10].Value = dt_SS[0]["xGenHeatingSystem_CkM"];
            dataGridView_CHK["MasterComments", 10].Value = dt_SS[0]["xGenHeatingSystem_Remark"];


            dataGridView_CHK["correspondence", 11].Value = dt_SS[0]["xGenFlooring_Crr"];
            dataGridView_CHK["Accept", 11].Value = dt_SS[0]["xGenFlooring_CkM"];
            dataGridView_CHK["MasterComments", 11].Value = dt_SS[0]["xGenFlooring_Remark"];


            dataGridView_CHK["correspondence", 12].Value = dt_SS[0]["xGenKitchenWall_Crr"];
            dataGridView_CHK["Accept", 12].Value = dt_SS[0]["xGenKitchenWall_CkM"];
            dataGridView_CHK["MasterComments", 12].Value = dt_SS[0]["xGenKitchenWall_Remark"];


            dataGridView_CHK["correspondence", 13].Value = dt_SS[0]["xGenKitchenFloor_Crr"];
            dataGridView_CHK["Accept", 13].Value = dt_SS[0]["xGenKitchenFloor_CkM"];
            dataGridView_CHK["MasterComments", 13].Value = dt_SS[0]["xGenKitchenFloor_Remark"];


            dataGridView_CHK["correspondence", 14].Value = dt_SS[0]["xGenKitchenCupboards_Crr"];
            dataGridView_CHK["Accept", 14].Value = dt_SS[0]["xGenKitchenCupboards_CkM"];
            dataGridView_CHK["MasterComments", 14].Value = dt_SS[0]["xGenKitchenCupboards_Remark"];


            dataGridView_CHK["correspondence", 15].Value = dt_SS[0]["xGenBathroomPiping_Crr"];
            dataGridView_CHK["Accept", 15].Value = dt_SS[0]["xGenBathroomPiping_CkM"];
            dataGridView_CHK["MasterComments", 15].Value = dt_SS[0]["xGenBathroomPiping_Remark"];


            dataGridView_CHK["correspondence", 16].Value = dt_SS[0]["xBathtub_Crr"];
            dataGridView_CHK["Accept", 16].Value = dt_SS[0]["xBathtub_CkM"];
            dataGridView_CHK["MasterComments", 16].Value = dt_SS[0]["xBathtub_Remark"];


            dataGridView_CHK["correspondence", 17].Value = dt_SS[0]["xBathTile_Crr"];
            dataGridView_CHK["Accept", 17].Value = dt_SS[0]["xBathTile_CkM"];
            dataGridView_CHK["MasterComments", 17].Value = dt_SS[0]["xBathTile_Remark"];

            if (dt_SS[0]["xGenAdaptationMap_"] != DBNull.Value)
                cmb_xGenAdaptationMap_.SelectedValue = (int?)dt_SS[0]["xGenAdaptationMap_"];

            if (dt_SS[0]["xGenPrepareCurrentSituationMaps_"] != DBNull.Value)
                cmb_xGenPrepareCurrentSituationMaps_.SelectedValue = (int?)dt_SS[0]["xGenPrepareCurrentSituationMaps_"];

            if (dt_SS[0]["xGenAmountDestruction_"] != DBNull.Value)
                cmb_xGenAmountDestruction_.SelectedValue = (int?)dt_SS[0]["xGenAmountDestruction_"];


            if (dt_SS[0]["xGenTransportDestructionMetod_"] != DBNull.Value)
                cmb_xGenTransportDestructionMetod_.SelectedValue = (int?)dt_SS[0]["xGenTransportDestructionMetod_"];


            if (dt_SS[0]["xGenAccessDestructionMetod_"] != DBNull.Value)
                cmb_xGenAccessDestructionMetod_.SelectedValue = (int?)dt_SS[0]["xGenAccessDestructionMetod_"];

            if (dt_SS[0]["xNeighborUnitCount"] != DBNull.Value)
                this.txt_xNeighborUnitCount.Text = dt_SS[0]["xNeighborUnitCount"].ToString();

            //if (dt_SS[0]["xWeightDestruction"] != DBNull.Value)
            //    this.txt_xWeightDestruction.Text = dt_SS[0]["xWeightDestruction"].ToString();

            if (dt_SS[0]["xNeighborsLivingNumber"] != DBNull.Value)
                this.txt_xNeighborsLivingNumber.Text = dt_SS[0]["xNeighborsLivingNumber"].ToString();

            if (dt_SS[0]["xRiskNeighborsComplaints"] != DBNull.Value)
                this.txt_xRiskNeighborsComplaints.Text = dt_SS[0]["xRiskNeighborsComplaints"].ToString();

            if (dt_SS[0]["xRiskMunicipalityPrevent"] != DBNull.Value)
                this.txt_xRiskMunicipalityPrevent.Text = dt_SS[0]["xRiskMunicipalityPrevent"].ToString();

            if (dt_SS[0]["xRiskForcedDestruction"] != DBNull.Value)
                this.txt_xRiskForcedDestruction.Text = dt_SS[0]["xRiskForcedDestruction"].ToString();

            if (dt_SS[0]["xRiskDamageBuilding"] != DBNull.Value)
                this.txt_xRiskDamageBuilding.Text = dt_SS[0]["xRiskDamageBuilding"].ToString();

            if (dt_SS[0]["xDestructionDurationDay"] != DBNull.Value)
                this.txt_xDestructionDurationDay.Text = dt_SS[0]["xDestructionDurationDay"].ToString();

            if (dt_SS[0]["xDestructionRebuildingDay"] != DBNull.Value)
                this.txt_xDestructionRebuildingDay.Text = dt_SS[0]["xDestructionRebuildingDay"].ToString();

        }
        void SaveDataCorrespondence()
        {
            dt_SS[0]["xBedroomsNumber_Crr"] = dataGridView_CHK["correspondence", 0].Value;
            dt_SS[0]["xBedroomsNumber_CkM"] = dataGridView_CHK["Accept", 0].Value;
            dt_SS[0]["xBedroomsNumber_Remark"] = dataGridView_CHK["MasterComments", 0].Value;

            dt_SS[0]["xBathroomNumber_Crr"] = dataGridView_CHK["correspondence", 1].Value;
            dt_SS[0]["xBathroomNumber_CkM"] = dataGridView_CHK["Accept", 1].Value;
            dt_SS[0]["xBathroomNumber_Remark"] = dataGridView_CHK["MasterComments", 1].Value;

            dt_SS[0]["xToiletNumber_Crr"] = dataGridView_CHK["correspondence", 2].Value;
            dt_SS[0]["xToiletNumber_CkM"] = dataGridView_CHK["Accept", 2].Value;
            dt_SS[0]["xToiletNumber_Remark"] = dataGridView_CHK["MasterComments", 2].Value;

            dt_SS[0]["xGenRoof_Crr"] = dataGridView_CHK["correspondence", 3].Value;
            dt_SS[0]["xGenRoof_CkM"] = dataGridView_CHK["Accept", 3].Value;
            dt_SS[0]["xGenRoof_Remark"] = dataGridView_CHK["MasterComments", 3].Value;

            dt_SS[0]["xGenBuildingSkeleton_Crr"] = dataGridView_CHK["correspondence", 4].Value;
            dt_SS[0]["xGenBuildingSkeleton_CkM"] = dataGridView_CHK["Accept", 4].Value;
            dt_SS[0]["xGenBuildingSkeleton_Remark"] = dataGridView_CHK["MasterComments", 4].Value;

            dt_SS[0]["xGenFoundation_Crr"] = dataGridView_CHK["correspondence", 5].Value;
            dt_SS[0]["xGenFoundation_CkM"] = dataGridView_CHK["Accept", 5].Value;
            dt_SS[0]["xGenFoundation_Remark"] = dataGridView_CHK["MasterComments", 5].Value;

            dt_SS[0]["xGenWall_Crr"] = dataGridView_CHK["correspondence", 6].Value;
            dt_SS[0]["xGenWall_CkM"] = dataGridView_CHK["Accept", 6].Value;
            dt_SS[0]["xGenWall_Remark"] = dataGridView_CHK["MasterComments", 6].Value;

            dt_SS[0]["xGenWaterPiping_Crr"] = dataGridView_CHK["correspondence", 7].Value;
            dt_SS[0]["xGenWaterPiping_CkM"] = dataGridView_CHK["Accept", 7].Value;
            dt_SS[0]["xGenWaterPiping_Remark"] = dataGridView_CHK["MasterComments", 7].Value;

            dt_SS[0]["xGenGasPiping_Crr"] = dataGridView_CHK["correspondence", 8].Value;
            dt_SS[0]["xGenGasPiping_CkM"] = dataGridView_CHK["Accept", 8].Value;
            dt_SS[0]["xGenGasPiping_Remark"] = dataGridView_CHK["MasterComments", 8].Value;

            dt_SS[0]["xGenCoolingSystem_Crr"] = dataGridView_CHK["correspondence", 9].Value;
            dt_SS[0]["xGenCoolingSystem_CkM"] = dataGridView_CHK["Accept", 9].Value;
            dt_SS[0]["xGenCoolingSystem_Remark"] = dataGridView_CHK["MasterComments", 9].Value;

            dt_SS[0]["xGenHeatingSystem_Crr"] = dataGridView_CHK["correspondence", 10].Value;
            dt_SS[0]["xGenHeatingSystem_CkM"] = dataGridView_CHK["Accept", 10].Value;
            dt_SS[0]["xGenHeatingSystem_Remark"] = dataGridView_CHK["MasterComments", 10].Value;


            dt_SS[0]["xGenFlooring_Crr"] = dataGridView_CHK["correspondence", 11].Value;
            dt_SS[0]["xGenFlooring_CkM"] = dataGridView_CHK["Accept", 11].Value;
            dt_SS[0]["xGenFlooring_Remark"] = dataGridView_CHK["MasterComments", 11].Value;


            dt_SS[0]["xGenKitchenWall_Crr"] = dataGridView_CHK["correspondence", 12].Value;
            dt_SS[0]["xGenKitchenWall_CkM"] = dataGridView_CHK["Accept", 12].Value;
            dt_SS[0]["xGenKitchenWall_Remark"] = dataGridView_CHK["MasterComments", 12].Value;


            dt_SS[0]["xGenKitchenFloor_Crr"] = dataGridView_CHK["correspondence", 13].Value;
            dt_SS[0]["xGenKitchenFloor_CkM"] = dataGridView_CHK["Accept", 13].Value;
            dt_SS[0]["xGenKitchenFloor_Remark"] = dataGridView_CHK["MasterComments", 13].Value;


            dt_SS[0]["xGenKitchenCupboards_Crr"] = dataGridView_CHK["correspondence", 14].Value;
            dt_SS[0]["xGenKitchenCupboards_CkM"] = dataGridView_CHK["Accept", 14].Value;
            dt_SS[0]["xGenKitchenCupboards_Remark"] = dataGridView_CHK["MasterComments", 14].Value;


            dt_SS[0]["xGenBathroomPiping_Crr"] = dataGridView_CHK["correspondence", 15].Value;
            dt_SS[0]["xGenBathroomPiping_CkM"] = dataGridView_CHK["Accept", 15].Value;
            dt_SS[0]["xGenBathroomPiping_Remark"] = dataGridView_CHK["MasterComments", 15].Value;


            dt_SS[0]["xBathtub_Crr"] = dataGridView_CHK["correspondence", 16].Value;
            dt_SS[0]["xBathtub_CkM"] = dataGridView_CHK["Accept", 16].Value;
            dt_SS[0]["xBathtub_Remark"] = dataGridView_CHK["MasterComments", 16].Value;


            dt_SS[0]["xBathTile_Crr"] = dataGridView_CHK["correspondence", 17].Value;
            dt_SS[0]["xBathTile_CkM"] = dataGridView_CHK["Accept", 17].Value;
            dt_SS[0]["xBathTile_Remark"] = dataGridView_CHK["MasterComments", 17].Value;

            if (cmb_xGenAdaptationMap_.SelectedValue == null)
                dt_SS[0]["xGenAdaptationMap_"] = DBNull.Value;
            else
                dt_SS[0]["xGenAdaptationMap_"] = cmb_xGenAdaptationMap_.SelectedValue;

            if (cmb_xGenPrepareCurrentSituationMaps_.SelectedValue == null)
                dt_SS[0]["xGenPrepareCurrentSituationMaps_"] = DBNull.Value;
            else
                dt_SS[0]["xGenPrepareCurrentSituationMaps_"] = cmb_xGenPrepareCurrentSituationMaps_.SelectedValue;

            if (cmb_xGenAmountDestruction_.SelectedValue == null)
                dt_SS[0]["xGenAmountDestruction_"] = DBNull.Value;
            else
                dt_SS[0]["xGenAmountDestruction_"] = cmb_xGenAmountDestruction_.SelectedValue;

            if (cmb_xGenTransportDestructionMetod_.SelectedValue == null)
                dt_SS[0]["xGenTransportDestructionMetod_"] = DBNull.Value;
            else
                dt_SS[0]["xGenTransportDestructionMetod_"] = cmb_xGenTransportDestructionMetod_.SelectedValue;



            if (cmb_xGenAccessDestructionMetod_.SelectedValue == null)
                dt_SS[0]["xGenAccessDestructionMetod_"] = DBNull.Value;
            else
                dt_SS[0]["xGenAccessDestructionMetod_"] = cmb_xGenAccessDestructionMetod_.SelectedValue;

            dt_SS[0]["xNeighborUnitCount"] = this.txt_xNeighborUnitCount.Text;
            dt_SS[0]["xNeighborsLivingNumber"] = this.txt_xNeighborsLivingNumber.Text;
            dt_SS[0]["xRiskNeighborsComplaints"] = this.txt_xRiskNeighborsComplaints.Text;
            dt_SS[0]["xRiskMunicipalityPrevent"] = this.txt_xRiskMunicipalityPrevent.Text;
            dt_SS[0]["xRiskForcedDestruction"] = this.txt_xRiskForcedDestruction.Text;
            dt_SS[0]["xRiskDamageBuilding"] = this.txt_xRiskDamageBuilding.Text;
            dt_SS[0]["xDestructionDurationDay"] = this.txt_xDestructionDurationDay.Text;
            dt_SS[0]["xDestructionRebuildingDay"] = this.txt_xDestructionRebuildingDay.Text;


            new BLL.Rebuilding.csRebuilding().UdRebuildingByx_(dt_SS);

        }
        void SetValueForm(int x_)
        {
            dt_R = new BLL.Rebuilding.csRebuilding().mRebuildingByx_(x_);
            if (dt_R[0]["xGenUsageType_"] != DBNull.Value)
                cmb_xGenUsageType_.SelectedValue = (int?)dt_R[0]["xGenUsageType_"];
            if (dt_R[0]["xBuldingStatus_"] != DBNull.Value)
                cmb_xGenBuldingStatus_.SelectedValue = (int?)dt_R[0]["xBuldingStatus_"];
            if (dt_R[0]["xGenContractType_"] != DBNull.Value)
                cmb_xGenContractType_.SelectedValue = (int?)dt_R[0]["xGenContractType_"];
            if (dt_R[0]["xGenPosition_"] != DBNull.Value)
                cmb_xGenPosition_.SelectedValue = (int?)dt_R[0]["xGenPosition_"];
            if (dt_R[0]["xGenRoof_"] != DBNull.Value)
                cmb_xGenRoof_.SelectedValue = (int?)dt_R[0]["xGenRoof_"];
            if (dt_R[0]["xGenWall_"] != DBNull.Value)
                cmb_xGenWall_.SelectedValue = (int?)dt_R[0]["xGenWall_"];
            if (dt_R[0]["xGenBuildingSkeleton_"] != DBNull.Value)
                cmb_xGenBuildingSkeleton_.SelectedValue = (int?)dt_R[0]["xGenBuildingSkeleton_"];
            if (dt_R[0]["xGenFoundation_"] != DBNull.Value)
                cmb_xGenFoundation_.SelectedValue = (int?)dt_R[0]["xGenFoundation_"];
            if (dt_R[0]["xGenHeatingSystem_"] != DBNull.Value)
                cmb_xGenHeatingSystem_.SelectedValue = (int?)dt_R[0]["xGenHeatingSystem_"];
            if (dt_R[0]["xGenWaterPiping_"] != DBNull.Value)
                cmb_xGenWaterPiping_.SelectedValue = (int?)dt_R[0]["xGenWaterPiping_"];
            if (dt_R[0]["xGenGasPiping_"] != DBNull.Value)
                cmb_xGenGasPiping_.SelectedValue = (int?)dt_R[0]["xGenGasPiping_"];
            if (dt_R[0]["xGenBathroomPiping_"] != DBNull.Value)
                cmb_xGenBathroomPiping_.SelectedValue = (int?)dt_R[0]["xGenBathroomPiping_"];
            if (dt_R[0]["xGenCoolingSystem_"] != DBNull.Value)
                cmb_xGenCoolingSystem_.SelectedValue = (int?)dt_R[0]["xGenCoolingSystem_"];
            if (dt_R[0]["xGenFlooring_"] != DBNull.Value)
                cmb_xGenFlooring_.SelectedValue = (int?)dt_R[0]["xGenFlooring_"];
            if (dt_R[0]["xGenKitchenFloor_"] != DBNull.Value)
                cmb_xGenKitchenFloor_.SelectedValue = (int?)dt_R[0]["xGenKitchenFloor_"];
            if (dt_R[0]["xGenKitchenWall_"] != DBNull.Value)
                cmb_xGenKitchenWall_.SelectedValue = (int?)dt_R[0]["xGenKitchenWall_"];
            if (dt_R[0]["xGenKitchenCupboards_"] != DBNull.Value)
                cmb_xGenKitchenCupboards_.SelectedValue = (int?)dt_R[0]["xGenKitchenCupboards_"];
            if (dt_R[0]["xGenReasonsRebuilding_"] != DBNull.Value)
                cmb_xGenReasonsRebuilding_.SelectedValue = (int?)dt_R[0]["xGenReasonsRebuilding_"];
            if (dt_R[0]["xAddress"] != DBNull.Value)
                this.uc_txtBox_xAddress.Text = dt_R[0]["xAddress"].ToString();
            if (dt_R[0]["xWidth"] != DBNull.Value)
                this.txt_xWidth.Text = dt_R[0]["xWidth"].ToString();
            if (dt_R[0]["xArea"] != DBNull.Value)
                this.txt_xArea.Text = dt_R[0]["xArea"].ToString();
            if (dt_R[0]["xBuildingUnitsNumberRequest"] != DBNull.Value)
                this.txt_xBuildingUnitsNumberRequest.Text = dt_R[0]["xBuildingUnitsNumberRequest"].ToString();
            if (dt_R[0]["xFloorsNumber"] != DBNull.Value)
                this.txt_xFloorsNumber.Text = dt_R[0]["xFloorsNumber"].ToString();
            if (dt_R[0]["xAreaRebuilding"] != DBNull.Value)
                this.txt_xAreaRebuilding.Text = dt_R[0]["xAreaRebuilding"].ToString();
            if (dt_R[0]["xUnitArea"] != DBNull.Value)
                this.txt_xUnitArea.Text = dt_R[0]["xUnitArea"].ToString();
            if (dt_R[0]["xToiletNumber"] != DBNull.Value)
                this.txt_xToiletNumber.Text = dt_R[0]["xToiletNumber"].ToString();
            if (dt_R[0]["xBathroomNumber"] != DBNull.Value)
                this.txt_xBathroomNumber.Text = dt_R[0]["xBathroomNumber"].ToString();
            if (dt_R[0]["xBedroomsNumber"] != DBNull.Value)
                this.txt_xBedroomsNumber.Text = dt_R[0]["xBedroomsNumber"].ToString();
            if (dt_R[0]["xBuildingYear"] != DBNull.Value)
                this.txt_xBuildingYear.Text = dt_R[0]["xBuildingYear"].ToString();
            //if (dt_R[0]["xUnitID"] != DBNull.Value)
            //    this.txt_xUnitID.Text = dt_R[0]["xUnitID"].ToString();
            if (dt_R[0]["xBuildingUnitsNumber"] != DBNull.Value)
                this.txt_xBuildingUnitsNumber.Text = dt_R[0]["xBuildingUnitsNumber"].ToString();
            if (dt_R[0]["xlength"] != DBNull.Value)
                this.txt_xlength.Text = dt_R[0]["xlength"].ToString();
            if (dt_R[0]["xZone"] != DBNull.Value)
                this.txt_xZone.Text = dt_R[0]["xZone"].ToString();


            if (dt_R[0]["xGenRoof_Ch_"] != DBNull.Value)
                cmb_xGenRoof_Ch_.SelectedValue = (int?)dt_R[0]["xGenRoof_Ch_"];
            if (dt_R[0]["xGenWall_Ch_"] != DBNull.Value)
                cmb_xGenWall_Ch_.SelectedValue = (int?)dt_R[0]["xGenWall_Ch_"];
            if (dt_R[0]["xGenBuildingSkeleton_Ch_"] != DBNull.Value)
                cmb_xGenBuildingSkeleton_Ch_.SelectedValue = (int?)dt_R[0]["xGenBuildingSkeleton_Ch_"];
            if (dt_R[0]["xGenFoundation_Ch_"] != DBNull.Value)
                cmb_xGenFoundation_Ch_.SelectedValue = (int?)dt_R[0]["xGenFoundation_Ch_"];
            if (dt_R[0]["xGenHeatingSystem_Ch_"] != DBNull.Value)
                cmb_xGenHeatingSystem_Ch_.SelectedValue = (int?)dt_R[0]["xGenHeatingSystem_Ch_"];
            if (dt_R[0]["xGenWaterPiping_Ch_"] != DBNull.Value)
                cmb_xGenWaterPiping_Ch_.SelectedValue = (int?)dt_R[0]["xGenWaterPiping_Ch_"];
            if (dt_R[0]["xGenGasPiping_Ch_"] != DBNull.Value)
                cmb_xGenGasPiping_Ch_.SelectedValue = (int?)dt_R[0]["xGenGasPiping_Ch_"];
            if (dt_R[0]["xGenBathroomPiping_Ch_"] != DBNull.Value)
                cmb_xGenBathroomPiping_Ch_.SelectedValue = (int?)dt_R[0]["xGenBathroomPiping_Ch_"];
            if (dt_R[0]["xGenCoolingSystem_Ch_"] != DBNull.Value)
                cmb_xGenCoolingSystem_Ch_.SelectedValue = (int?)dt_R[0]["xGenCoolingSystem_Ch_"];
            if (dt_R[0]["xGenFlooring_Ch_"] != DBNull.Value)
                cmb_xGenFlooring_Ch_.SelectedValue = (int?)dt_R[0]["xGenFlooring_Ch_"];
            if (dt_R[0]["xGenKitchenFloor_Ch_"] != DBNull.Value)
                cmb_xGenKitchenFloor_Ch_.SelectedValue = (int?)dt_R[0]["xGenKitchenFloor_Ch_"];
            if (dt_R[0]["xGenKitchenWall_Ch_"] != DBNull.Value)
                cmb_xGenKitchenWall_Ch_.SelectedValue = (int?)dt_R[0]["xGenKitchenWall_Ch_"];
            if (dt_R[0]["xGenKitchenCupboards_Ch_"] != DBNull.Value)
                cmb_xGenKitchenCupboards_Ch_.SelectedValue = (int?)dt_R[0]["xGenKitchenCupboards_Ch_"];






            if (dt_R[0]["xToiletNumber_Ch"] != DBNull.Value)
                this.txt_xToiletNumber_Ch.Text = dt_R[0]["xToiletNumber_Ch"].ToString();
            if (dt_R[0]["xBathroomNumber_Ch"] != DBNull.Value)
                this.txt_xBathroomNumber_Ch.Text = dt_R[0]["xBathroomNumber_Ch"].ToString();
            if (dt_R[0]["xBedroomsNumber_Ch"] != DBNull.Value)
                this.txt_xBedroomsNumber_Ch.Text = dt_R[0]["xBedroomsNumber_Ch"].ToString();

            if (dt_R[0]["xLicenseRebuilding"] != DBNull.Value)
                this.chb_xLicenseRebuilding.Checked = (bool)dt_R[0]["xLicenseRebuilding"];
            if (dt_R[0]["xProductionLicense"] != DBNull.Value)
                this.chb_xProductionLicense.Checked = (bool)dt_R[0]["xProductionLicense"];


            if (dt_R[0]["xBathTile"] != DBNull.Value)
                this.chb_xBathTile.Checked = (bool)dt_R[0]["xBathTile"];
            if (dt_R[0]["xBathtub"] != DBNull.Value)
                this.chb_xBathtub.Checked = (bool)dt_R[0]["xBathtub"];

            if (dt_R[0]["xBathTile_Ch"] != DBNull.Value)
                this.chb_xBathTile_Ch.Checked = (bool)dt_R[0]["xBathTile_Ch"];
            if (dt_R[0]["xBathtub_Ch"] != DBNull.Value)
                this.chb_xBathtub_Ch.Checked = (bool)dt_R[0]["xBathtub_Ch"];



        }
        void SaveByx_(int x_)
        {
            if (cmb_xGenUsageType_.SelectedValue == null)
                dt_R[0]["xGenUsageType_"] = DBNull.Value;
            else
                dt_R[0]["xGenUsageType_"] = cmb_xGenUsageType_.SelectedValue;

            if (cmb_xGenBuldingStatus_.SelectedValue == null)
                dt_R[0]["xBuldingStatus_"] = DBNull.Value;
            else
                dt_R[0]["xBuldingStatus_"] = cmb_xGenBuldingStatus_.SelectedValue;

            if (cmb_xGenContractType_.SelectedValue == null)
                dt_R[0]["xGenContractType_"] = DBNull.Value;
            else
                dt_R[0]["xGenContractType_"] = cmb_xGenContractType_.SelectedValue;

            if (cmb_xGenPosition_.SelectedValue == null)
                dt_R[0]["xGenPosition_"] = DBNull.Value;
            else
                dt_R[0]["xGenPosition_"] = cmb_xGenPosition_.SelectedValue;

            if (cmb_xGenRoof_.SelectedValue == null)
                dt_R[0]["xGenRoof_"] = DBNull.Value;
            else
                dt_R[0]["xGenRoof_"] = cmb_xGenRoof_.SelectedValue;

            if (cmb_xGenWall_.SelectedValue == null)
                dt_R[0]["xGenWall_"] = DBNull.Value;
            else
                dt_R[0]["xGenWall_"] = cmb_xGenWall_.SelectedValue;

            if (cmb_xGenBuildingSkeleton_.SelectedValue == null)
                dt_R[0]["xGenBuildingSkeleton_"] = DBNull.Value;
            else
                dt_R[0]["xGenBuildingSkeleton_"] = cmb_xGenBuildingSkeleton_.SelectedValue;

            if (cmb_xGenFoundation_.SelectedValue == null)
                dt_R[0]["xGenFoundation_"] = DBNull.Value;
            else
                dt_R[0]["xGenFoundation_"] = cmb_xGenFoundation_.SelectedValue;

            if (cmb_xGenHeatingSystem_.SelectedValue == null)
                dt_R[0]["xGenHeatingSystem_"] = DBNull.Value;
            else
                dt_R[0]["xGenHeatingSystem_"] = cmb_xGenHeatingSystem_.SelectedValue;

            if (cmb_xGenWaterPiping_.SelectedValue == null)
                dt_R[0]["xGenWaterPiping_"] = DBNull.Value;
            else
                dt_R[0]["xGenWaterPiping_"] = cmb_xGenWaterPiping_.SelectedValue;

            if (cmb_xGenGasPiping_.SelectedValue == null)
                dt_R[0]["xGenGasPiping_"] = DBNull.Value;
            else
                dt_R[0]["xGenGasPiping_"] = cmb_xGenGasPiping_.SelectedValue;

            if (cmb_xGenBathroomPiping_.SelectedValue == null)
                dt_R[0]["xGenBathroomPiping_"] = DBNull.Value;
            else
                dt_R[0]["xGenBathroomPiping_"] = cmb_xGenBathroomPiping_.SelectedValue;

            if (cmb_xGenCoolingSystem_.SelectedValue == null)
                dt_R[0]["xGenCoolingSystem_"] = DBNull.Value;
            else
                dt_R[0]["xGenCoolingSystem_"] = cmb_xGenCoolingSystem_.SelectedValue;

            if (cmb_xGenFlooring_.SelectedValue == null)
                dt_R[0]["xGenFlooring_"] = DBNull.Value;
            else
                dt_R[0]["xGenFlooring_"] = cmb_xGenFlooring_.SelectedValue;

            if (cmb_xGenKitchenFloor_.SelectedValue == null)
                dt_R[0]["xGenKitchenFloor_"] = DBNull.Value;
            else
                dt_R[0]["xGenKitchenFloor_"] = cmb_xGenKitchenFloor_.SelectedValue;

            if (cmb_xGenKitchenWall_.SelectedValue == null)
                dt_R[0]["xGenKitchenWall_"] = DBNull.Value;
            else
                dt_R[0]["xGenKitchenWall_"] = cmb_xGenKitchenWall_.SelectedValue;

            if (cmb_xGenKitchenCupboards_.SelectedValue == null)
                dt_R[0]["xGenKitchenCupboards_"] = DBNull.Value;
            else
                dt_R[0]["xGenKitchenCupboards_"] = cmb_xGenKitchenCupboards_.SelectedValue;

            if (cmb_xGenReasonsRebuilding_.SelectedValue == null)
                dt_R[0]["xGenReasonsRebuilding_"] = DBNull.Value;
            else
                dt_R[0]["xGenReasonsRebuilding_"] = cmb_xGenReasonsRebuilding_.SelectedValue;

            if (cmb_xGenRoof_Ch_.SelectedValue == null)
                dt_R[0]["xGenRoof_Ch_"] = DBNull.Value;
            else
                dt_R[0]["xGenRoof_Ch_"] = cmb_xGenRoof_Ch_.SelectedValue;

            if (cmb_xGenWall_Ch_.SelectedValue == null)
                dt_R[0]["xGenWall_Ch_"] = DBNull.Value;
            else
                dt_R[0]["xGenWall_Ch_"] = cmb_xGenWall_Ch_.SelectedValue;

            if (cmb_xGenBuildingSkeleton_Ch_.SelectedValue == null)
                dt_R[0]["xGenBuildingSkeleton_Ch_"] = DBNull.Value;
            else
                dt_R[0]["xGenBuildingSkeleton_Ch_"] = cmb_xGenBuildingSkeleton_Ch_.SelectedValue;

            if (cmb_xGenFoundation_Ch_.SelectedValue == null)
                dt_R[0]["xGenFoundation_Ch_"] = DBNull.Value;
            else
                dt_R[0]["xGenFoundation_Ch_"] = cmb_xGenFoundation_Ch_.SelectedValue;

            if (cmb_xGenHeatingSystem_Ch_.SelectedValue == null)
                dt_R[0]["xGenHeatingSystem_Ch_"] = DBNull.Value;
            else
                dt_R[0]["xGenHeatingSystem_Ch_"] = cmb_xGenHeatingSystem_Ch_.SelectedValue;

            if (cmb_xGenWaterPiping_Ch_.SelectedValue == null)
                dt_R[0]["xGenWaterPiping_Ch_"] = DBNull.Value;
            else
                dt_R[0]["xGenWaterPiping_Ch_"] = cmb_xGenWaterPiping_Ch_.SelectedValue;

            if (cmb_xGenGasPiping_Ch_.SelectedValue == null)
                dt_R[0]["xGenGasPiping_Ch_"] = DBNull.Value;
            else
                dt_R[0]["xGenGasPiping_Ch_"] = cmb_xGenGasPiping_Ch_.SelectedValue;

            if (cmb_xGenBathroomPiping_Ch_.SelectedValue == null)
                dt_R[0]["xGenBathroomPiping_Ch_"] = DBNull.Value;
            else
                dt_R[0]["xGenBathroomPiping_Ch_"] = cmb_xGenBathroomPiping_Ch_.SelectedValue;

            if (cmb_xGenCoolingSystem_Ch_.SelectedValue == null)
                dt_R[0]["xGenCoolingSystem_Ch_"] = DBNull.Value;
            else
                dt_R[0]["xGenCoolingSystem_Ch_"] = cmb_xGenCoolingSystem_Ch_.SelectedValue;

            if (cmb_xGenFlooring_Ch_.SelectedValue == null)
                dt_R[0]["xGenFlooring_Ch_"] = DBNull.Value;
            else
                dt_R[0]["xGenFlooring_Ch_"] = cmb_xGenFlooring_Ch_.SelectedValue;

            if (cmb_xGenKitchenFloor_Ch_.SelectedValue == null)
                dt_R[0]["xGenKitchenFloor_Ch_"] = DBNull.Value;
            else
                dt_R[0]["xGenKitchenFloor_Ch_"] = cmb_xGenKitchenFloor_Ch_.SelectedValue;

            if (cmb_xGenKitchenWall_Ch_.SelectedValue == null)
                dt_R[0]["xGenKitchenWall_Ch_"] = DBNull.Value;
            else
                dt_R[0]["xGenKitchenWall_Ch_"] = cmb_xGenKitchenWall_Ch_.SelectedValue;

            if (cmb_xGenKitchenCupboards_Ch_.SelectedValue == null)
                dt_R[0]["xGenKitchenCupboards_Ch_"] = DBNull.Value;
            else
                dt_R[0]["xGenKitchenCupboards_Ch_"] = cmb_xGenKitchenCupboards_Ch_.SelectedValue;


            dt_R[0]["xAddress"] = this.uc_txtBox_xAddress.Text;
            dt_R[0]["xWidth"] = this.txt_xWidth.Text;
            dt_R[0]["xArea"] = this.txt_xArea.Text;
            dt_R[0]["xBuildingUnitsNumberRequest"] = this.txt_xBuildingUnitsNumberRequest.Text;
            dt_R[0]["xFloorsNumber"] = this.txt_xFloorsNumber.Text;
            dt_R[0]["xAreaRebuilding"] = this.txt_xAreaRebuilding.Text;
            dt_R[0]["xUnitArea"] = this.txt_xUnitArea.textWithoutcomma;
            dt_R[0]["xToiletNumber"] = this.txt_xToiletNumber.Text;
            dt_R[0]["xBathroomNumber"] = this.txt_xBathroomNumber.Text;
            dt_R[0]["xBedroomsNumber"] = this.txt_xBedroomsNumber.Text;
            dt_R[0]["xBuildingYear"] = this.txt_xBuildingYear.textWithoutcomma;
            //dt_R[0]["xUnitID"] = this.txt_xUnitID.Text;
            dt_R[0]["xBuildingUnitsNumber"] = this.txt_xBuildingUnitsNumber.Text;
            dt_R[0]["xlength"] = this.txt_xlength.Text;
            dt_R[0]["xZone"] = this.txt_xZone.Text;

            dt_R[0]["xBathTile_Ch"] = this.chb_xBathTile_Ch.Checked;
            dt_R[0]["xBathTile"] = this.chb_xBathTile.Checked;
            dt_R[0]["xBathtub"] = this.chb_xBathtub.Checked;
            dt_R[0]["xBathtub_Ch"] = this.chb_xBathtub_Ch.Checked;
            dt_R[0]["xLicenseRebuilding"] = this.chb_xLicenseRebuilding.Checked;
            dt_R[0]["xProductionLicense"] = this.chb_xProductionLicense.Checked;

        }
        int Cust = -1;
        int x;
        void ShowData()
        {

        }
        void CmbGiveValue()
        {
            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();

            cmb_xGenUsageType_.DataSource = csm.SlGenGroup("UsageType");
            cmb_xGenUsageType_.DisplayMember = "xName";
            cmb_xGenUsageType_.ValueMember = "x_";
            cmb_xGenUsageType_.SelectedIndex = -1;

            cmb_xGenBuldingStatus_.DataSource = csm.SlGenGroup("BuldingStatus");
            cmb_xGenBuldingStatus_.DisplayMember = "xName";
            cmb_xGenBuldingStatus_.ValueMember = "x_";
            cmb_xGenBuldingStatus_.SelectedIndex = -1;

            cmb_xGenContractType_.DataSource = csm.SlGenGroup("ContractType");
            cmb_xGenContractType_.DisplayMember = "xName";
            cmb_xGenContractType_.ValueMember = "x_";
            cmb_xGenContractType_.SelectedIndex = -1;

            cmb_xGenPosition_.DataSource = csm.SlGenGroup("PositionBuilding");
            cmb_xGenPosition_.DisplayMember = "xName";
            cmb_xGenPosition_.ValueMember = "x_";
            cmb_xGenPosition_.SelectedIndex = -1;

            cmb_xGenRoof_.DataSource = csm.SlGenGroup("Roof");
            cmb_xGenRoof_.DisplayMember = "xName";
            cmb_xGenRoof_.ValueMember = "x_";
            cmb_xGenRoof_.SelectedIndex = -1;

            cmb_xGenRoof_Ch_.DataSource = csm.SlGenGroup("Roof");
            cmb_xGenRoof_Ch_.DisplayMember = "xName";
            cmb_xGenRoof_Ch_.ValueMember = "x_";
            cmb_xGenRoof_Ch_.SelectedIndex = -1;

            cmb_xGenWall_.DataSource = csm.SlGenGroup("Wall");
            cmb_xGenWall_.DisplayMember = "xName";
            cmb_xGenWall_.ValueMember = "x_";
            cmb_xGenWall_.SelectedIndex = -1;

            cmb_xGenWall_Ch_.DataSource = csm.SlGenGroup("Wall");
            cmb_xGenWall_Ch_.DisplayMember = "xName";
            cmb_xGenWall_Ch_.ValueMember = "x_";
            cmb_xGenWall_Ch_.SelectedIndex = -1;

            cmb_xGenBuildingSkeleton_.DataSource = csm.SlGenGroup("BuildingSkeleton");
            cmb_xGenBuildingSkeleton_.DisplayMember = "xName";
            cmb_xGenBuildingSkeleton_.ValueMember = "x_";
            cmb_xGenBuildingSkeleton_.SelectedIndex = -1;

            cmb_xGenBuildingSkeleton_Ch_.DataSource = csm.SlGenGroup("BuildingSkeleton");
            cmb_xGenBuildingSkeleton_Ch_.DisplayMember = "xName";
            cmb_xGenBuildingSkeleton_Ch_.ValueMember = "x_";
            cmb_xGenBuildingSkeleton_Ch_.SelectedIndex = -1;

            cmb_xGenFoundation_.DataSource = csm.SlGenGroup("Foundation");
            cmb_xGenFoundation_.DisplayMember = "xName";
            cmb_xGenFoundation_.ValueMember = "x_";
            cmb_xGenFoundation_.SelectedIndex = -1;

            cmb_xGenFoundation_Ch_.DataSource = csm.SlGenGroup("Foundation");
            cmb_xGenFoundation_Ch_.DisplayMember = "xName";
            cmb_xGenFoundation_Ch_.ValueMember = "x_";
            cmb_xGenFoundation_Ch_.SelectedIndex = -1;

            cmb_xGenHeatingSystem_.DataSource = csm.SlGenGroup("HeatingSystem");
            cmb_xGenHeatingSystem_.DisplayMember = "xName";
            cmb_xGenHeatingSystem_.ValueMember = "x_";
            cmb_xGenHeatingSystem_.SelectedIndex = -1;

            cmb_xGenHeatingSystem_Ch_.DataSource = csm.SlGenGroup("HeatingSystem");
            cmb_xGenHeatingSystem_Ch_.DisplayMember = "xName";
            cmb_xGenHeatingSystem_Ch_.ValueMember = "x_";
            cmb_xGenHeatingSystem_Ch_.SelectedIndex = -1;

            cmb_xGenWaterPiping_.DataSource = csm.SlGenGroup("WaterPiping");
            cmb_xGenWaterPiping_.DisplayMember = "xName";
            cmb_xGenWaterPiping_.ValueMember = "x_";
            cmb_xGenWaterPiping_.SelectedIndex = -1;

            cmb_xGenWaterPiping_Ch_.DataSource = csm.SlGenGroup("WaterPiping");
            cmb_xGenWaterPiping_Ch_.DisplayMember = "xName";
            cmb_xGenWaterPiping_Ch_.ValueMember = "x_";
            cmb_xGenWaterPiping_Ch_.SelectedIndex = -1;

            cmb_xGenGasPiping_.DataSource = csm.SlGenGroup("GasPiping");
            cmb_xGenGasPiping_.DisplayMember = "xName";
            cmb_xGenGasPiping_.ValueMember = "x_";
            cmb_xGenGasPiping_.SelectedIndex = -1;

            cmb_xGenGasPiping_Ch_.DataSource = csm.SlGenGroup("GasPiping");
            cmb_xGenGasPiping_Ch_.DisplayMember = "xName";
            cmb_xGenGasPiping_Ch_.ValueMember = "x_";
            cmb_xGenGasPiping_Ch_.SelectedIndex = -1;

            cmb_xGenBathroomPiping_.DataSource = csm.SlGenGroup("BathroomPiping");
            cmb_xGenBathroomPiping_.DisplayMember = "xName";
            cmb_xGenBathroomPiping_.ValueMember = "x_";
            cmb_xGenBathroomPiping_.SelectedIndex = -1;

            cmb_xGenBathroomPiping_Ch_.DataSource = csm.SlGenGroup("BathroomPiping");
            cmb_xGenBathroomPiping_Ch_.DisplayMember = "xName";
            cmb_xGenBathroomPiping_Ch_.ValueMember = "x_";
            cmb_xGenBathroomPiping_Ch_.SelectedIndex = -1;

            cmb_xGenCoolingSystem_.DataSource = csm.SlGenGroup("CoolingSystem");
            cmb_xGenCoolingSystem_.DisplayMember = "xName";
            cmb_xGenCoolingSystem_.ValueMember = "x_";
            cmb_xGenCoolingSystem_.SelectedIndex = -1;

            cmb_xGenCoolingSystem_Ch_.DataSource = csm.SlGenGroup("CoolingSystem");
            cmb_xGenCoolingSystem_Ch_.DisplayMember = "xName";
            cmb_xGenCoolingSystem_Ch_.ValueMember = "x_";
            cmb_xGenCoolingSystem_Ch_.SelectedIndex = -1;

            cmb_xGenFlooring_.DataSource = csm.SlGenGroup("Flooring");
            cmb_xGenFlooring_.DisplayMember = "xName";
            cmb_xGenFlooring_.ValueMember = "x_";
            cmb_xGenFlooring_.SelectedIndex = -1;

            cmb_xGenFlooring_Ch_.DataSource = csm.SlGenGroup("Flooring");
            cmb_xGenFlooring_Ch_.DisplayMember = "xName";
            cmb_xGenFlooring_Ch_.ValueMember = "x_";
            cmb_xGenFlooring_Ch_.SelectedIndex = -1;

            cmb_xGenKitchenFloor_.DataSource = csm.SlGenGroup("KitchenFloor");
            cmb_xGenKitchenFloor_.DisplayMember = "xName";
            cmb_xGenKitchenFloor_.ValueMember = "x_";
            cmb_xGenKitchenFloor_.SelectedIndex = -1;

            cmb_xGenKitchenFloor_Ch_.DataSource = csm.SlGenGroup("KitchenFloor");
            cmb_xGenKitchenFloor_Ch_.DisplayMember = "xName";
            cmb_xGenKitchenFloor_Ch_.ValueMember = "x_";
            cmb_xGenKitchenFloor_Ch_.SelectedIndex = -1;

            cmb_xGenKitchenWall_.DataSource = csm.SlGenGroup("KitchenWall");
            cmb_xGenKitchenWall_.DisplayMember = "xName";
            cmb_xGenKitchenWall_.ValueMember = "x_";
            cmb_xGenKitchenWall_.SelectedIndex = -1;

            cmb_xGenKitchenWall_Ch_.DataSource = csm.SlGenGroup("KitchenWall");
            cmb_xGenKitchenWall_Ch_.DisplayMember = "xName";
            cmb_xGenKitchenWall_Ch_.ValueMember = "x_";
            cmb_xGenKitchenWall_Ch_.SelectedIndex = -1;

            cmb_xGenKitchenCupboards_.DataSource = csm.SlGenGroup("KitchenCupboards");
            cmb_xGenKitchenCupboards_.DisplayMember = "xName";
            cmb_xGenKitchenCupboards_.ValueMember = "x_";
            cmb_xGenKitchenCupboards_.SelectedIndex = -1;

            cmb_xGenKitchenCupboards_Ch_.DataSource = csm.SlGenGroup("KitchenCupboards");
            cmb_xGenKitchenCupboards_Ch_.DisplayMember = "xName";
            cmb_xGenKitchenCupboards_Ch_.ValueMember = "x_";
            cmb_xGenKitchenCupboards_Ch_.SelectedIndex = -1;

            cmb_xGenReasonsRebuilding_.DataSource = csm.SlGenGroup("ReasonsRebuilding");
            cmb_xGenReasonsRebuilding_.DisplayMember = "xName";
            cmb_xGenReasonsRebuilding_.ValueMember = "x_";
            cmb_xGenReasonsRebuilding_.SelectedIndex = -1;

            cmb_xGenAdaptationMap_.DataSource = csm.SlGenGroup("AdaptationMap");
            cmb_xGenAdaptationMap_.DisplayMember = "xName";
            cmb_xGenAdaptationMap_.ValueMember = "x_";
            cmb_xGenAdaptationMap_.SelectedIndex = -1;

            cmb_xGenPrepareCurrentSituationMaps_.DataSource = csm.SlGenGroup("PrepareCurrentSituationMaps");
            cmb_xGenPrepareCurrentSituationMaps_.DisplayMember = "xName";
            cmb_xGenPrepareCurrentSituationMaps_.ValueMember = "x_";
            cmb_xGenPrepareCurrentSituationMaps_.SelectedIndex = -1;


            cmb_xGenAmountDestruction_.DataSource = csm.SlGenGroup("AmountDestruction");
            cmb_xGenAmountDestruction_.DisplayMember = "xName";
            cmb_xGenAmountDestruction_.ValueMember = "x_";
            cmb_xGenAmountDestruction_.SelectedIndex = -1;


            cmb_xGenTransportDestructionMetod_.DataSource = csm.SlGenGroup("TransportDestructionMetod");
            cmb_xGenTransportDestructionMetod_.DisplayMember = "xName";
            cmb_xGenTransportDestructionMetod_.ValueMember = "x_";
            cmb_xGenTransportDestructionMetod_.SelectedIndex = -1;


            cmb_xGenAccessDestructionMetod_.DataSource = csm.SlGenGroup("AccessDestructionMetod");
            cmb_xGenAccessDestructionMetod_.DisplayMember = "xName";
            cmb_xGenAccessDestructionMetod_.ValueMember = "x_";
            cmb_xGenAccessDestructionMetod_.SelectedIndex = -1;

        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void Btn_insert_Click(object sender, EventArgs e)
        {
            if (x < 0)
            {
                if (new CS.csMessage().ShowMessageSaveYesNo())
                {
                    new BLL.Rebuilding.csRebuilding().InRebuildingAll(
                    BLL.csshamsidate.shamsidate,
                    Cust,
                    (int?)cmb_xGenUsageType_.SelectedValue,
                    (int?)cmb_xGenBuldingStatus_.SelectedValue,
                    txt_xArea.textWithoutcomma == null ? 0 : int.Parse(txt_xArea.textWithoutcomma),
                    txt_xZone.Text,
                    uc_txtBox_xAddress.Text,
                    (int?)cmb_xGenPosition_.SelectedValue,
                    txt_xlength.textWithoutcomma == null ? 0 : int.Parse(txt_xlength.textWithoutcomma),
                    txt_xWidth.textWithoutcomma == null ? 0 : int.Parse(txt_xWidth.textWithoutcomma), 
                    (int?)cmb_xGenContractType_.SelectedValue,
                    chb_xLicenseRebuilding.Checked,
                    "",
                    chb_xProductionLicense.Checked,
                    "",
                     txt_xBuildingUnitsNumber.textWithoutcomma == null ? 0 : int.Parse(txt_xBuildingUnitsNumber.textWithoutcomma),
                     txt_xFloorsNumber.textWithoutcomma == null ? 0 : int.Parse(txt_xFloorsNumber.textWithoutcomma),
                     txt_xBuildingUnitsNumberRequest.textWithoutcomma == null ? 0 : int.Parse(txt_xBuildingUnitsNumberRequest.textWithoutcomma),
                    0, //txt_xUnitID.textWithoutcomma == null ? 0 : int.Parse(txt_xUnitID.textWithoutcomma),
                     txt_xUnitArea.textWithoutcomma == null ? 0 : int.Parse(txt_xUnitArea.textWithoutcomma),
                     txt_xAreaRebuilding.textWithoutcomma == null ? 0 : int.Parse(txt_xAreaRebuilding.textWithoutcomma),
                     txt_xBuildingYear.Text,
                     txt_xBedroomsNumber.textWithoutcomma == null ? 0 : int.Parse(txt_xBedroomsNumber.textWithoutcomma),
                     txt_xBedroomsNumber_Ch.textWithoutcomma == null ? 0 : int.Parse(txt_xBedroomsNumber_Ch.textWithoutcomma),
                     txt_xBathroomNumber.textWithoutcomma == null ? 0 : int.Parse(txt_xBathroomNumber.textWithoutcomma),
                     txt_xBathroomNumber_Ch.textWithoutcomma == null ? 0 : int.Parse(txt_xBathroomNumber_Ch.textWithoutcomma),
                     txt_xToiletNumber.textWithoutcomma == null ? 0 : int.Parse(txt_xToiletNumber.textWithoutcomma),
                     txt_xToiletNumber_Ch.textWithoutcomma == null ? 0 : int.Parse(txt_xToiletNumber_Ch.textWithoutcomma),
                    (int?)cmb_xGenRoof_.SelectedValue,
                    (int?)cmb_xGenRoof_Ch_.SelectedValue,
                    (int?)cmb_xGenBuildingSkeleton_.SelectedValue,
                    (int?)cmb_xGenBuildingSkeleton_Ch_.SelectedValue,
                    (int?)cmb_xGenFoundation_.SelectedValue,
                    (int?)cmb_xGenFoundation_Ch_.SelectedValue,
                    (int?)cmb_xGenWall_.SelectedValue,
                    (int?)cmb_xGenWall_Ch_.SelectedValue,
                    (int?)cmb_xGenWaterPiping_.SelectedValue,
                    (int?)cmb_xGenWaterPiping_Ch_.SelectedValue,
                    (int?)cmb_xGenGasPiping_.SelectedValue,
                    (int?)cmb_xGenGasPiping_Ch_.SelectedValue,
                    (int?)cmb_xGenCoolingSystem_.SelectedValue,
                    (int?)cmb_xGenCoolingSystem_Ch_.SelectedValue,
                    (int?)cmb_xGenHeatingSystem_.SelectedValue,
                    (int?)cmb_xGenHeatingSystem_Ch_.SelectedValue,
                    (int?)cmb_xGenFlooring_.SelectedValue,
                    (int?)cmb_xGenFlooring_Ch_.SelectedValue,
                    (int?)cmb_xGenKitchenWall_.SelectedValue,
                    (int?)cmb_xGenKitchenWall_Ch_.SelectedValue,
                    (int?)cmb_xGenKitchenFloor_.SelectedValue,
                    (int?)cmb_xGenKitchenFloor_Ch_.SelectedValue,
                    (int?)cmb_xGenKitchenCupboards_.SelectedValue,
                    (int?)cmb_xGenKitchenCupboards_Ch_.SelectedValue,
                    (int?)cmb_xGenBathroomPiping_.SelectedValue,
                    (int?)cmb_xGenBathroomPiping_Ch_.SelectedValue,
                    chb_xBathtub.Checked,
                    chb_xBathtub_Ch.Checked,
                    chb_xBathTile.Checked,
                    chb_xBathTile_Ch.Checked,
                    (int?)cmb_xGenReasonsRebuilding_.SelectedValue,
                    BLL.authentication.x_
                    );
                    this.Close();

                }
            }
            else
            {

                if (new CS.csMessage().ShowMessageSaveYesNo())
                {
                    if (TypeUser_ == CS.csEnum.RebuildingUser.Master)
                    {
                        SaveDataCorrespondence();
                    }
                    else
                    {
                        SaveByx_(-1);
                        new BLL.Rebuilding.csRebuilding().UdRebuildingByx_(dt_R);
                        this.Close();
                    }
                }
            }
        }
        private void Btn_Print_Click(object sender, EventArgs e)
        {
            if (TypeUser_ == CS.csEnum.RebuildingUser.User)
            {
                Report.SendReport cs = new Report.SendReport();
                frmReport r = new frmReport();
                DataTable dt = new BLL.Rebuilding.csRebuilding().SlRebuildingByx_(x);
                r.GetReport = cs.GetReport(dt, "crsRebuildingRequest");
                r.ShowDialog();
                r.Dispose();
            }
            if(TypeUser_ == CS.csEnum.RebuildingUser.Master)
            {
                Report.SendReport cs = new Report.SendReport();
                frmReport r = new frmReport();
                DataTable dt = new BLL.Rebuilding.csRebuilding().SlRebuildingByx_(x);
                r.GetReport = cs.GetReport(dt, "crsRebuildingForMaster");
                r.ShowDialog();
                r.Dispose();
            }
        }
    }
}
