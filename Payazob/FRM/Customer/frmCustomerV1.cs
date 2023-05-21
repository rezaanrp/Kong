using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MIS.FRM.Customer
{
    public partial class frmCustomerV1 : Form
    {
        public frmCustomerV1()
        {
            InitializeComponent();
            DataGridViewCmbLoad();
            ShowData("");
        }
        void DataGridViewCmbLoad()
        {
            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();


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
        private void toolStripButton_Add_Click(object sender, EventArgs e)
        {
            new frmCustomerAdd(-1).ShowDialog();
            ShowData(txt_Search.Text);

        }
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
        void SaveData()
        {
            this.dataGridView1.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.Customer.csCustomer().UdCustomer_Srch(dt_P));
                ShowData(txt_Search.Text);
            }
        }
        private void glassButton_EXit_Click(object sender, EventArgs e)
        {
            ShowData(txt_Search.Text);

        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmCustomerAdd fr = new frmCustomerAdd((int)dataGridView1["x_", e.RowIndex].Value);
            //  fr((int)dataGridView1["x_", e.RowIndex].Value)
            fr.ShowDialog();
            if (fr.flgEdit)
                ShowData(txt_Search.Text);
        }
    }
}
