// See https://aka.ms/new-console-template for more information

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