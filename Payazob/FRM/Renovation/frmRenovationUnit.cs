using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MIS.FRM.Renovation
{
    public partial class frmRenovationUnit : Form
    {
        public frmRenovationUnit(int xRenovation_,int x_)
        {
            InitializeComponent();
            CmbGiveValue();
            x    = x_;
            xRenovation = xRenovation_;
            dt_R = new DAL.Renovation.DataSet_Renovation.mRenovationUnitDataTable();

            if (x_ > 0)
            {
                SetValueForm(x_);
            }
        }
        DAL.Renovation.DataSet_Renovation.mRenovationUnitDataTable dt_R;
        DAL.Renovation.DataSet_Renovation.mRenovationUnit_Byx_DataTable dt_R_X_;
        int x;
        int xRenovation;
        void SetValueForm(int x_)
        {
            dt_R_X_ = new BLL.Renovation.csRenovation().mRenovationUnit_Byx_(x_);

            if (dt_R_X_[0]["xGenHeatingSystem_"] != DBNull.Value)
                cmb_xGenHeatingSystem_.SelectedValue = (int?)dt_R_X_[0]["xGenHeatingSystem_"];

            if (dt_R_X_[0]["xGenCoolingSystem_"] != DBNull.Value)
                cmb_xGenCoolingSystem_.SelectedValue = (int?)dt_R_X_[0]["xGenCoolingSystem_"];

            if (dt_R_X_[0]["xGenFlooring_"] != DBNull.Value)
                cmb_xGenFlooring_.SelectedValue = (int?)dt_R_X_[0]["xGenFlooring_"];

            if (dt_R_X_[0]["xGenKitchenCupboards_"] != DBNull.Value)
                cmb_xGenKitchenCupboards_.SelectedValue = (int?)dt_R_X_[0]["xGenKitchenCupboards_"];

            if (dt_R_X_[0]["xWidth"] != DBNull.Value)
                this.txt_xWidth.Text = dt_R_X_[0]["xWidth"].ToString();

            if (dt_R_X_[0]["xArea"] != DBNull.Value)
                this.txt_xArea.Text = dt_R_X_[0]["xArea"].ToString();

            if (dt_R_X_[0]["xToiletNumber"] != DBNull.Value)
                this.txt_xToiletNumber.Text = dt_R_X_[0]["xToiletNumber"].ToString();

            if (dt_R_X_[0]["xBathroomNumber"] != DBNull.Value)
                this.txt_xBathroomNumber.Text = dt_R_X_[0]["xBathroomNumber"].ToString();

            if (dt_R_X_[0]["xBedroomsNumber"] != DBNull.Value)
                this.txt_xBedroomsNumber.Text = dt_R_X_[0]["xBedroomsNumber"].ToString();

            if (dt_R_X_[0]["xUnitNumber"] != DBNull.Value)
                this.txt_xUnitNumber.Text = dt_R_X_[0]["xUnitNumber"].ToString();

            if (dt_R_X_[0]["xComment"] != DBNull.Value)
                this.txt_xComment.Text = dt_R_X_[0]["xComment"].ToString();

            if (dt_R_X_[0]["xlength"] != DBNull.Value)
                this.txt_xlength.Text = dt_R_X_[0]["xlength"].ToString();

            if (dt_R_X_[0]["xBathtub"] != DBNull.Value)
                this.chb_xBathtub.Checked = (bool)dt_R_X_[0]["xBathtub"];
            if (dt_R_X_[0]["xJacuzzi"] != DBNull.Value)
                this.chb_xJacuzzi.Checked = (bool)dt_R_X_[0]["xJacuzzi"];
            if (dt_R_X_[0]["xSauna"] != DBNull.Value)
                this.chb_xSauna.Checked = (bool)dt_R_X_[0]["xSauna"];

        }
        void SaveByx_()
        {

            if (cmb_xGenHeatingSystem_.SelectedValue == null)
                dt_R_X_[0]["xGenHeatingSystem_"] = DBNull.Value;
            else
                dt_R_X_[0]["xGenHeatingSystem_"] = cmb_xGenHeatingSystem_.SelectedValue;


            if (cmb_xGenCoolingSystem_.SelectedValue == null)
                dt_R_X_[0]["xGenCoolingSystem_"] = DBNull.Value;
            else
                dt_R_X_[0]["xGenCoolingSystem_"] = cmb_xGenCoolingSystem_.SelectedValue;

            if (cmb_xGenFlooring_.SelectedValue == null)
                dt_R_X_[0]["xGenFlooring_"] = DBNull.Value;
            else
                dt_R_X_[0]["xGenFlooring_"] = cmb_xGenFlooring_.SelectedValue;


            if (cmb_xGenKitchenCupboards_.SelectedValue == null)
                dt_R_X_[0]["xGenKitchenCupboards_"] = DBNull.Value;
            else
                dt_R_X_[0]["xGenKitchenCupboards_"] = cmb_xGenKitchenCupboards_.SelectedValue;

            dt_R_X_[0]["xUnitNumber"] = this.txt_xUnitNumber.Text;
            dt_R_X_[0]["xWidth"] = this.txt_xWidth.Text;
            dt_R_X_[0]["xArea"] = this.txt_xArea.Text;
            dt_R_X_[0]["xLength"] = this.txt_xlength.Text;
            dt_R_X_[0]["xToiletNumber"] = this.txt_xToiletNumber.Text;
            dt_R_X_[0]["xBathroomNumber"] = this.txt_xBathroomNumber.Text;
            dt_R_X_[0]["xBedroomsNumber"] = this.txt_xBedroomsNumber.Text;
            dt_R_X_[0]["xlength"] = this.txt_xlength.Text;
            dt_R_X_[0]["xComment"] = this.txt_xComment.Text;
            dt_R_X_[0]["xBathtub"] = this.chb_xBathtub.Checked;
            dt_R_X_[0]["xJacuzzi"] = this.chb_xJacuzzi.Checked;
            dt_R_X_[0]["xSauna"] = this.chb_xSauna.Checked;
        }
        void CmbGiveValue()
        {
            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();



            cmb_xGenHeatingSystem_.DataSource = csm.SlGenGroup("HeatingSystem");
            cmb_xGenHeatingSystem_.DisplayMember = "xName";
            cmb_xGenHeatingSystem_.ValueMember = "x_";
            cmb_xGenHeatingSystem_.SelectedIndex = -1;

          
       
            cmb_xGenCoolingSystem_.DataSource = csm.SlGenGroup("CoolingSystem");
            cmb_xGenCoolingSystem_.DisplayMember = "xName";
            cmb_xGenCoolingSystem_.ValueMember = "x_";
            cmb_xGenCoolingSystem_.SelectedIndex = -1;

       

            cmb_xGenFlooring_.DataSource = csm.SlGenGroup("Flooring");
            cmb_xGenFlooring_.DisplayMember = "xName";
            cmb_xGenFlooring_.ValueMember = "x_";
            cmb_xGenFlooring_.SelectedIndex = -1;

          

            cmb_xGenKitchenCupboards_.DataSource = csm.SlGenGroup("KitchenCupboards");
            cmb_xGenKitchenCupboards_.DisplayMember = "xName";
            cmb_xGenKitchenCupboards_.ValueMember = "x_";
            cmb_xGenKitchenCupboards_.SelectedIndex = -1;



       

        }
        private void Btn_insert_Click(object sender, EventArgs e)
        {
            if (x < 0)
            {
                if (new CS.csMessage().ShowMessageSaveYesNo())
                {
                    DataRow dr =  dt_R.NewRow();
                    if (cmb_xGenCoolingSystem_.SelectedValue == null)
                        dr["xGenCoolingSystem_"] = DBNull.Value;
                    else
                        dr["xGenCoolingSystem_"] = cmb_xGenCoolingSystem_.SelectedValue;

                    if (cmb_xGenHeatingSystem_.SelectedValue == null)
                        dr["xGenHeatingSystem_"] = DBNull.Value;
                    else
                        dr["xGenHeatingSystem_"] = cmb_xGenHeatingSystem_.SelectedValue;

                    if (cmb_xGenFlooring_.SelectedValue == null)
                        dr["xGenFlooring_"] = DBNull.Value;
                    else
                        dr["xGenFlooring_"] = cmb_xGenFlooring_.SelectedValue;

                    if (cmb_xGenKitchenCupboards_.SelectedValue == null)
                        dr["xGenKitchenCupboards_"] = DBNull.Value;
                    else
                        dr["xGenKitchenCupboards_"] = cmb_xGenKitchenCupboards_.SelectedValue;
                    dr["xRenovation_"] = xRenovation;
                    dr["xUnitNumber"] = txt_xUnitNumber.textWithoutcomma == null ? "0" : txt_xUnitNumber.textWithoutcomma;
                    dr["xArea"] = txt_xArea.textWithoutcomma == null ? "0" : txt_xArea.textWithoutcomma;
                    dr["xLength"] = txt_xlength.textWithoutcomma == null ? "0" : txt_xlength.textWithoutcomma;
                    dr["xWidth"] = txt_xWidth.textWithoutcomma == null ? "0" : txt_xWidth.textWithoutcomma;
                    dr["xBedroomsNumber"] = txt_xBedroomsNumber.textWithoutcomma == null ? "0" : txt_xBedroomsNumber.textWithoutcomma;
                    dr["xBathroomNumber"] = txt_xBathroomNumber.textWithoutcomma == null ? "0" : txt_xBathroomNumber.textWithoutcomma;
                    dr["xToiletNumber"] = txt_xToiletNumber.textWithoutcomma == null ? "0" : txt_xToiletNumber.textWithoutcomma;
                    dr["xBathtub"] = chb_xBathtub.Checked ;
                    dr["xJacuzzi"] = chb_xJacuzzi.Checked ;
                    dr["xSauna"] = chb_xSauna.Checked ;
                    dr["xComment"] = txt_xComment.Text;
                    dt_R.Rows.Add(dr);
                    new BLL.Renovation.csRenovation().UdxRenovationUnit_(dt_R);
                    this.Close();

                }
            }
            else
            {

                if (new CS.csMessage().ShowMessageSaveYesNo())
                {
                    //if (TypeUser_ == CS.csEnum.RebuildingUser.Master)
                    //{
                    //    SaveDataCorrespondence();
                    //}
                    //else
                    //{
                   SaveByx_();
                    new BLL.Renovation.csRenovation().UdRenovationUnit_Byx_(dt_R_X_);
                    this.Close();
                    //}
                }
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
