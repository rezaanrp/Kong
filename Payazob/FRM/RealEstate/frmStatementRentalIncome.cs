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
    public partial class frmStatementRentalIncome : Form
    {
        public frmStatementRentalIncome(CS.csEnum.FactorySection section)
        {
            InitializeComponent();
            Section_ = section;
            DataGridViewComboBoxColumn combobox_xSupplier_ = new DataGridViewComboBoxColumn()
            {
                DisplayIndex = 4,
                HeaderText = "ثبت کننده",
                DataSource = new BLL.authentication().NameOfUser(),
                DisplayMember = "NameAndFamily",
                ValueMember = "x_",
                DataPropertyName = "xSupplier_",
                Name = "xSupplier_",
                Width = 100,
                ReadOnly = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(combobox_xSupplier_);
            DataGridViewComboBoxColumn combobox_xFinancialApprove_ = new DataGridViewComboBoxColumn()
            {
                DisplayIndex = 4,
                HeaderText = "ثبت کننده",
                DataSource = new BLL.authentication().NameOfUser(),
                DisplayMember = "NameAndFamily",
                ValueMember = "x_",
                DataPropertyName = "xFinancialApprove_",
                Name = "xFinancialApprove_",
                Width = 100,
                ReadOnly = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(combobox_xFinancialApprove_);
            DataGridViewComboBoxColumn combobox_xContractConsultant_ = new DataGridViewComboBoxColumn()
            {
                DisplayIndex = 4,
                HeaderText = "ثبت کننده",
                DataSource = new BLL.RealEstate.csRealEstate().SlUserFromHira(),
                DisplayMember = "Name",
                ValueMember = "Name",
                DataPropertyName = "xContractConsultant",
                Name = "xContractConsultant",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(combobox_xContractConsultant_);
            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();
            DataGridViewComboBoxColumn combobox_xGenBuildingType_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("BuildingType"),
                DisplayMember = "xName",
                HeaderText = "جنسیت",
                ValueMember = "x_",
                DataPropertyName = "xGenBuildingType_",
                Name = "xGenBuildingType_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };

            dataGridView1.Columns.Add(combobox_xGenBuildingType_);
            ShowData("", false, "", false, "", false, "", false, ""
     , false, "", false, "", false, "", false,true);
        }
        CS.csEnum.FactorySection Section_ = CS.csEnum.FactorySection.Guest;
        DAL.RealEstate.DataSet_StatementRentalIncome.SlStatementRentalIncomeDataTable dt_P;
        void ShowData(string xBuildingAddress,
         bool SearchxBuildingAddress,

         string xContractConsultant,
         bool SearchxContractConsultant,

         string xContractNumber,
         bool SearchxContractNumber,

         string xContractManager,
         bool SearchxContractManager,

         string xLessorTel,
         bool SearchxLessorTel,

         string xTenantTel,
         bool SearchxTenantTel,

         string xTenantName,
         bool SearchxTenantName,

         string xLessorName,
         bool SearchxLessorName, bool SearchDate)
        {
            dt_P = new BLL.RealEstate.csRealEstate().SlStatementRentalIncome(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo,
                 xBuildingAddress,
          SearchxBuildingAddress,

          xContractConsultant,
          SearchxContractConsultant,

          xContractNumber,
          SearchxContractNumber,

          xContractManager,
          SearchxContractManager,

          xLessorTel,
          SearchxLessorTel,

          xTenantTel,
          SearchxTenantTel,

          xTenantName,
          SearchxTenantName,

          xLessorName,
          SearchxLessorName, SearchDate);
            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            CS.csDic css = new CS.csDic();
            foreach (DataColumn dc in dt_P.Columns)
            {
                if (dataGridView1.Columns[dc.ColumnName] != null)
                {
                    dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                    dataGridView1.Columns[dc.ColumnName].DisplayIndex = dt_P.Columns[dc.ColumnName].Ordinal;
                    //dataGridView1.Columns[dc.ColumnName].ReadOnly = flag;
                }
            }
            if (Section_ != CS.csEnum.FactorySection.Edari)
            {
                foreach (DataGridViewColumn dc in dataGridView1.Columns)
                {
                    dc.ReadOnly = true;
                }
            }
            if (Section_ == CS.csEnum.FactorySection.Edari)
                dataGridView1.Columns["xFinancialApprove"].ReadOnly = true;
            else if (Section_ == CS.csEnum.FactorySection.Financial)
            {
                dataGridView1.Columns["xFinancialApprove"].ReadOnly = false;
                dataGridView1.Columns["xFinancialApprove"].DefaultCellStyle.BackColor = Color.Honeydew;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;

            }
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xGenBuildingType"].Visible = false;
            dataGridView1.Columns["xLessorAddress"].Width = 200;
            dataGridView1.Columns["xTenantAddress"].Width = 200;
            dataGridView1.Columns["xBuildingAddress"].Width = 200;
            dataGridView1.Columns["xComment"].Width = 200;
            dt_P.xContractDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_P.xSupplier_Column.DefaultValue = BLL.authentication.x_;

            dataGridView1.Columns["xLessorCommission"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["xTenantCommission"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["xMortgage"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["xRent"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["xLessorEarnestCommission"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["xTenantEarnestCommission"].DefaultCellStyle.Format = "N0";

            dataGridView1.Columns["xTaxLessorCommission"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["xTaxTenantCommission"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["xSumLessorAndTenantCommission"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["xSumTaxLessorAndTenantCommission"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["xSumTotalByTaxLessorAndTenantCommission"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["xGuildCommission"].DefaultCellStyle.Format = "N0";

        }
        void SaveData()
        {
            this.dataGridView1.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.RealEstate.csRealEstate().UdStatementRentalIncome(dt_P));
                ShowData("",false,"",false, "", false, "", false,""
                    , false, "", false,"", false, "", false,true);
            }
        }
        private void glassButton_EXit_Click(object sender, EventArgs e)
        {
            ShowData("", false, "", false, "", false, "", false, ""
            , false, "", false, "", false, "", false,true);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }


        private void toolStripButton_Add_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (
                dataGridView1.Columns[e.ColumnIndex].Name == "xContractDate"
               || dataGridView1.Columns[e.ColumnIndex].Name == "xHomeDeliveryDate"
               || dataGridView1.Columns[e.ColumnIndex].Name == "xContractEndDate"

               )
            {

                if (e.FormattedValue.ToString().Length == 0 || (
                    new Validation.VDate().ValidationDate(e.FormattedValue.ToString())
                    )
                     )
                    e.Cancel = false;
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("تاریخ صحیح نمی باشد");
                }
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridView1_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if( e.ColumnIndex > -1 && e.RowIndex > -1 && dataGridView1.Columns[e.ColumnIndex].Name == "btn_LessorSurvey" && (int)dataGridView1["x_", e.RowIndex].Value > 0)
            {
                DataTable dt = new BLL.RealEstate.csRealEstate().mStatementRentalIncomeSurvey((int)dataGridView1["x_", e.RowIndex].Value, (int)CS.csEnum.xGenSurveyForWho_.Mojer);
                if (dt.Rows.Count < 1)
                    new FRM.RealEstate.frmStatementRentalIncomeSurvey(true, (int)dataGridView1["x_", e.RowIndex].Value, CS.csEnum.xGenSurveyForWho_.Mojer).ShowDialog();
                else
                    new FRM.RealEstate.frmStatementRentalIncomeSurvey(false, (int)dataGridView1["x_", e.RowIndex].Value, CS.csEnum.xGenSurveyForWho_.Mojer).ShowDialog();
            }
            else if(e.ColumnIndex > -1 &&  e.RowIndex > -1 && dataGridView1.Columns[e.ColumnIndex].Name == "btn_TenantSurvey" && (int)dataGridView1["x_", e.RowIndex].Value > 0)
            {
                DataTable dt = new BLL.RealEstate.csRealEstate().mStatementRentalIncomeSurvey((int)dataGridView1["x_", e.RowIndex].Value , (int)CS.csEnum.xGenSurveyForWho_.Mostajer);
                if (dt.Rows.Count < 1)
                    new FRM.RealEstate.frmStatementRentalIncomeSurvey(true, (int)dataGridView1["x_", e.RowIndex].Value, CS.csEnum.xGenSurveyForWho_.Mostajer).ShowDialog();
                else
                    new FRM.RealEstate.frmStatementRentalIncomeSurvey(false, (int)dataGridView1["x_", e.RowIndex].Value, CS.csEnum.xGenSurveyForWho_.Mostajer).ShowDialog();
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "xFinancialApprove")
            {
                if ((bool)dataGridView1[e.ColumnIndex, e.RowIndex].FormattedValue == true)
                {
                    dataGridView1["xFinancialApprove_", e.RowIndex].Value = BLL.authentication.x_;
                //    dataGridView1["xConfirmDate", e.RowIndex].Value = BLL.csshamsidate.shamsidate;
                }
                else
                {
                    dataGridView1["xFinancialApprove_", e.RowIndex].Value = DBNull.Value;
                  //  dataGridView1["xConfirmDate", e.RowIndex].Value = DBNull.Value;

                }

            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

            Report.SendReport cs = new Report.SendReport();
            frmReport r = new frmReport();
       //     DataTable dt = new BLL.RealEstate.csRealEstate().(xProject_Id);
            r.GetReport = cs.GetReport(dt_P, "crsStatementRentalIncome");
            r.ShowDialog();
            r.Dispose();
            //crsStatementRentalIncome
        }

        private void toolStripButton_Search_Click(object sender, EventArgs e)
        {
            FRM.RealEstate.frmStatementRentalIncomeSearch frm = new FRM.RealEstate.frmStatementRentalIncomeSearch();
            frm.ShowDialog();
            ShowData(frm.xBuildingAddress,
          frm.SearchxBuildingAddress,

          frm.xContractConsultant,
          frm.SearchxContractConsultant,

          frm.xContractNumber,
          frm.SearchxContractNumber,

          frm.xContractManager,
          frm.SearchxContractManager,

          frm.xLessorTel,
          frm.SearchxLessorTel,

          frm.xTenantTel,
          frm.SearchxTenantTel,

          frm.xTenantName,
          frm.SearchxTenantName,

          frm.xLessorName,
          frm.SearchxLessorName,false);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ucStatusBar1.DgvCell = dataGridView1.SelectedCells;

        }
    }
}
