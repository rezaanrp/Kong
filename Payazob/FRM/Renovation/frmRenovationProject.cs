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
    public partial class frmRenovationProject : Form
    {
        public frmRenovationProject(CS.csEnum.ProjectType ProjectType)
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
            ProjectType_ = ProjectType;
            DataGridViewCmbLoad();
            ShowData("");

        }
        CS.csEnum.ProjectType ProjectType_; 
        void DataGridViewCmbLoad()
        {
            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();


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
            dataGridView2.Columns.Add(combobox_xSupplier_);

            DataGridViewComboBoxColumn xGenCUSTOMERTYPE_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("CUSTOMERTYPE"),
                DisplayMember = "xName",
                ValueMember = "x_",
                DataPropertyName = "xGenCUSTOMERTYPE_",
                Name = "xGenCUSTOMERTYPE_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(xGenCUSTOMERTYPE_);
        }
        DAL.Customer.DataSet_Customer.mCustomer_SrchDataTable dt_P;
        DAL.Renovation.DataSet_RenovationProject.mRenovationProjectDataTable dt_R;
        void ShowData(string Src)
        {
            BLL.Customer.csCustomer cs = new BLL.Customer.csCustomer();
            dt_P = cs.mCustomer_Srch(Src);
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
        private void glassButton_EXit_Click(object sender, EventArgs e)
        {
            ShowData(txt_Search.Text);
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                ShowDataDetails((int)dataGridView1["x_", e.RowIndex].Value);
        }
        private void dataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView2["x_", e.RowIndex].Value != DBNull.Value && (int)dataGridView2["x_", e.RowIndex].Value > 0)
                new FRM.Renovation.frmRenovationV2((int)dataGridView2["x_", e.RowIndex].Value, (int)dataGridView2["xGenQUESTLEVL1_", e.RowIndex].Value).ShowDialog();
        }
        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            this.dataGridView2.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.Renovation.csRenovationProject().UdRenovationProject(dt_R));
                if (dataGridView1.SelectedCells.Count > 0)
                    ShowDataDetails((int)dataGridView1["x_", dataGridView1.SelectedCells[0].RowIndex].Value);
            }
        }

        private void toolStripButton_Add_Click(object sender, EventArgs e)
        {
            new FRM.Customer.frmCustomerAdd(-1).ShowDialog();
            ShowData("");
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            new FRM.Customer.frmCustomerAdd((int)dataGridView1["x_", e.RowIndex].Value).ShowDialog();
            ShowData(txt_Search.Text);
        }
    }
}
