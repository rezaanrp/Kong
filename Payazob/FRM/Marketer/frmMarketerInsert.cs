using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MIS.FRM.Marketer
{
    public partial class frmMarketerInsert : Form
    {
        public frmMarketerInsert(int x_, bool ReadOnlyForm)
        {
            InitializeComponent();
            ReadOnlyForm_ = ReadOnlyForm;
            txt_xDate.Text = BLL.csshamsidate.shamsidate;
            CmbGiveValue();

            if (x_ > 0)
            {
                var dt_R = new BLL.Marketer.csMarketer().mMarketerInformation_By_x_(x_);
                SetValueForm(dt_R[0]);
            }
            else if (x_ < 0)
            {
                // dvgLoad();
            }
            x_Pu = x_;
            if (ReadOnlyForm)
                MakeReadOnlyForm();

        }
        int x_Pu;
        bool ReadOnlyForm_;
        void MakeReadOnlyForm()
        {
            txt_xDate.ReadOnly = true;
            txt_xBuildingOwner.ReadOnly = true;
            txt_xArea.ReadOnly = true;
            txt_xAddress.ReadOnly = true;
            btn_insert.Enabled = false;
            txt_xGuardTel.ReadOnly = true;
            txt_xInterViewerJob.ReadOnly = true;
            txt_xInterViewerTel.ReadOnly = true;
            txt_xSiteManegerTel.ReadOnly = true;
            txt_xContractorTel.ReadOnly = true;
            txt_xBuildingOwnerTel.ReadOnly = true;
            txt_xInterViewer.ReadOnly = true;
            txt_xGuardName.ReadOnly = true;
            txt_xContractor.ReadOnly = true;
            txt_xSiteManeger.ReadOnly = true;
            chb_xFloorCoverings.Enabled = false;
            chb_xConcrete.Enabled = false;
            chb_xDecorationInside.Enabled = false;
            txt_xOtherService.ReadOnly = true;
            chb_xStoneAndBricks.Enabled = false;
            chb_xKitchen.Enabled = false;
            chb_xWoodenProducts.Enabled = false;
            chb_xWallCoverings.Enabled = false;
            chb_xFacilities.Enabled = false;
            chb_xDesignService.Enabled = false;
            txt_xBuildingLicenseDate.ReadOnly = true;
            txt_xComment.ReadOnly = true;
            cmb_xBulidingTypeService_.Enabled = false;
            cmb_xConstractionState_.Enabled = false;
            cmb_xGenUsage_.Enabled = false;
            txt_xIntroductionCode.ReadOnly = true;
            txt_xIntroductionFor.ReadOnly = true;
            txt_xUnitNumber.ReadOnly = true;
            txt_xFloorNumber.ReadOnly = true;
        }
        DAL.Marketer.DataSet_MarketerInformation.mMarketerInformationDataTable dt_C;
        void CmbGiveValue()
        {
            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();
            cmb_xBulidingTypeService_.DataSource = csm.SlGenGroup("BULIDINGTYPESERVICE");
            cmb_xBulidingTypeService_.DisplayMember = "xName";
            cmb_xBulidingTypeService_.ValueMember = "x_";
            cmb_xBulidingTypeService_.SelectedIndex = -1;

            cmb_xConstractionState_.DataSource = csm.SlGenGroup("CONSTRACTIONSTATE");
            cmb_xConstractionState_.DisplayMember = "xName";
            cmb_xConstractionState_.ValueMember = "x_";
            cmb_xConstractionState_.SelectedIndex = -1;

            cmb_xGenUsage_.DataSource = csm.SlGenGroup("UsageType");
            cmb_xGenUsage_.DisplayMember = "xName";
            cmb_xGenUsage_.ValueMember = "x_";
            cmb_xGenUsage_.SelectedIndex = -1;
        }
        void InsertData()
        {
            dt_C = new DAL.Marketer.DataSet_MarketerInformation.mMarketerInformationDataTable();
            DataRow dr_C = dt_C.NewRow();
            dr_C["xRegisterDate"] = BLL.csshamsidate.shamsidate;
            dr_C["xSupplier_"] = BLL.authentication.x_;
            foreach (ControlLibrary.uc_txtBox item in splitContainer1.Panel2.Controls.OfType<ControlLibrary.uc_txtBox>())
            {
                if (item.Text.Replace(" ", "") == "")
                    dr_C[item.Name.Substring(4)] = DBNull.Value;
                else
                    dr_C[item.Name.Substring(4)] = item.Text;
            }
            foreach (MaskedTextBox item in splitContainer1.Panel2.Controls.OfType<MaskedTextBox>())
            {
                if (item.Text.Replace(" ", "") == "")
                    dr_C[item.Name.Substring(4)] = DBNull.Value;
                else
                    dr_C[item.Name.Substring(4)] = item.Text;
            }
            foreach (ComboBox item in splitContainer1.Panel2.Controls.OfType<ComboBox>())
            {
                if (item.SelectedValue != null)
                    dr_C[item.Name.Substring(4)] = item.SelectedValue;
            }




            foreach (ControlLibrary.uc_txtBox item in groupBox2.Controls.OfType<ControlLibrary.uc_txtBox>())
            {
                if (item.Text.Replace(" ", "") == "")
                    dr_C[item.Name.Substring(4)] = DBNull.Value;
                else
                    dr_C[item.Name.Substring(4)] = item.Text;
            }
            foreach (MaskedTextBox item in groupBox2.Controls.OfType<MaskedTextBox>())
            {
                if (item.Text.Replace(" ", "") == "")
                    dr_C[item.Name.Substring(4)] = DBNull.Value;
                else
                    dr_C[item.Name.Substring(4)] = item.Text;
            }
            foreach (ComboBox item in groupBox2.Controls.OfType<ComboBox>())
            {
                if (item.SelectedValue != null)
                    dr_C[item.Name.Substring(4)] = item.SelectedValue;
            }
            foreach (ControlLibrary.uc_txtBox item in groupBox1.Controls.OfType<ControlLibrary.uc_txtBox>())
            {
                if (item.Text.Replace(" ", "") == "")
                    dr_C[item.Name.Substring(4)] = DBNull.Value;
                else
                    dr_C[item.Name.Substring(4)] = item.Text;
            }
            foreach (MaskedTextBox item in groupBox1.Controls.OfType<MaskedTextBox>())
            {
                if (item.Text.Replace(" ", "") == "")
                    dr_C[item.Name.Substring(4)] = DBNull.Value;
                else
                    dr_C[item.Name.Substring(4)] = item.Text;
            }
            foreach (ComboBox item in groupBox1.Controls.OfType<ComboBox>())
            {
                if (item.SelectedValue != null)
                    dr_C[item.Name.Substring(4)] = item.SelectedValue;
            }


            foreach (CheckBox item in groupBox1.Controls.OfType<CheckBox>())
            {
                if (item.Checked == true)
                    dr_C[item.Name.Substring(4)] = true;
            }
            foreach (CheckBox item in splitContainer1.Panel2.Controls.OfType<CheckBox>())
            {
                if (item.Checked == true)
                    dr_C[item.Name.Substring(4)] = true;
            }
            dt_C.Rows.Add(dr_C);
            new BLL.Marketer.csMarketer().UdMarketerInformation(dt_C);
        }
        bool FormValidate()
        {
            bool flag = true;
            Validation.VDate vd = new Validation.VDate();
            if(!vd.ValidationDate(txt_xDate.Text))
            {
                MessageBox.Show("تاریخ را صحیح وارد کنید");
                return false;
            }
                return flag;
        }
        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (x_Pu < 0)
            {
                if (FormValidate())
                {
                    InsertData();
                    this.Close();
                }

            }
            else
            {
                EditData(x_Pu);
                this.Close();

            }
        }
        void SetValueForm(DataRow dt_R)
        {
            foreach (ControlLibrary.uc_txtBox item in splitContainer1.Panel2.Controls.OfType<ControlLibrary.uc_txtBox>())
            {
                if (dt_R[item.Name.Substring(4)] != DBNull.Value)
                    item.Text = dt_R[item.Name.Substring(4)].ToString();
            }
            foreach (ComboBox item in splitContainer1.Panel2.Controls.OfType<ComboBox>())
            {
                if (dt_R[item.Name.Substring(4)] != DBNull.Value)
                    item.SelectedValue = (int?)dt_R[item.Name.Substring(4)];
            }
            foreach (MaskedTextBox item in splitContainer1.Panel2.Controls.OfType<MaskedTextBox>())
            {
                if (dt_R[item.Name.Substring(4)] != DBNull.Value)
                    item.Text = dt_R[item.Name.Substring(4)].ToString();
            }
            foreach (ControlLibrary.uc_txtBox item in groupBox1.Controls.OfType<ControlLibrary.uc_txtBox>())
            {
                if (dt_R[item.Name.Substring(4)] != DBNull.Value)
                    item.Text = dt_R[item.Name.Substring(4)].ToString();
            }
            foreach (ComboBox item in groupBox1.Controls.OfType<ComboBox>())
            {
                if (dt_R[item.Name.Substring(4)] != DBNull.Value)
                    item.SelectedValue = (int?)dt_R[item.Name.Substring(4)];
            }
            foreach (MaskedTextBox item in groupBox1.Controls.OfType<MaskedTextBox>())
            {
                if (dt_R[item.Name.Substring(4)] != DBNull.Value)
                    item.Text = dt_R[item.Name.Substring(4)].ToString();
            }

            foreach (ControlLibrary.uc_txtBox item in groupBox2.Controls.OfType<ControlLibrary.uc_txtBox>())
            {
                if (dt_R[item.Name.Substring(4)] != DBNull.Value)
                    item.Text = dt_R[item.Name.Substring(4)].ToString();
            }
            foreach (ComboBox item in groupBox2.Controls.OfType<ComboBox>())
            {
                if (dt_R[item.Name.Substring(4)] != DBNull.Value)
                    item.SelectedValue = (int?)dt_R[item.Name.Substring(4)];
            }
            foreach (MaskedTextBox item in groupBox2.Controls.OfType<MaskedTextBox>())
            {
                if (dt_R[item.Name.Substring(4)] != DBNull.Value)
                    item.Text = dt_R[item.Name.Substring(4)].ToString();
            }

            foreach (CheckBox item in splitContainer1.Panel2.Controls.OfType<CheckBox>())
            {
                if (dt_R[item.Name.Substring(4)] != DBNull.Value)
                    item.Checked = (bool)dt_R[item.Name.Substring(4)];
            }
            foreach (CheckBox item in groupBox1.Controls.OfType<CheckBox>())
            {
                if (dt_R[item.Name.Substring(4)] != DBNull.Value)
                    item.Checked = (bool)dt_R[item.Name.Substring(4)];
            }
        }

        void EditData(int x_)
        {
            DAL.Marketer.DataSet_MarketerInformation.mMarketerInformation_By_x_DataTable dt_C;

            dt_C = new BLL.Marketer.csMarketer().mMarketerInformation_By_x_(x_);
            if (dt_C.Rows.Count > 0)
            {
                dt_C[0]["xRegisterDate"] = BLL.csshamsidate.shamsidate;
                dt_C[0]["xSupplier_"] = BLL.authentication.x_;
                foreach (ControlLibrary.uc_txtBox item in splitContainer1.Panel2.Controls.OfType<ControlLibrary.uc_txtBox>())
                {
                    if (item.Text.Replace(" ", "") == "")
                        dt_C[0][item.Name.Substring(4)] = DBNull.Value;
                    else
                        dt_C[0][item.Name.Substring(4)] = item.Text;
                }
                foreach (MaskedTextBox item in splitContainer1.Panel2.Controls.OfType<MaskedTextBox>())
                {
                    if (item.Text.Replace(" ", "") == "")
                        dt_C[0][item.Name.Substring(4)] = DBNull.Value;
                    else
                        dt_C[0][item.Name.Substring(4)] = item.Text;
                }
                foreach (ComboBox item in splitContainer1.Panel2.Controls.OfType<ComboBox>())
                {
                    if (item.SelectedValue != null)
                        dt_C[0][item.Name.Substring(4)] = item.SelectedValue;
                }
                foreach (ControlLibrary.uc_txtBox item in groupBox1.Controls.OfType<ControlLibrary.uc_txtBox>())
                {
                    if (item.Text.Replace(" ", "") == "")
                        dt_C[0][item.Name.Substring(4)] = DBNull.Value;
                    else
                        dt_C[0][item.Name.Substring(4)] = item.Text;
                }
                foreach (MaskedTextBox item in groupBox1.Controls.OfType<MaskedTextBox>())
                {
                    if (item.Text.Replace(" ", "") == "")
                        dt_C[0][item.Name.Substring(4)] = DBNull.Value;
                    else
                        dt_C[0][item.Name.Substring(4)] = item.Text;
                }
                foreach (ComboBox item in groupBox1.Controls.OfType<ComboBox>())
                {
                    if (item.SelectedValue != null)
                        dt_C[0][item.Name.Substring(4)] = item.SelectedValue;
                }

                foreach (ControlLibrary.uc_txtBox item in groupBox2.Controls.OfType<ControlLibrary.uc_txtBox>())
                {
                    if (item.Text.Replace(" ", "") == "")
                        dt_C[0][item.Name.Substring(4)] = DBNull.Value;
                    else
                        dt_C[0][item.Name.Substring(4)] = item.Text;
                }
                foreach (MaskedTextBox item in groupBox2.Controls.OfType<MaskedTextBox>())
                {
                    if (item.Text.Replace(" ", "") == "")
                        dt_C[0][item.Name.Substring(4)] = DBNull.Value;
                    else
                        dt_C[0][item.Name.Substring(4)] = item.Text;
                }
                foreach (ComboBox item in groupBox2.Controls.OfType<ComboBox>())
                {
                    if (item.SelectedValue != null)
                        dt_C[0][item.Name.Substring(4)] = item.SelectedValue;
                }

                foreach (CheckBox item in groupBox1.Controls.OfType<CheckBox>())
                {
                    dt_C[0][item.Name.Substring(4)] = item.Checked;
                }
                foreach (CheckBox item in splitContainer1.Panel2.Controls.OfType<CheckBox>())
                {
                    dt_C[0][item.Name.Substring(4)] = item.Checked;
                }
                new BLL.Marketer.csMarketer().UdMarketerInformation_By_x_(dt_C);
                this.Validate();
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txt_xBuildingOwnerTel_Validating(object sender, CancelEventArgs e)
        {
            if ( (sender as ControlLibrary.uc_txtBox).Text.Length == 11 || (sender as ControlLibrary.uc_txtBox).Text.Length == 0)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
