using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is you name?");
        string name = Console.ReadLine();

        Console.Write("What is your lastname?");
        string surname = Console.ReadLine();
        
        Console.WriteLine($"your name is {surname}, {name} {surname}. ");
    }
}