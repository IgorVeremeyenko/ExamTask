
using System.Diagnostics;
using System.Net;
using System.Web.Http;

namespace ExamTask
{
    public class Requests
    {
        private static HttpClient _httpClient;
        public Dictionary<int, string> Request(string url)
        {
            
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                var response = (HttpWebResponse)request.GetResponse();
                var code = ((int)response.StatusCode);
                var result = new Dictionary<int, string>();
                result.Add(code, url);
                return result;
            }
            catch (Exception msg)
            {

                Console.WriteLine(msg.Message);
                return null;
            }
            return null;
        }

        public async Task<HttpWebResponse> StartWebRequest(string url)
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);


            return (HttpWebResponse)request.GetResponse();


        }


    }
}
