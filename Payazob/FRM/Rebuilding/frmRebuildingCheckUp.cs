using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MIS.FRM.Rebuilding
{
    public partial class frmRebuildingCheckUp : Form
    {
        public frmRebuildingCheckUp()
        {
            InitializeComponent();
            GenDatatableForCorrespondence();
        }
        DAL.Rebuilding.DataSet_Rebuilding.SlRebuilding_Byx_DataTable dt_RR;
        DAL.Rebuilding.DataSet_Rebuilding.mRebuilding_Byx_DataTable dt_SS;

        void GenDatatableForCorrespondence()
        {
            dt_RR = new BLL.Rebuilding.csRebuilding().SlRebuildingByx_(1);
            dt_SS = new BLL.Rebuilding.csRebuilding().mRebuildingByx_(1);
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
            dataGridView_CHK["correspondence", 0].Value = dt_SS[0]["xBedroomsNumber_Crr"]  ;
            dataGridView_CHK["Accept", 0].Value = dt_SS[0]["xBedroomsNumber_CkM"]  ;
            dataGridView_CHK["MasterComments", 0].Value = dt_SS[0]["xBedroomsNumber_Remark"] ;

            dataGridView_CHK["correspondence", 1].Value = dt_SS[0]["xBathroomNumber_Crr"] ;
            dataGridView_CHK["Accept", 1].Value = dt_SS[0]["xBathroomNumber_CkM"]  ;
            dataGridView_CHK["MasterComments", 1].Value = dt_SS[0]["xBathroomNumber_Remark"] ;

            dataGridView_CHK["correspondence", 2].Value = dt_SS[0]["xToiletNumber_Crr"]  ;
            dataGridView_CHK["Accept", 2].Value = dt_SS[0]["xToiletNumber_CkM"]  ;
            dataGridView_CHK["MasterComments", 2].Value = dt_SS[0]["xToiletNumber_Remark"]  ;

            dataGridView_CHK["correspondence", 3].Value = dt_SS[0]["xGenRoof_Crr"] ;
            dataGridView_CHK["Accept", 3].Value = dt_SS[0]["xGenRoof_CkM"]  ;
            dataGridView_CHK["MasterComments", 3].Value = dt_SS[0]["xGenRoof_Remark"]  ;

            dataGridView_CHK["correspondence", 4].Value = dt_SS[0]["xGenBuildingSkeleton_Crr"]  ;
            dataGridView_CHK["Accept", 4].Value = dt_SS[0]["xGenBuildingSkeleton_CkM"]  ;
            dataGridView_CHK["MasterComments", 4].Value = dt_SS[0]["xGenBuildingSkeleton_Remark"] ;

            dataGridView_CHK["correspondence", 5].Value = dt_SS[0]["xGenFoundation_Crr"] ;
            dataGridView_CHK["Accept", 5].Value = dt_SS[0]["xGenFoundation_CkM"] ;
            dataGridView_CHK["MasterComments", 5].Value  = dt_SS[0]["xGenFoundation_Remark"]  ;

            dataGridView_CHK["correspondence", 6].Value = dt_SS[0]["xGenWall_Crr"]  ;
            dataGridView_CHK["Accept", 6].Value = dt_SS[0]["xGenWall_CkM"]  ;
            dataGridView_CHK["MasterComments", 6].Value = dt_SS[0]["xGenWall_Remark"]  ;

            dataGridView_CHK["correspondence", 7].Value = dt_SS[0]["xGenWaterPiping_Crr"]  ;
            dataGridView_CHK["Accept", 7].Value = dt_SS[0]["xGenWaterPiping_CkM"]  ;
            dataGridView_CHK["MasterComments", 7].Value = dt_SS[0]["xGenWaterPiping_Remark"]  ;

            dataGridView_CHK["correspondence", 8].Value = dt_SS[0]["xGenGasPiping_Crr"]  ;
            dataGridView_CHK["Accept", 8].Value = dt_SS[0]["xGenGasPiping_CkM"]  ;
            dataGridView_CHK["MasterComments", 8].Value = dt_SS[0]["xGenGasPiping_Remark"]  ;

            dataGridView_CHK["correspondence", 9].Value = dt_SS[0]["xGenCoolingSystem_Crr"]  ;
            dataGridView_CHK["Accept", 9].Value = dt_SS[0]["xGenCoolingSystem_CkM"]  ;
            dataGridView_CHK["MasterComments", 9].Value = dt_SS[0]["xGenCoolingSystem_Remark"]  ;

            dataGridView_CHK["correspondence", 10].Value = dt_SS[0]["xGenHeatingSystem_Crr"]  ;
            dataGridView_CHK["Accept", 10].Value = dt_SS[0]["xGenHeatingSystem_CkM"]  ;
            dataGridView_CHK["MasterComments", 10].Value = dt_SS[0]["xGenHeatingSystem_Remark"]  ;


            dataGridView_CHK["correspondence", 11].Value = dt_SS[0]["xGenFlooring_Crr"]  ;
            dataGridView_CHK["Accept", 11].Value = dt_SS[0]["xGenFlooring_CkM"]  ;
            dataGridView_CHK["MasterComments", 11].Value = dt_SS[0]["xGenFlooring_Remark"]  ;


            dataGridView_CHK["correspondence", 12].Value = dt_SS[0]["xGenKitchenWall_Crr"]  ;
            dataGridView_CHK["Accept", 12].Value = dt_SS[0]["xGenKitchenWall_CkM"]  ;
            dataGridView_CHK["MasterComments", 12].Value = dt_SS[0]["xGenKitchenWall_Remark"]  ;


            dataGridView_CHK["correspondence", 13].Value = dt_SS[0]["xGenKitchenFloor_Crr"]  ;
            dataGridView_CHK["Accept", 13].Value = dt_SS[0]["xGenKitchenFloor_CkM"]  ;
            dataGridView_CHK["MasterComments", 13].Value = dt_SS[0]["xGenKitchenFloor_Remark"]  ;


            dataGridView_CHK["correspondence", 14].Value = dt_SS[0]["xGenKitchenCupboards_Crr"]  ;
            dataGridView_CHK["Accept", 14].Value = dt_SS[0]["xGenKitchenCupboards_CkM"]  ;
            dataGridView_CHK["MasterComments", 14].Value = dt_SS[0]["xGenKitchenCupboards_Remark"]  ;


            dataGridView_CHK["correspondence", 15].Value = dt_SS[0]["xGenBathroomPiping_Crr"]  ;
            dataGridView_CHK["Accept", 15].Value = dt_SS[0]["xGenBathroomPiping_CkM"]  ;
            dataGridView_CHK["MasterComments", 15].Value = dt_SS[0]["xGenBathroomPiping_Remark"]  ;


            dataGridView_CHK["correspondence", 16].Value = dt_SS[0]["xBathtub_Crr"]  ;
            dataGridView_CHK["Accept", 16].Value = dt_SS[0]["xBathtub_CkM"]  ;
            dataGridView_CHK["MasterComments", 16].Value = dt_SS[0]["xBathtub_Remark"]  ;


            dataGridView_CHK["correspondence", 17].Value = dt_SS[0]["xBathTile_Crr"]  ;
            dataGridView_CHK["Accept", 17].Value = dt_SS[0]["xBathTile_CkM"]  ;
            dataGridView_CHK["MasterComments", 17].Value = dt_SS[0]["xBathTile_Remark"]  ;

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

            new BLL.Rebuilding.csRebuilding().UdRebuildingByx_(dt_SS);

        }
        private void Btn_insert_Click(object sender, EventArgs e)
        {
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                SaveDataCorrespondence();
                ShowDataCorrespondence();
            }

        }
    }
}
