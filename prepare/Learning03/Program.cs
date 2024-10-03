using System;

class Program
{
    static void Main(string[] args)
    {
    Fraction f = new Fraction();
    Fraction f1 = new Fraction(5);
    Fraction f2 = new Fraction(3,4);
    // fractions formats 
    Console.WriteLine(f.GetFractionString());
    Console.WriteLine(f.GetDecimalValue());
    Console.WriteLine(f1.GetFractionString());
    Console.WriteLine(f1.GetDecimalValue());
    Console.WriteLine(f2.GetFractionString());
    Console.WriteLine(f2.GetDecimalValue());
    


    //changing values with getter and setter
    f.SetTop(1);
    f.SetBottom(3);
    Console.WriteLine(f.GetFractionString());
    Console.WriteLine(f.GetDecimalValue());
    }
}