using System;

class Program
{
    static void Main(string[] args)
    {
        //instances
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();



        
        Console.WriteLine("Welcome to the journal!");
        

        int option = 0 ;

        while (option != 5){
            if(option != 5 ){
                Console.WriteLine("Please Select one Of the Following options:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.Write("What Would you like to do? ");
                option = int.Parse( Console.ReadLine());

                if(option == 1)
                {
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Entry entry = new Entry();

                    entry._promptText = prompt;
                    entry._date = dateText;
                    entry._entryText = Console.ReadLine();
                    Console.WriteLine("How did you feel today?");
                    entry._feeling = Console.ReadLine();
                    journal.AddEntry(entry);
                    entry.Display();
                }else if( option == 2){
                    if(journal._entries.Count > 0){
                        journal.DisplayAll();
                    }else{
                        Console.WriteLine("No entries to display");
                    }
                } else if(option == 3){
                    Console.Write("Enter the filename to load your journal: ");
                    string fileName = Console.ReadLine();  
                    journal.LoadFromFile(fileName); 
                }else if(option == 4){
                    Console.Write("Enter the filename to save your journal: ");
                    string fileName = Console.ReadLine();  
                    journal.SaveToFile(fileName); 
                }
            }
        }
    }
}