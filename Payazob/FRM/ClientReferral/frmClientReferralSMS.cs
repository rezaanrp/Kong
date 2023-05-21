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
    public partial class frmClientReferralSMS : Form
    {
        public frmClientReferralSMS(int x_)
        {
            InitializeComponent();
            x_P = x_;
            LoadForm();
        }
        int x_P;
        DAL.SMS.DataSet_SMSLog.mSMSContext_Byx_DataTable dt_S;
        void LoadForm()
        {
            dt_S = new BLL.SMS.csSMS().mSMSContext_Byx_(x_P);
            string st="";
            if (dt_S.Rows.Count > 0)
                st = dt_S.Rows[0]["xSMS"].ToString();

            uc_txtBox_Context.Text = st;

        }
        void SaveForm()
        {
            if(dt_S.Rows.Count > 0)
            {
                dt_S[0]["xSMS"] = uc_txtBox_Context.Text;

                MessageBox.Show( new BLL.SMS.csSMS().UdSMSContext_Byx_(dt_S) ); 
            }
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            SaveForm();
        }
    }
}
