using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MIS.FRM.Renovation
{
    public partial class frmRenovationV2 : Form
    {
        public frmRenovationV2(int xProject_, int projectType)
        {
            InitializeComponent();
            xProject_Id = xProject_;
            ProjectType_ = projectType;
            CmbGiveValue();
            ShowData(xProject_);
            ShowDataRenovationUnit(-1, true);

        }
        int xProject_Id;
        int ProjectType_;
        void CmbGiveValue()
        {
            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();
            DataGridViewComboBoxColumn xGenUsageType_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("QUESTLEVL2"),
                DisplayMember = "xName",
                HeaderText = "xGenUnitType_",
                ValueMember = "x_",
                DataPropertyName = "xGenUnitType_",
                Name = "xGenUnitType_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(xGenUsageType_);


        }
        DAL.Renovation.DataSet_RenovationN.mRenovationFloorDataTable dt_P;
        DAL.ProjectAnswer.DataSet_ProjectAnswer.SlRenovationListQuestionNotAnswerDataTable dt_R;
        DAL.Question.DataSet_Question.mQuestionItemDataTable dt_RU;
        void ShowData(int x_)
        {
            dt_P = new BLL.Renovation.csRenovationN().mRenovationFloor(x_);
            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            CS.csDic css = new CS.csDic();
            foreach (DataColumn dc in dt_P.Columns)
            {
                if (dataGridView1.Columns[dc.ColumnName] != null)
                    dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                dataGridView1.Columns[dc.ColumnName].DisplayIndex = dt_P.Columns[dc.ColumnName].Ordinal;

            }
            dt_P.xRenovationProject_Column.DefaultValue = x_;
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xRenovationProject_"].Visible = false;

            dataGridView1.Columns["xUnitNumber"].HeaderText = "شماره واحد یا طبقه";
            dataGridView1.Columns["xGenUnitType_"].HeaderText = "نوع کاربری";
            dataGridView1.Columns["xUnitNumber"].Width = 150;
        }
        void ShowDataDetails(int xGrp1_, int xGrp2_, int projectFloor_)
        {

            dt_R = new BLL.ProjectAnswer.csProjectAnswer().SlRenovationListQuestionNotAnswer(xGrp1_, xGrp2_, projectFloor_);
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
                    dataGridView2.Columns[dc.ColumnName].Visible = false;
                }
            }
            dataGridView2.Columns["xQuestion"].HeaderText = "سوالات";
            dataGridView2.Columns["xQuestion"].Visible = true;
            dataGridView2.Columns["xQuestion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }
        void ShowDataRenovationUnit(int x_, bool IsContext)
        {
            dt_RU = new BLL.Question.csQuestion().mQuestionItem(x_);
            bindingSource3.DataSource = dt_RU;
            dataGridView3.DataSource = bindingSource3;
            bindingNavigator3.BindingSource = bindingSource3;
            CS.csDic css = new CS.csDic();
            foreach (DataColumn dc in dt_RU.Columns)
            {
                if (dataGridView3.Columns[dc.ColumnName] != null)
                    dataGridView3.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                dataGridView3.Columns[dc.ColumnName].DisplayIndex = dt_RU.Columns[dc.ColumnName].Ordinal;
                dataGridView3.Columns[dc.ColumnName].Visible = false;
            }
            if (!IsContext)
            {
                dataGridView3.Columns["dchb_Answer"].Visible = true;
                dataGridView3.Columns["xQuestionItem"].Visible = true;
                dataGridView3.Columns["xQuestionItem"].HeaderText = "گزینه ها";
                dataGridView3.Columns["dchb_Answer"].HeaderText = "";
                dataGridView3.Columns["dtxt_Context"].HeaderText = "شرح";
                dataGridView3.Columns["dtxt_Context"].Visible = true;
            }
            else
            {
                dataGridView3.Columns["dchb_Answer"].Visible = false;
                dataGridView3.Columns["xQuestionItem"].Visible = false;
                dataGridView3.Columns["xQuestionItem"].HeaderText = "گزینه ها";
                dataGridView3.Columns["dchb_Answer"].HeaderText = "";
                dataGridView3.Columns["dtxt_Context"].HeaderText = "شرح";
                dataGridView3.Columns["dtxt_Context"].Visible = true;
                dt_RU.Rows.Add();
            }
        }
        void ShowDataGridView1CellEnter(int e_i)
        {
            if (dataGridView1["xGenUnitType_", e_i].Value != DBNull.Value 
                && dataGridView1["x_", e_i].Value != DBNull.Value
                      && (int)dataGridView1["x_", e_i].Value > 0)
            {
                ShowDataDetails((int)ProjectType_,
                    (int)dataGridView1["xGenUnitType_", e_i].Value,
                    (int)dataGridView1["x_", e_i].Value
                    );
                bool iste = false;
                int x_2 = -1;
                //if ((int)dataGridView2["xGenType_", dataGridView1].Value == 187)
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    x_2 = (int)dataGridView2.SelectedRows[0].Cells["x_"].Value;
                    if ((int)dataGridView2.SelectedRows[0].Cells["xGenType_"].Value == 187)
                        iste = true;
                }
                ShowDataRenovationUnit(x_2, iste);
                dataGridView2.Enabled = true;
            }
            else
            {
                ShowDataDetails(-1, -1, -1);
                ShowDataRenovationUnit(-1, true);
                dataGridView2.Enabled = false;
            }
        }
        void ShowDataUnit(int e_inx)
        {
            if (dataGridView2["xGenType_", e_inx].Value != DBNull.Value)
            {
                bool iste = false;
                if (dataGridView2["xGenType_", e_inx].Value != null && (int)dataGridView2["xGenType_", e_inx].Value == 187)
                    iste = true;
                if (dataGridView2["x_", e_inx].Value != null && dataGridView2["x_", e_inx].Value != DBNull.Value)
                {
                    ShowDataRenovationUnit((int)dataGridView2["x_", e_inx].Value, iste);
                }
                else
                {
                    ShowDataRenovationUnit(-1, iste);
                }

            }
        }
        void SaveUnit()
        {
            this.dataGridView3.EndEdit();
            this.Validate();
            DAL.ProjectAnswer.DataSet_ProjectAnswer.mRenovationProjectAnswerDataTable dt_PP
                = new DAL.ProjectAnswer.DataSet_ProjectAnswer.mRenovationProjectAnswerDataTable();

            foreach (DataGridViewRow item in dataGridView3.Rows)
            {

                if (
                    (int)dataGridView2.SelectedRows[0].Cells["xGenType_"].Value == 186 &&
                    item.Cells["dchb_Answer"].Value != null &&
                    item.Cells["dchb_Answer"].Value != DBNull.Value &&
                    (bool)item.Cells["dchb_Answer"].Value
                    )
                {
                    DataRow dr_PP = dt_PP.NewRow();
                    dr_PP["xRenovationFloor_"] = dataGridView1.SelectedRows[0].Cells["x_"].Value;
                    dr_PP["xQuestion_"] = dataGridView2.SelectedRows[0].Cells["x_"].Value;
                    dr_PP["xQuestionItem_"] = item.Cells["x_"].Value;
                    dr_PP["xQestionContext"] = item.Cells["dtxt_Context"].Value;
                    // dr_PP["xConfirm"] = item.Cells[""].Value;
                    //dr_PP["xComment"] = "";
                    dr_PP["xSupplier_"] = BLL.authentication.x_;
                    dr_PP["xDate"] = BLL.csshamsidate.shamsidate;
                    dt_PP.Rows.Add(dr_PP);

                }
                else if ((int)dataGridView2.SelectedRows[0].Cells["xGenType_"].Value == 187)
                {
                    DataRow dr_PP = dt_PP.NewRow();
                    dr_PP["xRenovationFloor_"] = dataGridView1.SelectedRows[0].Cells["x_"].Value;
                    dr_PP["xQuestion_"] = dataGridView2.SelectedRows[0].Cells["x_"].Value;
                    //   dr_PP["xQuestionItem_"] = item.Cells["x_"].Value;
                    dr_PP["xQestionContext"] = item.Cells["dtxt_Context"].Value;
                    // dr_PP["xConfirm"] = item.Cells[""].Value;
                    //dr_PP["xComment"] = "";
                    dr_PP["xSupplier_"] = BLL.authentication.x_;
                    dr_PP["xDate"] = BLL.csshamsidate.shamsidate;
                    dt_PP.Rows.Add(dr_PP);
                }

            }
            new BLL.ProjectAnswer.csProjectAnswer().UdProjectAnswerRenovation(dt_PP);

            ShowDataGridView1CellEnter((int)dataGridView1.SelectedRows[0].Index);
        }
        void SaveFloor()
        {
            this.dataGridView1.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.Renovation.csRenovationN().UdRenovationFloor(dt_P));
                ShowData(xProject_Id);
            }
        }
        private void ToolStripButton_Add_Rebuilding_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.SelectedRows.Count > 0)
            //{
            //    new FRM.Renovation.frmRenovationRegister((int)dataGridView1.SelectedRows[0].Cells["x_"].Value, -1, CS.csEnum.RebuildingUser.User).ShowDialog();
            //    ShowDataDetails((int)ProjectType_, (int)dataGridView1["xGenUnitType_", dataGridView1.SelectedCells[0].RowIndex].Value
            //        , (int)dataGridView1["x_", dataGridView1.SelectedCells[0].RowIndex].Value);
            //}
        }
        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                ShowDataGridView1CellEnter(e.RowIndex);
            }
        }
        private void DataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (e.RowIndex > -1 && dataGridView2["x_", e.RowIndex].Value != DBNull.Value && (int)dataGridView2["x_", e.RowIndex].Value > 0)
            //{
            //    new FRM.Renovation.frmRenovationRegister(-1, (int)dataGridView2["x_", e.RowIndex].Value, CS.csEnum.RebuildingUser.User).ShowDialog();
            //    if (dataGridView1.SelectedCells.Count > 0)
            //        ShowDataDetails((int)ProjectType_, (int)dataGridView1["xGenUnitType_", dataGridView1.SelectedCells[0].RowIndex].Value,
            //            (int)dataGridView1["x_", dataGridView1.SelectedCells[0].RowIndex].Value);
            //}
        }
        private void DataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                ShowDataUnit(e.RowIndex);
            }
        }
        private void ToolStripButton_Unit_Save_Click(object sender, EventArgs e)
        {
            SaveUnit();
        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFloor();
        }
        private void toolStripButton_Unit_Save_Click_1(object sender, EventArgs e)
        {
            //DAL.ProjectAnswer.DataSet_ProjectAnswer.mRenovationProjectAnswerDataTable dt_A
            //     = new DAL.ProjectAnswer.DataSet_ProjectAnswer.mRenovationProjectAnswerDataTable();
            //DataRow dr_ = dt_A.NewRow();
            //dr_["xProject_"] = data;
            //dr_["xQuestion_"] = "";
            //dr_["xQuestionItem_"] = "";
            //dr_["xQestionContext"] = "";
            //dr_["xConfirm"] = "";
            //dr_["xComment"] = "";
            //dr_["xSupplier_"] = "";
            //dr_["xDate"] = "";
        }
        private void glassButton_EXit_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int inx = (int)dataGridView1.SelectedRows[0].Cells["x_"].Value;
                new FRM.Renovation.frmRenovationListAnswer(inx).ShowDialog();
            }

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (System.Windows.Forms.Keys.Enter ):
                    // MessageBox.Show(this.ActiveControl.Name);
                  // SaveFloor();
                    SaveUnit();
                    return true;
                    break;


            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridView2_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void glassButton1_Print_Click(object sender, EventArgs e)
        {
          //  int x_ = (int)dataGridView1.SelectedRows[0].Cells["xRenovationProject_"].Value;
            Report.SendReport cs = new Report.SendReport();
            frmReport r = new frmReport();
            DataTable dt = new BLL.ProjectAnswer.csProjectAnswer().SlRenovationProjectAnswer_ALL(xProject_Id);
            r.GetReport = cs.GetReport(dt, "crsProjectAnswer");
            r.ShowDialog();
            r.Dispose();
        }
    }
}
