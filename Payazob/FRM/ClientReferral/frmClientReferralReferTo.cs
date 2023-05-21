using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MIS.FRM.ClientReferral
{
    public partial class frmClientReferralReferTo : Form
    {
        public frmClientReferralReferTo(CS.csEnum.ReferTo referTo)
        {
            InitializeComponent();
            ReferTo_ = referTo;
            //
            DataGridViewComboBoxColumn combobox_xReferConfirmSupplier_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.authentication().NameOfUser(),
                DisplayMember = "NameAndFamily",
                ValueMember = "x_",
                DataPropertyName = "xReferConfirmSupplier_",
                Name = "xReferConfirmSupplier_",
                Width = 100,
                ReadOnly = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(combobox_xReferConfirmSupplier_);
            DataGridViewComboBoxColumn combobox_xSupplier_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.authentication().NameOfUser(),
                DisplayMember = "NameAndFamily",
                ValueMember = "x_",
                DataPropertyName = "xSupplier_",
                Name = "xSupplier_",
                Width = 100,
                ReadOnly = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(combobox_xSupplier_);
            DataGridViewComboBoxColumn combobox_xSupplier1_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.authentication().NameOfUser(),
                DisplayMember = "NameAndFamily",
                ValueMember = "x_",
                DataPropertyName = "xSupplier_",
                Name = "xSupplier_",
                Width = 100,
                ReadOnly = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(combobox_xSupplier1_);

            DataGridViewComboBoxColumn combobox_ResultOfReferral_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("ResultOfReferral"),
                DisplayMember = "xName",
                HeaderText = " نتیجه مراجعه",
                ValueMember = "x_",
                DataPropertyName = "xGenResultOfReferral_",
                Name = "xGenResultOfReferral_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
            };
            dataGridView1.Columns.Add(combobox_ResultOfReferral_);

            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();
            DataGridViewComboBoxColumn xGenFollowUp_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("FOLLOWUPTYPE"),
                DisplayMember = "xName",
                ValueMember = "x_",
                DataPropertyName = "xGenFollowUp_",
                Name = "xGenFollowUp_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(xGenFollowUp_);

            DataGridViewComboBoxColumn combobox_xGenReferTo_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("ReferTo"),
                DisplayMember = "xName",
                ValueMember = "x_",
                DataPropertyName = "xGenReferTo_",
                Name = "xGenReferTo_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
            };
            dataGridView1.Columns.Add(combobox_xGenReferTo_);

        }
        CS.csEnum.ReferTo ReferTo_;
        private void frmClientReferralFollowUp_Load(object sender, EventArgs e)
        {
            ShowData(true, "", false, "", false, "", false, -1, false);

            if (dataGridView1.SelectedRows.Count > 0)

                ShowDataDetails((int)dataGridView1.SelectedRows[0].Cells["x_"].Value);

            else
                ShowDataDetails(-1);

        }
        DAL.ClientReferral.DataSet_ClientReferral.SlClientReferral_ReferDataTable dt_P;
        DAL.ClientReferral.DataSet_ClientReferral.mClientReferralFollowUpDataTable dt_D;
        void ShowData(bool SearchDate,
                        string xClientReferral,
                        bool SearchxClientReferral,
                        string xTel,
                        bool SearchxTel,
                        string xRequestedGoods,
                        bool SearchxRequestedGoods,
                        int xGenResultOfReferral_,
                        bool SearchxGenResultOfReferral_)
        {
            dt_P = new BLL.ClientReferral.csClientReferral().SlClientReferral_Refer(
                uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo,
                SearchDate,
                xClientReferral,
                SearchxClientReferral,
                xTel,
                SearchxTel,
                xRequestedGoods,
                SearchxRequestedGoods,
                xGenResultOfReferral_,
                SearchxGenResultOfReferral_, (int)ReferTo_
                );
            dataGridView1.DataSource = dt_P;
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
            //dataGridView1.Columns["xReferConfirmSupplier_"].Visible = false;
            //dataGridView1.Columns["xReferConfirmDate"].Visible = false;
            dataGridView1.Columns["xReferConfirmDate"].ReadOnly = true;
            dataGridView1.Columns["xReferFinanceConfirm"].ReadOnly = true;
            dataGridView1.Columns["xAddress"].Width = 200;
            dataGridView1.Columns["xComment"].Width = 200;
            dataGridView1.Columns["xAction"].Width = 200;
            dataGridView1.Columns["xRequestedGoods"].Width = 200;
            dataGridView1.Columns["xTime"].Width = 65;
            dt_P.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_P.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_P.xTimeColumn.DefaultValue = new BLL.csshamsidate().CurrentTime;
            dataGridView1.Columns["xContractPrice"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["xRecommenderCommission"].DefaultCellStyle.Format = "N0";


            if (ReferTo_ == CS.csEnum.ReferTo.mali)
            {
                foreach (DataGridViewColumn dc in dataGridView1.Columns)
                {
                    if (dc.Name == "xReferFinanceConfirm"
                        || dc.Name == "xContractPrice"
                        || dc.Name == "xRecommenderCommission")
                    {
                        dc.ReadOnly = false;
                        dc.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else
                        dc.ReadOnly = true;

                }
            }
            else
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                if (dr.Cells["xGenResultOfReferral_"].Value == null
                    || dr.Cells["xGenResultOfReferral_"].Value == DBNull.Value)
                    continue;
                if (
                    dr.Cells["xReferFinanceConfirm"].Value != null
                 && dr.Cells["xReferFinanceConfirm"].Value != DBNull.Value
                 && (bool)dr.Cells["xReferFinanceConfirm"].Value == true
                    )
                {
                    dr.ReadOnly = true;
                    dr.DefaultCellStyle.BackColor = Color.Gray;
                    continue;

                }
                if ((int)dr.Cells["xGenResultOfReferral_"].Value == 284)
                {
                    dr.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else if ((int)dr.Cells["xGenResultOfReferral_"].Value == 285)
                {
                    dr.DefaultCellStyle.BackColor = Color.LightYellow;
                }
                else if ((int)dr.Cells["xGenResultOfReferral_"].Value == 286)
                {
                    dr.DefaultCellStyle.BackColor = Color.LightPink;
                }
                else if ((int)dr.Cells["xGenResultOfReferral_"].Value == 287)
                {
                    dr.DefaultCellStyle.BackColor = Color.LightBlue;
                }


            }
        }
        void SaveData()
        {
            this.dataGridView1.EndEdit();
            this.dataGridView2.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.ClientReferral.csClientReferral().UdClientReferralFollowUp(dt_D));
                ShowData(true, "", false, "", false, "", false, -1, false);

            }
        }
        void ShowDataDetails(int x_)
        {
            if (x_ > 0)
            {
                dt_D = new BLL.ClientReferral.csClientReferral().mClientReferralFollowUp(x_);
                dataGridView2.ReadOnly = false;
                bindingNavigator1.Enabled = true;
            }
            else
            {
                dt_D = new DAL.ClientReferral.DataSet_ClientReferral.mClientReferralFollowUpDataTable();
                dataGridView2.ReadOnly = true;
                bindingNavigator1.Enabled = false;
            }
            bindingSource1.DataSource = dt_D;
            dataGridView2.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            CS.csDic css = new CS.csDic();
            foreach (DataColumn dc in dt_D.Columns)
            {
                if (dataGridView2.Columns[dc.ColumnName] != null)
                {
                    dataGridView2.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                    dataGridView2.Columns[dc.ColumnName].DisplayIndex = dt_D.Columns[dc.ColumnName].Ordinal;
                }
            }
            if (dataGridView1.SelectedRows.Count > 0
                && dataGridView1.SelectedRows[0].Cells["xGenResultOfReferral_"].Value != DBNull.Value
                && (int?)dataGridView1.SelectedRows[0].Cells["xGenResultOfReferral_"].Value == 287)
            {
                dataGridView2.Columns["xConstructionStage"].Visible = true;
            }
            else
                dataGridView2.Columns["xConstructionStage"].Visible = false;

            dataGridView2.Columns["x_"].Visible = false;
            dataGridView2.Columns["xClientReferral_"].Visible = false;
            dataGridView2.Columns["xAction"].Width = 300;
            dataGridView2.Columns["xMasterFollowUp"].Width = 120;
            dt_D.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_D.xTimeColumn.DefaultValue = new BLL.csshamsidate().CurrentTime;
            dt_D.xClientReferral_Column.DefaultValue = x_;
            dt_D.xSupplier_Column.DefaultValue = BLL.authentication.x_;
        }
        private void glassButton_EXit_Click(object sender, EventArgs e)
        {
            ShowData(true, "", false, "", false, "", false, -1, false);

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            //uc.Fildvg = dataGridView1;
            //uc.RunExcel();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //   splitContainer3.Panel2Collapsed = true;

            if (e.RowIndex > -1 && e.ColumnIndex > -1)
                if (dataGridView1["xTel", e.RowIndex].Value != DBNull.Value
                    && dataGridView1["xTel", e.RowIndex].Value != null)
                    ShowDataDetails((int)dataGridView1["x_", e.RowIndex].Value);

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }
        List<string> ListMobForSMS()
        {
            List<string> Mob = new List<string>();

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Selected && item.Cells["xTel"].Value != DBNull.Value)
                    Mob.Add((string)item.Cells["xTel"].Value);
            }
            return Mob;
        }
        private void toolStripButton_SMS_Click(object sender, EventArgs e)
        {
            //   new FRM.SMSPanel.frmSendSMS(ListMobForSMS(), "ClientReferral").ShowDialog();

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            //    splitContainer3.Panel2Collapsed = true;

        }

        private void toolStripButton_Search_Click(object sender, EventArgs e)
        {
            FRM.ClientReferral.frmClientReferralSearch frm = new FRM.ClientReferral.frmClientReferralSearch();
            frm.ShowDialog();
            ShowData(false, frm.xClientReferral, frm.SearchxClientReferral,
                frm.xTel,
                frm.SearchxTel,
                frm.xRequestedGoods,
                frm.SearchxRequestedGoods,
                frm.xGenResultOfReferral_,
                frm.SearchxGenResultOfReferral_);
        }

        private void toolStripButton_SaveTop_Click(object sender, EventArgs e)
        {
            this.dataGridView1.EndEdit();
            this.dataGridView2.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.ClientReferral.csClientReferral().UdClientReferral_Refer(dt_P));
                ShowData(true, "", false, "", false, "", false, -1, false);

            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "xReferConfirm")
            {
                if ((bool)dataGridView1[e.ColumnIndex, e.RowIndex].FormattedValue == true)
                {
                    dataGridView1["xReferConfirmSupplier_", e.RowIndex].Value = BLL.authentication.x_;
                    dataGridView1["xReferConfirmDate", e.RowIndex].Value = BLL.csshamsidate.shamsidate;
                }
                else
                {
                    dataGridView1["xReferConfirmSupplier_", e.RowIndex].Value = DBNull.Value;
                    dataGridView1["xReferConfirmDate", e.RowIndex].Value = DBNull.Value;

                }

            }
        }
    }
}
