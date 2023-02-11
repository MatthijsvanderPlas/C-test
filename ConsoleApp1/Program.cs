// See https://aka.ms/new-console-template for more information
// Using all the classes from the ConsoleApp1 namespace
using ConsoleApp1;


static void Print(string name, int repeat)
{
    for (var i = 0; i < repeat; i++)
    {
        Console.WriteLine(name);
    }
}

// declaring a constant integer
const int times = 5;
// declaring a constant string
const string name = "matthijs";
// calling my Print method with the variables name and times
Print(name: name, repeat: times);

// declaring the result variable and initialize it with the Test.Sum() Method from a different file!
var result = Test.Sum(1,2);
Console.WriteLine(result);
    
double d1 = 3.1415;
double d2 = 5.2;
double dDiv = d1/d2;

Console.WriteLine("d1 + d2 is " + dDiv);

float f1 = 3.1415f;
float f2 = 5.1f;
float fDiv = f1 / f2;

Console.WriteLine("f1 + f2 is " + fDiv);

