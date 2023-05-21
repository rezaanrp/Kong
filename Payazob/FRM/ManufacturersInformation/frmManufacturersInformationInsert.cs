using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MIS.FRM.ManufacturersInformation
{
    public partial class frmManufacturersInformationInsert : Form
    {
        public frmManufacturersInformationInsert(int x_, bool ReadOnlyForm)
        {
            InitializeComponent();
            ReadOnlyForm_ = ReadOnlyForm;
        //    txt_xDate.Text = BLL.csshamsidate.shamsidate;
            CmbGiveValue();

            if (x_ > 0)
            {
                var dt_R = new BLL.ManufacturersInformation.csManufacturersInformation().mManufacturersInformation(x_);
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
            foreach (ControlLibrary.uc_txtBox item in splitContainer1.Panel2.Controls.OfType<ControlLibrary.uc_txtBox>())
            {

                item.ReadOnly = true;  
            }
            foreach (MaskedTextBox item in splitContainer1.Panel2.Controls.OfType<MaskedTextBox>())
            {
                item.ReadOnly = true;

            }
            foreach (ComboBox item in splitContainer1.Panel2.Controls.OfType<ComboBox>())
            {
                item.Enabled = false;

            }
        }
        DAL.ManufacturersInformation.DataSet_ManufacturersInformation.mManufacturersInformationDataTable dt_C;
        void CmbGiveValue()
        {
            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();


            cmb_xGenEducation_.DataSource = csm.SlGenGroup("Education");
            cmb_xGenEducation_.DisplayMember = "xName";
            cmb_xGenEducation_.ValueMember = "x_";
            cmb_xGenEducation_.SelectedIndex = -1;

            cmb_xGenMarital_.DataSource = csm.SlGenGroup("Marital");
            cmb_xGenMarital_.DisplayMember = "xName";
            cmb_xGenMarital_.ValueMember = "x_";
            cmb_xGenMarital_.SelectedIndex = -1;

            cmb_xGenAnnualActivityVolume_.DataSource = csm.SlGenGroup("AnnualActivityVolume");
            cmb_xGenAnnualActivityVolume_.DisplayMember = "xName";
            cmb_xGenAnnualActivityVolume_.ValueMember = "x_";
            cmb_xGenAnnualActivityVolume_.SelectedIndex = -1;


            cmb_xGenAbilitiesBuyAndSell_.DataSource = csm.SlGenGroup("Abilities");
            cmb_xGenAbilitiesBuyAndSell_.DisplayMember = "xName";
            cmb_xGenAbilitiesBuyAndSell_.ValueMember = "x_";
            cmb_xGenAbilitiesBuyAndSell_.SelectedIndex = -1;


            cmb_xGenAbilitiesDesigning_.DataSource = csm.SlGenGroup("Abilities");
            cmb_xGenAbilitiesDesigning_.DisplayMember = "xName";
            cmb_xGenAbilitiesDesigning_.ValueMember = "x_";
            cmb_xGenAbilitiesDesigning_.SelectedIndex = -1;


            cmb_xGenAbilitiesImplementation_.DataSource = csm.SlGenGroup("Abilities");
            cmb_xGenAbilitiesImplementation_.DisplayMember = "xName";
            cmb_xGenAbilitiesImplementation_.ValueMember = "x_";
            cmb_xGenAbilitiesImplementation_.SelectedIndex = -1;

            cmb_xGenAbilitiesSupply_.DataSource = csm.SlGenGroup("Abilities");
            cmb_xGenAbilitiesSupply_.DisplayMember = "xName";
            cmb_xGenAbilitiesSupply_.ValueMember = "x_";
            cmb_xGenAbilitiesSupply_.SelectedIndex = -1;

            cmb_xGenAbilitiesPermissions_.DataSource = csm.SlGenGroup("Abilities");
            cmb_xGenAbilitiesPermissions_.DisplayMember = "xName";
            cmb_xGenAbilitiesPermissions_.ValueMember = "x_";
            cmb_xGenAbilitiesPermissions_.SelectedIndex = -1;


        }
        void InsertData()
        {
            dt_C = new DAL.ManufacturersInformation.DataSet_ManufacturersInformation.mManufacturersInformationDataTable();
            DataRow dr_C = dt_C.NewRow();
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




            //foreach (ControlLibrary.uc_txtBox item in groupBox2.Controls.OfType<ControlLibrary.uc_txtBox>())
            //{
            //    if (item.Text.Replace(" ", "") == "")
            //        dr_C[item.Name.Substring(4)] = DBNull.Value;
            //    else
            //        dr_C[item.Name.Substring(4)] = item.Text;
            //}
            //foreach (MaskedTextBox item in groupBox2.Controls.OfType<MaskedTextBox>())
            //{
            //    if (item.Text.Replace(" ", "") == "")
            //        dr_C[item.Name.Substring(4)] = DBNull.Value;
            //    else
            //        dr_C[item.Name.Substring(4)] = item.Text;
            //}
            //foreach (ComboBox item in groupBox2.Controls.OfType<ComboBox>())
            //{
            //    if (item.SelectedValue != null)
            //        dr_C[item.Name.Substring(4)] = item.SelectedValue;
            //}
            //foreach (ControlLibrary.uc_txtBox item in groupBox1.Controls.OfType<ControlLibrary.uc_txtBox>())
            //{
            //    if (item.Text.Replace(" ", "") == "")
            //        dr_C[item.Name.Substring(4)] = DBNull.Value;
            //    else
            //        dr_C[item.Name.Substring(4)] = item.Text;
            //}
            //foreach (MaskedTextBox item in groupBox1.Controls.OfType<MaskedTextBox>())
            //{
            //    if (item.Text.Replace(" ", "") == "")
            //        dr_C[item.Name.Substring(4)] = DBNull.Value;
            //    else
            //        dr_C[item.Name.Substring(4)] = item.Text;
            //}
            //foreach (ComboBox item in groupBox1.Controls.OfType<ComboBox>())
            //{
            //    if (item.SelectedValue != null)
            //        dr_C[item.Name.Substring(4)] = item.SelectedValue;
            //}


            //foreach (CheckBox item in groupBox1.Controls.OfType<CheckBox>())
            //{
            //    if (item.Checked == true)
            //        dr_C[item.Name.Substring(4)] = true;
            //}
            foreach (CheckBox item in splitContainer1.Panel2.Controls.OfType<CheckBox>())
            {
                if (item.Checked == true)
                    dr_C[item.Name.Substring(4)] = true;
            }
            dt_C.Rows.Add(dr_C);
            new BLL.ManufacturersInformation.csManufacturersInformation().UdManufacturersInformation(dt_C);
        }
        bool FormValidate()
        {
            bool flag = true;
            Validation.VDate vd = new Validation.VDate();
    
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
            //foreach (ControlLibrary.uc_txtBox item in groupBox1.Controls.OfType<ControlLibrary.uc_txtBox>())
            //{
            //    if (dt_R[item.Name.Substring(4)] != DBNull.Value)
            //        item.Text = dt_R[item.Name.Substring(4)].ToString();
            //}
            //foreach (ComboBox item in groupBox1.Controls.OfType<ComboBox>())
            //{
            //    if (dt_R[item.Name.Substring(4)] != DBNull.Value)
            //        item.SelectedValue = (int?)dt_R[item.Name.Substring(4)];
            //}
            //foreach (MaskedTextBox item in groupBox1.Controls.OfType<MaskedTextBox>())
            //{
            //    if (dt_R[item.Name.Substring(4)] != DBNull.Value)
            //        item.Text = dt_R[item.Name.Substring(4)].ToString();
            //}

            //foreach (ControlLibrary.uc_txtBox item in groupBox2.Controls.OfType<ControlLibrary.uc_txtBox>())
            //{
            //    if (dt_R[item.Name.Substring(4)] != DBNull.Value)
            //        item.Text = dt_R[item.Name.Substring(4)].ToString();
            //}
            //foreach (ComboBox item in groupBox2.Controls.OfType<ComboBox>())
            //{
            //    if (dt_R[item.Name.Substring(4)] != DBNull.Value)
            //        item.SelectedValue = (int?)dt_R[item.Name.Substring(4)];
            //}
            //foreach (MaskedTextBox item in groupBox2.Controls.OfType<MaskedTextBox>())
            //{
            //    if (dt_R[item.Name.Substring(4)] != DBNull.Value)
            //        item.Text = dt_R[item.Name.Substring(4)].ToString();
            //}

            foreach (CheckBox item in splitContainer1.Panel2.Controls.OfType<CheckBox>())
            {
                if (dt_R[item.Name.Substring(4)] != DBNull.Value)
                    item.Checked = (bool)dt_R[item.Name.Substring(4)];
            }
            //foreach (CheckBox item in groupBox1.Controls.OfType<CheckBox>())
            //{
            //    if (dt_R[item.Name.Substring(4)] != DBNull.Value)
            //        item.Checked = (bool)dt_R[item.Name.Substring(4)];
            //}
        }

        void EditData(int x_)
        {
            DAL.ManufacturersInformation.DataSet_ManufacturersInformation.mManufacturersInformationDataTable dt_C;

            dt_C = new BLL.ManufacturersInformation.csManufacturersInformation().mManufacturersInformation(x_);
            if (dt_C.Rows.Count > 0)
            {
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
                //foreach (ControlLibrary.uc_txtBox item in groupBox1.Controls.OfType<ControlLibrary.uc_txtBox>())
                //{
                //    if (item.Text.Replace(" ", "") == "")
                //        dt_C[0][item.Name.Substring(4)] = DBNull.Value;
                //    else
                //        dt_C[0][item.Name.Substring(4)] = item.Text;
                //}
                //foreach (MaskedTextBox item in groupBox1.Controls.OfType<MaskedTextBox>())
                //{
                //    if (item.Text.Replace(" ", "") == "")
                //        dt_C[0][item.Name.Substring(4)] = DBNull.Value;
                //    else
                //        dt_C[0][item.Name.Substring(4)] = item.Text;
                //}
                //foreach (ComboBox item in groupBox1.Controls.OfType<ComboBox>())
                //{
                //    if (item.SelectedValue != null)
                //        dt_C[0][item.Name.Substring(4)] = item.SelectedValue;
                //}

                //foreach (ControlLibrary.uc_txtBox item in groupBox2.Controls.OfType<ControlLibrary.uc_txtBox>())
                //{
                //    if (item.Text.Replace(" ", "") == "")
                //        dt_C[0][item.Name.Substring(4)] = DBNull.Value;
                //    else
                //        dt_C[0][item.Name.Substring(4)] = item.Text;
                //}
                //foreach (MaskedTextBox item in groupBox2.Controls.OfType<MaskedTextBox>())
                //{
                //    if (item.Text.Replace(" ", "") == "")
                //        dt_C[0][item.Name.Substring(4)] = DBNull.Value;
                //    else
                //        dt_C[0][item.Name.Substring(4)] = item.Text;
                //}
                //foreach (ComboBox item in groupBox2.Controls.OfType<ComboBox>())
                //{
                //    if (item.SelectedValue != null)
                //        dt_C[0][item.Name.Substring(4)] = item.SelectedValue;
                //}

                //foreach (CheckBox item in groupBox1.Controls.OfType<CheckBox>())
                //{
                //    dt_C[0][item.Name.Substring(4)] = item.Checked;
                //}
                foreach (CheckBox item in splitContainer1.Panel2.Controls.OfType<CheckBox>())
                {
                    dt_C[0][item.Name.Substring(4)] = item.Checked;
                }
                new BLL.ManufacturersInformation.csManufacturersInformation().UdManufacturersInformation(dt_C);
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
