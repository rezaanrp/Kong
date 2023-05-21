namespace MIS.CS
{
    public class csReportForm
    {
        public System.Data.DataTable OpenForm(string st)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            switch (st)
            {

                case "SlClientReferralSurveyReport":
                    dt = new BLL.ClientReferral.csClientReferral().SlClientReferralSurveyReport(DateFrom, DateTo);
                    break;
                case "SlStatementSaleIncomeSurveyReport":
                    dt = new BLL.ClientReferral.csClientReferral().SlStatementSaleIncomeSurveyReport(DateFrom, DateTo);
                    break;
                case "SlStatementRentalIncomeContractConsultant_Report":
                    dt = new BLL.RealEstate.csRealEstate().SlStatementRentalIncomeContractConsultant_Report(DateFrom, DateTo);
                    break;
                case "SlStatementSaleIncomeContractConsultant_Report":
                    dt = new BLL.RealEstate.csRealEstate().SlStatementSaleIncomeContractConsultant_Report(DateFrom, DateTo);
                    break;
                case "SlStatementRentalIncomeSurveyReport":
                    dt = new BLL.ClientReferral.csClientReferral().SlStatementRentalIncomeSurveyReport(DateFrom, DateTo);
                    break;
                case "SlHiraDemandManagerReport":
                    dt = new BLL.RealEstate.csRealEstate().SlHiraDemandManagerReport(DateFrom, DateTo);
                    break;
                case "SlHiraManagerReport":
                    dt = new BLL.RealEstate.csRealEstate().SlHiraManagerReport(DateFrom, DateTo);
                    break;
                case "SMSLOG":
                    dt = new BLL.SMS.csSMS().SlSMSLOG(DateFrom, DateTo);
                    break;
                case "SalePlan":
                 //   dt = new BLL.SalePlan.csSalePlan().SlSalePlan(DateFrom, DateTo, "");
                    break;
                default:
                    dt = new System.Data.DataTable();
                    break;
            }
            return dt;
        }
        public string DateFrom;
        public string DateTo;

    }
}
