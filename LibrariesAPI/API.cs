using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;

namespace LibrariesAPI
{

    public class API
    {
        public static List<T> Get<T>(String url)
        {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(String.Format(url));
            WebReq.Method = "GET";
            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

            string jsonString;
            using (Stream stream = WebResp.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                jsonString = reader.ReadToEnd();
            }

            dynamic items = JsonConvert.DeserializeObject(jsonString);
            List<T> list = new List<T>();

            foreach (dynamic item in items.value)
            {
                list.Add(item.ToObject<T>());
            }

            return list;
        }

        public static T GetById<T>(String url)
        {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(String.Format(url));
            WebReq.Method = "GET";
            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

            string jsonString;
            using (Stream stream = WebResp.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                jsonString = reader.ReadToEnd();
            }

            dynamic items = JsonConvert.DeserializeObject<T>(jsonString);
;           Console.WriteLine(items);

            return items;

        }

        public static bool Post<T>(String url, T value)
        {

            var json = JsonConvert.SerializeObject(value);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            HttpClient client = new HttpClient();

            var response = client.PostAsync(url, data).Result;

            string resString = response.Content.ReadAsStringAsync().Result;
            
            dynamic resJson= JsonConvert.DeserializeObject(resString);

            return resJson.status;
            
        }

        public static bool Delete(String url)
        {
            Console.WriteLine(url);
            HttpClient client = new HttpClient();

            var response = client.DeleteAsync(url).Result;

            string resString = response.Content.ReadAsStringAsync().Result;

            dynamic resJson = JsonConvert.DeserializeObject(resString);
            return resJson.status;

        }
    }
}
