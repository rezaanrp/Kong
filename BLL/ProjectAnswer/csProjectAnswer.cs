using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.ProjectAnswer
{
  public  class csProjectAnswer
    {
        public DAL.ProjectAnswer.DataSet_ProjectAnswer.SlRenovationListQuestionNotAnswerDataTable SlRenovationListQuestionNotAnswer(int xGenGroupLevel1,int  xGenGroupLevel2 ,int Project_)
        {
            DAL.ProjectAnswer.DataSet_ProjectAnswerTableAdapters.SlRenovationListQuestionNotAnswerTableAdapter adp =
               new DAL.ProjectAnswer.DataSet_ProjectAnswerTableAdapters.SlRenovationListQuestionNotAnswerTableAdapter();
            return adp.GetData(xGenGroupLevel1,xGenGroupLevel2 ,Project_);
        }
        public DAL.ProjectAnswer.DataSet_ProjectAnswer.SlRenovationProjectAnswer_ALLDataTable SlRenovationProjectAnswer_ALL(int? Project_)
        {
            DAL.ProjectAnswer.DataSet_ProjectAnswerTableAdapters.SlRenovationProjectAnswer_ALLTableAdapter adp =
               new DAL.ProjectAnswer.DataSet_ProjectAnswerTableAdapters.SlRenovationProjectAnswer_ALLTableAdapter();
            return adp.GetData(Project_);
        }

        public DAL.ProjectAnswer.DataSet_ProjectAnswer.mRenovationProjectAnswer_ContextDataTable mRenovationProjectAnswer_Context(int? Project_)
        {
            DAL.ProjectAnswer.DataSet_ProjectAnswerTableAdapters.mRenovationProjectAnswer_ContextTableAdapter adp =
               new DAL.ProjectAnswer.DataSet_ProjectAnswerTableAdapters.mRenovationProjectAnswer_ContextTableAdapter();
            return adp.GetData(Project_);
        }
        public string UdRenovationProjectAnswer_Context(DAL.ProjectAnswer.DataSet_ProjectAnswer.mRenovationProjectAnswer_ContextDataTable dt)
        {
            try
            {
                DAL.ProjectAnswer.DataSet_ProjectAnswerTableAdapters.mRenovationProjectAnswer_ContextTableAdapter adp =
                   new DAL.ProjectAnswer.DataSet_ProjectAnswerTableAdapters.mRenovationProjectAnswer_ContextTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
        public DAL.ProjectAnswer.DataSet_ProjectAnswer.mQuestionItemDataTable mQuestionItem()
        {
            DAL.ProjectAnswer.DataSet_ProjectAnswerTableAdapters.mQuestionItemTableAdapter adp =
               new DAL.ProjectAnswer.DataSet_ProjectAnswerTableAdapters.mQuestionItemTableAdapter();
            return adp.GetData();
        }
        public DAL.ProjectAnswer.DataSet_ProjectAnswer.mQuestionDataTable mQuestion()
        {
            DAL.ProjectAnswer.DataSet_ProjectAnswerTableAdapters.mQuestionTableAdapter  adp =
               new DAL.ProjectAnswer.DataSet_ProjectAnswerTableAdapters.mQuestionTableAdapter();
            return adp.GetData();
        }
        public DAL.ProjectAnswer.DataSet_ProjectAnswer.mRenovationProjectAnswerDataTable mProjectAnswerRenovation(int? Project_)
        {
            DAL.ProjectAnswer.DataSet_ProjectAnswerTableAdapters.mRenovationProjectAnswerTableAdapter adp =
               new DAL.ProjectAnswer.DataSet_ProjectAnswerTableAdapters.mRenovationProjectAnswerTableAdapter();
            return adp.GetData(Project_);
        }
        public string UdProjectAnswerRenovation(DAL.ProjectAnswer.DataSet_ProjectAnswer.mRenovationProjectAnswerDataTable dt)
        {
            try
            {
                DAL.ProjectAnswer.DataSet_ProjectAnswerTableAdapters.mRenovationProjectAnswerTableAdapter adp =
                   new DAL.ProjectAnswer.DataSet_ProjectAnswerTableAdapters.mRenovationProjectAnswerTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
    }
}
