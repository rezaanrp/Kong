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
    public partial class frmMarketerInformation : Form
    {
        public frmMarketerInformation(bool ReadOnlyForm)
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
        private void frmMarketerInformation_Load(object sender, EventArgs e)
        {
            ShowData();
        }
        DAL.Marketer.DataSet_MarketerInformation.mMarketerInformationDataTable dt_P;
        void ShowData()
        {
            if (ReadOnlyForm_)
                dt_P = new BLL.Marketer.csMarketer().mMarketerInformation(
                    uc_Filter_Date1.DateFrom,
                    uc_Filter_Date1.DateTo, 
                    -1);
            else
                dt_P = new BLL.Marketer.csMarketer().mMarketerInformation(
                    uc_Filter_Date1.DateFrom, 
                    uc_Filter_Date1.DateTo, 
                    BLL.authentication.x_);
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
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xRegisterDate"].ReadOnly = true;
            dataGridView1.Columns["xAddress"].Width = 200;
            dt_P.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_P.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_P.xRegisterDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
        }
        void SaveData()
        {
            this.dataGridView1.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.Marketer.csMarketer().UdMarketerInformation(dt_P));
                ShowData();
            }
        }
        private void toolStripButton_Add_Click(object sender, EventArgs e)
        {
            new FRM.Marketer.frmMarketerInsert(-1, ReadOnlyForm_).ShowDialog();
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
            new FRM.Marketer.frmMarketerInsert((int)dataGridView1["x_", e.RowIndex].Value, ReadOnlyForm_).ShowDialog();
            ShowData();
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "xDate")
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
            FRM.Marketer.frmMarketerInformationSearch frm = 
                new FRM.Marketer.frmMarketerInformationSearch();
            frm.ShowDialog();
         //   ShowData();
            dt_P.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "xBuildingOwner", frm.xBuildingOwner);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }
    }
}
