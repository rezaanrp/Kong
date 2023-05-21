﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MIS.FRM.RealEstate
{
    public partial class frmStatementRentalIncomeSurvey : Form
    {
        public frmStatementRentalIncomeSurvey(bool IsNew, int xStatementRentalIncome, CS.csEnum.xGenSurveyForWho_ xGenSurveyForWho_)
        {
            InitializeComponent();
            Isnew_ = IsNew;
            xGenSurveyForWho = xGenSurveyForWho_;
            xStatementRentalIncome_ = xStatementRentalIncome;
            if (!IsNew)
            {
                FillForm();
            }

        }
        bool Isnew_ = false;
        int xStatementRentalIncome_;
        CS.csEnum.xGenSurveyForWho_ xGenSurveyForWho;
        DAL.RealEstate.DataSet_StatementRentalIncome.mStatementRentalIncomeSurveyDataTable dt_S;

        void FillForm()
        {
            dt_S = new BLL.RealEstate.csRealEstate().mStatementRentalIncomeSurvey(xStatementRentalIncome_, (int)xGenSurveyForWho);
            foreach (DataRow item in dt_S.Rows)
            {
                foreach (GroupBox tb in flowLayoutPanel1.Controls.OfType<GroupBox>())
                {
                    foreach (RadioButton rb in tb.Controls.OfType<RadioButton>())
                    {
                        if (rb.Name == "radioButton_" + item["xAnswerNumber"].ToString())
                        {
                            rb.Checked = true;
                        }
                        else if (item["xAnswerNumber"].ToString() == "-1")
                        {
                            txt_Comment.Text = item["xAnswerContext"].ToString();
                        }
                        // (int)item["xAnswerNumber"]
                    }
                }

            }
        }

        bool CheckFillForm()
        {
            int i = 0;
            foreach (GroupBox tb in flowLayoutPanel1.Controls.OfType<GroupBox>())
            {
                foreach (RadioButton rb in tb.Controls.OfType<RadioButton>())
                {
                    if (rb.Checked)
                        i++;
                }
            }
            if (i == 8)

                return true;
            return false;
        }
        private void glassButton_Save_Click(object sender, EventArgs e)
        {
            //if (!CheckFillForm())
            //{
            //    MessageBox.Show("لطفا فرم را کامل پر کنید");
            //    return;
            //}
            bool flag = false;

            if (Isnew_)
            {
                dt_S = new DAL.RealEstate.DataSet_StatementRentalIncome.mStatementRentalIncomeSurveyDataTable();

                foreach (GroupBox tb in flowLayoutPanel1.Controls.OfType<GroupBox>())
                {
                    flag = false;

                    foreach (RadioButton rb in tb.Controls.OfType<RadioButton>())
                    {
                        if (rb.Checked)
                        {
                            DataRow dr = dt_S.NewRow();
                            dr["xStatementRentalIncome_"] = xStatementRentalIncome_;
                            dr["xAnswerNumber"] = rb.Name.Substring(12);
                            dr["xGenSurveyForWho_"] = xGenSurveyForWho;
                            dr["xQuestion"] = tb.Text;
                            dr["xAnswerContext"] = rb.Text;
                            dt_S.Rows.Add(dr);
                            flag = true;

                            break;
                        }
                    }
                    if (!flag)
                    {
                        DataRow dr = dt_S.NewRow();
                        dr["xStatementRentalIncome_"] = xStatementRentalIncome_;
                        dr["xGenSurveyForWho_"] = xGenSurveyForWho;
                        dr["xAnswerNumber"] = tb.Tag.ToString() + "0";
                        dr["xQuestion"] = tb.Text;
                        dr["xAnswerContext"] = "عدم پاسخگویی";
                        dt_S.Rows.Add(dr);
                    }
                }
                DataRow drc = dt_S.NewRow();
                drc["xStatementRentalIncome_"] = xStatementRentalIncome_;
                drc["xAnswerNumber"] = -1;
                drc["xGenSurveyForWho_"] = xGenSurveyForWho;
                drc["xQuestion"] = "توضیحات";
                drc["xAnswerContext"] = txt_Comment.Text;
                dt_S.Rows.Add(drc);

            }
            else
            {
                int i = 0;
                foreach (GroupBox tb in flowLayoutPanel1.Controls.OfType<GroupBox>())
                {
                    foreach (RadioButton rb in tb.Controls.OfType<RadioButton>())
                    {
                        if (rb.Checked)
                        {
                            dt_S[i]["xStatementRentalIncome_"] = xStatementRentalIncome_;
                            dt_S[i]["xAnswerNumber"] = rb.Name.Substring(12);
                            dt_S[i]["xGenSurveyForWho_"] = xGenSurveyForWho;
                            dt_S[i]["xQuestion"] = tb.Text;
                            dt_S[i]["xAnswerContext"] = rb.Text;
                            break;
                        }
                    }
                    i++;
                }

                dt_S[i]["xStatementRentalIncome_"] = xStatementRentalIncome_;
                dt_S[i]["xAnswerNumber"] = -1;
                dt_S[i]["xQuestion"] = "توضیحات";
                dt_S[i]["xGenSurveyForWho_"] = xGenSurveyForWho;
                dt_S[i++]["xAnswerContext"] = txt_Comment.Text;

            }
            //radioButton_11
            new BLL.RealEstate.csRealEstate().UdStatementRentalIncomeSurvey(dt_S);
            this.Close();

        }

        private void glassButton_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
