using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MIS.FRM.Indicator
{
    public partial class frmIndicatorFilingInsert : Form
    {
        public frmIndicatorFilingInsert(int x_, bool ReadOnlyForm)
        {
            InitializeComponent();
            ReadOnlyForm_ = ReadOnlyForm;
            txt_filing_date.Text = BLL.csshamsidate.shamsidate;
            CmbGiveValue();

            if (x_ > 0)
            {
                var dt_R = new BLL.Indicator.csIndicator().mIndicatorFiling_ById(x_);
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
            txt_filing_date.ReadOnly = true;
            txt_building_type.ReadOnly = true;
            btn_insert.Enabled = false;
            cmb_gen_how_refer_.Enabled = false;
            cmb_gen_transaction_type_.Enabled = false;
        }
        DAL.Indicator.DataSet_Indicator.mIndicatorFiling_ByIdDataTable dt_C;
        void CmbGiveValue()
        {
            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();
            cmb_gen_how_refer_.DataSource = csm.SlGenGroup("HowRefer");
            cmb_gen_how_refer_.DisplayMember = "xName";
            cmb_gen_how_refer_.ValueMember = "x_";
            cmb_gen_how_refer_.SelectedIndex = -1;



            cmb_gen_transaction_type_.DataSource = csm.SlGenGroup("TransactionType");
            cmb_gen_transaction_type_.DisplayMember = "xName";
            cmb_gen_transaction_type_.ValueMember = "x_";
            cmb_gen_transaction_type_.SelectedIndex = -1;
        }
        void InsertData()
        {
            dt_C = new DAL.Indicator.DataSet_Indicator.mIndicatorFiling_ByIdDataTable();
            DataRow dr_C = dt_C.NewRow();
            dr_C["supplier_"] = BLL.authentication.x_;
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

            foreach (CheckBox item in splitContainer1.Panel2.Controls.OfType<CheckBox>())
            {
                if (item.Checked == true)
                    dr_C[item.Name.Substring(4)] = true;
            }
            dt_C.Rows.Add(dr_C);
            new BLL.Indicator.csIndicator().UdIndicatorFiling_ById(dt_C);
        }
        bool FormValidate()
        {
            bool flag = true;
            Validation.VDate vd = new Validation.VDate();
            if(!vd.ValidationDate(txt_filing_date.Text))
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


            foreach (CheckBox item in splitContainer1.Panel2.Controls.OfType<CheckBox>())
            {
                if (dt_R[item.Name.Substring(4)] != DBNull.Value)
                    item.Checked = (bool)dt_R[item.Name.Substring(4)];
            }

        }

        void EditData(int x_)
        {
            DAL.Indicator.DataSet_Indicator.mIndicatorFiling_ByIdDataTable dt_C;
            
            dt_C = new BLL.Indicator.csIndicator().mIndicatorFiling_ById(x_);
            if (dt_C.Rows.Count > 0)
            {
                dt_C[0]["supplier_"] = BLL.authentication.x_;
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


                foreach (CheckBox item in splitContainer1.Panel2.Controls.OfType<CheckBox>())
                {
                    dt_C[0][item.Name.Substring(4)] = item.Checked;
                }
                new BLL.Indicator.csIndicator().UdIndicatorFiling_ById(dt_C);
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

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
