using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MIS.FRM.Store
{
    public partial class frmStoreInsert : Form
    {
        public frmStoreInsert(int x_, bool ReadOnlyForm)
        {
            InitializeComponent();
            IsEditing = false;
            ReadOnlyForm_ = ReadOnlyForm;
            txt_xDate.Text = BLL.csshamsidate.shamsidate;
            CmbGiveValue();

            if (x_ > 0)
            {
                var dt_R = new BLL.Store.csStore().mStore_By_x_(x_);
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
       public bool IsEditing;
        void MakeReadOnlyForm()
        {
            txt_xDate.ReadOnly = true;
            btn_insert.Enabled = false;
            cmb_xCustomer_.Enabled = false;
            //cmb_xGoods_.Enabled = false;
        }
        DAL.Store.DataSet_Store.mStoreDataTable dt_C;
        void CmbGiveValue()
        {
            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();
            cmb_xGenStatus_.DataSource = csm.SlGenGroup("STATSTORESALE");
            cmb_xGenStatus_.DisplayMember = "xName";
            cmb_xGenStatus_.ValueMember = "x_";
            cmb_xGenStatus_.SelectedIndex = -1;

            cmb_xCustomer_.DataSource = new BLL.Customer.csCustomer().mCustomer();
            cmb_xCustomer_.DisplayMember = "xName";
            cmb_xCustomer_.ValueMember = "x_";
            cmb_xCustomer_.SelectedIndex = -1;

            //cmb_xGoods_.DataSource = new BLL.Goods.csGoods().mGoods("");
            //cmb_xGoods_.DisplayMember = "xName";
            //cmb_xGoods_.ValueMember = "x_";
            //cmb_xGoods_.SelectedIndex = -1;

            cmb_xSellerUser_.DataSource = new BLL.authentication().NameOfUser();
            cmb_xSellerUser_.DisplayMember = "NameAndFamily";
            cmb_xSellerUser_.ValueMember = "x_";
            cmb_xSellerUser_.SelectedIndex = -1;

        }
        void InsertData()
        {
            dt_C = new DAL.Store.DataSet_Store.mStoreDataTable();
            DataRow dr_C = dt_C.NewRow();
            //dr_C["xRegisterDate"] = BLL.csshamsidate.shamsidate;
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


            dt_C.Rows.Add(dr_C);
            new BLL.Store.csStore().UdStore(dt_C);
        }
        bool FormValidate()
        {
            bool flag = true;
            Validation.VDate vd = new Validation.VDate();
            if (!vd.ValidationDate(txt_xDate.Text))
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
                    IsEditing = true;
                    this.Close();
                }

            }
            else
            {
                EditData(x_Pu);
                IsEditing = true;
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

        }

        void EditData(int x_)
        {
            DAL.Store.DataSet_Store.mStore_By_x_DataTable dt_C;

            dt_C = new BLL.Store.csStore().mStore_By_x_(x_);
            if (dt_C.Rows.Count > 0)
            {
             //   dt_C[0]["xRegisterDate"] = BLL.csshamsidate.shamsidate;
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

                new BLL.Store.csStore().UdStore_By_x_(dt_C);
                this.Validate();
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txt_xBuildingOwnerTel_Validating(object sender, CancelEventArgs e)
        {
            if ((sender as ControlLibrary.uc_txtBox).Text.Length == 11 || (sender as ControlLibrary.uc_txtBox).Text.Length == 0)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
