// See https://aka.ms/new-console-template for more information

using ExamTask;
using System.Collections.Generic;

Console.WriteLine("Введите количество сайтов которые хотите проверить");
string val = string.Empty;
int count = 0;
int tryings = 0;
string url = string.Empty;
var wrongUrl = new List<string>();
var urls = new List<string>();
var requests = new Requests();
var result = new List<Dictionary<int, string>>();
var show = new Showing();

while(tryings <= 4)
{
    try
    {
        val = Console.ReadLine()!;
        count = int.Parse(val);
        break;
    }
    catch (FormatException msg)
    {
        if(tryings == 4)
        {
            Console.WriteLine("Приложение будет закрыто");
            break;
        }
        Console.WriteLine("Введите пожалуйста целое число");
    }
    tryings++;
}
Console.WriteLine("Введите {0} сайт(ов) через запятую", count);
while(count > 0)
{
    url = Console.ReadLine();
    requests.StartWebRequest(url);
     
    
    count--;
}

foreach (var item in result)
{
    if (item.ContainsKey(404))
    {
        show.Show404(item);
    }
    if (item.ContainsKey(200))
    {
        show.Show200(item);
    }
    if (item.ContainsKey(500))
    {
        show.Show500(item);
    }
}
