// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

static void Print(string name, int repeat)
{
    for (var i = 0; i < repeat; i++)
    {
        Console.WriteLine(name);
    }
}

const int times = 5;
const string name = "matthijs";
Print(name: name, repeat: times);

var result = Test.Sum(1,2);
Console.WriteLine(result);
    
