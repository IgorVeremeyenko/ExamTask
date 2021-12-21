// See https://aka.ms/new-console-template for more information

using ExamTask;

Checker checker = new Checker();//class Checker
Showing show = new Showing();//show results
Validation validation = new Validation();
Console.WriteLine("Введите количество сайтов которые хотите проверить");
string val;//adress url
int count = 0;//adress count
int tryings = 0;
List<string> listUrls = new List<string>();
while (tryings <= 4)
{
    try
    {
        val = Console.ReadLine()!;       
        count = int.Parse(val);
        break;
    }
    catch (FormatException)
    {
        if (tryings == 4)
        {
            Console.WriteLine("Приложение будет закрыто");
            break;
        }
        Console.WriteLine("Введите пожалуйста целое число");
    }
    tryings++;
}
    
Console.WriteLine("Введите {0} сайт(ов) через запятую", count);
char[] charsToTrim = { '«', '»', ' ', '\'', ']', '[', '%' };
string url = Console.ReadLine();
string result = url.Trim(charsToTrim);
var userArray = result.Split(',');
foreach (var item in userArray)
{
    validation.Validate(item);
    if (validation.Url != null)
    {
        listUrls.Add(item);
        count--;
    }
    else
    {
        Console.WriteLine("Not valid url");
        break;
    }
}

if(validation.Url != null)
{
    checker.WaitingResults = listUrls;
    show.ShowUnchecked(checker.WaitingResults);
    checker.Checking();

    show.Show(checker.Checked);
}

