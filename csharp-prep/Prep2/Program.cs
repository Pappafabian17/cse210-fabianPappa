using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is you grade percentage?");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);
        string letter;
        string sign = "";
        int reminder;
        if(grade >= 90){
            letter="A";
        }else if(grade >= 80){
            letter="B";
        }else if(grade >= 70){
            letter="C";
        }else if(grade >= 60){
            letter="D";
        }else {
            letter="F";
        }

        if(grade <= 89 && grade >= 60){
        reminder = grade % 10;
        if( reminder >= 7){
            sign = "+";
        }else if( reminder > 3){
            sign = "";
        }else {
            sign = "-";
        }
        }

            Console.WriteLine($"Your grade is : {sign} {letter}");



        if(grade >= 70 ){
            Console.Write("Congrats! you did a good job!");
        }else{
            Console.Write("Sorry, try again, good luck next time!");
        }
    }
}