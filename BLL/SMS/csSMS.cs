using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Text;

namespace BLL.SMS
{
    public class csSMS
    {
        public DAL.SMS.DataSet_SMSLog.mSMSContext_Byx_DataTable mSMSContext_Byx_(int x_)
        {
            DAL.SMS.DataSet_SMSLogTableAdapters.mSMSContext_Byx_TableAdapter adp =
               new DAL.SMS.DataSet_SMSLogTableAdapters.mSMSContext_Byx_TableAdapter();
             return adp.GetData(x_);

        }
        public string UdSMSContext_Byx_(DAL.SMS.DataSet_SMSLog.mSMSContext_Byx_DataTable dt)
        {
            try
            {
                DAL.SMS.DataSet_SMSLogTableAdapters.mSMSContext_Byx_TableAdapter adp =
               new DAL.SMS.DataSet_SMSLogTableAdapters.mSMSContext_Byx_TableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

    
    public DAL.SMS.DataSet_SMSLog.mSMSContextDataTable mSMSContext()
    {
        DAL.SMS.DataSet_SMSLogTableAdapters.mSMSContextTableAdapter adp =
           new DAL.SMS.DataSet_SMSLogTableAdapters.mSMSContextTableAdapter();
        return adp.GetData();
    }
    public string UdSMSContext(DAL.SMS.DataSet_SMSLog.mSMSContextDataTable dt)
    {
        try
        {
            DAL.SMS.DataSet_SMSLogTableAdapters.mSMSContextTableAdapter adp =
               new DAL.SMS.DataSet_SMSLogTableAdapters.mSMSContextTableAdapter();
            adp.Update(dt);
            return "عملیات ذخیره سازی با موفقیت انجام شد";
        }
        catch (Exception e)
        {
            return e.Message;
        }

    }
    public string SendSms(Dictionary<string, string> sms)
    {
        DAL.GenGroup.DataSet_GenGroupTableAdapters.SlGenGroupTableAdapter adp =
             new DAL.GenGroup.DataSet_GenGroupTableAdapters.SlGenGroupTableAdapter();
        ServiceReference1.ServiceSoapClient ss = new ServiceReference1.ServiceSoapClient();
        string username = adp.GetData("SMSUSER")[0]["xName"].ToString();
        string password = adp.GetData("SMSPASS")[0]["xName"].ToString();
        string panelno = adp.GetData("SMSFROM")[0]["xName"].ToString();

        foreach (var item in sms)
        {
            ss.SendSMS(username, password, item.Value, item.Key, panelno);
        }
        return "";
    }
    public DAL.SMS.DataSet_SMSLog.mSMSLogDataTable mSMSLogs(string DateFrom, string DateTo)
    {
        DAL.SMS.DataSet_SMSLogTableAdapters.mSMSLogTableAdapter adp = new
            DAL.SMS.DataSet_SMSLogTableAdapters.mSMSLogTableAdapter();
        return adp.GetData(DateFrom, DateTo);
    }
    public DAL.SMS.DataSet_SMSLog.SlSMSLOGDataTable SlSMSLOG(string DateFrom, string DateTo)
    {
        DAL.SMS.DataSet_SMSLogTableAdapters.SlSMSLOGTableAdapter adp = new
            DAL.SMS.DataSet_SMSLogTableAdapters.SlSMSLOGTableAdapter();
        return adp.GetData(DateFrom, DateTo);
    }
    public string UdSMSLogs(DAL.SMS.DataSet_SMSLog.mSMSLogDataTable dt)
    {
        try
        {
            DAL.SMS.DataSet_SMSLogTableAdapters.mSMSLogTableAdapter adp = new
                DAL.SMS.DataSet_SMSLogTableAdapters.mSMSLogTableAdapter();
            adp.Update(dt);
            return "عملیات ذخیره سازی با موفقیت انجام شد";
        }
        catch (Exception e)
        {
            return e.Message;
        }

    }
    public string UdSMSLogs(string Context, List<string> rcpts, int User_, string xForm, string Result)
    {
        try
        {
            DAL.SMS.DataSet_SMSLog.mSMSLogDataTable dt = new DAL.SMS.DataSet_SMSLog.mSMSLogDataTable();
            foreach (string item in rcpts)
            {
                DataRow dr = dt.NewRow();
                dr["xMobile"] = item;
                dr["xUser_"] = User_;
                dr["xDate"] = BLL.csshamsidate.shamsidate;
                dr["xTime"] = new BLL.csshamsidate().CurrentTime;
                dr["xContext"] = Context;
                dr["xForm"] = xForm;
                dr["xResult"] = Result;
                dt.Rows.Add(dr);
            }

            DAL.SMS.DataSet_SMSLogTableAdapters.mSMSLogTableAdapter adp = new
                DAL.SMS.DataSet_SMSLogTableAdapters.mSMSLogTableAdapter();
            adp.Update(dt);
            return "عملیات ذخیره سازی با موفقیت انجام شد";
        }
        catch (Exception e)
        {
            return e.Message;
        }

    }
        

    public string SendSMS_EsfahanPayamak(string Context, List<string> rcpts
        //Dictionary<string, string> sms
        //
        )
    {
         string Usr = new BLL.GenGroup.csGenGroup().SlGenGroup("SMSUSERNAME").Rows[0]["xName"].ToString();
         string Pas = new BLL.GenGroup.csGenGroup().SlGenGroup("SMSPASS").Rows[0]["xName"].ToString();

        
        WebRequest request = WebRequest.Create("http://ippanel.com/services.jspd");
        string json = JsonConvert.SerializeObject(rcpts);
        request.Method = "POST";
        string postData = "op=send&uname="+ Usr + "&pass="+ Pas + "&message=" + Context + "&to=" + json + "&from=+989999171675                            ";
        byte[] byteArray = Encoding.UTF8.GetBytes(postData);
        request.ContentType = "application/x-www-form-urlencoded";
        request.ContentLength = byteArray.Length;
        Stream dataStream = request.GetRequestStream();
        dataStream.Write(byteArray, 0, byteArray.Length);
        dataStream.Close();
        WebResponse response = request.GetResponse();
        Console.WriteLine(((HttpWebResponse)response).StatusDescription);
        dataStream = response.GetResponseStream();
        StreamReader reader = new StreamReader(dataStream);
        string responseFromServer = reader.ReadToEnd();
        reader.Close();
        dataStream.Close();
        response.Close();

        return responseFromServer;
    }

}
}
