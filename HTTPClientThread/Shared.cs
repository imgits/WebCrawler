using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http; //  <-- ensure you add a reference for this to the project
using System.Xml;
using System.Xml.Serialization;

// File contains shared vars and methods between form and worker thread


namespace HTTPClientThread
{
    public class SimpleObj
    {
        public string WebURL; // web address to send post to
        public string ResultCode; // 0 = failure, 1 = success
        public string XMLData; // Used to store the html received back from our HTTPClient request
        public string Message; // What we will show back to the user as response 
        public string ItemID; // Used to store the ListView item ID/index so we can update it when the thread completes
    }


    class Shared 
    {

        public static async Task<SimpleObj> SendWebRequest(SimpleObj rec)
        {
            SimpleObj rslt = new SimpleObj();
            rslt = rec;
            var httpClient = new HttpClient();
            StringContent content = new StringContent(rec.ItemID); // we send the server the ItemID

            try
            {
                HttpResponseMessage response = await httpClient.PostAsync(rec.WebURL, content);

                if (response.IsSuccessStatusCode)
                {

                    HttpContent stream = response.Content;
                    Task<string> data = stream.ReadAsStringAsync();
                    rslt.XMLData = data.Result.ToString();

                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(rslt.XMLData);
                    XmlNode resultNode = doc.SelectSingleNode("response");
                    string resultStatus = resultNode.InnerText;
                    if (resultStatus == "1")
                        rslt.ResultCode = "OK";
                    else if (resultStatus == "0")
                        rslt.ResultCode = "ERR";
                    rslt.Message = doc.InnerXml;
                }

            }
            catch (Exception ex)
            {
                rslt.ResultCode = "ERR";
                rslt.Message = "Connection error: " + ex.Message;
            }

            return rslt;
        }


    }
}
