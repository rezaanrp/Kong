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
    public partial class frmRenovationProjectCheckMaster : Form
    {
        public frmRenovationProjectCheckMaster()
        {
            InitializeComponent();
            DataGridViewComboBoxColumn QUESTLEVL1 = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("QUESTLEVL1"),
                DisplayMember = "xName",
                HeaderText = "xGenQUESTLEVL1_",
                ValueMember = "x_",
                DataPropertyName = "xGenQUESTLEVL1_",
                Name = "xGenQUESTLEVL1_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(QUESTLEVL1);
            DataGridViewComboBoxColumn xGenCUSTOMERTYPE_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("CUSTOMERTYPE"),
                DisplayMember = "xName",
                ValueMember = "x_",
                DataPropertyName = "xGenCUSTOMERTYPE_",
                Name = "xGenCUSTOMERTYPE_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(xGenCUSTOMERTYPE_);
            ShowData("");
        }

        DAL.Customer.DataSet_Customer.SlCustomerOpenProjectDataTable dt_P;
        DAL.Renovation.DataSet_RenovationProject.mRenovationProjectDataTable dt_R;
        void ShowData(string Src)
        {
            BLL.Customer.csCustomer cs = new BLL.Customer.csCustomer();
            dt_P = cs.SlCustomerOpenProject();
            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            CS.csDic css = new CS.csDic();
            foreach (DataColumn dc in dt_P.Columns)
            {
                if (dataGridView1.Columns[dc.ColumnName] != null)
                    dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
            dataGridView1.Columns["xName"].HeaderText = "نام";
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xDate"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
            dataGridView1.Columns["xLastName"].HeaderText = "نام خانوادگی";

            dataGridView1.Columns["xBirthDay"].DisplayIndex = dt_P.Columns["xBirthDay"].Ordinal;

            dt_P.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_P.xSupplier_Column.DefaultValue = BLL.authentication.x_;
        }
        void ShowDataDetails(int x_)
        {
            dt_R = new BLL.Renovation.csRenovationProject().mRenovationProject(x_);
            bindingSource2.DataSource = dt_R;
            dataGridView2.DataSource = bindingSource2;
            bindingNavigator2.BindingSource = bindingSource2;
            CS.csDic css = new CS.csDic();
            foreach (DataColumn dc in dt_R.Columns)
            {
                if (dataGridView2.Columns[dc.ColumnName] != null)
                    dataGridView2.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                dataGridView2.Columns[dc.ColumnName].DisplayIndex = dt_R.Columns[dc.ColumnName].Ordinal;

            }
            dt_R.xCustomer_Column.DefaultValue = x_;
            dt_R.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_R.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dataGridView2.Columns["x_"].Visible = false;
            dataGridView2.Columns["xCustomer_"].Visible = false;


        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                ShowDataDetails((int)dataGridView1["x_", e.RowIndex].Value);
        }
        private void dataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           if (dataGridView2["x_", e.RowIndex].Value != DBNull.Value && (int)dataGridView2["x_", e.RowIndex].Value > 0)
                new FRM.Renovation.frmRenovationListAnswerCheckMaster((int)dataGridView2["x_", e.RowIndex].Value).ShowDialog();
        }

        private void glassButton_EXit_Click(object sender, EventArgs e)
        {
            ShowData(txt_Search.Text);
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            new FRM.Customer.frmCustomerAdd((int)dataGridView1["x_", e.RowIndex].Value).ShowDialog();
            ShowData(txt_Search.Text);
        }
    }
}
