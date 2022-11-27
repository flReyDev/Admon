using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Admin_panel.Helpers.Web
{
    internal class HttpHelper : IHttpHelper
    {

        public async Task<string> HttpGet(string url)
        {
            WebRequest request = Request(url);
            WebResponse response = Response(request);
            StreamReader reader = GetResponseStream(response);
            return await reader.ReadToEndAsync();
        }

        public T Post<T>(string url, T view, string method = "POST")
        {
            T result;

            WebRequest CreateRequest = this.Request(url);
            CreateRequest.Method = method;
            CreateRequest.ContentType = "application/json;charset=UTF-8";
            //Se escribe la solicitud
            this.GetWriteStream<T>(CreateRequest, view);
            WebResponse response = this.Response(CreateRequest);
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                result = ResponSerializableObject<T>(reader.ReadToEnd());
            }
            return result;
        }

        private WebRequest Request(string url)
        {
            return WebRequest.Create(url);
        }

        private WebResponse Response(WebRequest request)
        {
            return request.GetResponse();
        }

        private StreamReader GetResponseStream(WebResponse response)
        {
            return new StreamReader(response.GetResponseStream());
        }

        private void GetWriteStream<T>(WebRequest request, T view)
        {

            using (var write = new StreamWriter(request.GetRequestStream()))
            {
                string jsonResult = JsonConvert.SerializeObject(view);
                write.Write(jsonResult);
                write.Flush();
                write.Close();
            }

        }

        public List<T> ResponSerializableList<T>(string response)
        {
            List<T> JsonSerializable = JsonConvert.DeserializeObject<List<T>>(response);
            return JsonSerializable;
        }

        public T ResponSerializableObject<T>(string response)
        {
            T JsonSerializable = JsonConvert.DeserializeObject<T>(response);
            return JsonSerializable;
        }
    }
}
