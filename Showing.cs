
namespace ExamTask
{
    public class Showing
    {
        public void Show200(Dictionary<int, string> value)
        {
            if (value[200] != null)
            {
                ShowOptions(value, 200);
            }
        }
        public void Show404(Dictionary<int, string> value)
        {
            if (value[404] != null)
            {
                ShowOptions(value, 404);
            }
        }
        public void Show500(Dictionary<int, string> value)
        {
            if (value[500] != null)
            {
                ShowOptions(value, 500);
            }
        }
        private void ShowOptions(Dictionary<int, string> value, int code)
        {
            int c = 0;
            if (value[code] != null)
            {
                var count = new List<string>();
                foreach (var item in value)
                {
                    count.Add(value[code]);
                }

                c = count.Count;
                Console.WriteLine("[кол-во(200) {0}]", c);
            }
            else
            {
                var msg = new Exception();
                Console.WriteLine(msg.Message);
            }

        }
    }
}
