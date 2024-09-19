using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userNumber = -1 ;
        float totalSum = 0;
        float listLength = 0;
        float average = 0;
        int largest = 0;
        int smallest = int.MaxValue;


        while(userNumber != 0 ){
            Console.Write("Enter number:");
            string auxNumber = Console.ReadLine();
            int number = int.Parse(auxNumber);
            numberList.Add(number);
            userNumber = number;
            totalSum = totalSum + number;
            listLength = listLength + 1;
            if(largest < number){
                largest = number;
            }
            if( smallest > number && number != 0 && number > 0){
                smallest = number;
            }
        }
        average = totalSum / (listLength -1);


        Console.WriteLine($"The sum is : {totalSum}");
        Console.WriteLine($"The average is : {average}");
        Console.WriteLine($"The largest number is : {largest}");
        Console.WriteLine($"The smallest number is : {smallest}");
        numberList.Sort();
        numberList.Reverse();
        foreach(int number in numberList){
            Console.WriteLine(number);
        }
    }
}