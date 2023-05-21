using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MIS.FRM.Goods
{
    public partial class frmGoods : Form
    {
        public frmGoods()
        {
            InitializeComponent();
            DataGridViewCmbLoad();
        }
        DAL.Goods.DataSet_Goods.mGoodsDataTable dt_P;
        void ShowData(string src)
        {
            dt_P = new BLL.Goods.csGoods().mGoods(src);
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
            dataGridView1.Columns["xSupplier_"].Visible = false;
            dt_P.xSupplier_Column.DefaultValue = BLL.authentication.x_;
        }
        void DataGridViewCmbLoad()
        {
            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();
            DataGridViewComboBoxColumn combobox_1_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("GOODSGROUP"),
                DisplayMember = "xName",
                ValueMember = "x_",
                DataPropertyName = "xGenGroup_",
                Name = "xGenGroup_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(combobox_1_);

            DataGridViewComboBoxColumn combobox_2_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("GOODSUNIT"),
                DisplayMember = "xName",
                ValueMember = "x_",
                DataPropertyName = "xGenUnit_",
                Name = "xGenUnit_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(combobox_2_);
        }
        private void FrmGoods_Load(object sender, EventArgs e)
        {
            ShowData("");
        }
        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            this.dataGridView1.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.Goods.csGoods().UdGoods(dt_P));
                ShowData("");
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }
    }
}
