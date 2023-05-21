using System.Collections.Generic;
using System.Data;

namespace Report
{
    public class SendReport
    {
        public CrystalDecisions.CrystalReports.Engine.ReportDocument GetReport(System.Data.DataTable Data, string NameReport)
        {
            if (NameReport == "")
                return null;
            CrystalDecisions.CrystalReports.Engine.ReportDocument rpt = FindReport(NameReport);
            if (Data != null)
                rpt.SetDataSource(Data);
            else
            {
                Data = new DataTable();
                //    rpt.SetDataSource(Data);
            }
            while (stackParamName.Count > 0)
            {
                rpt.SetParameterValue(stackParamName.Pop(), stackParamValue.Pop());

            }
            return rpt;
        }


        public CrystalDecisions.CrystalReports.Engine.ReportDocument GetReport(System.Data.DataTable Data, string NameReport, System.Data.DataTable Data_S, string NameReport_S)
        {
            if (NameReport == "")
                return null;
            CrystalDecisions.CrystalReports.Engine.ReportDocument rpt = FindReport(NameReport);
            rpt.SetDataSource(Data);
            rpt.Subreports[NameReport_S].SetDataSource(Data_S);

            while (stackParamName.Count > 0)
            {
                rpt.SetParameterValue(stackParamName.Pop(), stackParamValue.Pop());

            }
            return rpt;
        }
        private Stack<string> stackParamName = new Stack<string>();
        private Stack<string> stackParamValue = new Stack<string>();

        public void SetParam(string Name, string Value)
        {
            stackParamName.Push(Name);
            stackParamValue.Push(Value);
        }

        private CrystalDecisions.CrystalReports.Engine.ReportDocument FindReport(string Name)
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument rpt;
            switch (Name)
            {

                //
                //crsStoreBillByTax
                case "crsStatementSaleIncome":
                    rpt = new crsStatementSaleIncome();
                    break;
                case "crsStatementRentalIncome":
                    rpt = new crsStatementRentalIncome();
                    break;
                case "crsStoreBillByTax":
                    rpt = new crsStoreBillByTax();
                    break;
                case "crsStoreBill":
                    rpt = new crsStoreBill();
                    break;
                case "crsProjectAnswer":
                    rpt = new crsProjectAnswer();
                    break;
                case "crsRenovationByx_":
                    rpt = new crsRenovationByx_();
                    break;
                case "crsRebuildingRequest":
                    rpt = new crsRebuildingByx_();
                    break;
                case "crsRebuildingForMaster":
                    rpt = new crsRebuildingForMaster();
                    break;

                case "crsMessageElan":
                    rpt = new crsMessageElan();
                    break;


                //case "crsPiecesProductPlan":
                //    rpt = new crsPiecesProductPlan();
                //    break;

                case "Chart_ProcessControl":
                    rpt = new Chart_ProcessControl();
                    break;

                default:
                    rpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                    break;


            }
            return rpt;
        }
    }
}
