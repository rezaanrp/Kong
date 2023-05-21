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
    public partial class frmMarketerInformationFollowUp : Form
    {
        public frmMarketerInformationFollowUp(bool ReadOnlyForm)
        {
            InitializeComponent();
            ReadOnlyForm_ = ReadOnlyForm;
            if (ReadOnlyForm_)
            {
                dataGridView1.ReadOnly = true;
                bindingNavigator1.Enabled = false;
            }
            DataGridViewCmbLoad();


            DataGridViewComboBoxColumn combobox_xSupplier1_ = new DataGridViewComboBoxColumn()
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
            dataGridView2.Columns.Add(combobox_xSupplier1_);

            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();
            DataGridViewComboBoxColumn xGenFollowUp_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("FOLLOWUPTYPE"),
                DisplayMember = "xName",
                ValueMember = "x_",
                DataPropertyName = "xGenFollowUp_",
                Name = "xGenFollowUp_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(xGenFollowUp_);
            ShowData();
            ShowDataDetails(-1);

        }
        bool ReadOnlyForm_;
        void DataGridViewCmbLoad()
        {
            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();
            DataGridViewComboBoxColumn combobox_1_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("BULIDINGTYPESERVICE"),
                DisplayMember = "xName",
                ValueMember = "x_",
                DataPropertyName = "xBulidingTypeService_",
                Name = "xBulidingTypeService_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(combobox_1_);

            DataGridViewComboBoxColumn combobox_2_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("CONSTRACTIONSTATE"),
                DisplayMember = "xName",
                ValueMember = "x_",
                DataPropertyName = "xConstractionState_",
                Name = "xConstractionState_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(combobox_2_);
            DataGridViewComboBoxColumn combobox_3_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("UsageType"),
                DisplayMember = "xName",
                ValueMember = "x_",
                DataPropertyName = "xGenUsage_",
                Name = "xGenUsage_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(combobox_3_);
            DataGridViewComboBoxColumn combobox_xSupplier_ = new DataGridViewComboBoxColumn()
            {
                DisplayIndex = 4,
                HeaderText = "ثبت کننده",
                DataSource = new BLL.authentication().NameOfUser(),
                DisplayMember = "NameAndFamily",
                ValueMember = "x_",
                DataPropertyName = "xSupplier_",
                Name = "xSupplier_",
                Width = 150,
                ReadOnly = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(combobox_xSupplier_);
        }
        DAL.Marketer.DataSet_MarketerInformation.mMarketerInformationDataTable dt_P;
        DAL.Marketer.DataSet_MarketerInformation.mMarketerInformationFollowUpDataTable dt_D;
        void ShowData()
        {
            if (ReadOnlyForm_)
                dt_P = new BLL.Marketer.csMarketer().mMarketerInformation(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, -1);
            else
                dt_P = new BLL.Marketer.csMarketer().mMarketerInformation(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, BLL.authentication.x_);
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
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xRegisterDate"].ReadOnly = true;
            dataGridView1.Columns["xAddress"].Width = 200;
        }
        void SaveData()
        {
            this.dataGridView1.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.Marketer.csMarketer().UdMarketerInformationFollowUp(dt_D));
                ShowData();
            }
        }
        void ShowDataDetails(int x_)
        {
            if (x_ > 0)
            {
                dt_D = new BLL.Marketer.csMarketer().mMarketerInformationFollowUp(x_);
                dataGridView2.ReadOnly = false;
                bindingNavigator1.Enabled = true;
            }
            else
            {
                dt_D = new DAL.Marketer.DataSet_MarketerInformation.mMarketerInformationFollowUpDataTable();
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
            dataGridView2.Columns["x_"].Visible = false;
            dataGridView2.Columns["xMarketerInformation_"].Visible = false;
            dataGridView2.Columns["xComment"].Width = 300;
            dt_D.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_D.xTimeColumn.DefaultValue = new BLL.csshamsidate().CurrentTime;
            dt_D.xMarketerInformation_Column.DefaultValue = x_;
            dt_D.xSupplier_Column.DefaultValue = BLL.authentication.x_;
        }
        private void glassButton_EXit_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            //uc.Fildvg = dataGridView1;
            //uc.RunExcel();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //   splitContainer3.Panel2Collapsed = true;

            if (e.RowIndex > -1 && e.ColumnIndex > -1)                    
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
            FRM.Marketer.frmMarketerInformationSearch frm =
                new FRM.Marketer.frmMarketerInformationSearch();
            frm.ShowDialog();
            dt_P.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "xBuildingOwner", frm.xBuildingOwner);
        }
    }
}
