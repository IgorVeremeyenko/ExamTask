
namespace ExamTask
{
    public class Showing
    {
        public void Show(List<Dictionary<int, string>> value)
        {
            int c200 = 0;
            int c404 = 0;
            int c500 = 0;
            foreach (var item in value)
            {
                if (item.ContainsKey(200))
                {
                    ShowOptions(item, 200);
                    c200++;
                }
                if (item.ContainsKey(404))
                {
                    ShowOptions(item, 404);
                    c404++;
                }
                if (item.ContainsKey(500))
                {
                    ShowOptions(item, 500);
                    c500++;
                }
            }
            Console.WriteLine("Проверены:");
            Console.WriteLine("Доступных сайтов: [{0}(код ответа {1})]", c200, 200);
            Console.WriteLine("Недоступных: [{0}(код ответа {1})]", c404, 404);
            Console.WriteLine("Не известно: [{0}(код ответа {1})]", c500, 500);

        }

        public void ShowUnchecked(List<string> values)
        {
            Console.WriteLine("Ожидающие проверки");
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
        }
       
        private void ShowOptions(Dictionary<int, string> value, int code)
        {
            int c = 0;
            foreach (var item in value)
            {
                if (item.Value != null)
                {
                    var count = value;
                    c = count.Count;
                    
                }
                else
                {
                    var msg = new Exception();
                    Console.WriteLine(msg.Message);
                }
            }
            

        }
    }
}
