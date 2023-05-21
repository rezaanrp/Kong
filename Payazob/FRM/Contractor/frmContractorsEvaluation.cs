using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MIS.FRM.Contractor
{
    public partial class frmContractorsEvaluation : Form
    {
        public frmContractorsEvaluation()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
            //DataGridViewComboBoxColumn combobox_JOB_ = new DataGridViewComboBoxColumn()
            //{
            //    DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("JOB"),
            //    DisplayMember = "xName",
            //    HeaderText = "حیطه کاری",
            //    ValueMember = "x_",
            //    DataPropertyName = "xGenJob_",
            //    Name = "xGenJob_",
            //    Width = 200,
            //    DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
            //};
            //dataGridView1.Columns.Add(combobox_JOB_);

            DataGridViewComboBoxColumn combobox_Eva_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("EVACONTRACTOR"),
                DisplayMember = "xName",
                HeaderText = "مورد ارزیابی",
                ValueMember = "x_",
                DataPropertyName = "xGenEvaluationName_",
                Name = "xGenEvaluationName_",
                Width = 200,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
            };
            dataGridView2.Columns.Add(combobox_Eva_);
            ShowData();
        }
        DAL.Contractor.DataSet_Contractor.SlContractorsDataTable dt_P;
        DAL.Contractor.DataSet_Contractor.mContractorsEvaluationDataTable dt_PD;
        void ShowData()
        {
            BLL.Contractor.csContractor cs = new BLL.Contractor.csContractor();
            dt_P = cs.SlContractor("");
            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            CS.csDic css = new CS.csDic();
            foreach (DataColumn dc in dt_P.Columns)
            {
                if (dataGridView1.Columns[dc.ColumnName] != null)
                    dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }

            dataGridView1.Columns["xGenJob_"].DisplayIndex = 5;
            dataGridView1.Columns["xName"].HeaderText = "نام";
            dataGridView1.Columns["Raiting"].HeaderText = "ارزیابی";
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
            dataGridView1.Columns["xFamily"].HeaderText = "نام خانوادگی";
            dataGridView1.Columns["xAddress"].Width = 300;

            dataGridView1.Columns["Raiting"].DefaultCellStyle.BackColor = Color.LightBlue;


          //  dt_P.xSupplier_Column.DefaultValue = BLL.authentication.x_;
        }
        void ShowDataDetails(int x_)
        {
            dt_PD = new BLL.Contractor.csContractor().mContractorsEvaluation(x_);
            bindingSource2.DataSource = dt_PD;
            dataGridView2.DataSource = bindingSource2;
            bindingNavigator2.BindingSource = bindingSource2;
            CS.csDic css = new CS.csDic();
            foreach (DataColumn dc in dt_PD.Columns)
            {
                if (dataGridView2.Columns[dc.ColumnName] != null)
                    dataGridView2.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                dataGridView2.Columns[dc.ColumnName].DisplayIndex = dt_PD.Columns[dc.ColumnName].Ordinal;

            }
            dt_PD.xContractors_Column.DefaultValue = x_;
            dt_PD.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dataGridView2.Columns["x_"].Visible = false;
            dataGridView2.Columns["xSupplier_"].Visible = false;
            dataGridView2.Columns["xContractors_"].Visible = false;

            dataGridView2.Columns["xGenEvaluationName_"].ReadOnly = true;
            dataGridView2.Columns["xGenEvaluationName_"].Width = 200;
            dataGridView2.Columns["xScore"].DefaultCellStyle.BackColor = Color.LightGreen;
            //dataGridView2.Columns["xScore"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }
        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1 )
            ShowDataDetails((int)dataGridView1["id",e.RowIndex].Value);
        }

        private void ToolStripButton11_Click(object sender, EventArgs e)
        {
            this.dataGridView2.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.Contractor.csContractor().UdContractorsEvaluation(dt_PD));
                ShowData();
            }
        }
    }
}
