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
    public partial class frmContractor : Form
    {
        public frmContractor()
        {
            InitializeComponent();
            uc_txtBoxName.DataBindings.Add(new Binding("Text", this.bindingSource1, "xName", true));
            uc_txtBox_xFamily.DataBindings.Add(new Binding("Text", this.bindingSource1, "xFamily", true));
            uc_txtBox_xMob.DataBindings.Add(new Binding("Text", this.bindingSource1, "xMobile", true));
            uc_txtBox_xNationalCode.DataBindings.Add(new Binding("Text", this.bindingSource1, "xNationalCode", true));
            uc_txtBox_xTel.DataBindings.Add(new Binding("Text", this.bindingSource1, "xTel", true));
            uc_txtBox_FatherName.DataBindings.Add(new Binding("Text", this.bindingSource1, "xFatherName", true));
            uc_txtBox_xAddress.DataBindings.Add(new Binding("Text", this.bindingSource1, "xAddress", true));

            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();

            DataGridViewComboBoxColumn combobox_JOB_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("JOB"),
                DisplayMember = "xName",
                HeaderText = "حیطه کاری",
                ValueMember = "x_",
                DataPropertyName = "xGenJob_",
                Name = "xGenJob_",
                Width = 200,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
            };
            dataGridView1.Columns.Add(combobox_JOB_);


            cmb_xGenJob_.DataSource = csm.SlGenGroup("JOB");
            cmb_xGenJob_.DisplayMember = "xName";
            cmb_xGenJob_.ValueMember = "x_";
            cmb_xGenJob_.SelectedIndex = -1;
            //dt_P = new DAL.Contractor.DataSet_Contractor.mContractorDataTable();
            //bindingSource1.DataSource = dt_P;
            //dataGridView1.DataSource = bindingSource1;
            //bindingNavigator1.BindingSource = bindingSource1;
            ShowData("*");
        }
        DAL.Contractor.DataSet_Contractor.mContractorDataTable dt_P;
        void ShowData(string SRC)
        {
            BLL.Contractor.csContractor cs = new BLL.Contractor.csContractor();
            if (cmb_xGenJob_.SelectedValue != null)
                dt_P = cs.mContractor(SRC, (int)cmb_xGenJob_.SelectedValue);
            else
                dt_P = cs.mContractor(SRC, -1);

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
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
            dataGridView1.Columns["xFamily"].HeaderText = "نام خانوادگی";
            dataGridView1.Columns["xAddress"].Width = 300;

            dt_P.xSupplier_Column.DefaultValue = BLL.authentication.x_;
        }

        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            this.dataGridView1.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.Contractor.csContractor().UdContractor(dt_P));
                ShowData("*");
            }
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }

        private void ToolStripButton_Add_Click(object sender, EventArgs e)
        {
            new FRM.Contractor.frmContractorNew().ShowDialog();
            ShowData("*");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowData(uc_txtBox1.Text);
        }
    }
}
