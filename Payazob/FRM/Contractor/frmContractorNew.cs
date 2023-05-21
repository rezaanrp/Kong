using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MIS.FRM.Contractor
{
    public partial class frmContractorNew : Form
    {
        public frmContractorNew()
        {
            InitializeComponent();
            CmbGiveValue();

        }
        DAL.Contractor.DataSet_Contractor.mContractorDataTable dt_C;

        void CmbGiveValue()
        {
            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();
            cmb_xGenJob_.DataSource = csm.SlGenGroup("JOB");
            cmb_xGenJob_.DisplayMember = "xName";
            cmb_xGenJob_.ValueMember = "x_";
            cmb_xGenJob_.SelectedIndex = -1;
        }
        private void Panel_Pub_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmContractorNew_Load(object sender, EventArgs e)
        {

        }
        void Erase()
        {
            txt_xName.Text = "";
            txt_xFamily.Text = "";
            txt_xFatherName.Text = "";
            txt_xNationalCode.Text = "";
            txt_xMobile.Text = "";
            txt_xTel.Text = "";
            txt_xZone.Text = "";
            txt_xAddress.Text = "";
            cmb_xGenJob_.SelectedValue = -1;
        }
        bool chk_frm()
        {
                txt_xMobile.ForeColor = Color.Black;
                txt_xTel.ForeColor = Color.Black;
                txt_xNationalCode.ForeColor = Color.Black;
            Match m1 = Regex.Match(txt_xMobile.Text, "09(1[0-9]|3[1-9]|2[1-9])-?[0-9]{3}-?[0-9]{4}");
            Match m2 = Regex.Match(txt_xTel.Text, "^0\\d{2,3}\\d{8}$");
            Match m3 = Regex.Match(txt_xNationalCode.Text, "^([0-9]){10}$");
            if (  (m1.Success )
                && (m2.Success || txt_xTel.Text == "" || txt_xTel.Text == "0") 
                && (m3.Success || txt_xNationalCode.Text == "" || txt_xNationalCode.Text == "0") )
            {
                return true;
            }
            if (!m1.Success )
                txt_xMobile.ForeColor = Color.Red;
            if (!m2.Success)
                txt_xTel.ForeColor = Color.Red;
            if (!m3.Success)
                txt_xNationalCode.ForeColor = Color.Red;
            return false;
        }
        private void Btn_insert_Click(object sender, EventArgs e)
        {
            if (!chk_frm())
            {
                MessageBox.Show("فیلدها به درستی ثبت نمایید ");
                return;
            }

            dt_C = new DAL.Contractor.DataSet_Contractor.mContractorDataTable();
            DataTable dt_gen = new BLL.GenGroup.csGenGroup().mGenGroup("EVACONTRACTOR");
            DAL.Contractor.DataSet_Contractor.mContractorsEvaluationDataTable dt_D
                = new DAL.Contractor.DataSet_Contractor.mContractorsEvaluationDataTable();
            DataRow dr = dt_C.NewRow();
            dr["xName"] = txt_xName.Text;
            dr["xFamily"] = txt_xFamily.Text;
            dr["xFatherName"] = txt_xFatherName.Text;
            dr["xNationalCode"] = txt_xNationalCode.Text;
            dr["xMobile"] = txt_xMobile.Text;
            dr["xTel"] = txt_xTel.Text;
            dr["xZone"] = txt_xZone.Text;
            dr["xAddress"] = txt_xAddress.Text;
            dr["xSupplier_"] = BLL.authentication.x_;
            if (cmb_xGenJob_.SelectedValue != null)
                dr["xGenJob_"] = cmb_xGenJob_.SelectedValue;
            dt_C.Rows.Add(dr);
            new BLL.Contractor.csContractor().UdContractor(dt_C);

            foreach (DataRow item in dt_gen.Rows)
            {
                DataRow dr_D = dt_D.NewRow();
                if (dt_C.Rows.Count > 0)
                    dr_D["xContractors_"] = dt_C[0]["x_"];
                dr_D["xGenEvaluationName_"] = item["x_"];
                dt_D.Rows.Add(dr_D);
            }
            //new BLL.Contractor.csContractor().UdContractorsEvaluation(dt_D);
            MessageBox.Show(new BLL.Contractor.csContractor().UdContractorsEvaluation(dt_D));
            Erase();

        }

        private void txt_Form_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Name == "txt_xMobile")
            {

                string phone_regexp = "09(1[0-9]|3[1-9]|2[1-9])-?[0-9]{3}-?[0-9]{4}";
                Match m = Regex.Match(txt_xMobile.Text, phone_regexp);
                if (!m.Success)
                {
                    txt_xMobile.BackColor = Color.LightPink;
                }
                else
                {
                    txt_xMobile.BackColor = Color.LightGreen;
                }
            }
            else if ((sender as TextBox).Name == "txt_xTel")
            {

                string phone_regexp = "^0\\d{2,3}\\d{8}$";
                Match m = Regex.Match(txt_xTel.Text, phone_regexp);
                if (!m.Success)
                {
                    txt_xTel.BackColor = Color.LightPink;
                }
                else
                {
                    txt_xTel.BackColor = Color.LightGreen;
                }
            }
            else if ((sender as TextBox).Name == "txt_xNationalCode")
            {

                string phone_regexp = "^([0-9]){10}$";
                Match m = Regex.Match(txt_xNationalCode.Text, phone_regexp);
                if (!m.Success)
                {
                    txt_xNationalCode.BackColor = Color.LightPink;
                }
                else
                {
                    txt_xNationalCode.BackColor = Color.LightGreen;
                }
            }
        }
    }
}
