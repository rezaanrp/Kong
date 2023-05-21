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
    public partial class frmCustomerAdd : Form
    {
        public frmCustomerAdd(int x_)
        {
            InitializeComponent();
            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();
            //DataGridViewComboBoxColumn combobox_1_ = new DataGridViewComboBoxColumn()
            //{
            //    DataSource = csm.SlGenGroup("EFFCPCUS"),
            //    DisplayMember = "xName",
            //    ValueMember = "x_",
            //    DataPropertyName = "xGen_",
            //    Name = "xGen_",
            //    ReadOnly = true,
            //    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            //    DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            //};
            //dvg_EFFCPCUS.Columns.Add(combobox_1_);
            //DataGridViewComboBoxColumn combobox_2_ = new DataGridViewComboBoxColumn()
            //{
            //    DataSource = csm.SlGenGroup("FAVOCUS"),
            //    DisplayMember = "xName",
            //    ValueMember = "x_",
            //    DataPropertyName = "xGen_",
            //    Name = "xGen_",
            //    ReadOnly = true,
            //    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            //    DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            //};
            //dvg_FAVOCUS.Columns.Add(combobox_2_);
            x_Pu = x_;
            cmbLoad();
            if (x_ > 0)
            {
                var dt_R = new BLL.Customer.csCustomer().mCustomer_Byx_(x_);
                SetValueForm(dt_R[0]);
                //SetValueFormCheckListBox(x_);
                dvgFill();
            }
            else if (x_ < 0)
            {
                dvgLoad();
            }
        }
        int x_Pu;
        public bool flgEdit = false;
        void cmbLoad()
        {
            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();
            foreach (ComboBox item in splitContainer1.Panel2.Controls.OfType<ComboBox>())
            {
                item.DataSource = csm.SlGenGroup(item.Tag.ToString());
                item.DisplayMember = "xName";
                item.ValueMember = "x_";
                item.SelectedIndex = -1;
            }
        }
        void dvgLoad()
        {

            //dt_EFFCPCUS = new DAL.Customer.DataSet_Customer.mCustomerCheckedListDataTable();
            //dt_FAVOCUS = new DAL.Customer.DataSet_Customer.mCustomerCheckedListDataTable();

            //DataTable dt_1 = new BLL.GenGroup.csGenGroup().SlGenGroup("EFFCPCUS");
            //DataTable dt_2 = new BLL.GenGroup.csGenGroup().SlGenGroup("FAVOCUS");

            //bindingSource1.DataSource = dt_EFFCPCUS;
            //bindingSource2.DataSource = dt_FAVOCUS;

            //dvg_EFFCPCUS.DataSource = bindingSource1;
            //dvg_FAVOCUS.DataSource = bindingSource2;


            //foreach (DataRow item in dt_1.Rows)
            //{
            //    DataRow dr = dt_EFFCPCUS.NewRow();
            //    dr["xCustomer_"] = x_Pu;
            //    dr["xGen_"] = item["x_"];
            //    dr["xType"] = item["xType"];
            //    dr["xChecked"] = false;
            //    dt_EFFCPCUS.Rows.Add(dr);
            //}

            /////////////////////////////////////////////////////////////////////////////////////
            //foreach (DataRow item in dt_2.Rows)
            //{
            //    DataRow dr = dt_FAVOCUS.NewRow();
            //    dr["xCustomer_"] = x_Pu;
            //    dr["xGen_"] = item["x_"];
            //    dr["xType"] = item["xType"];
            //    dr["xChecked"] = false;
            //    dt_FAVOCUS.Rows.Add(dr);
            //}

            //foreach (DataGridView itemdvg in splitContainer1.Panel2.Controls.OfType<DataGridView>())
            //{
            //    if (itemdvg.Name.Contains("dvg"))
            //    {
            //        foreach (DataGridViewColumn item in itemdvg.Columns)
            //        {
            //            item.Visible = false;
            //        }
            //        itemdvg.Columns["xGen_"].Visible = true;
            //        itemdvg.Columns["xChecked"].Visible = true;
            //        itemdvg.Columns["xGen_"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //        itemdvg.Columns["xChecked"].Width = 20;
            //    }
            //}
        }
        void dvgFill()
        {

            //dt_EFFCPCUS = new BLL.Customer.csCustomer().mCustomerCheckedList(x_Pu, "EFFCPCUS");
            //bindingSource1.DataSource = dt_EFFCPCUS;
            //dvg_EFFCPCUS.DataSource = bindingSource1;
            //foreach (DataGridViewColumn item in dvg_EFFCPCUS.Columns)
            //{
            //    item.Visible = false;
            //}

            //dvg_EFFCPCUS.Columns["xGen_"].Visible = true;
            //dvg_EFFCPCUS.Columns["xChecked"].Visible = true;
            //dvg_EFFCPCUS.Columns["xGen_"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dvg_EFFCPCUS.Columns["xChecked"].Width = 20;


            //dt_FAVOCUS = new BLL.Customer.csCustomer().mCustomerCheckedList(x_Pu, "FAVOCUS");
            //bindingSource2.DataSource = dt_FAVOCUS;
            //dvg_FAVOCUS.DataSource = bindingSource2;
            //foreach (DataGridViewColumn item in dvg_FAVOCUS.Columns)
            //{
            //    item.Visible = false;
            //}

            //dvg_FAVOCUS.Columns["xGen_"].Visible = true;
            //dvg_FAVOCUS.Columns["xChecked"].Visible = true;
            //dvg_FAVOCUS.Columns["xGen_"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dvg_FAVOCUS.Columns["xChecked"].Width = 20;
        }
        void SetValueForm(DataRow dt_R)
        {
            foreach (ControlLibrary.uc_txtBox item in splitContainer1.Panel2.Controls.OfType<ControlLibrary.uc_txtBox>())
            {
                if (dt_R[item.Name.Substring(4)] != DBNull.Value)
                    item.Text = dt_R[item.Name.Substring(4)].ToString();
            }
            foreach (ComboBox item in splitContainer1.Panel2.Controls.OfType<ComboBox>())
            {
                if (dt_R[item.Name.Substring(4)] != DBNull.Value)
                    item.SelectedValue = (int?)dt_R[item.Name.Substring(4)];
            }
            foreach (MaskedTextBox item in splitContainer1.Panel2.Controls.OfType<MaskedTextBox>())
            {
                if (dt_R[item.Name.Substring(4)] != DBNull.Value)
                    item.Text = dt_R[item.Name.Substring(4)].ToString();
            }
            //foreach (CheckedListBox itemC in splitContainer1.Panel2.Controls.OfType<CheckedListBox>())
            //{
            //    DataTable dt = new BLL.Customer.csCustomer().SlCustomerCheckedList(x_Pu, itemC.Tag.ToString());
            //    foreach (DataRow item in dt.Rows)
            //    {
            //        if ((bool)item["Checked"])
            //            itemC.Items.Add(item["xName"], CheckState.Checked);
            //        else
            //            itemC.Items.Add(item["xName"], CheckState.Unchecked);
            //    }
            //}
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void InsertData()
        {
            DAL.Customer.DataSet_Customer.mCustomer_Byx_DataTable dt_C
                = new DAL.Customer.DataSet_Customer.mCustomer_Byx_DataTable();
            DataRow dr_C = dt_C.NewRow();
            dr_C["xDate"] = BLL.csshamsidate.shamsidate;
            dr_C["xSupplier_"] = BLL.authentication.x_;
            foreach (ControlLibrary.uc_txtBox item in splitContainer1.Panel2.Controls.OfType<ControlLibrary.uc_txtBox>())
            {
                if (item.Text.Replace(" ", "") == "")
                    dr_C[item.Name.Substring(4)] = DBNull.Value;
                else
                    dr_C[item.Name.Substring(4)] = item.Text;
            }
            foreach (MaskedTextBox item in splitContainer1.Panel2.Controls.OfType<MaskedTextBox>())
            {
                if (item.Text.Replace(" ", "") == "")
                    dr_C[item.Name.Substring(4)] = DBNull.Value;
                else
                    dr_C[item.Name.Substring(4)] = item.Text;
            }
            foreach (ComboBox item in splitContainer1.Panel2.Controls.OfType<ComboBox>())
            {
                if (item.SelectedValue != null)
                    dr_C[item.Name.Substring(4)] = item.SelectedValue;
            }
            dt_C.Rows.Add(dr_C);
            new BLL.Customer.csCustomer().UdCustomer_Byx_(dt_C);
            flgEdit = true;
            //foreach (DataRow item in dt_EFFCPCUS)
            //{
            //    item["xCustomer_"] = dt_C.Rows[0]["x_"];
            //}
            //foreach (DataRow item in dt_FAVOCUS)
            //{
            //    item["xCustomer_"] = dt_C.Rows[0]["x_"];
            //}
            //new BLL.Customer.csCustomer().UdCustomerCheckedList(dt_FAVOCUS);
            //new BLL.Customer.csCustomer().UdCustomerCheckedList(dt_EFFCPCUS);

        }
        void EditData(int x_)
        {
            DAL.Customer.DataSet_Customer.mCustomer_Byx_DataTable dt_C;

            dt_C = new BLL.Customer.csCustomer().mCustomer_Byx_(x_);
            if (dt_C.Rows.Count > 0)
            {
                dt_C[0]["xDate"] = BLL.csshamsidate.shamsidate;
                dt_C[0]["xSupplier_"] = BLL.authentication.x_;
                foreach (ControlLibrary.uc_txtBox item in splitContainer1.Panel2.Controls.OfType<ControlLibrary.uc_txtBox>())
                {
                    if (item.Text.Replace(" ", "") == "")
                        dt_C[0][item.Name.Substring(4)] = DBNull.Value;
                    else
                        dt_C[0][item.Name.Substring(4)] = item.Text;
                }
                foreach (MaskedTextBox item in splitContainer1.Panel2.Controls.OfType<MaskedTextBox>())
                {
                    if (item.Text.Replace(" ", "") == "")
                        dt_C[0][item.Name.Substring(4)] = DBNull.Value;
                    else
                        dt_C[0][item.Name.Substring(4)] = item.Text;
                }
                foreach (ComboBox item in splitContainer1.Panel2.Controls.OfType<ComboBox>())
                {
                    if (item.SelectedValue != null)
                        dt_C[0][item.Name.Substring(4)] = item.SelectedValue;
                }
                new BLL.Customer.csCustomer().UdCustomer_Byx_(dt_C);
                flgEdit = true;

                this.Validate();
               // dvg_EFFCPCUS.EndEdit();
            //    new BLL.Customer.csCustomer().UdCustomerCheckedList(dt_EFFCPCUS);


            }
        }
        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (x_Pu < 0)
                InsertData();
            else
            {
                EditData(x_Pu);
            }
            this.Close();

        }
    }
}
