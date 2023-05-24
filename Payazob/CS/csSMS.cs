using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace MIS.CS
{
    public class csSMS
    {
        public void CheckRentalIncomeSmsBeforeEndContract()
        {
            var dt = new BLL.RealEstate.csRealEstate().SlStatementRentalIncomeSmsBeforeEndContract(60);
            if (dt.Rows.Count > 0)
            {

                List<string> MobLessor = new List<string>();
                List<string> MobTenant = new List<string>();

                foreach (DataRow item in dt.Rows)
                {
                    if (item["xLessorTel"] != DBNull.Value)
                    {
                       MobLessor.Add(item["xLessorTel"].ToString());
                    }
                    if (item["xTenantTel"] != DBNull.Value)
                    {
                        MobTenant.Add(item["xTenantTel"].ToString());
                    }
                    item["xSmsBeforeEndContract"] = 1;
                }

                DataTable dt_t = new BLL.SMS.csSMS().mSMSContext_Byx_(3);
                DataTable dt_l = new BLL.SMS.csSMS().mSMSContext_Byx_(2);
                string smstextTenant = "";
                string smstextLessor = "";
                //if (dt_t.Rows.Count > 0)
                //    smstextTenant = "تست";
                //if (dt_l.Rows.Count > 0)
                //    smstextLessor = "تست";
                if (dt_t.Rows.Count > 0)
                    smstextTenant = dt_t.Rows[0]["xSMS"].ToString();
                if (dt_l.Rows.Count > 0)
                    smstextLessor = dt_l.Rows[0]["xSMS"].ToString();

                string Rl = new BLL.SMS.csSMS().SendSMS_EsfahanPayamak(smstextLessor, MobLessor);
                string Rt = new BLL.SMS.csSMS().SendSMS_EsfahanPayamak(smstextTenant, MobTenant);

                string Sms_For_manager = "ارسال پیام تمدید قرارداد اجاره برای شماره قراداد های ";
                List<string> Sms_For_manager_Number = new List<string>();

                DataTable dt_sm = new BLL.GenGroup.csGenGroup().SlGenGroup("SMSStatementRentalManager");

                foreach (DataRow item in dt_sm.Rows)
                {
                    Sms_For_manager_Number.Add(item["xName"].ToString());
                }
                foreach (DataRow dr in dt.Rows)
                {
                    Sms_For_manager += dr["xContractNumber"].ToString() + " ";
                }
                string RLog = new BLL.SMS.csSMS().SendSMS_EsfahanPayamak(Sms_For_manager, Sms_For_manager_Number);

                new BLL.RealEstate.csRealEstate().UdStatementRentalIncomeSmsBeforeEndContract(dt);

                float dd;
                if (
                    float.TryParse(Rl.Replace("[", "").Replace("]", ""), out dd)

                    )
                {
                    new BLL.SMS.csSMS().UdSMSLogs(smstextTenant, MobTenant, BLL.authentication.x_, "StatementRentalIncome_Tenant", Rl);
                    new BLL.SMS.csSMS().UdSMSLogs(smstextLessor, MobLessor, BLL.authentication.x_, "StatementRentalIncome_Lessor", Rt);
                }

                if (
                float.TryParse(RLog.Replace("[", "").Replace("]", ""), out dd)

                    )
                {
                    new BLL.SMS.csSMS().UdSMSLogs(Sms_For_manager, Sms_For_manager_Number, BLL.authentication.x_, "StatementRentalIncome_Tenant", RLog);
                }
            }
        }
    }
}
