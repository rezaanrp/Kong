using MIS.FRM.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Forms;

namespace MIS.FRM.Company
{
    public partial class frmCompany : Form
    {
        public frmCompany()
        {
            InitializeComponent();



            txt_xCompanyName.DataBindings.Add(new Binding("Text", this.bindingSource1, "xCompanyName", true));
            txt_xBusinessNumber.DataBindings.Add(new Binding("Text", this.bindingSource1, "xBusinessNumber", true));
            txt_xRegistrationNumber.DataBindings.Add(new Binding("Text", this.bindingSource1, "xRegistrationNumber", true));
            txt_xNationalCode.DataBindings.Add(new Binding("Text", this.bindingSource1, "xNationalCode", true));
            txt_xTel.DataBindings.Add(new Binding("Text", this.bindingSource1, "xTel", true));
            txt_xFax.DataBindings.Add(new Binding("Text", this.bindingSource1, "xFax", true));
            txt_xEmail.DataBindings.Add(new Binding("Text", this.bindingSource1, "xEmail", true));
            txt_xZipCode.DataBindings.Add(new Binding("Text", this.bindingSource1, "xZipCode", true));
            txt_xAddress.DataBindings.Add(new Binding("Text", this.bindingSource1, "xAddress", true));
            txt_xWebsite.DataBindings.Add(new Binding("Text", this.bindingSource1, "xWebsite", true));
            txt_xSupplyManager.DataBindings.Add(new Binding("Text", this.bindingSource1, "xSupplyManager", true));
            txt_xSupplyManagerTel.DataBindings.Add(new Binding("Text", this.bindingSource1, "xSupplyManagerTel", true));
            txt_xDirectorFactor.DataBindings.Add(new Binding("Text", this.bindingSource1, "xDirectorFactor", true));
            txt_xDirectorFactorTel.DataBindings.Add(new Binding("Text", this.bindingSource1, "xDirectorFactorTel", true));
            txt_xGrade.DataBindings.Add(new Binding("Text", this.bindingSource1, "xGrade", true));
            txt_xGradeDate.DataBindings.Add(new Binding("Text", this.bindingSource1, "xGradeDate", true));
            txt_xEvaluationPerson.DataBindings.Add(new Binding("Text", this.bindingSource1, "xEvaluationPerson", true));
            txt_xComment.DataBindings.Add(new Binding("Text", this.bindingSource1, "xComment", true));
            chb_xActive.DataBindings.Add(new Binding("Checked", this.bindingSource1, "xActive", true));
            ShowData();
        }
        DAL.Company.DataSet_Company.mCompanyDataTable dt_C;
        void ShowData()
        {
            dt_C = new BLL.Company.csCompany().mCompany("");
            bindingSource1.DataSource = dt_C;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_C.Columns)
            {
                if (dataGridView1.Columns[dc.ColumnName] != null)
                    dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
            dataGridView1.Columns["x_"].Visible = false;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridView1.EndEdit();
            if (new MIS.CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.Company.csCompany().UdCompany(dt_C), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.bindingSource1.DataSource = this.dt_C;
                this.dataGridView1.DataSource = this.bindingSource1;
                this.bindingNavigator1.BindingSource = this.bindingSource1;
                this.ShowData();
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void toolStripButton_Add_Click(object sender, EventArgs e)
        {
            new frmCompanyAdd(-1).ShowDialog();
            ShowData();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmCompanyAdd fr = new frmCompanyAdd((int)dataGridView1["x_", e.RowIndex].Value);
            //  fr((int)dataGridView1["x_", e.RowIndex].Value)
            fr.ShowDialog();
            if (fr.flgEdit)
                ShowData();
        }
    }
}
