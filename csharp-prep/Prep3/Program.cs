using System;

class Program
{
    static void Main(string[] args)
    {

        int guess = 0 ;
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int tries = 0;

		
		while(guess != magicNumber){
            
        

            Console.Write("What is your guess");
            string auxguess = Console.ReadLine();
            guess = int.Parse(auxguess);  



            if(magicNumber == guess){
            Console.WriteLine("Congrats it's the same number ");
            }else if(guess > magicNumber){
            Console.WriteLine("lower");
            }else{
            Console.WriteLine("Higher");
            }
            tries = tries + 1;
		}
        Console.WriteLine($" you did {tries} tries");
    }
}