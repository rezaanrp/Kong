using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MIS.FRM.ClientReferral
{
    public partial class frmClientReferralSearch : Form
    {
        public frmClientReferralSearch()
        {
            InitializeComponent();
            CmbGiveValue();
        }

        void CmbGiveValue()
        {
            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();
            cmb_xGenResultOfReferral_.DataSource = csm.SlGenGroup("ResultOfReferral");
            cmb_xGenResultOfReferral_.DisplayMember = "xName";
            cmb_xGenResultOfReferral_.ValueMember = "x_";
            cmb_xGenResultOfReferral_.SelectedIndex = -1;
        }
        public string xClientReferral = "";
        public string xTel = "";
        public string xRequestedGoods = "";
        public int xGenResultOfReferral_ = -1;
        public bool CanceLSearch = true;

        public bool SearchxClientReferral = false;
        public bool SearchxTel = false;
        public bool SearchxRequestedGoods = false;
        public bool SearchxGenResultOfReferral_ = false;


        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {


            SearchxClientReferral = chb_xClientReferral.Checked;
            SearchxTel = chb_xTel.Checked;
            SearchxRequestedGoods = chb_xRequestedGoods.Checked;
            SearchxGenResultOfReferral_ = chb_xGenResultOfReferral_.Checked;
            xClientReferral = txt_xClientReferral.Text;
            xTel = txt_xTel.Text;
            xRequestedGoods = txt_xRequestedGoods.Text;
            if (cmb_xGenResultOfReferral_.SelectedIndex > -1)
                xGenResultOfReferral_ = (int)cmb_xGenResultOfReferral_.SelectedValue;
            CanceLSearch = false;
            this.Close();
        }

        private void chb_xClientReferral_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Name == "chb_xClientReferral")
                txt_xClientReferral.Enabled = (sender as CheckBox).Checked;
            else if ((sender as CheckBox).Name == "chb_xRequestedGoods")
                txt_xRequestedGoods.Enabled = (sender as CheckBox).Checked;
            else if ((sender as CheckBox).Name == "chb_xTel")
                txt_xTel.Enabled = (sender as CheckBox).Checked;
            else if ((sender as CheckBox).Name == "chb_xGenResultOfReferral_")
                cmb_xGenResultOfReferral_.Enabled = (sender as CheckBox).Checked;
        }
    }
}
