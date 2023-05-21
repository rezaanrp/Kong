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
    public partial class frmRenovationListAnswer : Form
    {
        public frmRenovationListAnswer(int Project)
        {
            InitializeComponent();
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
            dataGridView1.Columns.Add(Columns1);
            dataGridView2.Columns.Add(Columns11);
            DataGridViewComboBoxColumn Columns2 = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.ProjectAnswer.csProjectAnswer().mQuestionItem(),
                DisplayMember = "xQuestionItem",
                HeaderText = "xQuestionItem_",
                ValueMember = "x_",
                DataPropertyName = "xQuestionItem_",
                Name = "xQuestionItem_",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(Columns2);
            dt_P = new DAL.ProjectAnswer.DataSet_ProjectAnswer.mRenovationProjectAnswerDataTable();
            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            Project_ = Project;
        }
        int Project_;
        DAL.ProjectAnswer.DataSet_ProjectAnswer.mRenovationProjectAnswerDataTable dt_P;
        DAL.ProjectAnswer.DataSet_ProjectAnswer.mRenovationProjectAnswer_ContextDataTable dt_PB;
        void ShowData(int x_)
        {

            dt_P = new BLL.ProjectAnswer.csProjectAnswer().mProjectAnswerRenovation(x_);
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
            dataGridView1.Columns["xRenovationFloor_"].Visible = false;
            dataGridView1.Columns["xGenStatus_"].Visible = false;
            dataGridView1.Columns["xComment"].Visible = false;
            dataGridView1.Columns["xDate"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
            dataGridView1.Columns["xQestionContext"].Visible = false;

            dt_PB = new BLL.ProjectAnswer.csProjectAnswer().mRenovationProjectAnswer_Context(x_);
            bindingSource2.DataSource = dt_PB;
            dataGridView2.DataSource = bindingSource2;
            bindingNavigator2.BindingSource = bindingSource2;
            foreach (DataColumn dc in dt_PB.Columns)
            {
                if (dataGridView2.Columns[dc.ColumnName] != null)
                    dataGridView2.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                dataGridView2.Columns[dc.ColumnName].DisplayIndex = dt_PB.Columns[dc.ColumnName].Ordinal;

            }
            dataGridView2.Columns["x_"].Visible = false;
            dataGridView2.Columns["xRenovationFloor_"].Visible = false;
            dataGridView2.Columns["xGenStatus_"].Visible = false;
            dataGridView2.Columns["xComment"].Visible = false;
            dataGridView2.Columns["xDate"].Visible = false;
            dataGridView2.Columns["xSupplier_"].Visible = false;
            dataGridView2.Columns["xQuestionItem_"].Visible = false;
            dataGridView2.Columns["xQestionContext"].Width = 300;
            dataGridView2.Columns["xQestionContext"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }
        private void frmRenovationListAnswer_Load(object sender, EventArgs e)
        {
            ShowData(Project_);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.dataGridView1.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.ProjectAnswer.csProjectAnswer().UdProjectAnswerRenovation(dt_P));
                ShowData(Project_);
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            this.dataGridView2.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.ProjectAnswer.csProjectAnswer().UdRenovationProjectAnswer_Context(dt_PB));
                ShowData(Project_);
            }
        }

        private void glassButton_EXit_Click(object sender, EventArgs e)
        {

        }
    }
}
