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
    public partial class frmRenovationRegister : Form
    {
        public frmRenovationRegister(int xCustomer_, int x_, CS.csEnum.RebuildingUser TypeUser)
        {
            InitializeComponent();
            Cust = xCustomer_;
            x = x_;
            CmbGiveValue();
            if (x_ > 0)
            {
                SetValueForm(x_);
            }
            //if (TypeUser_ == CS.csEnum.RebuildingUser.Master)
            //{
            //    GenDatatableForCorrespondence();

            //    ((Control)this.tabPage2).Enabled = false;
            //    ((Control)this.tabPage1).Enabled = false;
            //    panel_Pub.Enabled = false;
            //    tbc_01.SelectedTab = tabPage3;
            //}
            //else
            //{
            //    ((Control)this.tabPage3).Enabled = false;
            //    ((Control)this.tabPage4).Enabled = false;
            //}

        }
        CS.csEnum.RebuildingUser TypeUser_;
        DAL.Renovation.DataSet_Renovation.mRenovation_Byx_DataTable dt_R;
        int Cust = -1;
        int x;
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

         

        }
        void SetValueForm(int x_)
        {
            dt_R = new BLL.Renovation.csRenovation().mRenovationByx_(x_);
            if (dt_R[0]["xGenUsageType_"] != DBNull.Value)
                cmb_xGenUsageType_.SelectedValue = (int?)dt_R[0]["xGenUsageType_"];
            if (dt_R[0]["xBuildingStatus_"] != DBNull.Value)
                cmb_xGenBuldingStatus_.SelectedValue = (int?)dt_R[0]["xBuildingStatus_"];
            if (dt_R[0]["xGenContractType_"] != DBNull.Value)
                cmb_xGenContractType_.SelectedValue = (int?)dt_R[0]["xGenContractType_"];
            if (dt_R[0]["xGenPosition_"] != DBNull.Value)
                cmb_xGenPosition_.SelectedValue = (int?)dt_R[0]["xGenPosition_"];

  
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

            if (dt_R[0]["xParkingNumber"] != DBNull.Value)
                this.txt_xParkingNumber.Text = dt_R[0]["xParkingNumber"].ToString();

            if (dt_R[0]["xStorageNumber"] != DBNull.Value)
                this.txt_xStorageNumber.Text = dt_R[0]["xStorageNumber"].ToString();

            if (dt_R[0]["xlength"] != DBNull.Value)
                this.txt_xlength.Text = dt_R[0]["xlength"].ToString();
            if (dt_R[0]["xZone"] != DBNull.Value)
                this.txt_xZone.Text = dt_R[0]["xZone"].ToString();
            if (dt_R[0]["xComment"] != DBNull.Value)
                this.txt_xComment.Text = dt_R[0]["xComment"].ToString();

            if (dt_R[0]["xLicenseRenovation"] != DBNull.Value)
                this.chb_xLicenseRebuilding.Checked = (bool)dt_R[0]["xLicenseRenovation"];
            if (dt_R[0]["xProductionLicense"] != DBNull.Value)
                this.chb_xProductionLicense.Checked = (bool)dt_R[0]["xProductionLicense"];

        }
        void SaveByx_()
        {
            if (cmb_xGenUsageType_.SelectedValue == null)
                dt_R[0]["xGenUsageType_"] = DBNull.Value;
            else
                dt_R[0]["xGenUsageType_"] = cmb_xGenUsageType_.SelectedValue;

            if (cmb_xGenBuldingStatus_.SelectedValue == null)
                dt_R[0]["xBuildingStatus_"] = DBNull.Value;
            else
                dt_R[0]["xBuildingStatus_"] = cmb_xGenBuldingStatus_.SelectedValue;

            if (cmb_xGenContractType_.SelectedValue == null)
                dt_R[0]["xGenContractType_"] = DBNull.Value;
            else
                dt_R[0]["xGenContractType_"] = cmb_xGenContractType_.SelectedValue;

            if (cmb_xGenPosition_.SelectedValue == null)
                dt_R[0]["xGenPosition_"] = DBNull.Value;
            else
                dt_R[0]["xGenPosition_"] = cmb_xGenPosition_.SelectedValue;
            dt_R[0]["xAddress"] = this.uc_txtBox_xAddress.Text;
            dt_R[0]["xWidth"] = this.txt_xWidth.Text;
            dt_R[0]["xArea"] = this.txt_xArea.Text;
            dt_R[0]["xBuildingUnitsNumberRequest"] = this.txt_xBuildingUnitsNumberRequest.Text;
            dt_R[0]["xFloorsNumber"] = this.txt_xFloorsNumber.Text;
            dt_R[0]["xlength"] = this.txt_xlength.Text;
            dt_R[0]["xZone"] = this.txt_xZone.Text;
            dt_R[0]["xLicenseRenovation"] = this.chb_xLicenseRebuilding.Checked;
            dt_R[0]["xProductionLicense"] = this.chb_xProductionLicense.Checked;
            dt_R[0]["xComment"] = this.txt_xComment.Text;

            dt_R[0]["xComment"] = this.txt_xComment.Text;

            dt_R[0]["xParkingNumber"] = this.txt_xParkingNumber.Text;
            dt_R[0]["xStorageNumber"] = this.txt_xStorageNumber.Text;

        }
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Btn_insert_Click(object sender, EventArgs e)
        {
            if (x < 0)
            {
                if (new CS.csMessage().ShowMessageSaveYesNo())
                {
                    new BLL.Renovation.csRenovation().InRenovation(BLL.csshamsidate.shamsidate,
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
                    txt_xFloorsNumber.textWithoutcomma == null ? 0 : int.Parse(txt_xFloorsNumber.textWithoutcomma),
                     txt_xBuildingUnitsNumberRequest.textWithoutcomma == null ? 0 : int.Parse(txt_xBuildingUnitsNumberRequest.textWithoutcomma),
                    txt_xParkingNumber.textWithoutcomma == null ? 0 : int.Parse(txt_xParkingNumber.textWithoutcomma),
                    txt_xStorageNumber.textWithoutcomma == null ? 0 : int.Parse(txt_xStorageNumber.textWithoutcomma),
                    txt_xComment.Text,
                    BLL.authentication.x_
                    );
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
                        new BLL.Renovation.csRenovation().UdRenovationByx_(dt_R);
                        this.Close();
                    //}
                }
            }
        }
        private void Btn_Print_Click(object sender, EventArgs e)
        {
            Report.SendReport cs = new Report.SendReport();
            frmReport r = new frmReport();
            DataTable dt = new BLL.Renovation.csRenovation().SlRenovationByx_(x);
            r.GetReport = cs.GetReport(dt, "crsRenovationByx_");
            r.ShowDialog();
            r.Dispose();
        }
    }
}
