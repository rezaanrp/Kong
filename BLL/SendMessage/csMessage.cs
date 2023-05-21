using System;
namespace BLL.Message
{
    public class csMessage
    {
        public DAL.Message.DataSet_Message.SlMessageFileDataTable SlMessageFile(int x_)
        {
            DAL.Message.DataSet_MessageTableAdapters.SlMessageFileTableAdapter adp =
                new DAL.Message.DataSet_MessageTableAdapters.SlMessageFileTableAdapter();
            return adp.GetData(x_);
        }
        public DAL.Message.DataSet_Message.SlMessageElanDataTable SlMessageElan(string DateFrom, string DateTo, int User_)
        {
            DAL.Message.DataSet_MessageTableAdapters.SlMessageElanTableAdapter adp =
                new DAL.Message.DataSet_MessageTableAdapters.SlMessageElanTableAdapter();
            return adp.GetData(DateFrom, DateTo, User_);
        }

        public DAL.Message.DataSet_Message.SlMessageDataTable SlMessage(int ReciveLetter, int SendLetter, int x_Min, string Srch, string SrchTitle)
        {
            DAL.Message.DataSet_MessageTableAdapters.SlMessageTableAdapter adp =
                new DAL.Message.DataSet_MessageTableAdapters.SlMessageTableAdapter();
            return adp.GetData(ReciveLetter, SendLetter, x_Min, Srch, SrchTitle);
        }

        public string UdMessage(DAL.Message.DataSet_Message.SlMessageDataTable dt)
        {
            try
            {
                DAL.Message.DataSet_MessageTableAdapters.SlMessageTableAdapter adp =
                               new DAL.Message.DataSet_MessageTableAdapters.SlMessageTableAdapter();
                adp.Update(dt);
                return "ارسال با موفقیت انجام شد";

            }
            catch (Exception e)
            {

                return e.Message;
            }


        }

        public string SendMessage(int xUser_, string xSubject, string xContext, string xDate, int xSendTo_, bool elan)
        {
            try
            {
                DAL.Message.DataSet_MessageTableAdapters.SlMessageTableAdapter adp =
                               new DAL.Message.DataSet_MessageTableAdapters.SlMessageTableAdapter();
                string stl = BLL.authentication.x_.ToString() + DateTime.Now.Year + DateTime.Now.DayOfYear + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();

                adp.Insert(xUser_, xSubject, xContext, xDate, "", xSendTo_, "E", true, "", stl, "", "", elan,-1);
                return "ارسال با موفقیت انجام شد";

            }
            catch (Exception e)
            {

                return e.Message;
            }


        }


        public decimal SendMessageByFile( string xName, byte[] xFile)
        {
            try
            {
                DAL.Message.DataSet_MessageTableAdapters.QueriesTableAdapter adp =
                               new DAL.Message.DataSet_MessageTableAdapters.QueriesTableAdapter();


                return (decimal)adp.InMessageByFile(xName, xFile);
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public string SlMessagePopUp()
        {

            try
            {
                DAL.Message.DataSet_MessageTableAdapters.SlMessagePopUpTableAdapter adp =
                   new DAL.Message.DataSet_MessageTableAdapters.SlMessagePopUpTableAdapter();
                DAL.Message.DataSet_Message.SlMessagePopUpDataTable dt = adp.GetData(BLL.authentication.x_);
                if (dt.Rows.Count > 0)
                {

                    return dt[0]["SenderName"].ToString() + "  " + dt[0]["xSubject"].ToString();
                }
                return "";
            }
            catch (Exception)
            {
                return "";
            }

        }


    }
}
