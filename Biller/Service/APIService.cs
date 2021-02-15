using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Biller.Service
{
    public class APIService
    {
       const string ApiURL = "http://localhost:8080/";
       //const string ApiURL = "http://heavencloudapi.mine.nu/apisheaven/heavenlite/v2/api/";

        public static T Send<T>(string url, string Metodo, object Body = null, string header = "")
        {
            string json = string.Empty;
            try
            {
                HttpWebRequest wRequest1 = (HttpWebRequest)WebRequest.Create(ApiURL + url);

                if (header != "")
                {
                    wRequest1.Headers.Add(header);
                }

                wRequest1.ContentType = "application/json";
                wRequest1.Accept = "application/json";
                wRequest1.Method = Metodo;

                if (Body != null)
                {
                    byte[] body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(Body));
                    wRequest1.ContentLength = body.Length;
                    using (Stream srRead = wRequest1.GetRequestStream())
                    {
                        srRead.Write(body, 0, body.Length);
                    }
                }

                WebResponse wResponse1 = wRequest1.GetResponse();
                using (StreamReader srRead = new StreamReader(wResponse1.GetResponseStream()))
                {
                    json = srRead.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return JsonConvert.DeserializeObject<T>(json);
        }

        public async static Task<T> SendAsync<T>(string url, string Metodo, object Body = null, string header = "")
        {
            string json = string.Empty;
            try
            {
                HttpWebRequest wRequest1 = (HttpWebRequest)WebRequest.Create(url);

                if (header != "")
                {
                    wRequest1.Headers.Add(header);
                }

                wRequest1.ContentType = "application/json";
                wRequest1.Accept = "application/json";
                wRequest1.Method = Metodo;

                if (Body != null)
                {
                    byte[] body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(Body));
                    wRequest1.ContentLength = body.Length;
                    using (Stream srRead = wRequest1.GetRequestStream())
                    {
                        srRead.Write(body, 0, body.Length);
                    }
                }

                WebResponse wResponse1 = await wRequest1.GetResponseAsync();
                using (StreamReader srRead = new StreamReader(wResponse1.GetResponseStream()))
                {
                    json = srRead.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
