using System;
using System.Text.RegularExpressions;

namespace RegExAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press any key to start");
            ConsoleKeyInfo input;
            input = Console.ReadKey();
        
            while (input.Key != ConsoleKey.Escape)
            {
                Console.Clear();

                Regex rx = new Regex(@"^[a-zA-Z]+$");

                Console.WriteLine("Please enter a Expression or press enter for default(Esc Key to quit)");
                String userInput = Console.ReadLine();

                if (userInput.Length >= 2)
                    rx = new Regex(userInput);

                Console.WriteLine("Please enter a word to check for matches");
                userInput = Console.ReadLine();


                string text = userInput;

                // Find matches.
                MatchCollection matches = rx.Matches(text);

                if (matches.Count >= 1)
                    Console.WriteLine(userInput + " Matches " + rx.ToString() + " = True");
                else
                    Console.WriteLine(userInput + " Matches " + rx.ToString() + " = false");




                Console.ReadLine();
            }
        }
    }
}
