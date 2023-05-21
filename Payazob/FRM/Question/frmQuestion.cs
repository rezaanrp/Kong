using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MIS.FRM.Question
{
    public partial class frmQuestion : Form
    {
        public frmQuestion()
        {
            InitializeComponent();
            CmbGiveValue();
            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();

            cmb_GenGroupLevel1_.DataSource = csm.SlGenGroup("QUESTLEVL1");
            cmb_GenGroupLevel1_.DisplayMember = "xName";
            cmb_GenGroupLevel1_.ValueMember = "x_";
            cmb_GenGroupLevel1_.SelectedIndex = -1;

            cmb_GenGroupLevel2_.DataSource = csm.SlGenGroup("QUESTLEVL2");
            cmb_GenGroupLevel2_.DisplayMember = "xName";
            cmb_GenGroupLevel2_.ValueMember = "x_";
            cmb_GenGroupLevel2_.SelectedIndex = -1;

            // ShowData();
            ShowDataLoad();
        }

        void ShowDataLoad()
        {

            dt_P = new DAL.Question.DataSet_Question.mQuestion_ByGroupDataTable();
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
                dataGridView1.Columns["x_"].Visible = false;
                dataGridView1.Columns["xGenGroupLevel1_"].Visible = false;
                dataGridView1.Columns["xGenGroupLevel2_"].Visible = false;
                dataGridView1.Columns["xQuestion"].Width = 300;
            //dt_P.xActiveColumn.DefaultValue = true;
            //dt_P.xGenType_Column.DefaultValue = 186;
            //dt_P.xGenGroupLevel1_Column.DefaultValue = (int)cmb_GenGroupLevel1_.SelectedValue;
            //dt_P.xGenGroupLevel2_Column.DefaultValue = (int)cmb_GenGroupLevel2_.SelectedValue;
            dataGridView1.Enabled = false;
        }
        void CmbGiveValue()
        {
            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();
            //DataGridViewComboBoxColumn xGenUsageType_ = new DataGridViewComboBoxColumn()
            //{
            //    DataSource = csm.SlGenGroup("UsageType"),
            //    DisplayMember = "xName",
            //    HeaderText = "xGenUsageType_",
            //    ValueMember = "x_",
            //    DataPropertyName = "xGenUsageType_",
            //    Name = "xGenUsageType_",
            //    Width = 100,
            //    DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            //};
            //dataGridView2.Columns.Add(xGenUsageType_); QUESTLEVL1

            DataGridViewComboBoxColumn QUESTYPE = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("QUESTYPE"),
                DisplayMember = "xName",
                HeaderText = "xGenType_",
                ValueMember = "x_",
                DataPropertyName = "xGenType_",
                Name = "xGenType_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(QUESTYPE);
            //DataGridViewComboBoxColumn QUESTLEVL1 = new DataGridViewComboBoxColumn()
            //{
            //    DataSource = csm.SlGenGroup("QUESTLEVL1"),
            //    DisplayMember = "xName",
            //    HeaderText = "xGenGroupLevel1_",
            //    ValueMember = "x_",
            //    DataPropertyName = "xGenGroupLevel1_",
            //    Name = "xGenGroupLevel1_",
            //    Width = 100,
            //    DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            //};
            //dataGridView1.Columns.Add(QUESTLEVL1);

            //DataGridViewComboBoxColumn QUESTLEVL2 = new DataGridViewComboBoxColumn()
            //{
            //    DataSource = csm.SlGenGroup("QUESTLEVL2"),
            //    DisplayMember = "xName",
            //    HeaderText = "xGenGroupLevel2_",
            //    ValueMember = "x_",
            //    DataPropertyName = "xGenGroupLevel2_",
            //    Name = "xGenGroupLevel2_",
            //    Width = 100,
            //    DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            //};
            //dataGridView1.Columns.Add(QUESTLEVL2);
        }

        DAL.Question.DataSet_Question.mQuestion_ByGroupDataTable dt_P;
        DAL.Question.DataSet_Question.mQuestionItemDataTable dt_D;
        void ShowData()
        {
            if (cmb_GenGroupLevel1_.SelectedIndex > -1 && cmb_GenGroupLevel2_.SelectedIndex > -1)
            {
                dataGridView1.Enabled = true;
                BLL.Question.csQuestion cs = new BLL.Question.csQuestion();
                dt_P = cs.mQuestion_ByGroup((int)cmb_GenGroupLevel1_.SelectedValue, (int)cmb_GenGroupLevel2_.SelectedValue);
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
                dataGridView1.Columns["x_"].Visible = false;
                dataGridView1.Columns["xGenGroupLevel1_"].Visible = false;
                dataGridView1.Columns["xGenGroupLevel2_"].Visible = false;
                dataGridView1.Columns["xQuestion"].Width = 300;
                dt_P.xActiveColumn.DefaultValue = true;
                dt_P.xGenType_Column.DefaultValue = 186;
                dt_P.xGenGroupLevel1_Column.DefaultValue = (int)cmb_GenGroupLevel1_.SelectedValue;
                dt_P.xGenGroupLevel2_Column.DefaultValue = (int)cmb_GenGroupLevel2_.SelectedValue;
            }
            else
            {
                ShowDataLoad();
            }
        }

        void ShowDataDetails(int x_)
        {
            if (x_ > 0)
                dt_D = new BLL.Question.csQuestion().mQuestionItem(x_);
            else
                dt_D = new DAL.Question.DataSet_Question.mQuestionItemDataTable();

            bindingSource2.DataSource = dt_D;
            dataGridView2.DataSource = bindingSource2;
            bindingNavigator2.BindingSource = bindingSource2;
            dt_D.xQuestion_Column.DefaultValue = x_;
            CS.csDic css = new CS.csDic();
            foreach (DataColumn dc in dt_D.Columns)
            {
                if (dataGridView2.Columns[dc.ColumnName] != null)
                    dataGridView2.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                dataGridView2.Columns[dc.ColumnName].DisplayIndex = dt_D.Columns[dc.ColumnName].Ordinal;

            }
            dataGridView2.Columns["xQuestionItem"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                 dataGridView2.Columns["x_"].Visible = false;
              dataGridView2.Columns["xQuestion_"].Visible = false;
        }

        private void GlassButton_EXit_Click(object sender, EventArgs e)
        {
            // ShowData();
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if ((int)dataGridView1["x_", e.RowIndex].Value > 0)
                    if (dataGridView1["xGenType_", e.RowIndex].Value != DBNull.Value
                        && (int)dataGridView1["xGenType_", e.RowIndex].Value == 186)
                    {
                        dataGridView2.Enabled = true;
                        ShowDataDetails((int)dataGridView1["x_", e.RowIndex].Value);
                    }
                    else
                    {
                        dataGridView2.Enabled = false;
                        ShowDataDetails(-1);

                    }
                else
                {
                    dataGridView2.Enabled = false;
                    ShowDataDetails(-1);

                }
            }
        }

        private void ToolStripButton_Add_Rebuilding_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.SelectedRows.Count > 0)
            //    new FRM.Rebuilding.frmRebuildingRegister((int)dataGridView1.SelectedRows[0].Cells["x_"].Value, -1, CS.csEnum.RebuildingUser.User).ShowDialog();
        }

        private void DataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //new FRM.Rebuilding.frmRebuildingRegister(-1, (int)dataGridView2.SelectedRows[0].Cells["x_"].Value, rebuildingUser_).ShowDialog();
            //if (dataGridView1.SelectedCells.Count > 0)
            //    ShowDataDetails((int)dataGridView1["x_", dataGridView1.SelectedCells[0].RowIndex].Value);

        }

        private void ToolStripButton11_Click(object sender, EventArgs e)
        {
            SaveDataTop();
        }

        void SaveDataTop()
        {
            this.dataGridView2.EndEdit();
            this.Validate();
            MessageBox.Show(new BLL.Question.csQuestion().UdQuestionItem(dt_D));
            if (dataGridView1.SelectedCells.Count > 0)
                ShowDataDetails((int)dataGridView1["x_", dataGridView1.SelectedCells[0].RowIndex].Value);
        }
        void SaveDataBottom()
        {
            this.dataGridView1.EndEdit();
            this.dataGridView2.EndEdit();
            this.Validate();
            MessageBox.Show(new BLL.Question.csQuestion().UdQuestion_ByGroup(dt_P));
            ShowData();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveDataBottom();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && this.dataGridView1.Columns[e.ColumnIndex].Name == "xPublic")
            {
                if ((bool)this.dataGridView1["xPublic", e.RowIndex].Value)
                {
                    dataGridView1["xGenGroupLevel2_", e.RowIndex].Value = DBNull.Value;
                    dataGridView1["xGenGroupLevel1_", e.RowIndex].Value = DBNull.Value;

                    dataGridView1["xGenGroupLevel1_", e.RowIndex].ReadOnly = true;
                    dataGridView1["xGenGroupLevel2_", e.RowIndex].ReadOnly = true;

                    dataGridView1["xGenGroupLevel1_", e.RowIndex].Style.BackColor = Color.LightPink;
                    dataGridView1["xGenGroupLevel2_", e.RowIndex].Style.BackColor = Color.LightPink;


                }
                else
                {
                    dataGridView1["xGenGroupLevel1_", e.RowIndex].ReadOnly = false;
                    dataGridView1["xGenGroupLevel2_", e.RowIndex].ReadOnly = false;

                    dataGridView1["xGenGroupLevel1_", e.RowIndex].Style.BackColor = Color.White;
                    dataGridView1["xGenGroupLevel2_", e.RowIndex].Style.BackColor = Color.White;
                }

            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (System.Windows.Forms.Keys.Control | Keys.S):
                   // MessageBox.Show(this.ActiveControl.Name);

                    SaveDataTop();
                    SaveDataBottom();
                    return true;
                    break;


            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void cmb_GenGroupLevel1__SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowData();
            ShowDataDetails(-1);
        }
    }
}
