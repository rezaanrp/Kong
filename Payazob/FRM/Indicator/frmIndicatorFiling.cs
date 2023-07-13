using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MIS.FRM.Indicator
{
    public partial class frmIndicatorFiling : Form
    {
        public frmIndicatorFiling(bool ReadOnlyForm)
        {
            InitializeComponent();
            ReadOnlyForm_ = ReadOnlyForm;
            if (ReadOnlyForm_)
            {
                dataGridView1.ReadOnly = true;
                saveToolStripButton.Enabled = false;
            }
            DataGridViewCmbLoad();

        }
        bool ReadOnlyForm_;
        void DataGridViewCmbLoad()
        {
            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();
            DataGridViewComboBoxColumn gen_transaction_type_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("TransactionType"),
                DisplayMember = "xName",
                ValueMember = "x_",
                DataPropertyName = "gen_transaction_type_",
                Name = "gen_transaction_type_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(gen_transaction_type_);

            DataGridViewComboBoxColumn gen_how_refer_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("HowRefer"),
                DisplayMember = "xName",
                ValueMember = "x_",
                DataPropertyName = "gen_how_refer_",
                Name = "gen_how_refer_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(gen_how_refer_);

            DataGridViewComboBoxColumn combobox_xSupplier_ = new DataGridViewComboBoxColumn()
            {
                HeaderText = "ثبت کننده",
                DataSource = new BLL.authentication().NameOfUser(),
                DisplayMember = "NameAndFamily",
                ValueMember = "x_",
                DataPropertyName = "supplier_",
                Name = "supplier_",
                Width = 150,
                ReadOnly = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(combobox_xSupplier_);
        }
        private void frmIndicatorFiling_Load(object sender, EventArgs e)
        {
            ShowData();
        }
        DAL.Indicator.DataSet_Indicator.mIndicatorFilingDataTable dt_P;
        void ShowData()
        {
            if (ReadOnlyForm_)
                dt_P = new BLL.Indicator.csIndicator().mIndicatorFiling(
                    uc_Filter_Date1.DateFrom,
                    uc_Filter_Date1.DateTo
                    );
            else
                dt_P = new BLL.Indicator.csIndicator().mIndicatorFiling(
                    uc_Filter_Date1.DateFrom, 
                    uc_Filter_Date1.DateTo 
                  );
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
                }
            }
            dataGridView1.Columns["id"].Visible = false;
       //     dataGridView1.Columns["xRegisterDate"].ReadOnly = true;
            dataGridView1.Columns["reason"].Width = 200;
            dt_P.date_supplierColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_P.supplier_Column.DefaultValue = BLL.authentication.x_;
            dt_P.filing_dateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
        }
        void SaveData()
        {
            this.dataGridView1.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.Indicator.csIndicator().UdIndicatorFiling(dt_P));
                ShowData();
            }
        }
        private void toolStripButton_Add_Click(object sender, EventArgs e)
        {
            new FRM.Indicator.frmIndicatorFilingInsert(-1, ReadOnlyForm_).ShowDialog();
            ShowData();

        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        private void glassButton_EXit_Click(object sender, EventArgs e)
        {
            ShowData();

        }
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           new FRM.Indicator.frmIndicatorFilingInsert((int)dataGridView1["id", e.RowIndex].Value, ReadOnlyForm_).ShowDialog();
            ShowData();
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "filing_date")
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

        private void toolStripButton_Search_Click(object sender, EventArgs e)
        {
         //   FRM.Indicator.frmIndicatorFilingSearch frm = 
         //       new FRM.Indicator.frmIndicatorFilingSearch();
         //   frm.ShowDialog();
         ////   ShowData();
         //   dt_P.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "xBuildingOwner", frm.xBuildingOwner);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }
    }
}
