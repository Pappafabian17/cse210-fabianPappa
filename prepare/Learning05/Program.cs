using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment asignment1 = new Assignment("Fabian Pappa","Web programming");
        Console.WriteLine(asignment1.GetSummary());

        MathAssignment homework1 = new MathAssignment("juan","fractions","7.3","9-19");
        Console.WriteLine(homework1.GetSummary());
        Console.WriteLine(homework1.GetHomeworkList());

        WritingAssignment homework2 = new WritingAssignment("Python data science","Hernan Pappa","science history");
        Console.WriteLine(homework2.GetSummary());
        Console.WriteLine(homework2.GetWritingInformation());
    }
}