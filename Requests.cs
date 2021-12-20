
using System.Diagnostics;
using System.Net;

namespace ExamTask
{
    public class Requests
    {
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

        public async void  StartWebRequest(string url)
        {
            var request = WebRequest.Create(url);
            var response = (HttpWebResponse)await Task.Factory
                .FromAsync(request.BeginGetResponse,
                                        request.EndGetResponse,
                                        null);
            Debug.Assert(response.StatusCode == HttpStatusCode.OK);
            Console.WriteLine(response.StatusCode);
        }


    }
}
