using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace MVCSimpleApp.Models
{
    public static class TestModel
    {

        public static string GetXMLResponse(string ItemID)
        {
        // generate a random result code, 0= fail, 1 = success
        // note that with Random, the upper bound is exclusive so this really means 1..2
        Random rnd = new Random();
        string ResultCode = rnd.Next(0, 2).ToString();
        string TimeStamp = GetTimeStamp();

        // create an XML document to send as response
        XmlDocument doc = new XmlDocument();

        // add root node and some attributes
        XmlNode rootNode = doc.CreateElement("response");
        XmlAttribute attr = doc.CreateAttribute("type");
        attr.Value = "response-out";
        rootNode.Attributes.Append(attr);
        attr = doc.CreateAttribute("timestamp");
        attr.Value = TimeStamp;
        rootNode.Attributes.Append(attr);
        doc.AppendChild(rootNode);

        // add child to root node sending back the item ID
        XmlNode dataNode = doc.CreateElement("itemid");
        dataNode.InnerText = ItemID;
        rootNode.AppendChild(dataNode);

        // add our random result
        dataNode = doc.CreateElement("result");
        dataNode.InnerText = ResultCode;
        rootNode.AppendChild(dataNode);

        // send back xml
        return doc.OuterXml;
        }




        // Particular timestamp format, can also be done using string format, buuut, I had this code lying around :)
        private static string GetTimeStamp()
        {
            DateTime MyTime;
            MyTime = DateTime.Now;
            String TimeStamp;

            TimeStamp = MyTime.Year.ToString();
            if (MyTime.Month < 10)
                TimeStamp = TimeStamp + "0" + MyTime.Month.ToString();
            else
                TimeStamp = TimeStamp + MyTime.Month.ToString();
            if (MyTime.Day < 10)
                TimeStamp = TimeStamp + "0" + MyTime.Day.ToString();
            else
                TimeStamp = TimeStamp + MyTime.Day.ToString();
            if (MyTime.Hour < 10)
                TimeStamp = TimeStamp + "0" + MyTime.Hour.ToString();
            else
                TimeStamp = TimeStamp + MyTime.Hour.ToString();
            if (MyTime.Minute < 10)
                TimeStamp = TimeStamp + "0" + MyTime.Minute.ToString();
            else
                TimeStamp = TimeStamp + MyTime.Minute.ToString();
            if (MyTime.Second < 10)
                TimeStamp = TimeStamp + "0" + MyTime.Second.ToString();
            else
                TimeStamp = TimeStamp + MyTime.Second.ToString();
            return TimeStamp;
        }
    }
}