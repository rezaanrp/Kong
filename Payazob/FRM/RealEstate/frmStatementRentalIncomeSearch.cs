using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MIS.FRM.RealEstate
{
    public partial class frmStatementRentalIncomeSearch : Form
    {
        public frmStatementRentalIncomeSearch()
        {
            InitializeComponent();
          //  CmbGiveValue();
        }

        void CmbGiveValue()
        {
            //BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();
            //cmb_xGenResultOfReferral_.DataSource = csm.SlGenGroup("ResultOfReferral");
            //cmb_xGenResultOfReferral_.DisplayMember = "xName";
            //cmb_xGenResultOfReferral_.ValueMember = "x_";
            //cmb_xGenResultOfReferral_.SelectedIndex = -1;
        }

        public string xBuildingAddress;
        public string xContractConsultant;
        public string xContractNumber;
        public string xContractManager;
        public string xLessorTel;
        public string xTenantTel;
        public string xTenantName;
        public string xLessorName;

        public bool SearchxBuildingAddress = false;
        public bool SearchxContractConsultant = false;
        public bool SearchxContractNumber = false;
        public bool SearchxContractManager = false;
        public bool SearchxLessorTel = false;
        public bool SearchxTenantTel = false;
        public bool SearchxTenantName = false;
        public bool SearchxLessorName = false;

        public bool CancelSearch = true;


        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            //SearchxClientReferral = chb_xContractNumber.Checked;
            //SearchxTel = chb_xContractConsultant.Checked;
            //SearchxRequestedGoods = chb_xBuildingAddress.Checked;
            //SearchxGenResultOfReferral_ = chb_xGenResultOfReferral_.Checked;
            //xClientReferral = txt_xContractNumber.Text;
            //xTel = txt_xContractConsultant.Text;
            //xRequestedGoods = txt_xBuildingAddress.Text;
            //if (cmb_xGenResultOfReferral_.SelectedIndex > -1)
            //    xGenResultOfReferral_ = (int)cmb_xGenResultOfReferral_.SelectedValue;

            xBuildingAddress = txt_xBuildingAddress.Text;
          SearchxBuildingAddress = chb_xBuildingAddress.Checked;

          xContractConsultant = txt_xContractConsultant.Text;
          SearchxContractConsultant = chb_xContractConsultant.Checked;

          xContractNumber = txt_xContractNumber.Text;
          SearchxContractNumber = chb_xContractNumber.Checked;

          xContractManager= txt_xContractManager.Text;
          SearchxContractManager = chb_xContractManager.Checked;

          xLessorTel = txt_xLessorTel.Text;
          SearchxLessorTel = chb_xLessorTel.Checked;

          xTenantTel = txt_xTenantTel.Text;
          SearchxTenantTel = chb_xTenantTel.Checked;

          xTenantName = txt_xTenantName.Text;
          SearchxTenantName = chb_xTenantName.Checked;

          xLessorName= txt_xLessorName.Text;
          SearchxLessorName = chb_xLessorName.Checked;
            CancelSearch = false;
            this.Close();
        }

        private void chb_xClientReferral_CheckedChanged(object sender, EventArgs e)
        {
                ControlLibrary.uc_txtBox  d = 
                this.splitContainer1.Panel2.Controls.Find("txt_" + (sender as CheckBox).Name.Substring(4), true).FirstOrDefault() 
                as ControlLibrary.uc_txtBox;
                d.Enabled = (sender as CheckBox).Checked;
        }
    }
}
