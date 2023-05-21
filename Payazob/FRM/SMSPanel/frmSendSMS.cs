using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MIS.FRM.SMSPanel
{
    public partial class frmSendSMS : Form
    {
        public frmSendSMS(List<string> st_Mob_,string xForm)
        {
            InitializeComponent();
            st_Mob = st_Mob_;
            xForm_ = xForm;
            FilltxtMobile();
        }
        List<string> st_Mob;
        string xForm_;
        void FilltxtMobile()
        {
            foreach (string item in st_Mob)
            {
                txt_MobList.Text += item.ToString() + " - ";
            }
        }
        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (st_Mob.Count > 0)
            {
                string Rs = new BLL.SMS.csSMS().SendSMS_EsfahanPayamak(txt_ContextSMS.Text, st_Mob);
                new BLL.SMS.csSMS().UdSMSLogs(txt_ContextSMS.Text, st_Mob, BLL.authentication.x_, xForm_, Rs);
                MessageBox.Show(Rs);
                this.Close();
            }
        }
    }
}
