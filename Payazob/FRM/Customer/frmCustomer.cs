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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
            uc_txtBoxName.DataBindings.Add(new Binding("Text", this.bindingSource1, "xName", true));
            uc_txtBox_xFamily.DataBindings.Add(new Binding("Text", this.bindingSource1, "xLastName", true));
            uc_txtBox_xMob.DataBindings.Add(new Binding("Text", this.bindingSource1, "xMobile", true));
            uc_txtBox_xNationalCode.DataBindings.Add(new Binding("Text", this.bindingSource1, "xNationalCode", true));
            uc_txtBox_xTel.DataBindings.Add(new Binding("Text", this.bindingSource1, "xPhone", true));
            uc_txtBox_FatherName.DataBindings.Add(new Binding("Text", this.bindingSource1, "xFatherName", true));
            uc_txtBox_xAddress.DataBindings.Add(new Binding("Text", this.bindingSource1, "xAddress", true));
            uc_txtBox_xEmail.DataBindings.Add(new Binding("Text", this.bindingSource1, "xEmail", true));

            cmb_Sex.DataBindings.Add(new Binding("SelectedValue", this.bindingSource1, "xGenSex_", true));


            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();
            DataGridViewComboBoxColumn combobox_Sex_ = new DataGridViewComboBoxColumn();
            combobox_Sex_.DataSource = csm.SlGenGroup("SEX");
            combobox_Sex_.DisplayMember = "xName";
            combobox_Sex_.HeaderText = "جنسیت";
            combobox_Sex_.ValueMember = "x_";
            combobox_Sex_.DataPropertyName = "xGenSex_";
            combobox_Sex_.Name = "cmb_Sex_";
            combobox_Sex_.Width = 100;
            combobox_Sex_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridView1.Columns.Add(combobox_Sex_);

            cmb_Section.DataSource = csm.SlGenGroup("SEC");
            cmb_Section.DisplayMember = "xName";
            cmb_Section.ValueMember = "x_";

            cmb_Sex.DataSource = csm.SlGenGroup("SEX");
            cmb_Sex.DisplayMember = "xName";
            cmb_Sex.ValueMember = "x_";

            dt_P = new DAL.Customer.DataSet_Customer.mCustomerDataTable();
            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
        }
        DAL.Customer.DataSet_Customer.mCustomerDataTable dt_P;
        private void MCustomerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }
        void ShowData()
        {

            BLL.Customer.csCustomer cs = new BLL.Customer.csCustomer();
            dt_P = cs.mCustomer();
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
        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parkerDataSet.mCustomer' table. You can move, or remove it, as needed.
            ShowData();

        }
        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            this.dataGridView1.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
         

                MessageBox.Show(new BLL.Customer.csCustomer().UdCustomer(dt_P));
                ShowData();
            }
        }
        Stack<int> dvg_ind = new Stack<int>();
        private void uc_txtBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dvg_ind.Count > 0)
                {
                    int i = dvg_ind.Pop();
                    dataGridView1.Rows[i].Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows[i].Index > 1 ? dataGridView1.Rows[i].Index - 2 : dataGridView1.Rows[i].Index;
                }
            }
            else
            {
                dvg_ind.Clear();
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    item.Selected = false;
                }


                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell itemCell in item.Cells)
                    {

                        if (
                            itemCell.Visible == true && itemCell.Value != DBNull.Value && itemCell.Value != null &&
                            (itemCell.FormattedValue.ToString().Contains(uc_txtBox1.Text) ||
                             itemCell.FormattedValue.ToString().Contains(uc_txtBox1.Text.Replace('ی', 'ي')) ||
                              itemCell.FormattedValue.ToString().Contains(uc_txtBox1.Text.Replace('ي', 'ی')) ||
                               itemCell.FormattedValue.ToString().Contains(uc_txtBox1.Text.Replace('ک', 'ك')) ||
                                itemCell.FormattedValue.ToString().Contains(uc_txtBox1.Text.Replace('ك', 'ک')))
                            )
                        {

                            dvg_ind.Push(item.Index);
                            break;
                            //return;
                        }


                    }
                }
                if (dvg_ind.Count > 0)
                {
                    int i = dvg_ind.Pop();
                    dataGridView1.Rows[i].Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows[i].Index > 1 ? dataGridView1.Rows[i].Index - 2 : dataGridView1.Rows[i].Index;
                }
            }
            ///////////////////////////
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }

        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
