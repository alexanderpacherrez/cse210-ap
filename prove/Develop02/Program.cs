using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program");
        String choice;
        do {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();
            if (choice == "1")
            {

            }
            else if (choice == "2")
            {

            }            
            else if (choice == "3")
            {

            }            
            else if (choice == "4")
            {

            }            
            else if (choice == "5")
            {
                Console.WriteLine("Thanks, goodbye.");
            }
            else 
            {
                Console.WriteLine("Invalid Choice.");
            }      
        }
        while (choice != "5");
    }
}