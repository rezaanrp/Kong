
using System.Windows.Forms;
using System.Drawing;
namespace MIS.CS
{
    public class csOpenForm
    {
        public void FindForm(string frm, string TitleForm)
        {
            Form f;
            switch (frm)
            {
                case "IndicatorFiling":
                    f = new FRM.Indicator.frmIndicatorFiling(true);
                    break;
                case "ManufacturersInformation_Process":
                    f = new FRM.ManufacturersInformation.frmManufacturersInformation(true);
                    break;
                case "ManufacturersInformation":
                    f = new FRM.ManufacturersInformation.frmManufacturersInformation(false);
                    break;
                case "SlClientReferralSurveyReport":
                    f = new frmEmpty_Report("SlClientReferralSurveyReport", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).FilterDateTo_Visible = true;
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
                    (f as frmEmpty_Report).SetParamSize("xQuestion", 400);

                    break;
                case "StatementRefer":
                    f = new FRM.RealEstate.frmStatementRefer(csEnum.StatementReferTo.amlak);
                    break;
                case "StatementRefer_Finance":
                    f = new FRM.RealEstate.frmStatementRefer(csEnum.StatementReferTo.mali);
                    break;
                case "StatementRefer_Execute":
                    f = new FRM.RealEstate.frmStatementRefer(csEnum.StatementReferTo.ejrae);
                    break;
                case "StatementRefer_Desgin":
                    f = new FRM.RealEstate.frmStatementRefer(csEnum.StatementReferTo.tarahi);
                    break;
                case "StatementRefer_Store":
                    f = new FRM.RealEstate.frmStatementRefer(csEnum.StatementReferTo.foroshgah);
                    break;
                //StatementRefer
                case "SlStatementSaleIncomeSurveyReport":
                    f = new frmEmpty_Report("SlStatementSaleIncomeSurveyReport", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).FilterDateTo_Visible = true;
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
                    (f as frmEmpty_Report).SetParamSize("xQuestion", 400);

                    break;
                case "SlStatementSaleIncomeContractConsultant_Report":
                    f = new frmEmpty_Report("SlStatementSaleIncomeContractConsultant_Report", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).FilterDateTo_Visible = true;
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
                    break;
                case "SlStatementRentalIncomeContractConsultant_Report":
                    f = new frmEmpty_Report("SlStatementRentalIncomeContractConsultant_Report", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).FilterDateTo_Visible = true;
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
                    break;
                case "SlClientReferral_Refer_Finance":
                    f = new FRM.ClientReferral.frmClientReferralReferTo(csEnum.ReferTo.mali);
                    break;
                case "SlStatementRentalIncomeSurveyReport":
                    f = new frmEmpty_Report("SlStatementRentalIncomeSurveyReport", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).FilterDateTo_Visible = true;
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
                    (f as frmEmpty_Report).SetParamSize("xQuestion", 400);

                    break;
                case "SlClientReferral_Refer_RealEstate":
                    f = new FRM.ClientReferral.frmClientReferralReferTo( csEnum.ReferTo.amlak);
                    break;
                case "SlClientReferral_Refer_Desgin":
                    f = new FRM.ClientReferral.frmClientReferralReferTo(csEnum.ReferTo.tarahi);
                    break;
                case "SlClientReferral_Refer_Execute":
                    f = new FRM.ClientReferral.frmClientReferralReferTo(csEnum.ReferTo.ejrae);
                    break;
                case "SlHiraDemandManagerReport":
                    f = new frmEmpty_Report("SlHiraDemandManagerReport", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).FilterDateTo_Visible = true;
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
                    break;
                case "SlHiraManagerReport":
                    f = new frmEmpty_Report("SlHiraManagerReport", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).FilterDateTo_Visible = true;
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
                    break;
                case "RealEstate_General":
                    f = new FRM.RealEstate.frmRealEstate_GeneralReport();
                    break;
                case "StatementSaleIncome_Financial":
                    f = new FRM.RealEstate.frmStatementSaleIncome(csEnum.FactorySection.Financial);
                    break;
                case "StatementSaleIncome":
                    f = new FRM.RealEstate.frmStatementSaleIncome(csEnum.FactorySection.Edari);
                    break;
                case "StatementRentalIncome":
                    f = new FRM.RealEstate.frmStatementRentalIncome( csEnum.FactorySection.Edari);
                    break;
                case "StatementRentalIncome_Financial":
                    f = new FRM.RealEstate.frmStatementRentalIncome(csEnum.FactorySection.Financial);
                    break;
                case "SMSLOG":
                    f = new frmEmpty_Report("SMSLOG", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).FilterDateTo_Visible = true;
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
                    break;
                case "ClientReferralSMS":
                    f = new FRM.ClientReferral.frmClientReferralSMS(1);
                    break;
                case "MarketerInformationFollowUpBoos":
                    f = new FRM.Marketer.frmMarketerInformationFollowUp(true);
                    break;
                case "MarketerInformationFollowUp":
                    f = new FRM.Marketer.frmMarketerInformationFollowUp(false);
                    break;
                case "ClientReferralFollowUp":
                    f = new FRM.ClientReferral.frmClientReferralFollowUp();
                    break;
                case "Store":
                    f = new FRM.Store.frmStore(false);
                    break;
                case "Store_Report":
                    f = new FRM.Store.frmStore(true);
                    break;
                case "GoodsAndSupplierInfo":
                    f = new FRM.GoodsAndSupplierInfo.frmGoodsAndSupplierInfo();
                    break;
                case "Company":
                    f = new FRM.Company.frmCompany();
                    break;
                case "GenGroup_GOODSGROUP":
                    f = new FRM.GenGroup.frmGenGroup("GOODSGROUP", true, true, false, true, false);
                    break;
                case "Goods":
                    f = new FRM.Goods.frmGoods();
                    break;
                case "MarketerInformation_Report":
                    f = new FRM.Marketer.frmMarketerInformation(true);
                    break;
                case "ClientReferral":
                    f = new FRM.ClientReferral.frmClientReferral();
                    break;
                case "MarketerInformation":
                    f = new FRM.Marketer.frmMarketerInformation(false);
                    break;
                case "Register":
                    f = new FRM.RegisterUser.mRegister();
                    break;

                case "RenovationProjectCheckMaster":
                    f = new FRM.Renovation.frmRenovationProjectCheckMaster();
                    break;
                case "Question":
                    f = new FRM.Question.frmQuestion();
                    break;
                case "ContractorsEvaluation":
                    f = new FRM.Contractor.frmContractorsEvaluation();
                    break;
                case "GenGroup_EVACONTRACTOR":
                    f = new FRM.GenGroup.frmGenGroup("EVACONTRACTOR", true, true, false, true, false);
                    break;
                case "Contractor":
                    f = new FRM.Contractor.frmContractor();
                    break;
                case "Renovation":
                    f = new FRM.Renovation.frmRenovationProject(csEnum.ProjectType.Renovation);
                    break;
                case "CustomerList":
                    f = new FRM.Customer.frmCustomerV1();
                    break;

                case "Rebuilding":
                    f = new FRM.Renovation.frmRenovationProject(csEnum.ProjectType.Rebuilding);
                    break;

                case "RebuildingMasterCheck":
                    f = new FRM.Rebuilding.frmRebuilding(CS.csEnum.RebuildingUser.Master);
                    break;
                default:
                    return;
                    // f = new Form();
                    // break;
            }
            if (BLL.authentication.objectallow(frm))
            {
                BLL.csEvent Event = new BLL.csEvent();
                Event.eventlogin("LOGIN FORM", "", TitleForm, frm, BLL.authentication.x_.ToString());
                //    if (BLL.authentication.x_ == 5 || BLL.authentication.x_ == 58 || BLL.authentication.x_ == 51 || BLL.authentication.x_ == 26)
                //  {
                f.Text = TitleForm;
                f.Size = new System.Drawing.Size(950, 500);
                f.Show();



            }
        }
    }
}
