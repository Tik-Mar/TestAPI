using Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.Sleep(5000);
           
            //Request
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:50770/api/Home/Sum");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            InputParam inputParam = new InputParam();
            inputParam.A = 20;
            inputParam.B = 10;
            inputParam.C = 30;

            string json = JsonConvert.SerializeObject(inputParam, Formatting.Indented);
            ASCIIEncoding encoder = new ASCIIEncoding();
            byte[] data = encoder.GetBytes(json); // a json object, or xml, whatever...
            httpWebRequest.ContentLength = data.Length;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }
    }
}
