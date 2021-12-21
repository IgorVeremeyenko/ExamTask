
using System.Net;
using System.Web.Http;

namespace ExamTask
{
    public class Checker
    {
        private List<string> _waitingResults = new List<string>();
        private List<Dictionary<int, string>> _checked = new List<Dictionary<int, string>>();
        

        public List<string> WaitingResults {
            get
            {
                return _waitingResults;
            }
            set 
            {
                _waitingResults = value;
            } 
        }
        public List<Dictionary<int, string>> Checked 
        {
            get
            {
                return _checked;
            }
            set
            {
                _checked = value;
            }
        }
        public async void Checking()
        {
            var list = new List<Dictionary<int, string>>();
            Requests requests = new Requests();
            foreach (var value in WaitingResults)
            {
                var result = requests.StartWebRequest(value);
                if (result != null)
                {
                    try
                    {
                        var keyAndValues = new Dictionary<int, string>();
                        var status = result.Result.StatusCode;                        
                        int code = (int)status;
                        keyAndValues.Add(code, value);
                        list.Add(keyAndValues);
                        Checked = list;

                    }
                    catch (Exception err)
                    {                        
                       
                        if (err.Message.Contains("404"))
                        {
                            Console.WriteLine("code 404 Not Found");
                            int code = 404;
                            var keyAndValues = new Dictionary<int, string>();
                            keyAndValues.Add(code, value);
                            list.Add(keyAndValues);
                            Checked = list;
                        }
                        if (err.Message.Contains("500"))
                        {
                            Console.WriteLine("code 500 Internal Server Error");
                            int code = 500;
                            var keyAndValues = new Dictionary<int, string>();
                            keyAndValues.Add(code, value);
                            list.Add(keyAndValues);
                            Checked = list;
                        }



                    }
                }
                
            }
        }
                
    }
}
