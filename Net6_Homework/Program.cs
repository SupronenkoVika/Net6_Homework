
using CL;

Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.Green;

Console.WriteLine("Hello, World!");

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.BackgroundColor = ConsoleColor.White;

for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.Yellow;

for (int i = 0; i < 6; i++)
{
    for (int j = 6; j > i; j--)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Class1 classTest = new Class1();

