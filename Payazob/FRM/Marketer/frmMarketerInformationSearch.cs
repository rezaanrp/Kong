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
    public partial class frmMarketerInformationSearch : Form
    {
        public frmMarketerInformationSearch()
        {
            InitializeComponent();
            CmbGiveValue();
        }

        void CmbGiveValue()
        {

        }
        public string xBuildingOwner = "";
        public string xBuildingOwnerTel = "";
        public bool CanceLSearch = true;

        public bool SearchxBuildingOwner = false;
        public bool SearchxBuildingOwnerTel = false;


        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {


            SearchxBuildingOwner = chb_xBuildingOwner.Checked;
            SearchxBuildingOwnerTel = chb_xBuildingOwnerTel.Checked;
            xBuildingOwner = txt_xBuildingOwner.Text;
            xBuildingOwnerTel = txt_xBuildingOwnerTel.Text;
            CanceLSearch = false;
            this.Close();
        }

        private void chb_xClientReferral_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Name == "chb_xBuildingOwner")
                txt_xBuildingOwner.Enabled = (sender as CheckBox).Checked;

            else if ((sender as CheckBox).Name == "chb_xBuildingOwnerTel")
                txt_xBuildingOwnerTel.Enabled = (sender as CheckBox).Checked;

        }
    }
}
