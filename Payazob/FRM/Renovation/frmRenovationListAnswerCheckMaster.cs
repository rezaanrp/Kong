using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MIS.FRM.Renovation
{
    public partial class frmRenovationListAnswerCheckMaster : Form
    {
        public frmRenovationListAnswerCheckMaster(int x_)
        {
            InitializeComponent();


            CmbGiveValue();
            ShowData(x_);
        }
        
        void CmbGiveValue()
        {
            DataGridViewComboBoxColumn Columns1 = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.ProjectAnswer.csProjectAnswer().mQuestion(),
                DisplayMember = "xQuestion",
                HeaderText = "xQuestion_",
                ValueMember = "x_",
                DataPropertyName = "xQuestion_",
                Name = "xQuestion_",
                Width = 300,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };

            dataGridView2.Columns.Add(Columns1);
            DataGridViewComboBoxColumn Columns11 = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.ProjectAnswer.csProjectAnswer().mQuestion(),
                DisplayMember = "xQuestion",
                HeaderText = "xQuestion_",
                ValueMember = "x_",
                DataPropertyName = "xQuestion_",
                Name = "xQuestion_",
                Width = 300,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };

            dataGridView3.Columns.Add(Columns11);
            DataGridViewComboBoxColumn Columns2 = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.ProjectAnswer.csProjectAnswer().mQuestionItem(),
                DisplayMember = "xQuestionItem",
                HeaderText = "xQuestionItem_",
                ValueMember = "x_",
                DataPropertyName = "xQuestionItem_",
                Name = "xQuestionItem_",
                Width = 300,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(Columns2);
            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();

            DataGridViewComboBoxColumn Columns3 = new DataGridViewComboBoxColumn()
            {
                DataSource =  csm.SlGenGroup("STATUS"),
                DisplayMember = "xName",
                HeaderText = "xGenStatus_",
                ValueMember = "x_",
                DataPropertyName = "xGenStatus_",
                Name = "xGenStatus_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(Columns3);

            DataGridViewComboBoxColumn Columns4 = new DataGridViewComboBoxColumn()
            {
                DataSource =  csm.SlGenGroup("STATUS"),
                DisplayMember = "xName",
                HeaderText = "xGenStatus_",
                ValueMember = "x_",
                DataPropertyName = "xGenStatus_",
                Name = "xGenStatus_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView3.Columns.Add(Columns4);

            DataGridViewComboBoxColumn xGenUsageType_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("QUESTLEVL2"),
                DisplayMember = "xName",
                HeaderText = "xGenUnitType_",
                ValueMember = "x_",
                DataPropertyName = "xGenUnitType_",
                Name = "xGenUnitType_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(xGenUsageType_);


        }
        private void frmRenovationListAnswerCheckMaster_Load(object sender, EventArgs e)
        {

        }
        DAL.Renovation.DataSet_RenovationN.mRenovationFloorDataTable dt_P;
        DAL.ProjectAnswer.DataSet_ProjectAnswer.mRenovationProjectAnswerDataTable dt_P1;
        DAL.ProjectAnswer.DataSet_ProjectAnswer.mRenovationProjectAnswer_ContextDataTable dt_P2;


        void ShowData(int x_)
        {
            dt_P = new BLL.Renovation.csRenovationN().mRenovationFloor(x_);
            dataGridView1.DataSource = dt_P;
            CS.csDic css = new CS.csDic();
            foreach (DataColumn dc in dt_P.Columns)
            {
                if (dataGridView1.Columns[dc.ColumnName] != null)
                    dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                dataGridView1.Columns[dc.ColumnName].DisplayIndex = dt_P.Columns[dc.ColumnName].Ordinal;

            }
            dataGridView1.Columns["xRenovationProject_"].Visible = false;
            dataGridView1.Columns["x_"].Visible = false;

            dataGridView1.Columns["xUnitNumber"].HeaderText = "شماره واحد یا طبقه";
            dataGridView1.Columns["xGenUnitType_"].HeaderText = "نوع کاربری";
            dataGridView1.Columns["xUnitNumber"].Width = 150;
        }
        void ShowDataGrid1(int x_)
        {
            dt_P1 = new BLL.ProjectAnswer.csProjectAnswer().mProjectAnswerRenovation(x_);
            bindingSource1.DataSource = dt_P1;
            dataGridView2.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            CS.csDic css = new CS.csDic();
            foreach (DataColumn dc in dt_P1.Columns)
            {
                if (dataGridView2.Columns[dc.ColumnName] != null)
                {
                    dataGridView2.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                    dataGridView2.Columns[dc.ColumnName].DisplayIndex = dt_P1.Columns[dc.ColumnName].Ordinal;

                }
            }
            dataGridView2.Columns["x_"].Visible = false;
            dataGridView2.Columns["xRenovationFloor_"].Visible = false;
            dataGridView2.Columns["xQestionContext"].Visible = false;
            dataGridView2.Columns["xDate"].Visible = false;
            dataGridView2.Columns["xSupplier_"].Visible = false;

            dataGridView2.Columns["xComment"].Width = 250;


        }
        void ShowDataGrid2(int x_)
        {
            dt_P2 = new BLL.ProjectAnswer.csProjectAnswer().mRenovationProjectAnswer_Context(x_);
            bindingSource2.DataSource = dt_P2;
            dataGridView3.DataSource = bindingSource2;
            bindingNavigator2.BindingSource = bindingSource2;
            CS.csDic css = new CS.csDic();
            foreach (DataColumn dc in dt_P2.Columns)
            {
                if (dataGridView3.Columns[dc.ColumnName] != null)
                {
                    dataGridView3.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                    dataGridView3.Columns[dc.ColumnName].DisplayIndex = dt_P2.Columns[dc.ColumnName].Ordinal;

                }
            }
            dataGridView3.Columns["x_"].Visible = false;
            dataGridView3.Columns["xRenovationFloor_"].Visible = false;
            dataGridView3.Columns["xQuestionItem_"].Visible = false;
            dataGridView3.Columns["xQestionContext"].Visible = true;
            dataGridView3.Columns["xDate"].Visible = false;
            dataGridView3.Columns["xSupplier_"].Visible = false;

            dataGridView3.Columns["xComment"].Width = 250;


        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                ShowDataGrid1((int)dataGridView1["x_", e.RowIndex].Value);
                ShowDataGrid2((int)dataGridView1["x_", e.RowIndex].Value);

            }
        }

        private void dataGridView3_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
     
        }

        private void saveToolStripButton_Top_Click(object sender, EventArgs e)
        {
            this.dataGridView2.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.ProjectAnswer.csProjectAnswer().UdProjectAnswerRenovation(dt_P1));
                if (dataGridView1.SelectedRows.Count > 0)
                    ShowDataGrid1((int)dataGridView1.SelectedRows[0].Cells["x_"].Value);
            }
        }

        private void toolStripButton_Bottom_Click(object sender, EventArgs e)
        {
            this.dataGridView3.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.ProjectAnswer.csProjectAnswer().UdRenovationProjectAnswer_Context(dt_P2));
                if (dataGridView1.SelectedRows.Count > 0)
                    ShowDataGrid2((int)dataGridView1.SelectedRows[0].Cells["x_"].Value);
            }
        }

        private void glassButton_EXit_Click(object sender, EventArgs e)
        {
        
            int x_ = (int)dataGridView1.SelectedRows[0].Cells["xRenovationProject_"].Value;
            Report.SendReport cs = new Report.SendReport();
            frmReport r = new frmReport();
            DataTable dt = new BLL.ProjectAnswer.csProjectAnswer().SlRenovationProjectAnswer_ALL(x_);
            r.GetReport = cs.GetReport(dt, "crsProjectAnswer");
            r.ShowDialog();
            r.Dispose();
        }
    }
}
