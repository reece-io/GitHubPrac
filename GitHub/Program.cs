using System;

namespace SmallConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the C# Console App!");
            
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"\nHello, {name}! Let's do a quick calculation.");
             
            
            if (int.TryParse(input, out int number))
            {
                int answer = number * 2;
                Console.WriteLine($"Double your number is: {answer}");
            }
            else
            {
                Console.WriteLine("That wasn't a valid number.");
            }
 
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        SmallConsoleApp.Program
    }
}