using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Question
{
  public  class csQuestion
    {

        public DAL.Question.DataSet_Question.mQuestion_ByGroupDataTable mQuestion_ByGroup(int xGenGroupLevel1,int xGenGroupLevel2)
        {
            DAL.Question.DataSet_QuestionTableAdapters.mQuestion_ByGroupTableAdapter adp =
               new DAL.Question.DataSet_QuestionTableAdapters.mQuestion_ByGroupTableAdapter();
            return adp.GetData(xGenGroupLevel1,xGenGroupLevel2);
        }

        public string UdQuestion_ByGroup(DAL.Question.DataSet_Question.mQuestion_ByGroupDataTable dt)
        {
            try
            {
                DAL.Question.DataSet_QuestionTableAdapters.mQuestion_ByGroupTableAdapter adp =
                   new DAL.Question.DataSet_QuestionTableAdapters.mQuestion_ByGroupTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        public DAL.Question.DataSet_Question.mQuestionItemDataTable mQuestionItem(int x_)
        {
            DAL.Question.DataSet_QuestionTableAdapters.mQuestionItemTableAdapter adp =
               new DAL.Question.DataSet_QuestionTableAdapters.mQuestionItemTableAdapter();
            return adp.GetData(x_);
        }
        public string UdQuestionItem(DAL.Question.DataSet_Question.mQuestionItemDataTable dt)
        {
            try
            {
                DAL.Question.DataSet_QuestionTableAdapters.mQuestionItemTableAdapter adp =
                   new DAL.Question.DataSet_QuestionTableAdapters.mQuestionItemTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
        public DAL.Question.DataSet_Question.mQuestionDataTable mQuestion()
        {
            DAL.Question.DataSet_QuestionTableAdapters.mQuestionTableAdapter adp =
               new DAL.Question.DataSet_QuestionTableAdapters.mQuestionTableAdapter();
            return adp.GetData();
        }
        public string UdQuestion(DAL.Question.DataSet_Question.mQuestionDataTable dt)
        {
            try
            {
                DAL.Question.DataSet_QuestionTableAdapters.mQuestionTableAdapter adp =
                   new DAL.Question.DataSet_QuestionTableAdapters.mQuestionTableAdapter();
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
