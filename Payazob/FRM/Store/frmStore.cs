using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MIS.FRM.Store
{
    public partial class frmStore : Form
    {
        public frmStore(bool ReadOnlyForm)
        {
            InitializeComponent();
            ReadOnlyForm_ = ReadOnlyForm;
            if (ReadOnlyForm_)
            {
                dataGridView1.ReadOnly = true;
                bindingNavigator1.Enabled = false;
            }
         //   DataGridView1CmbLoad();
            DataGridView2CmbLoad();

            ShowDataDetails(-1);
            // x_, xDate, xName, xLastName, xFatherName, xChildNo, xNationalCode, xBirthDay, xMobile, xPhone, xEmploy, xGenIntroductionMethod_, xGenFaith_, xAddress, xSupplier_

            uc_DataGridViewBtn1.ColumnsFilter_ = "xName";
            uc_DataGridViewBtn1.Ds = new BLL.Customer.csCustomer().mCustomer();

            uc_DataGridViewBtn1.ParamName = new string[] { "xName", "xLastName", "xNationalCode" };
            uc_DataGridViewBtn1.ParamValue = new string[] { "نام ", "فامیل", "کد ملی" };
            uc_DataGridViewBtn1.ParamHide = new string[] { "x_" };

            formFunctionPointer += new functioncall(Replicate);
            uc_DataGridViewBtn1.userFunctionPointer = formFunctionPointer;



        }
        public delegate void functioncall(string Display, string value);
        private event functioncall formFunctionPointer;
        private void Replicate(string Display, string value)
        {
            if (value != "-1")
            {
                dataGridView1["Customer", uc_DataGridViewBtn1.RI].Value = int.Parse(value);
                dataGridView1["xCustomer_", uc_DataGridViewBtn1.RI].Value = int.Parse(value);
            }
        }
        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            uc_DataGridViewBtn1.Visible = false;
        }
        bool ReadOnlyForm_;
        void DataGridView2CmbLoad()
        {
            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();
            DataGridViewComboBoxColumn combobox_xGoods__ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.Goods.csGoods().mGoods(""),
                DisplayMember = "xName",
                ValueMember = "x_",
                DataPropertyName = "xGoods_",
                Name = "xGoods_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(combobox_xGoods__);
           
        }
        void DataGridView1CmbLoad()
        {
            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();

            DataGridViewTextBoxColumn tx = new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "xCustomer_",
                Name = "Customer",
                HeaderText = "کد مشتری"
            };
            dataGridView1.Columns.Add(tx);

            //DataGridViewTextBoxColumn tx1 = new DataGridViewTextBoxColumn()
            //{
            //    DataPropertyName = "xCompanyCustomer_",
            //    Name = "xCompanyCustomer_",
            //    HeaderText = "کد مشتری"
            //};
            //dataGridView1.Columns.Add(tx1);
            DataGridViewComboBoxColumn combobox_xCustomer__ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.Customer.csCustomer().mCustomer_ComboBox(),
                DisplayMember = "NamAndFamily",
                ValueMember = "x_",
                DataPropertyName = "xCustomer_",
                Name = "xCustomer_",
                Width = 150,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(combobox_xCustomer__);

            DataGridViewComboBoxColumn combobox_xGenStatus_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("STATSTORESALE"),
                DisplayMember = "xName",
                ValueMember = "x_",
                DataPropertyName = "xGenStatus_",
                Name = "xGenStatus_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(combobox_xGenStatus_);
            DataGridViewComboBoxColumn combobox_xSupplier_ = new DataGridViewComboBoxColumn()
            {
                DisplayIndex = 4,
                DataSource = new BLL.authentication().NameOfUser(),
                DisplayMember = "NameAndFamily",
                ValueMember = "x_",
                DataPropertyName = "xSupplier_",
                Name = "xSupplier_",
                ReadOnly = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(combobox_xSupplier_);
            DataGridViewComboBoxColumn combobox_xSellerUser_ = new DataGridViewComboBoxColumn()
            {
                DisplayIndex = 4,
                DataSource = new BLL.authentication().NameOfUser(),
                DisplayMember = "NameAndFamily",
                ValueMember = "x_",
                DataPropertyName = "xSellerUser_",
                Name = "xSellerUser_",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(combobox_xSellerUser_);
        }
        DAL.Store.DataSet_Store.mStoreDataTable dt_P;
        DAL.Store.DataSet_Store.mStoreDetialsDataTable dt_D;
        void ShowData(int x_)
        {
            int rdb = -1;
                rdb = 240;

                dataGridView1.DataSource = null;
                bindingSource1.DataSource = null;
                DataGridView1CmbLoad();


                if (x_ > 0)
                    dt_P = new BLL.Store.csStore().mStore(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
                else
                    dt_P = new DAL.Store.DataSet_Store.mStoreDataTable();

                bindingSource1.DataSource = dt_P;
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;

                //dataGridView1.Columns["xCustomer_"].Visible = false;
                //dataGridView1.Columns["Customer"].Visible = false;


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
            dt_P.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_P.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_P.xRegisterTimeColumn.DefaultValue = new BLL.csshamsidate().CurrentTime;
            dataGridView1.Columns["xComment"].Width = 300;
            dataGridView1.Columns["xRegisterTime"].Width = 60;
            dataGridView1.Columns["xRegisterTime"].ReadOnly = true;

            dataGridView1.Columns["Customer"].DisplayIndex = dataGridView1.Columns["xCustomer_"].DisplayIndex;



        }
        void ShowDataDetails(int x_)
        {
            if (x_ > 0)
            {
                dt_D = new BLL.Store.csStore().mStoreDetials(x_);
                dataGridView2.ReadOnly = false;
                bindingNavigator2.Enabled = true;
            }
            else
            {
                dt_D = new DAL.Store.DataSet_Store.mStoreDetialsDataTable();
                dataGridView2.ReadOnly = true;
                bindingNavigator2.Enabled = false;
            }
            bindingSource2.DataSource = dt_D;
            dataGridView2.DataSource = bindingSource2;
            bindingNavigator2.BindingSource = bindingSource2;
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
            dataGridView2.Columns["xStore_"].Visible = false;
            dataGridView2.Columns["xAmount"].DefaultCellStyle.Format = "N2";
            dataGridView2.Columns["xPrice"].DefaultCellStyle.Format = "N0";
            dataGridView2.Columns["xDiscount"].DefaultCellStyle.Format = "N0";
            dt_D.xStore_Column.DefaultValue = x_;

            dataGridView2.Columns["xGoodsContext"].Width = 200;

            //xGoodsContext
        }
        void SaveData()
        {
            this.dataGridView1.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.Store.csStore().UdStore(dt_P));
                ShowData(1);
            }
        }
        void SaveDataDetails()
        {
            this.dataGridView2.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.Store.csStore().UdStoreDetials(dt_D));
                if (dataGridView1.SelectedCells.Count > 0)
                    ShowDataDetails((int)dataGridView1["x_", dataGridView1.SelectedCells[0].RowIndex].Value);
            }
        }
        private void toolStripButton_Add_Click(object sender, EventArgs e)
        {
            new FRM.Store.frmStoreInsert(-1, ReadOnlyForm_).ShowDialog();
            ShowData(1);

        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveData();
            ShowData(1);
            if (dataGridView1.SelectedRows.Count > 0)
                ShowDataDetails((int)dataGridView1.SelectedRows[0].Cells["x_"].Value);
        }
        private void glassButton_EXit_Click(object sender, EventArgs e)
        {
            ShowData(1);

        }
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            FRM.Store.frmStoreInsert frm = new FRM.Store.frmStoreInsert((int)dataGridView1["x_", e.RowIndex].Value, ReadOnlyForm_);
            frm.ShowDialog();
            if (frm.IsEditing)
                ShowData(1);
        }
        private void frmStore_Load(object sender, EventArgs e)
        {
            ShowData(-1);

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
        private void printToolStripButton_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                ShowDataDetails((int)dataGridView1["x_", e.RowIndex].Value);
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Customer")
                {
                    uc_DataGridViewBtn1.Visible = true;
                    var cellRectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    uc_DataGridViewBtn1.Location = new Point(cellRectangle.X, cellRectangle.Y);
                    uc_DataGridViewBtn1.Size = new Size(20, dataGridView1.Rows[e.RowIndex].Height);
                    uc_DataGridViewBtn1.RI = e.RowIndex;
                    uc_DataGridViewBtn1.CI = e.ColumnIndex;
                }

                else
                    uc_DataGridViewBtn1.Visible = false;
            }
        }
        private void toolStripButton_SaveDetails_Click(object sender, EventArgs e)
        {
            SaveDataDetails();
        }
        private void toolStripButtonPrintDetails_Click(object sender, EventArgs e)
        {
            if (rdb_241.Checked
                && dataGridView1.SelectedRows[0].Cells["x_"].Value != DBNull.Value)
            {
                int ft = (int)dataGridView1.SelectedRows[0].Cells["x_"].Value;
                Report.SendReport cs = new Report.SendReport();
                cs.SetParam("BillCode", ft.ToString());

                frmReport r = new frmReport();
                DataTable dt = new BLL.Store.csStore().SlStoreBill(ft);
                r.GetReport = cs.GetReport(dt, "crsStoreBill");

                r.ShowDialog();
                r.Dispose();
            }
            if (rdb_240.Checked
                        && dataGridView1.SelectedRows[0].Cells["x_"].Value != DBNull.Value)
            {
                int ft = (int)dataGridView1.SelectedRows[0].Cells["x_"].Value;
                Report.SendReport cs = new Report.SendReport();
                cs.SetParam("BillCode", ft.ToString());

                frmReport r = new frmReport();
                DataTable dt = new BLL.Store.csStore().SlStoreBillTax(ft);
                r.GetReport = cs.GetReport(dt, "crsStoreBillByTax");

                r.ShowDialog();
                r.Dispose();
            }
        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                // ShowDataDetails((int)dataGridView1["x_", e.RowIndex].Value);
                if (dataGridView1.Columns[e.ColumnIndex].Name != "Customer")

                    uc_DataGridViewBtn1.Visible = false;
                //else
                //{
                //    uc_DataGridViewBtn1.Visible = true;
                //    var cellRectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                //    uc_DataGridViewBtn1.Location = new Point(cellRectangle.X, cellRectangle.Y);
                //    uc_DataGridViewBtn1.Size = new Size(20, dataGridView1.Rows[e.RowIndex].Height);
                //    uc_DataGridViewBtn1.RI = e.RowIndex;
                //    uc_DataGridViewBtn1.CI = e.ColumnIndex;
                //}
            }
        }
    }
}
