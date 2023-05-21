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
    public partial class frmClientReferral : Form
    {
        public frmClientReferral()
        {
            InitializeComponent();
            splitContainer3.Panel2Collapsed = true;
            //
            DataGridViewComboBoxColumn combobox_xSupplier_ = new DataGridViewComboBoxColumn()
            {
                DisplayIndex = 4,
                HeaderText = "ثبت کننده",
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
                DisplayIndex = 4,
                HeaderText = "ثبت کننده",
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

            DataGridViewComboBoxColumn combobox_xGenReferTo_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("ReferTo"),
                DisplayMember = "xName",
                HeaderText = "  ",
                ValueMember = "x_",
                DataPropertyName = "xGenReferTo_",
                Name = "xGenReferTo_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
            };
            dataGridView1.Columns.Add(combobox_xGenReferTo_);



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

            DataGridViewComboBoxColumn combobox_ResultOfReferral1_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("ResultOfReferral"),
                DisplayMember = "xName",
                HeaderText = " نتیجه مراجعه ",
                ValueMember = "x_",
                DataPropertyName = "xGenResultOfReferral_",
                Name = "xGenResultOfReferral_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
            };
            dataGridView2.Columns.Add(combobox_ResultOfReferral1_);


        }
        DAL.ClientReferral.DataSet_ClientReferral.SlClientReferralDataTable dt_P;
        private void frmClientReferral_Load(object sender, EventArgs e)
        {
            ShowData(true, "", false, "", false, "", false, -1, false);

        }
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
            dt_P = new BLL.ClientReferral.csClientReferral().SlClientReferral(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo
                , SearchDate,
                                                            xClientReferral,
                                                            SearchxClientReferral,
                                                            xTel,
                                                            SearchxTel,
                                                            xRequestedGoods,
                                                            SearchxRequestedGoods,
                                                            xGenResultOfReferral_,
                                                            SearchxGenResultOfReferral_
                );
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
            dataGridView1.Columns["xSendWellComeMessage"].Visible = false;
            dataGridView1.Columns["xAddress"].Width = 200;
            dataGridView1.Columns["xComment"].Width = 200;
            dataGridView1.Columns["xAction"].Width = 200;
            dataGridView1.Columns["xRequestedGoods"].Width = 200;
            dataGridView1.Columns["xTime"].Width = 60;
            dt_P.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_P.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_P.xTimeColumn.DefaultValue = new BLL.csshamsidate().CurrentTime;


            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {

                if (dr.Cells["xGenResultOfReferral_"].Value == null || dr.Cells["xGenResultOfReferral_"].Value == DBNull.Value)
                    continue;
                if (
                        dr.Cells["xReferConfirm"].Value != null
                     && dr.Cells["xReferConfirm"].Value != DBNull.Value
                     && (bool)dr.Cells["xReferConfirm"].Value == true
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
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.ClientReferral.csClientReferral().UdClientReferral(dt_P));
                DAL.ClientReferral.DataSet_ClientReferral.SlClientReferral_ForWellComeSMSDataTable
                    dt = new BLL.ClientReferral.csClientReferral().SlClientReferral_ForWellComeSMS();
                if (dt.Rows.Count > 0)
                {
                    List<string> Mob = new List<string>();

                    foreach (DataRow item in dt.Rows)
                    {
                        if (item["xTel"] != DBNull.Value)
                        {
                            Mob.Add(item["xTel"].ToString());
                            item["xSendWellComeMessage"] = 1;
                        }
                    }

                    DataTable dt_t = new BLL.SMS.csSMS().mSMSContext_Byx_(1);
                    string smstext = "";
                    if (dt_t.Rows.Count > 0)
                        smstext = dt_t.Rows[0]["xSMS"].ToString();

                    string Rs = new BLL.SMS.csSMS().SendSMS_EsfahanPayamak(smstext, Mob);
                    float dd;
                    if (float.TryParse(Rs.Replace("[", "").Replace("]", ""), out dd))
                    {
                        new BLL.ClientReferral.csClientReferral().UdClientReferral_ForWellComeSMS(dt);
                        new BLL.SMS.csSMS().UdSMSLogs(smstext, Mob, BLL.authentication.x_, "ClientReferral", Rs);
                    }
                }
                ShowData(true, "", false, "", false, "", false, -1, false);



            }
        }
        void ShowDataDetails(string Mob, int x_)
        {

            DAL.ClientReferral.DataSet_ClientReferral.mClientReferral_TelDataTable dt
                = new BLL.ClientReferral.csClientReferral().mClientReferral_Tel(Mob);
            bool flag = false;
            if (x_ > 0 && dt.Rows.Count > 1)
                flag = true;
            else if (x_ < 0 && dt.Rows.Count > 0)
                flag = true;
            if (flag)
            {
                splitContainer3.Panel2Collapsed = false;

                dataGridView2.DataSource = dt;
                CS.csDic css = new CS.csDic();
                foreach (DataColumn dc in dt.Columns)
                {
                    if (dataGridView2.Columns[dc.ColumnName] != null)
                    {
                        dataGridView2.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                        dataGridView2.Columns[dc.ColumnName].DisplayIndex = dt.Columns[dc.ColumnName].Ordinal;
                    }
                }
                dataGridView2.Columns["x_"].Visible = false;
                dataGridView2.Columns["xAddress"].Width = 200;
                dataGridView2.Columns["xComment"].Width = 200;
                dataGridView2.Columns["xRequestedGoods"].Width = 200;

            }

            //   dataGridView2.Columns["xTime"].Width = 60;
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
            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //   splitContainer3.Panel2Collapsed = true;

            if (e.RowIndex > -1 && e.ColumnIndex > -1)
                if (dataGridView1["xTel", e.RowIndex].Value != DBNull.Value
                    && dataGridView1["xTel", e.RowIndex].Value != null)
                    ShowDataDetails((string)dataGridView1["xTel", e.RowIndex].Value, (int)dataGridView1["x_", e.RowIndex].Value);
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns["xTel"].Index == e.ColumnIndex)
            {
                if ((int)dataGridView1["x_", e.RowIndex].Value < 0 &&
                    dataGridView1["xTel", e.RowIndex].Value != DBNull.Value
                    && dataGridView1["xTel", e.RowIndex].Value != null)
                {
                    string st = (string)dataGridView1["xTel", e.RowIndex].Value;
                    DataTable dt =
                        new BLL.ClientReferral.csClientReferral().mClientReferral_Tel(st);
                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                }
            }
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
            new FRM.SMSPanel.frmSendSMS(ListMobForSMS(), "ClientReferral").ShowDialog();

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            splitContainer3.Panel2Collapsed = true;

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

        private void toolStripButton2_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1 && dataGridView1.Columns[e.ColumnIndex].Name == "btn_Seller" && (int)dataGridView1["x_", e.RowIndex].Value > 0)
            {
                DataTable dt = new BLL.ClientReferral.csClientReferral().mClientReferralSurvey((int)dataGridView1["x_", e.RowIndex].Value, (int)CS.csEnum.xGenSurveyForWho_.Mojer);
                if (dt.Rows.Count < 1)
                    new FRM.ClientReferral.frmClientReferralSurvey(true, (int)dataGridView1["x_", e.RowIndex].Value, CS.csEnum.xGenSurveyForWho_.Mojer).ShowDialog();
                else
                    new FRM.ClientReferral.frmClientReferralSurvey(false, (int)dataGridView1["x_", e.RowIndex].Value, CS.csEnum.xGenSurveyForWho_.Mojer).ShowDialog();
            }
            else if (e.ColumnIndex > -1 && e.RowIndex > -1 && dataGridView1.Columns[e.ColumnIndex].Name == "btn_Buyer" && (int)dataGridView1["x_", e.RowIndex].Value > 0)
            {
                DataTable dt = new BLL.ClientReferral.csClientReferral().mClientReferralSurvey((int)dataGridView1["x_", e.RowIndex].Value, (int)CS.csEnum.xGenSurveyForWho_.Mostajer);
                if (dt.Rows.Count < 1)
                    new FRM.ClientReferral.frmClientReferralSurvey(true, (int)dataGridView1["x_", e.RowIndex].Value, CS.csEnum.xGenSurveyForWho_.Mostajer).ShowDialog();
                else
                    new FRM.ClientReferral.frmClientReferralSurvey(false, (int)dataGridView1["x_", e.RowIndex].Value, CS.csEnum.xGenSurveyForWho_.Mostajer).ShowDialog();
            }
        }
    }
}
