using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MIS.FRM.ManufacturersInformation
{
    public partial class frmManufacturersInformationInProcessProjectNeeds : Form
    {
        public frmManufacturersInformationInProcessProjectNeeds(int xManufacturersInformationInProcessProject_)
        {
            InitializeComponent();
            xManufacturersInformationInProcessProject = xManufacturersInformationInProcessProject_;
            DataGridViewComboBoxColumn xGenFollowUpNeedResult_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("FollowUpNeedResult"),
                DisplayMember = "xName",
                ValueMember = "x_",
                DataPropertyName = "xGenFollowUpNeedResult_",
                Name = "xGenFollowUpNeedResult_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
            };
            dataGridView2.Columns.Add(xGenFollowUpNeedResult_);
        }
        int xManufacturersInformationInProcessProject;
        private void frmClientReferralFollowUp_Load(object sender, EventArgs e)
        {
            ShowData(xManufacturersInformationInProcessProject);

            if (dataGridView1.SelectedRows.Count > 0)

                ShowDataDetails((int)dataGridView1.SelectedRows[0].Cells["x_"].Value);

            else
                ShowDataDetails(-1);

        }
        DAL.ManufacturersInformation.DataSet_ManufacturersInformation.mManufacturersInformationInProcessProjectNeedsDataTable dt_P;
        DAL.ManufacturersInformation.DataSet_ManufacturersInformation.mManufacturersInformationInProcessProjectNeedsResultDataTable dt_D;
        void ShowData(int x_)
        {
            dt_P = new BLL.ManufacturersInformation.csManufacturersInformation().mManufacturersInformationInProcessProjectNeeds(
     x_
                );
            dataGridView1.DataSource = dt_P;
            CS.csDic css = new CS.csDic();
            foreach (DataColumn dc in dt_P.Columns)
            {
                if (dataGridView1.Columns[dc.ColumnName] != null)
                {
                    dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                    dataGridView1.Columns[dc.ColumnName].DisplayIndex = dt_P.Columns[dc.ColumnName].Ordinal;
                }
            }
            dataGridView1.Columns["xDate"].Visible = false;
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
            dataGridView1.Columns["xDate"].ReadOnly = true;

            dataGridView1.Columns["xManufacturersInformationInProcessProject_"].Visible = false;

            dataGridView1.Columns["xPossibleNeeds"].Width = 250;
            dataGridView1.Columns["xInChargeOfTheFollowUp"].Width = 150;

            dt_P.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_P.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_P.xManufacturersInformationInProcessProject_Column.DefaultValue = xManufacturersInformationInProcessProject;
        }
        void SaveDataDetails()
        {
            this.dataGridView1.EndEdit();
            this.dataGridView2.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.ManufacturersInformation.csManufacturersInformation().UdManufacturersInformationInProcessProjectNeedsResult(dt_D));
                ShowData(xManufacturersInformationInProcessProject);
            }
        }
        void ShowDataDetails(int x_)
        {
            if (x_ > 0)
            {
                dt_D = new BLL.ManufacturersInformation.csManufacturersInformation().mManufacturersInformationInProcessProjectNeedsResult(x_);
                dataGridView2.ReadOnly = false;
                bindingNavigator1.Enabled = true;
            }
            else
            {
                dt_D = new DAL.ManufacturersInformation.DataSet_ManufacturersInformation.mManufacturersInformationInProcessProjectNeedsResultDataTable();
                dataGridView2.ReadOnly = true;
                bindingNavigator1.Enabled = false;
            }
            bindingSource1.DataSource = dt_D;
            dataGridView2.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            CS.csDic css = new CS.csDic();
            foreach (DataColumn dc in dt_D.Columns)
            {
                if (dataGridView2.Columns[dc.ColumnName] != null)
                {
                    dataGridView2.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                    dataGridView2.Columns[dc.ColumnName].DisplayIndex = dt_D.Columns[dc.ColumnName].Ordinal;
                }
            }

            dataGridView2.Columns["xSupplier_"].ReadOnly = true;
            dataGridView2.Columns["xDate"].ReadOnly = true;

            dataGridView2.Columns["x_"].Visible = false;
            dataGridView2.Columns["xSupplier_"].Visible = false;
            dataGridView2.Columns["xManufacturersInformationInProcessProjectNeeds_"].Visible = false;

            dataGridView2.Columns["xObtainedResult"].Width = 250;
            dataGridView2.Columns["xReasonsNotAchievingOrAchievingResults"].Width = 250;


            dt_D.xManufacturersInformationInProcessProjectNeeds_Column.DefaultValue = x_;
            dt_D.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_D.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
        }
        private void glassButton_EXit_Click(object sender, EventArgs e)
        {
            ShowData(xManufacturersInformationInProcessProject);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveDataDetails();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            //uc.Fildvg = dataGridView1;
            //uc.RunExcel();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ShowDataDetails((int)dataGridView1["x_", e.RowIndex].Value);
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void toolStripButton_SMS_Click(object sender, EventArgs e)
        {
            //   new FRM.SMSPanel.frmSendSMS(ListMobForSMS(), "ClientReferral").ShowDialog();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            //    splitContainer3.Panel2Collapsed = true;
        }
        private void toolStripButton_Search_Click(object sender, EventArgs e)
        {
            //FRM.ClientReferral.frmClientReferralSearch frm = new FRM.ClientReferral.frmClientReferralSearch();
            //frm.ShowDialog();
            //ShowData(xManufacturersInformationInProcessProject);
        }

        private void toolStripButton_SaveTop_Click(object sender, EventArgs e)
        {
            this.dataGridView1.EndEdit();
            this.dataGridView2.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.ManufacturersInformation.csManufacturersInformation().UdManufacturersInformationInProcessProjectNeeds(dt_P));
                ShowData(xManufacturersInformationInProcessProject);
            }
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
