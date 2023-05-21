using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MIS.FRM.GoodsAndSupplierInfo
{
    public partial class frmGoodsAndSupplierInfo : Form
    {
        public frmGoodsAndSupplierInfo()
        {
            InitializeComponent();
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
            CmbGiveValue();
            ShowData("");
        }
        void CmbGiveValue()
        {

        }

        DAL.Company.DataSet_Company.mCompany_ActiveListDataTable dt_P;
        DAL.GoodsAndSupplierInfo.DataSet_GoodsAndSupplierInfo.mGoodsAndSupplierInfoDataTable dt_R;
        void ShowData(string Srch)
        {
            dt_P = new BLL.Company.csCompany().mCompany_ActiveList(Srch);
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
            dataGridView1.ReadOnly = true;
            bindingNavigator1.Enabled = false;
            dataGridView1.Columns["xCompanyName"].Width = 200;
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xAddress"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        void ShowDataDetails(int x_)
        {
            dt_R = new BLL.GoodsAndSupplierInfo.csGoodsAndSupplierInfo().mGoodsAndSupplierInfo(x_);
            bindingSource2.DataSource = dt_R;
            dataGridView2.DataSource = bindingSource2;
            bindingNavigator2.BindingSource = bindingSource2;
            CS.csDic css = new CS.csDic();
            foreach (DataColumn dc in dt_R.Columns)
            {
                if (dataGridView2.Columns[dc.ColumnName] != null)
                {
                    dataGridView2.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                    dataGridView2.Columns[dc.ColumnName].DisplayIndex = dt_R.Columns[dc.ColumnName].Ordinal;
                }
            }
            dt_R.xCompany_Column.DefaultValue = x_;
            dt_R.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dataGridView2.Columns["x_"].Visible = false;
            dataGridView2.Columns["xSupplier_"].Visible = false;
            dataGridView2.Columns["xCompany_"].Visible = false;
        }

        private void GlassButton_EXit_Click(object sender, EventArgs e)
        {
            ShowData(txt_Search.Text);
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                ShowDataDetails((int)dataGridView1["x_", e.RowIndex].Value);
            }
        }

        private void ToolStripButton_Add_Rebuilding_Click(object sender, EventArgs e)
        {
            //  if (dataGridView1.SelectedRows.Count > 0)
            //    new FRM.Rebuilding.frmRebuildingRegister((int)dataGridView1.SelectedRows[0].Cells["x_"].Value, -1, CS.csEnum.RebuildingUser.User).ShowDialog();
        }

        private void DataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // new FRM.Rebuilding.frmRebuildingRegister(-1, (int)dataGridView2.SelectedRows[0].Cells["x_"].Value, rebuildingUser_).ShowDialog();
            //if (dataGridView1.SelectedCells.Count > 0)
            //  ShowDataDetails((int)dataGridView1["x_", dataGridView1.SelectedCells[0].RowIndex].Value);

        }

        private void ToolStripButton11_Click(object sender, EventArgs e)
        {
            this.dataGridView2.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.GoodsAndSupplierInfo.csGoodsAndSupplierInfo().UdGoodsAndSupplierInfo(dt_R));
                if (dataGridView1.SelectedCells.Count > 0)
                    ShowDataDetails((int)dataGridView1["x_", dataGridView1.SelectedCells[0].RowIndex].Value);
            }
        }
    }
}
